namespace keymanx
{
    partial class Form4_scoreboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_scoreboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.local_ranklist = new System.Windows.Forms.TabPage();
            this.ranklist4 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ranklist3 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ranklist2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ranklist1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.all_previous_ranklist = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.local_ranklist.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.local_ranklist);
            this.tabControl1.Controls.Add(this.all_previous_ranklist);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1556, 736);
            this.tabControl1.TabIndex = 11;
            // 
            // local_ranklist
            // 
            this.local_ranklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.local_ranklist.Controls.Add(this.ranklist4);
            this.local_ranklist.Controls.Add(this.ranklist3);
            this.local_ranklist.Controls.Add(this.ranklist2);
            this.local_ranklist.Controls.Add(this.ranklist1);
            this.local_ranklist.Controls.Add(this.button2);
            this.local_ranklist.Controls.Add(this.button1);
            this.local_ranklist.Location = new System.Drawing.Point(4, 26);
            this.local_ranklist.Margin = new System.Windows.Forms.Padding(2);
            this.local_ranklist.Name = "local_ranklist";
            this.local_ranklist.Padding = new System.Windows.Forms.Padding(2);
            this.local_ranklist.Size = new System.Drawing.Size(1548, 706);
            this.local_ranklist.TabIndex = 0;
            this.local_ranklist.Text = "本地计分板";
            // 
            // ranklist4
            // 
            this.ranklist4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ranklist4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ranklist4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.ranklist4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ranklist4.ForeColor = System.Drawing.Color.White;
            this.ranklist4.FullRowSelect = true;
            this.ranklist4.HideSelection = false;
            this.ranklist4.Location = new System.Drawing.Point(1171, 54);
            this.ranklist4.Name = "ranklist4";
            this.ranklist4.Size = new System.Drawing.Size(363, 641);
            this.ranklist4.TabIndex = 20;
            this.ranklist4.UseCompatibleStateImageBehavior = false;
            this.ranklist4.View = System.Windows.Forms.View.Details;
            this.ranklist4.Leave += new System.EventHandler(this.ranklist_Leave);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "排名";
            this.columnHeader10.Width = 45;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "班级和姓名";
            this.columnHeader11.Width = 265;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "成绩";
            this.columnHeader12.Width = 45;
            // 
            // ranklist3
            // 
            this.ranklist3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ranklist3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ranklist3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.ranklist3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ranklist3.ForeColor = System.Drawing.Color.White;
            this.ranklist3.FullRowSelect = true;
            this.ranklist3.HideSelection = false;
            this.ranklist3.Location = new System.Drawing.Point(786, 54);
            this.ranklist3.Name = "ranklist3";
            this.ranklist3.Size = new System.Drawing.Size(363, 641);
            this.ranklist3.TabIndex = 19;
            this.ranklist3.UseCompatibleStateImageBehavior = false;
            this.ranklist3.View = System.Windows.Forms.View.Details;
            this.ranklist3.Leave += new System.EventHandler(this.ranklist_Leave);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "排名";
            this.columnHeader7.Width = 45;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "班级和姓名";
            this.columnHeader8.Width = 265;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "成绩";
            this.columnHeader9.Width = 45;
            // 
            // ranklist2
            // 
            this.ranklist2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ranklist2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ranklist2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ranklist2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ranklist2.ForeColor = System.Drawing.Color.White;
            this.ranklist2.FullRowSelect = true;
            this.ranklist2.HideSelection = false;
            this.ranklist2.Location = new System.Drawing.Point(400, 54);
            this.ranklist2.Name = "ranklist2";
            this.ranklist2.Size = new System.Drawing.Size(363, 641);
            this.ranklist2.TabIndex = 18;
            this.ranklist2.UseCompatibleStateImageBehavior = false;
            this.ranklist2.View = System.Windows.Forms.View.Details;
            this.ranklist2.Leave += new System.EventHandler(this.ranklist_Leave);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "排名";
            this.columnHeader4.Width = 45;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "班级和姓名";
            this.columnHeader5.Width = 265;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "成绩";
            this.columnHeader6.Width = 45;
            // 
            // ranklist1
            // 
            this.ranklist1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ranklist1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ranklist1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ranklist1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ranklist1.ForeColor = System.Drawing.Color.White;
            this.ranklist1.FullRowSelect = true;
            this.ranklist1.HideSelection = false;
            this.ranklist1.Location = new System.Drawing.Point(13, 54);
            this.ranklist1.Name = "ranklist1";
            this.ranklist1.Size = new System.Drawing.Size(363, 641);
            this.ranklist1.TabIndex = 17;
            this.ranklist1.UseCompatibleStateImageBehavior = false;
            this.ranklist1.View = System.Windows.Forms.View.Details;
            this.ranklist1.Leave += new System.EventHandler(this.ranklist_Leave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "排名";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "班级和姓名";
            this.columnHeader2.Width = 265;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "成绩";
            this.columnHeader3.Width = 45;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(79, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "高级";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "初级";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // all_previous_ranklist
            // 
            this.all_previous_ranklist.Location = new System.Drawing.Point(4, 26);
            this.all_previous_ranklist.Margin = new System.Windows.Forms.Padding(2);
            this.all_previous_ranklist.Name = "all_previous_ranklist";
            this.all_previous_ranklist.Padding = new System.Windows.Forms.Padding(2);
            this.all_previous_ranklist.Size = new System.Drawing.Size(1548, 706);
            this.all_previous_ranklist.TabIndex = 1;
            this.all_previous_ranklist.Text = "历届排名";
            this.all_previous_ranklist.UseVisualStyleBackColor = true;
            // 
            // Form4_scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1575, 758);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4_scoreboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "键盘侠 Keymanx 计分板";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_scoreboard_FormClosed);
            this.Load += new System.EventHandler(this.Form4_scoreboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.local_ranklist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage local_ranklist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage all_previous_ranklist;
        private System.Windows.Forms.ListView ranklist4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView ranklist3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView ranklist2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView ranklist1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}