using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using NppPluginNET;

namespace ClipboardHelper
{

    public partial class ClipboardForm : Form
    {
		//private const uint EM_SETTABSTOPS = 0x00CB;
		//public void delegate keyHandler;

        public ClipboardForm()
        {
            InitializeComponent();
			
			var tabSize = new[] { 4 * 4 };

			//Win32.SendMessage(textBoxClip.Handle, NppMsg.EM_SETTABSTOPS, 1, tabSize);

			//Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCN_CHARADDED , ref ProcessKeyPress, 0);
        }

		public void ProcessKeyPress(SCNotification msg)
		{
			
		}

		private void buttonCopy_Click(object sender, EventArgs e)
		{
			int start = 0, end = 0;
			int bufferSize = 0;

			IntPtr selStart = Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_GETSELECTIONSTART, 0, 0);
			IntPtr selEnd = Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_GETSELECTIONEND, 0, 0);

			start = selStart.ToInt32();
			end = selEnd.ToInt32();

			bufferSize = start < end ? end - start : start - end;

			if (bufferSize > 0)
			{
				var selectedText = new StringBuilder(bufferSize);
				Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_GETSELTEXT, 0, selectedText);
				listBoxItems.Items.Add(selectedText.ToString());
			}
		}

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex >= 0)
            {
                string selectedText = listBoxItems.SelectedItem.ToString();
                Clipboard.SetText(selectedText, TextDataFormat.Text);
                Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_PASTE, 0, 0);
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Clear();
            textBoxClip.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex >= 0)
            {
                listBoxItems.Items.RemoveAt(listBoxItems.SelectedIndex);
                textBoxClip.Text = "";
            }
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxItems.SelectedIndex >= 0)
            {
                textBoxClip.Text = listBoxItems.Items[listBoxItems.SelectedIndex].ToString();
            }
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex >= 0)
            {
                Swap(Direction.Down);
            }
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex > 0)
            {
                Swap(Direction.Up);
            }
        }

        private void Swap(Direction direction)
        {
            if (listBoxItems.SelectedIndex == -1 ||
                (direction == Direction.Down && listBoxItems.SelectedIndex == listBoxItems.Items.Count - 1) ||
                (direction == Direction.Up && listBoxItems.SelectedIndex == 0))
                return;

            string swapText = listBoxItems.Items[listBoxItems.SelectedIndex] as string;
            int targetIndex = direction == Direction.Down ? listBoxItems.SelectedIndex + 1 : listBoxItems.SelectedIndex - 1;

            listBoxItems.Items[listBoxItems.SelectedIndex] = listBoxItems.Items[targetIndex];
            listBoxItems.Items[targetIndex] = swapText;
            listBoxItems.SelectedIndex = targetIndex;
            textBoxClip.Text = swapText;

        }

        private void textBoxClip_TextChanged(object sender, EventArgs e)
        {
			if (listBoxItems.SelectedIndex != -1)
			{
				listBoxItems.Items[listBoxItems.SelectedIndex] = textBoxClip.Text;
			}
        }

        private enum Direction
        {
            Up,
            Down
        };
    }
}
