namespace WixPackageInstallTools
{
    partial class OutPutForm
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
            this.outPutRtbx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // outPutRtbx
            // 
            this.outPutRtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outPutRtbx.Location = new System.Drawing.Point(0, 0);
            this.outPutRtbx.Name = "outPutRtbx";
            this.outPutRtbx.Size = new System.Drawing.Size(493, 271);
            this.outPutRtbx.TabIndex = 0;
            this.outPutRtbx.Text = "";
            // 
            // OutPutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 271);
            this.Controls.Add(this.outPutRtbx);
            this.Name = "OutPutForm";
            this.Text = "输出信息";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox outPutRtbx;
    }
}