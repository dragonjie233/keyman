namespace keymanx
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btn_toForm1 = new System.Windows.Forms.Button();
            this.btn_toForm2 = new System.Windows.Forms.Button();
            this.btn_toForm3 = new System.Windows.Forms.Button();
            this.btn_toForm4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_home = new System.Windows.Forms.TabPage();
            this.tabPage_about = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage_home.SuspendLayout();
            this.tabPage_about.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_toForm1
            // 
            this.btn_toForm1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_toForm1.Location = new System.Drawing.Point(194, 65);
            this.btn_toForm1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_toForm1.Name = "btn_toForm1";
            this.btn_toForm1.Size = new System.Drawing.Size(175, 35);
            this.btn_toForm1.TabIndex = 0;
            this.btn_toForm1.Text = "初级";
            this.btn_toForm1.UseVisualStyleBackColor = true;
            this.btn_toForm1.Click += new System.EventHandler(this.btn_toForm1_Click);
            // 
            // btn_toForm2
            // 
            this.btn_toForm2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_toForm2.Location = new System.Drawing.Point(194, 110);
            this.btn_toForm2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_toForm2.Name = "btn_toForm2";
            this.btn_toForm2.Size = new System.Drawing.Size(175, 35);
            this.btn_toForm2.TabIndex = 1;
            this.btn_toForm2.Text = "高级";
            this.btn_toForm2.UseVisualStyleBackColor = true;
            this.btn_toForm2.Click += new System.EventHandler(this.btn_toForm2_Click);
            // 
            // btn_toForm3
            // 
            this.btn_toForm3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_toForm3.Location = new System.Drawing.Point(194, 156);
            this.btn_toForm3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_toForm3.Name = "btn_toForm3";
            this.btn_toForm3.Size = new System.Drawing.Size(175, 35);
            this.btn_toForm3.TabIndex = 2;
            this.btn_toForm3.Text = "专业";
            this.btn_toForm3.UseVisualStyleBackColor = true;
            this.btn_toForm3.Click += new System.EventHandler(this.btn_toForm3_Click);
            // 
            // btn_toForm4
            // 
            this.btn_toForm4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_toForm4.Location = new System.Drawing.Point(194, 202);
            this.btn_toForm4.Margin = new System.Windows.Forms.Padding(2);
            this.btn_toForm4.Name = "btn_toForm4";
            this.btn_toForm4.Size = new System.Drawing.Size(175, 35);
            this.btn_toForm4.TabIndex = 3;
            this.btn_toForm4.Text = "计分板";
            this.btn_toForm4.UseVisualStyleBackColor = true;
            this.btn_toForm4.Click += new System.EventHandler(this.btn_toForm4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_home);
            this.tabControl1.Controls.Add(this.tabPage_about);
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 341);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage_home
            // 
            this.tabPage_home.Controls.Add(this.btn_toForm4);
            this.tabPage_home.Controls.Add(this.btn_toForm1);
            this.tabPage_home.Controls.Add(this.btn_toForm3);
            this.tabPage_home.Controls.Add(this.btn_toForm2);
            this.tabPage_home.Location = new System.Drawing.Point(4, 22);
            this.tabPage_home.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_home.Name = "tabPage_home";
            this.tabPage_home.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_home.Size = new System.Drawing.Size(569, 315);
            this.tabPage_home.TabIndex = 0;
            this.tabPage_home.Text = "主界面";
            this.tabPage_home.UseVisualStyleBackColor = true;
            // 
            // tabPage_about
            // 
            this.tabPage_about.Controls.Add(this.linkLabel1);
            this.tabPage_about.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_about.Location = new System.Drawing.Point(4, 22);
            this.tabPage_about.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_about.Name = "tabPage_about";
            this.tabPage_about.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_about.Size = new System.Drawing.Size(569, 315);
            this.tabPage_about.TabIndex = 1;
            this.tabPage_about.Text = " 关于";
            this.tabPage_about.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.52511F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.47488F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 187);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 77);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(101, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "陈俊杰";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "主  设  计：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(2, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "辅助开发：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(2, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "图标设计：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(101, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "冼建成";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(101, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "谢祺辉";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(168, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "（计算机专业教师）";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(168, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "（21届计算机网络应用创新班）";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(168, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "（22届计算机网络应用创新2班）";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 20);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
            this.linkLabel1.Location = new System.Drawing.Point(388, 279);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(166, 28);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "dragonjie233/keymanx";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "键盘侠 Keymanx";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_home.ResumeLayout(false);
            this.tabPage_about.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_toForm1;
        private System.Windows.Forms.Button btn_toForm2;
        private System.Windows.Forms.Button btn_toForm3;
        private System.Windows.Forms.Button btn_toForm4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_home;
        private System.Windows.Forms.TabPage tabPage_about;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}