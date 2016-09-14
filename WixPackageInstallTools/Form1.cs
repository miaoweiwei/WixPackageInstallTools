using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WixPackageInstallTools
{
    public partial class Form1 : Form
    {
        private string cmd = "heat";
        private string harvestType;//得到类型
        private string soucerFilePath;//源路径
        private string arguments;//参数
        private string targetFilePath;//目标路径
        public Form1()
        {
            InitializeComponent();

        }

        private void FileRbtn_CheckedChanged(object sender, EventArgs e)
        {
            SourceTbx.Text = "";
        }
        private void FolderRbtn_CheckedChanged(object sender, EventArgs e)
        {
            SourceTbx.Text = "";
        }
        /// <summary>
        /// 选中源文件/文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourceBtn_Click(object sender, EventArgs e)
        {
            if (FileRbtn.Checked)
            {
                openFileDialog1.Multiselect = false; //是否允许选中多个文件
                openFileDialog1.Title = "请选择文件";
                openFileDialog1.Filter = "所有文件(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    harvestType = "file";
                    string file = openFileDialog1.FileName;
                    SourceTbx.Text = file;
                    soucerFilePath = file;
                    //MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (FolderRbtn.Checked)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    harvestType = "dir";
                    SourceTbx.Text = folderBrowserDialog1.SelectedPath;
                    soucerFilePath = folderBrowserDialog1.SelectedPath;
                }
            }
        }
        /// <summary>
        /// 选中目标文件/文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TargetBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TargetTbx.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        /// <summary>
        /// 开始执行heat.exe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (SourceTbx.Text == "" || TargetTbx.Text == "" || TargetNam.Text == "")
            {
                MessageBox.Show("请先选好源文件/文件夹和目标文件夹并填写目标文件的名字，然后在点击开始", "提示");
                return;
            }
          
            if (FileRbtn.Checked)
            {
                cmd = cmd + harvestType + soucerFilePath.Trim() + arguments + " -out " + targetFilePath.Trim() + TargetNam.Text.Trim();
            }
            else if (FolderRbtn.Checked)
            {
                cmd = cmd + harvestType + soucerFilePath.Trim() + " -out " + targetFilePath.Trim() + TargetNam.Text.Trim();
            }

            string output = null;
            cmd = cmd.Trim().TrimEnd('&') + "&exit"; //说明：不管命令是否成功均执行exit命令，否则当调用ReadToEnd()方法时，会处于假死状态
            using (Process p = new Process())
            {
                p.StartInfo.FileName = @"cmd.exe";   //执行exe的路径
                p.StartInfo.UseShellExecute = false; //是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true; //接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true; //由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true; //重定向标准错误输出
                p.StartInfo.CreateNoWindow = true; //不显示程序窗口
                p.Start(); //启动程序

                //向cmd窗口写入命令
                p.StandardInput.WriteLine(cmd);
                p.StandardInput.AutoFlush = true;

                //获取cmd窗口的输出信息
                output = p.StandardOutput.ReadToEnd();
                p.WaitForExit(); //等待程序执行完退出进程
                p.Close();
            }
        }

        private void CgBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CgBtn.Checked)
            {
                CgTbx.Enabled = true;
            }
            else
            {
                CgTbx.Enabled = false;
            }
        }
    }

}
