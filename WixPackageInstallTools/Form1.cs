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
        private string arguments=" ";//参数
        private string targetFilePath;//目标路径
        string output = null;
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
                    harvestType = "file ";
                    string file = openFileDialog1.FileName;
                    SourceTbx.Text = file;
                    soucerFilePath = file+" ";
                    //MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (FolderRbtn.Checked)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    harvestType = "dir ";
                    SourceTbx.Text = folderBrowserDialog1.SelectedPath;
                    soucerFilePath = folderBrowserDialog1.SelectedPath+" ";
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
                targetFilePath= folderBrowserDialog1.SelectedPath;
            }
        }
        /// <summary>
        /// 开始执行heat.exe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            string[] outputStrings;
            string errorSt;
            string Information;
            if (SourceTbx.Text == "" || TargetTbx.Text == "" || TargetNam.Text == "")
            {
                MessageBox.Show("请先选好源文件/文件夹和目标文件夹并填写目标文件的名字，然后在点击开始", "提示");
                return;
            }
            argumentSelect();
            //组织命令
            cmd = "heat " + harvestType + soucerFilePath + arguments + "-out " + targetFilePath + TargetNam.Text.Trim();
            cmd = cmd.Trim().TrimEnd('&') + "&exit"; //说明：不管命令是否成功均执行exit命令，否则当调用ReadToEnd()方法时，会处于假死状态
            try
            {
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
                    output ="生成时间："+ DateTime.Now.ToString()+"\r"+ p.StandardOutput.ReadToEnd();
                    p.WaitForExit(); //等待程序执行完退出进程
                    p.Close();
                    outputStrings= output.Split(new string[]{"\r\n"}, StringSplitOptions.None);
                    errorSt = outputStrings[outputStrings.Length - 2];
                    if (errorSt == "")
                    {
                        Information = "生成成功，是否打开文件夹";
                    }
                    else
                    {
                        Information = "生成失败,是否查看输出信息";
                    }
                }

                if (errorSt == "")
                {
                    if (MessageBox.Show(Information, "生成提示信息", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start(@targetFilePath);
                    }
                }
                else
                {
                    if (MessageBox.Show(Information, "生成提示信息", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        OutPutForm outPutForm = new OutPutForm();
                        outPutForm.outPutText(output);
                        outPutForm.Show();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(),"错误提示");
            }
        }

        private void cgCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (cgCbx.Checked)
            {
                cgTbx.Enabled = true;
            }
            else
            {
                cgTbx.Enabled = false;
            }
        }
        /// <summary>
        /// 选择参数
        /// </summary>
        private void argumentSelect()
        {
            arguments = " ";
            if (agCbx.Checked == true)
            {
                arguments = arguments + "-ag ";
            }
            if (ggCbx.Checked == true)
            {
                arguments = arguments + "-gg ";
            }

            if (cgCbx.Checked == true)
            {
                arguments = arguments + "-cg " + cgTbx.Text.Trim() + " ";
            }
            if (sfragCbx.Checked == true)
            {
                arguments = arguments + "-sfrag ";
            }
            if (suidCbx.Checked == true)
            {
                arguments = arguments + "-suid ";
            }


            if (sregCbx.Checked == true)
            {
                arguments = arguments + "-sreg ";
            }
        }

        #region 两种GUID只能选一个
        private void agCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (agCbx.Checked == true)
            {
                if (ggCbx.Checked == true)
                {
                    ggCbx.Checked = false;
                }
            }
        }
        private void ggCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (ggCbx.Checked == true)
            {
                if (agCbx.Checked == true)
                {
                    agCbx.Checked = false;
                }
            }
        }

        #endregion

        /// <summary>
        /// 查看输出信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OutPutForm outPutForm=new OutPutForm();
            outPutForm.outPutText(output);
            outPutForm.Show();
        }
    }

}
