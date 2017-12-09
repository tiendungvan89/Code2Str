namespace Code2Str
{
    partial class Code2Str
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Code2Str));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsConvert = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsClear = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtbSrc = new System.Windows.Forms.RichTextBox();
            this.rtbDst = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsConvert,
            this.toolStripSeparator1,
            this.tsClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(807, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsConvert
            // 
            this.tsConvert.ForeColor = System.Drawing.Color.Blue;
            this.tsConvert.Name = "tsConvert";
            this.tsConvert.Size = new System.Drawing.Size(49, 22);
            this.tsConvert.Text = "Convert";
            this.tsConvert.Click += new System.EventHandler(this.tsConvert_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsClear
            // 
            this.tsClear.ForeColor = System.Drawing.Color.Blue;
            this.tsClear.Name = "tsClear";
            this.tsClear.Size = new System.Drawing.Size(34, 22);
            this.tsClear.Text = "Clear";
            this.tsClear.Click += new System.EventHandler(this.tsClear_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbSrc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbDst);
            this.splitContainer1.Size = new System.Drawing.Size(807, 457);
            this.splitContainer1.SplitterDistance = 395;
            this.splitContainer1.TabIndex = 1;
            // 
            // rtbSrc
            // 
            this.rtbSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSrc.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSrc.ForeColor = System.Drawing.Color.Blue;
            this.rtbSrc.Location = new System.Drawing.Point(0, 0);
            this.rtbSrc.Name = "rtbSrc";
            this.rtbSrc.Size = new System.Drawing.Size(395, 457);
            this.rtbSrc.TabIndex = 0;
            this.rtbSrc.Text = "";
            // 
            // rtbDst
            // 
            this.rtbDst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDst.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDst.ForeColor = System.Drawing.Color.Blue;
            this.rtbDst.Location = new System.Drawing.Point(0, 0);
            this.rtbDst.Name = "rtbDst";
            this.rtbDst.ReadOnly = true;
            this.rtbDst.Size = new System.Drawing.Size(408, 457);
            this.rtbDst.TabIndex = 0;
            this.rtbDst.Text = "";
            // 
            // Code2Str
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 482);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Code2Str";
            this.Text = "Code2Str";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbSrc;
        private System.Windows.Forms.RichTextBox rtbDst;
        private System.Windows.Forms.ToolStripLabel tsConvert;
        private System.Windows.Forms.ToolStripLabel tsClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

