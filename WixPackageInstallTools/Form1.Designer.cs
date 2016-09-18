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
            this.sregCbx = new System.Windows.Forms.CheckBox();
            this.suidCbx = new System.Windows.Forms.CheckBox();
            this.cgTbx = new System.Windows.Forms.TextBox();
            this.ggCbx = new System.Windows.Forms.CheckBox();
            this.sfragCbx = new System.Windows.Forms.CheckBox();
            this.cgCbx = new System.Windows.Forms.CheckBox();
            this.agCbx = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.TargetNam.WordWrap = false;
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
            this.StartBtn.Location = new System.Drawing.Point(546, 37);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(89, 23);
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
            this.groupBox3.Controls.Add(this.sregCbx);
            this.groupBox3.Controls.Add(this.suidCbx);
            this.groupBox3.Controls.Add(this.cgTbx);
            this.groupBox3.Controls.Add(this.ggCbx);
            this.groupBox3.Controls.Add(this.sfragCbx);
            this.groupBox3.Controls.Add(this.cgCbx);
            this.groupBox3.Controls.Add(this.agCbx);
            this.groupBox3.Location = new System.Drawing.Point(28, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 130);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数选择";
            // 
            // sregCbx
            // 
            this.sregCbx.AutoSize = true;
            this.sregCbx.Location = new System.Drawing.Point(228, 105);
            this.sregCbx.Name = "sregCbx";
            this.sregCbx.Size = new System.Drawing.Size(174, 16);
            this.sregCbx.TabIndex = 6;
            this.sregCbx.Text = "DLL文件禁止生成注册表形式";
            this.sregCbx.UseVisualStyleBackColor = true;
            // 
            // suidCbx
            // 
            this.suidCbx.AutoSize = true;
            this.suidCbx.Location = new System.Drawing.Point(228, 64);
            this.suidCbx.Name = "suidCbx";
            this.suidCbx.Size = new System.Drawing.Size(168, 16);
            this.suidCbx.TabIndex = 5;
            this.suidCbx.Text = "为每个组件生成唯一表示Id";
            this.suidCbx.UseVisualStyleBackColor = true;
            // 
            // cgTbx
            // 
            this.cgTbx.Enabled = false;
            this.cgTbx.Location = new System.Drawing.Point(390, 21);
            this.cgTbx.Name = "cgTbx";
            this.cgTbx.Size = new System.Drawing.Size(100, 21);
            this.cgTbx.TabIndex = 4;
            this.cgTbx.WordWrap = false;
            // 
            // ggCbx
            // 
            this.ggCbx.AutoSize = true;
            this.ggCbx.Location = new System.Drawing.Point(6, 64);
            this.ggCbx.Name = "ggCbx";
            this.ggCbx.Size = new System.Drawing.Size(156, 16);
            this.ggCbx.TabIndex = 3;
            this.ggCbx.Text = "为每个文件生成唯一guid";
            this.ggCbx.UseVisualStyleBackColor = true;
            this.ggCbx.CheckedChanged += new System.EventHandler(this.ggCbx_CheckedChanged);
            // 
            // sfragCbx
            // 
            this.sfragCbx.AutoSize = true;
            this.sfragCbx.Location = new System.Drawing.Point(6, 105);
            this.sfragCbx.Name = "sfragCbx";
            this.sfragCbx.Size = new System.Drawing.Size(132, 16);
            this.sfragCbx.TabIndex = 2;
            this.sfragCbx.Text = "只生成一个Fragment";
            this.sfragCbx.UseVisualStyleBackColor = true;
            // 
            // cgCbx
            // 
            this.cgCbx.AutoSize = true;
            this.cgCbx.Location = new System.Drawing.Point(228, 21);
            this.cgCbx.Name = "cgCbx";
            this.cgCbx.Size = new System.Drawing.Size(156, 16);
            this.cgCbx.TabIndex = 1;
            this.cgCbx.Text = "设置ComponentGroup名称";
            this.cgCbx.UseVisualStyleBackColor = true;
            this.cgCbx.CheckedChanged += new System.EventHandler(this.cgCbx_CheckedChanged);
            // 
            // agCbx
            // 
            this.agCbx.AutoSize = true;
            this.agCbx.Location = new System.Drawing.Point(7, 21);
            this.agCbx.Name = "agCbx";
            this.agCbx.Size = new System.Drawing.Size(150, 16);
            this.agCbx.TabIndex = 0;
            this.agCbx.Text = "为每个文件生成Guid[*]";
            this.agCbx.UseVisualStyleBackColor = true;
            this.agCbx.CheckedChanged += new System.EventHandler(this.agCbx_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "查看输出信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Wix-XML代码生成工具";
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
        private System.Windows.Forms.TextBox cgTbx;
        private System.Windows.Forms.CheckBox ggCbx;
        private System.Windows.Forms.CheckBox sfragCbx;
        private System.Windows.Forms.CheckBox cgCbx;
        private System.Windows.Forms.CheckBox agCbx;
        private System.Windows.Forms.CheckBox suidCbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox sregCbx;
    }
}

