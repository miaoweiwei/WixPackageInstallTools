namespace WixPackageInstallTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FolderRbtn = new System.Windows.Forms.RadioButton();
            this.FileRbtn = new System.Windows.Forms.RadioButton();
            this.SourceBtn = new System.Windows.Forms.Button();
            this.SourceTbx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TargetNam = new System.Windows.Forms.TextBox();
            this.TargetBtn = new System.Windows.Forms.Button();
            this.TargetTbx = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.CgTbx = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.CgBtn = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FolderRbtn);
            this.groupBox1.Controls.Add(this.FileRbtn);
            this.groupBox1.Controls.Add(this.SourceBtn);
            this.groupBox1.Controls.Add(this.SourceTbx);
            this.groupBox1.Location = new System.Drawing.Point(28, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "源文件/文件夹";
            // 
            // FolderRbtn
            // 
            this.FolderRbtn.AutoSize = true;
            this.FolderRbtn.Location = new System.Drawing.Point(201, 29);
            this.FolderRbtn.Name = "FolderRbtn";
            this.FolderRbtn.Size = new System.Drawing.Size(59, 16);
            this.FolderRbtn.TabIndex = 4;
            this.FolderRbtn.Text = "文件夹";
            this.FolderRbtn.UseVisualStyleBackColor = true;
            this.FolderRbtn.CheckedChanged += new System.EventHandler(this.FolderRbtn_CheckedChanged);
            // 
            // FileRbtn
            // 
            this.FileRbtn.AutoSize = true;
            this.FileRbtn.Checked = true;
            this.FileRbtn.Location = new System.Drawing.Point(83, 29);
            this.FileRbtn.Name = "FileRbtn";
            this.FileRbtn.Size = new System.Drawing.Size(47, 16);
            this.FileRbtn.TabIndex = 3;
            this.FileRbtn.TabStop = true;
            this.FileRbtn.Text = "文件";
            this.FileRbtn.UseVisualStyleBackColor = true;
            this.FileRbtn.CheckedChanged += new System.EventHandler(this.FileRbtn_CheckedChanged);
            // 
            // SourceBtn
            // 
            this.SourceBtn.Location = new System.Drawing.Point(366, 51);
            this.SourceBtn.Name = "SourceBtn";
            this.SourceBtn.Size = new System.Drawing.Size(50, 23);
            this.SourceBtn.TabIndex = 2;
            this.SourceBtn.Text = "选择";
            this.SourceBtn.UseVisualStyleBackColor = true;
            this.SourceBtn.Click += new System.EventHandler(this.SourceBtn_Click);
            // 
            // SourceTbx
            // 
            this.SourceTbx.Location = new System.Drawing.Point(6, 51);
            this.SourceTbx.Multiline = true;
            this.SourceTbx.Name = "SourceTbx";
            this.SourceTbx.ReadOnly = true;
            this.SourceTbx.Size = new System.Drawing.Size(336, 21);
            this.SourceTbx.TabIndex = 1;
            this.SourceTbx.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TargetNam);
            this.groupBox2.Controls.Add(this.TargetBtn);
            this.groupBox2.Controls.Add(this.TargetTbx);
            this.groupBox2.Location = new System.Drawing.Point(28, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 83);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "目标文件/文件夹";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "目标文件名";
            // 
            // TargetNam
            // 
            this.TargetNam.Location = new System.Drawing.Point(90, 49);
            this.TargetNam.Name = "TargetNam";
            this.TargetNam.Size = new System.Drawing.Size(328, 21);
            this.TargetNam.TabIndex = 2;
            // 
            // TargetBtn
            // 
            this.TargetBtn.Location = new System.Drawing.Point(366, 20);
            this.TargetBtn.Name = "TargetBtn";
            this.TargetBtn.Size = new System.Drawing.Size(50, 23);
            this.TargetBtn.TabIndex = 1;
            this.TargetBtn.Text = "选择";
            this.TargetBtn.UseVisualStyleBackColor = true;
            this.TargetBtn.Click += new System.EventHandler(this.TargetBtn_Click);
            // 
            // TargetTbx
            // 
            this.TargetTbx.Location = new System.Drawing.Point(7, 20);
            this.TargetTbx.Name = "TargetTbx";
            this.TargetTbx.ReadOnly = true;
            this.TargetTbx.Size = new System.Drawing.Size(335, 21);
            this.TargetTbx.TabIndex = 0;
            this.TargetTbx.WordWrap = false;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(633, 37);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "开始";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.CgTbx);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.CgBtn);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(28, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 130);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数选择";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 108);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(168, 16);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "为每个组件生成唯一表示Id";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // CgTbx
            // 
            this.CgTbx.Enabled = false;
            this.CgTbx.Location = new System.Drawing.Point(170, 44);
            this.CgTbx.Name = "CgTbx";
            this.CgTbx.Size = new System.Drawing.Size(100, 21);
            this.CgTbx.TabIndex = 4;
            this.CgTbx.WordWrap = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 87);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(132, 16);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "为每个组件生产guid";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 67);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(132, 16);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "只生成一个Fragment";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // CgBtn
            // 
            this.CgBtn.AutoSize = true;
            this.CgBtn.Location = new System.Drawing.Point(7, 44);
            this.CgBtn.Name = "CgBtn";
            this.CgBtn.Size = new System.Drawing.Size(156, 16);
            this.CgBtn.TabIndex = 1;
            this.CgBtn.Text = "设置ComponentGroup名称";
            this.CgBtn.UseVisualStyleBackColor = true;
            this.CgBtn.CheckedChanged += new System.EventHandler(this.CgBtn_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "自动生成组件Guid[*]";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 396);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SourceBtn;
        private System.Windows.Forms.TextBox SourceTbx;
        private System.Windows.Forms.RadioButton FolderRbtn;
        private System.Windows.Forms.RadioButton FileRbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TargetNam;
        private System.Windows.Forms.Button TargetBtn;
        private System.Windows.Forms.TextBox TargetTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CgTbx;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox CgBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

