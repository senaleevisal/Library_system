namespace Library_Management_System.Book
{
    partial class PanelBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelBook));
            this.lbl_Window = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDDBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKSSEARCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKSUPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWODERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.guna2ContextMenuStrip3 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.guna2ContextMenuStrip4 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.aDDBOOKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.guna2ContextMenuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Window
            // 
            this.lbl_Window.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Window.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Window.Location = new System.Drawing.Point(163, 257);
            this.lbl_Window.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_Window.Name = "lbl_Window";
            this.lbl_Window.Size = new System.Drawing.Size(165, 42);
            this.lbl_Window.TabIndex = 5;
            this.lbl_Window.Text = "WELCOME !";
            this.lbl_Window.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(435, 167);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(540, 430);
            this.guna2Panel1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDBOOKToolStripMenuItem,
            this.bOOKSSEARCHToolStripMenuItem,
            this.bOOKSUPDATEToolStripMenuItem,
            this.vIEWODERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1019, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aDDBOOKToolStripMenuItem
            // 
            this.aDDBOOKToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.add__1_;
            this.aDDBOOKToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.aDDBOOKToolStripMenuItem.MergeIndex = 0;
            this.aDDBOOKToolStripMenuItem.Name = "aDDBOOKToolStripMenuItem";
            this.aDDBOOKToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.aDDBOOKToolStripMenuItem.Text = "ADD BOOK";
            this.aDDBOOKToolStripMenuItem.Click += new System.EventHandler(this.aDDBOOKToolStripMenuItem_Click);
            // 
            // bOOKSSEARCHToolStripMenuItem
            // 
            this.bOOKSSEARCHToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.search;
            this.bOOKSSEARCHToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bOOKSSEARCHToolStripMenuItem.Name = "bOOKSSEARCHToolStripMenuItem";
            this.bOOKSSEARCHToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.bOOKSSEARCHToolStripMenuItem.Text = "BOOKS SEARCH";
            // 
            // bOOKSUPDATEToolStripMenuItem
            // 
            this.bOOKSUPDATEToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.refresh;
            this.bOOKSUPDATEToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bOOKSUPDATEToolStripMenuItem.Name = "bOOKSUPDATEToolStripMenuItem";
            this.bOOKSUPDATEToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.bOOKSUPDATEToolStripMenuItem.Text = "BOOKS UPDATE";
            // 
            // vIEWODERToolStripMenuItem
            // 
            this.vIEWODERToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.eye;
            this.vIEWODERToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.vIEWODERToolStripMenuItem.Name = "vIEWODERToolStripMenuItem";
            this.vIEWODERToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.vIEWODERToolStripMenuItem.Text = "VIEW ODER";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2ContextMenuStrip2
            // 
            this.guna2ContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip2.Name = "guna2ContextMenuStrip2";
            this.guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip2.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip2.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2ContextMenuStrip3
            // 
            this.guna2ContextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip3.Name = "guna2ContextMenuStrip3";
            this.guna2ContextMenuStrip3.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip3.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip3.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip3.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip3.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip3.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip3.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip3.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip3.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2ContextMenuStrip4
            // 
            this.guna2ContextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDBOOKToolStripMenuItem1});
            this.guna2ContextMenuStrip4.Name = "guna2ContextMenuStrip4";
            this.guna2ContextMenuStrip4.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip4.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip4.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip4.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip4.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip4.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip4.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip4.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip4.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip4.Size = new System.Drawing.Size(155, 28);
            // 
            // aDDBOOKToolStripMenuItem1
            // 
            this.aDDBOOKToolStripMenuItem1.Name = "aDDBOOKToolStripMenuItem1";
            this.aDDBOOKToolStripMenuItem1.Size = new System.Drawing.Size(154, 24);
            this.aDDBOOKToolStripMenuItem1.Text = "ADD BOOK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 305);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PanelBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lbl_Window);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanelBook";
            this.Size = new System.Drawing.Size(1019, 742);
            this.Load += new System.EventHandler(this.PanelBook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.guna2ContextMenuStrip4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Window;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKSSEARCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKSUPDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWODERToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip3;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem aDDBOOKToolStripMenuItem1;
    }
}
