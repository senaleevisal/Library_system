namespace Library_Management_System.Member
{
    partial class PanelMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelMember));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_Window = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_FineCalculate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_SearchMember = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_AddMember = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(675, 274);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(810, 672);
            this.guna2Panel1.TabIndex = 13;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lbl_Window
            // 
            this.lbl_Window.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Window.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Window.Location = new System.Drawing.Point(234, 456);
            this.lbl_Window.Name = "lbl_Window";
            this.lbl_Window.Size = new System.Drawing.Size(293, 66);
            this.lbl_Window.TabIndex = 12;
            this.lbl_Window.Text = "Add Member";
            this.lbl_Window.Click += new System.EventHandler(this.lbl_Window_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(1331, 29);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(162, 41);
            this.guna2HtmlLabel2.TabIndex = 10;
            this.guna2HtmlLabel2.Text = "Make Order";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // lbl_FineCalculate
            // 
            this.lbl_FineCalculate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FineCalculate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FineCalculate.Location = new System.Drawing.Point(840, 29);
            this.lbl_FineCalculate.Name = "lbl_FineCalculate";
            this.lbl_FineCalculate.Size = new System.Drawing.Size(188, 41);
            this.lbl_FineCalculate.TabIndex = 9;
            this.lbl_FineCalculate.Text = "Fine Calculate";
            this.lbl_FineCalculate.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // lbl_SearchMember
            // 
            this.lbl_SearchMember.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SearchMember.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchMember.Location = new System.Drawing.Point(421, 29);
            this.lbl_SearchMember.Name = "lbl_SearchMember";
            this.lbl_SearchMember.Size = new System.Drawing.Size(212, 41);
            this.lbl_SearchMember.TabIndex = 8;
            this.lbl_SearchMember.Text = "Member Search";
            this.lbl_SearchMember.Click += new System.EventHandler(this.lbl_SearchBooks_Click);
            // 
            // lbl_AddMember
            // 
            this.lbl_AddMember.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddMember.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddMember.Location = new System.Drawing.Point(37, 29);
            this.lbl_AddMember.Name = "lbl_AddMember";
            this.lbl_AddMember.Size = new System.Drawing.Size(177, 41);
            this.lbl_AddMember.TabIndex = 7;
            this.lbl_AddMember.Text = "Add Member";
            this.lbl_AddMember.Click += new System.EventHandler(this.lbl_AddBook_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 528);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 326);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lbl_Window);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lbl_FineCalculate);
            this.Controls.Add(this.lbl_SearchMember);
            this.Controls.Add(this.lbl_AddMember);
            this.Name = "PanelMember";
            this.Size = new System.Drawing.Size(1528, 1159);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Window;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_FineCalculate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_SearchMember;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_AddMember;
    }
}
