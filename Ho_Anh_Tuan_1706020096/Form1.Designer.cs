namespace Ho_Anh_Tuan_1706020096
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.duong_thang = new System.Windows.Forms.ToolStripButton();
            this.tam_giac = new System.Windows.Forms.ToolStripButton();
            this.hinh_thoi = new System.Windows.Forms.ToolStripButton();
            this.pararaph = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pararaph)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.Open,
            this.duong_thang,
            this.tam_giac,
            this.hinh_thoi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(771, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Text = "save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 22);
            this.Open.Text = "open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // duong_thang
            // 
            this.duong_thang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.duong_thang.Image = ((System.Drawing.Image)(resources.GetObject("duong_thang.Image")));
            this.duong_thang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.duong_thang.Name = "duong_thang";
            this.duong_thang.Size = new System.Drawing.Size(23, 22);
            this.duong_thang.Text = "toolStripButton3";
            this.duong_thang.ToolTipText = "line";
            this.duong_thang.Click += new System.EventHandler(this.duong_thang_Click);
            // 
            // tam_giac
            // 
            this.tam_giac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tam_giac.Image = ((System.Drawing.Image)(resources.GetObject("tam_giac.Image")));
            this.tam_giac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tam_giac.Name = "tam_giac";
            this.tam_giac.Size = new System.Drawing.Size(23, 22);
            this.tam_giac.Text = "tamgiac";
            this.tam_giac.ToolTipText = "tamgiac";
            this.tam_giac.Click += new System.EventHandler(this.tam_giac_Click);
            // 
            // hinh_thoi
            // 
            this.hinh_thoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hinh_thoi.Image = ((System.Drawing.Image)(resources.GetObject("hinh_thoi.Image")));
            this.hinh_thoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hinh_thoi.Name = "hinh_thoi";
            this.hinh_thoi.Size = new System.Drawing.Size(23, 22);
            this.hinh_thoi.Text = "thoi";
            this.hinh_thoi.Click += new System.EventHandler(this.hinh_thoi_Click);
            // 
            // pararaph
            // 
            this.pararaph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pararaph.Location = new System.Drawing.Point(0, 25);
            this.pararaph.Name = "pararaph";
            this.pararaph.Size = new System.Drawing.Size(771, 425);
            this.pararaph.TabIndex = 1;
            this.pararaph.TabStop = false;
            this.pararaph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pararaph_MouseDown);
            this.pararaph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pararaph_MouseMove);
            this.pararaph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pararaph_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.pararaph);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pararaph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripButton duong_thang;
        private System.Windows.Forms.ToolStripButton tam_giac;
        private System.Windows.Forms.ToolStripButton hinh_thoi;
        private System.Windows.Forms.PictureBox pararaph;
    }
}

