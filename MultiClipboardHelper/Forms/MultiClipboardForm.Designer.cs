namespace MultiClipboardHelper
{
    partial class MultiClipboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listBoxItems = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxClip = new System.Windows.Forms.TextBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listBoxItems);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBoxClip);
			this.splitContainer1.Size = new System.Drawing.Size(606, 570);
			this.splitContainer1.SplitterDistance = 249;
			this.splitContainer1.TabIndex = 2;
			// 
			// listBoxItems
			// 
			this.listBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxItems.FormattingEnabled = true;
			this.listBoxItems.Location = new System.Drawing.Point(0, 44);
			this.listBoxItems.Name = "listBoxItems";
			this.listBoxItems.Size = new System.Drawing.Size(606, 205);
			this.listBoxItems.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.buttonCopy);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(606, 44);
			this.panel1.TabIndex = 0;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(522, 5);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(76, 23);
			this.button7.TabIndex = 6;
			this.button7.Text = "Delete All";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(436, 5);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(76, 23);
			this.button6.TabIndex = 5;
			this.button6.Text = "Insert";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// buttonCopy
			// 
			this.buttonCopy.Location = new System.Drawing.Point(350, 5);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(76, 23);
			this.buttonCopy.TabIndex = 4;
			this.buttonCopy.Text = "Copy";
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(264, 5);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(76, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Move Down";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(178, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(76, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Move Up";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(92, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(76, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(76, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Capture";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBoxClip
			// 
			this.textBoxClip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxClip.Location = new System.Drawing.Point(0, 0);
			this.textBoxClip.Multiline = true;
			this.textBoxClip.Name = "textBoxClip";
			this.textBoxClip.Size = new System.Drawing.Size(606, 317);
			this.textBoxClip.TabIndex = 0;
			// 
			// MultiClipboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 570);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MultiClipboardForm";
			this.Text = "Multi-Clipboard Helper";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox listBoxItems;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxClip;

	}
}