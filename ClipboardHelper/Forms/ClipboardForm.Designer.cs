namespace ClipboardHelper
{
    partial class ClipboardForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipboardForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listBoxItems = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonDeleteAll = new System.Windows.Forms.Button();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.buttonMoveDown = new System.Windows.Forms.Button();
			this.buttonMoveUp = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxClip = new System.Windows.Forms.TextBox();
			this.toolTipClipboard = new System.Windows.Forms.ToolTip(this.components);
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
			this.splitContainer1.Size = new System.Drawing.Size(401, 607);
			this.splitContainer1.SplitterDistance = 265;
			this.splitContainer1.TabIndex = 2;
			// 
			// listBoxItems
			// 
			this.listBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxItems.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxItems.FormattingEnabled = true;
			this.listBoxItems.ItemHeight = 14;
			this.listBoxItems.Location = new System.Drawing.Point(0, 38);
			this.listBoxItems.Name = "listBoxItems";
			this.listBoxItems.Size = new System.Drawing.Size(401, 227);
			this.listBoxItems.TabIndex = 1;
			this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
			this.listBoxItems.DoubleClick += new System.EventHandler(this.listBoxItems_DoubleClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonDeleteAll);
			this.panel1.Controls.Add(this.buttonInsert);
			this.panel1.Controls.Add(this.buttonCopy);
			this.panel1.Controls.Add(this.buttonMoveDown);
			this.panel1.Controls.Add(this.buttonMoveUp);
			this.panel1.Controls.Add(this.buttonDelete);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(401, 38);
			this.panel1.TabIndex = 0;
			// 
			// buttonDeleteAll
			// 
			this.buttonDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteAll.Image")));
			this.buttonDeleteAll.Location = new System.Drawing.Point(165, 4);
			this.buttonDeleteAll.Name = "buttonDeleteAll";
			this.buttonDeleteAll.Size = new System.Drawing.Size(28, 25);
			this.buttonDeleteAll.TabIndex = 6;
			this.toolTipClipboard.SetToolTip(this.buttonDeleteAll, "Delete all items in list");
			this.buttonDeleteAll.UseVisualStyleBackColor = true;
			this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
			// 
			// buttonInsert
			// 
			this.buttonInsert.Image = ((System.Drawing.Image)(resources.GetObject("buttonInsert.Image")));
			this.buttonInsert.Location = new System.Drawing.Point(37, 4);
			this.buttonInsert.Name = "buttonInsert";
			this.buttonInsert.Size = new System.Drawing.Size(28, 25);
			this.buttonInsert.TabIndex = 5;
			this.toolTipClipboard.SetToolTip(this.buttonInsert, "Paste selected item into document");
			this.buttonInsert.UseVisualStyleBackColor = true;
			this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
			// 
			// buttonCopy
			// 
			this.buttonCopy.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopy.Image")));
			this.buttonCopy.Location = new System.Drawing.Point(5, 3);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(28, 25);
			this.buttonCopy.TabIndex = 4;
			this.toolTipClipboard.SetToolTip(this.buttonCopy, "Copy selected text to Clipboard");
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
			// 
			// buttonMoveDown
			// 
			this.buttonMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveDown.Image")));
			this.buttonMoveDown.Location = new System.Drawing.Point(69, 4);
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Size = new System.Drawing.Size(28, 25);
			this.buttonMoveDown.TabIndex = 3;
			this.toolTipClipboard.SetToolTip(this.buttonMoveDown, "Move selected item down in the list");
			this.buttonMoveDown.UseVisualStyleBackColor = true;
			this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
			// 
			// buttonMoveUp
			// 
			this.buttonMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveUp.Image")));
			this.buttonMoveUp.Location = new System.Drawing.Point(101, 4);
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Size = new System.Drawing.Size(28, 25);
			this.buttonMoveUp.TabIndex = 2;
			this.toolTipClipboard.SetToolTip(this.buttonMoveUp, "Move selected item up in the list");
			this.buttonMoveUp.UseVisualStyleBackColor = true;
			this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
			this.buttonDelete.Location = new System.Drawing.Point(133, 3);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(28, 25);
			this.buttonDelete.TabIndex = 1;
			this.toolTipClipboard.SetToolTip(this.buttonDelete, "Delete selected item");
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// textBoxClip
			// 
			this.textBoxClip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxClip.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxClip.Location = new System.Drawing.Point(0, 0);
			this.textBoxClip.Multiline = true;
			this.textBoxClip.Name = "textBoxClip";
			this.textBoxClip.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxClip.Size = new System.Drawing.Size(401, 338);
			this.textBoxClip.TabIndex = 0;
			this.textBoxClip.WordWrap = false;
			this.textBoxClip.TextChanged += new System.EventHandler(this.textBoxClip_TextChanged);
			// 
			// toolTipClipboard
			// 
			this.toolTipClipboard.AutoPopDelay = 5000;
			this.toolTipClipboard.InitialDelay = 800;
			this.toolTipClipboard.IsBalloon = true;
			this.toolTipClipboard.ReshowDelay = 100;
			// 
			// ClipboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 607);
			this.Controls.Add(this.splitContainer1);
			this.Name = "ClipboardForm";
			this.Text = "Clipboard Helper";
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
		private System.Windows.Forms.Button buttonDeleteAll;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.Button buttonMoveDown;
		private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox textBoxClip;
        private System.Windows.Forms.ToolTip toolTipClipboard;

	}
}