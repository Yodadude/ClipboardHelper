using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NppPluginNET;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MultiClipboardHelper
{

    public partial class MultiClipboardForm : Form
    {

        public MultiClipboardForm()
        {
            InitializeComponent();

        }

		private void buttonCopy_Click(object sender, EventArgs e)
		{

            StringBuilder selectedText = new StringBuilder(1000);
            Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_GETSELTEXT, 0, selectedText);
            
            if (selectedText != null && selectedText.Length > 0)
            {
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
            listBoxItems.Items[listBoxItems.SelectedIndex] = textBoxClip.Text;
        }

        private enum Direction
        {
            Up,
            Down
        };
    }
}
