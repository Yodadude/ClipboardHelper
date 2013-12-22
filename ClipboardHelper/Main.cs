using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using NppPluginNET;
using System.Collections.Generic;

namespace ClipboardHelper
{
    class Main
    {
        #region " Fields "
        internal const string PluginName = "Clipboard Helper";
        static bool isDialogVisible = false;
        static ClipboardForm frmMyDlg = null;
        static int idMyDlg = -1;
		static Bitmap tbBmp = Properties.Resources.monitor;
		static Bitmap tbBmp_tbTab = Properties.Resources.monitor;
        static Icon tbIcon = null;
        static string iniFilePath = null;
        static bool persistClipboard = false;
        static IClipboardRepository repository = new ClipboardXmlRepository();
        #endregion

        #region " StartUp/CleanUp "

        internal static void CommandMenuInit()
        {
            StringBuilder sbIniFilePath = new StringBuilder(Win32.MAX_PATH);
            Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_GETPLUGINSCONFIGDIR, Win32.MAX_PATH, sbIniFilePath);

            iniFilePath = sbIniFilePath.ToString();
            if (!Directory.Exists(iniFilePath)) Directory.CreateDirectory(iniFilePath);
            iniFilePath = Path.Combine(iniFilePath, PluginName + ".ini");
            persistClipboard = (Win32.GetPrivateProfileInt("General", "persistClipboard", 0, iniFilePath) != 0);

            var persistPath = Path.Combine(sbIniFilePath.ToString(), PluginName.Replace(" ", "") + ".xml");

            repository.SetSource(persistPath);

            PluginBase.SetCommand(0, "Clipboard Helper", myDockableDialog);
            PluginBase.SetCommand(1, "Persist contents?", myMenuSave, persistClipboard);
			PluginBase.SetCommand(2, "About", myMenuAbout, new ShortcutKey(false, false, false, Keys.None));

            idMyDlg = 0;
        }

        internal static void SetToolBarIcon()
        {
            toolbarIcons tbIcons = new toolbarIcons();
            tbIcons.hToolbarBmp = tbBmp.GetHbitmap();
            IntPtr pTbIcons = Marshal.AllocHGlobal(Marshal.SizeOf(tbIcons));
            Marshal.StructureToPtr(tbIcons, pTbIcons, false);
            Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_ADDTOOLBARICON, PluginBase._funcItems.Items[idMyDlg]._cmdID, pTbIcons);
            Marshal.FreeHGlobal(pTbIcons);
        }

        internal static void PluginCleanUp()
        {
            if (persistClipboard && frmMyDlg != null)
            {
                repository.Save(frmMyDlg.GetItems());
            }
        }

        #endregion

        #region " Menu functions "

        internal static void myMenuSave()
        {
            persistClipboard = !persistClipboard;

            Win32.WritePrivateProfileString("General", "PersistClipboard", persistClipboard ? "1" : "0", iniFilePath);

            int i = Win32.CheckMenuItem(Win32.GetMenu(PluginBase.nppData._nppHandle), PluginBase._funcItems.Items[1]._cmdID,
                Win32.MF_BYCOMMAND | (persistClipboard ? Win32.MF_CHECKED : Win32.MF_UNCHECKED));

        }

		internal static void myMenuAbout()
        {
            MessageBox.Show("Clipboard Helper 1.2\n\nWritten using .Net C# with the NppPluginNet Plugin.\n\nAvailable on GitHub: https://github.com/Yodadude/ClipboardHelper \n\nJohn Byrne 2013");
        }

        internal static void myDockableDialog()
        {
            if (frmMyDlg == null)
            {
                frmMyDlg = new ClipboardForm();

                using (Bitmap newBmp = new Bitmap(16, 16))
                {
                    Graphics g = Graphics.FromImage(newBmp);
                    ColorMap[] colorMap = new ColorMap[1];
                    colorMap[0] = new ColorMap();
                    colorMap[0].OldColor = Color.Fuchsia;
                    colorMap[0].NewColor = Color.FromKnownColor(KnownColor.ButtonFace);
                    ImageAttributes attr = new ImageAttributes();
                    attr.SetRemapTable(colorMap);
                    g.DrawImage(tbBmp_tbTab, new Rectangle(0, 0, 16, 16), 0, 0, 16, 16, GraphicsUnit.Pixel, attr);
                    tbIcon = Icon.FromHandle(newBmp.GetHicon());
                }

                NppTbData _nppTbData = new NppTbData();
                _nppTbData.hClient = frmMyDlg.Handle;
				_nppTbData.pszName = "Clipboard Helper";
                _nppTbData.dlgID = idMyDlg;
                _nppTbData.uMask = NppTbMsg.DWS_DF_CONT_RIGHT | NppTbMsg.DWS_ICONTAB | NppTbMsg.DWS_ICONBAR;
                _nppTbData.hIconTab = (uint)tbIcon.Handle;
                _nppTbData.pszModuleName = PluginName;
                IntPtr _ptrNppTbData = Marshal.AllocHGlobal(Marshal.SizeOf(_nppTbData));
                Marshal.StructureToPtr(_nppTbData, _ptrNppTbData, false);

                Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_DMMREGASDCKDLG, 0, _ptrNppTbData);

                isDialogVisible = true;
            }
            else
            {
                Win32.SendMessage(PluginBase.nppData._nppHandle, isDialogVisible ? NppMsg.NPPM_DMMHIDE : NppMsg.NPPM_DMMSHOW, 0, frmMyDlg.Handle);
                isDialogVisible = !isDialogVisible;
            }

            frmMyDlg.SetItems(repository.Get());

        }

        #endregion

    }
}