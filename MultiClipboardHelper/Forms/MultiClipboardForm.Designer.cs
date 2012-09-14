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
			this.listBoxClipItems = new System.Windows.Forms.ListBox();
			this.textBoxClipViewer = new System.Windows.Forms.TextBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this.listBoxClipItems);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBoxClipViewer);
			this.splitContainer1.Size = new System.Drawing.Size(679, 570);
			this.splitContainer1.SplitterDistance = 249;
			this.splitContainer1.TabIndex = 2;
			// 
			// listBoxClipItems
			// 
			this.listBoxClipItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxClipItems.FormattingEnabled = true;
			this.listBoxClipItems.Location = new System.Drawing.Point(0, 0);
			this.listBoxClipItems.Name = "listBoxClipItems";
			this.listBoxClipItems.Size = new System.Drawing.Size(679, 249);
			this.listBoxClipItems.TabIndex = 0;
			// 
			// textBoxClipViewer
			// 
			this.textBoxClipViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxClipViewer.Location = new System.Drawing.Point(0, 0);
			this.textBoxClipViewer.Multiline = true;
			this.textBoxClipViewer.Name = "textBoxClipViewer";
			this.textBoxClipViewer.Size = new System.Drawing.Size(679, 317);
			this.textBoxClipViewer.TabIndex = 0;
			// 
			// MultiClipboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 570);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MultiClipboardForm";
			this.Text = "Multi-Clipboard";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox listBoxClipItems;
		private System.Windows.Forms.TextBox textBoxClipViewer;

	}
}