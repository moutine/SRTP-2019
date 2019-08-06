namespace AlgoriRearch
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
            this.picShow = new System.Windows.Forms.PictureBox();
            this.Btn_import = new System.Windows.Forms.Button();
            this.Lb_imageNames = new System.Windows.Forms.ListBox();
            this.lab_folderPath = new System.Windows.Forms.Label();
            this.folderPathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lb_curPic = new System.Windows.Forms.Label();
            this.Btn_DetectBorder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_export = new System.Windows.Forms.Button();
            this.progressBar_export = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.folderPexportDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lab_exportPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // picShow
            // 
            this.picShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShow.Location = new System.Drawing.Point(250, 57);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(653, 445);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 0;
            this.picShow.TabStop = false;
            // 
            // Btn_import
            // 
            this.Btn_import.Location = new System.Drawing.Point(35, 564);
            this.Btn_import.Name = "Btn_import";
            this.Btn_import.Size = new System.Drawing.Size(94, 38);
            this.Btn_import.TabIndex = 1;
            this.Btn_import.Text = "导入";
            this.Btn_import.UseVisualStyleBackColor = true;
            this.Btn_import.Click += new System.EventHandler(this.Btn_import_Click);
            // 
            // Lb_imageNames
            // 
            this.Lb_imageNames.FormattingEnabled = true;
            this.Lb_imageNames.ItemHeight = 12;
            this.Lb_imageNames.Location = new System.Drawing.Point(24, 57);
            this.Lb_imageNames.Name = "Lb_imageNames";
            this.Lb_imageNames.Size = new System.Drawing.Size(134, 448);
            this.Lb_imageNames.TabIndex = 2;
            this.Lb_imageNames.SelectedIndexChanged += new System.EventHandler(this.Lb_imageNames_SelectedIndexChanged);
            // 
            // lab_folderPath
            // 
            this.lab_folderPath.AutoSize = true;
            this.lab_folderPath.Location = new System.Drawing.Point(12, 9);
            this.lab_folderPath.Name = "lab_folderPath";
            this.lab_folderPath.Size = new System.Drawing.Size(77, 12);
            this.lab_folderPath.TabIndex = 3;
            this.lab_folderPath.Text = "未选择文件夹";
            // 
            // folderPathDialog
            // 
            this.folderPathDialog.Description = "选择存放数据文件夹";
            // 
            // lb_curPic
            // 
            this.lb_curPic.AutoSize = true;
            this.lb_curPic.Location = new System.Drawing.Point(250, 39);
            this.lb_curPic.Name = "lb_curPic";
            this.lb_curPic.Size = new System.Drawing.Size(11, 12);
            this.lb_curPic.TabIndex = 4;
            this.lb_curPic.Text = "-";
            // 
            // Btn_DetectBorder
            // 
            this.Btn_DetectBorder.Location = new System.Drawing.Point(667, 564);
            this.Btn_DetectBorder.Name = "Btn_DetectBorder";
            this.Btn_DetectBorder.Size = new System.Drawing.Size(94, 38);
            this.Btn_DetectBorder.TabIndex = 5;
            this.Btn_DetectBorder.Text = "检测边缘";
            this.Btn_DetectBorder.UseVisualStyleBackColor = true;
            this.Btn_DetectBorder.Click += new System.EventHandler(this.Btn_DetectBorder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "算法待实现1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "算法待实现2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 38);
            this.button3.TabIndex = 8;
            this.button3.Text = "算法待实现3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_export
            // 
            this.Btn_export.Location = new System.Drawing.Point(809, 564);
            this.Btn_export.Name = "Btn_export";
            this.Btn_export.Size = new System.Drawing.Size(94, 38);
            this.Btn_export.TabIndex = 9;
            this.Btn_export.Text = "导出";
            this.Btn_export.UseVisualStyleBackColor = true;
            this.Btn_export.Click += new System.EventHandler(this.Btn_export_Click);
            // 
            // progressBar_export
            // 
            this.progressBar_export.Location = new System.Drawing.Point(664, 521);
            this.progressBar_export.Name = "progressBar_export";
            this.progressBar_export.Size = new System.Drawing.Size(239, 10);
            this.progressBar_export.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "导出进度：";
            // 
            // lab_exportPath
            // 
            this.lab_exportPath.AutoSize = true;
            this.lab_exportPath.Location = new System.Drawing.Point(624, 545);
            this.lab_exportPath.Name = "lab_exportPath";
            this.lab_exportPath.Size = new System.Drawing.Size(17, 12);
            this.lab_exportPath.TabIndex = 12;
            this.lab_exportPath.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 632);
            this.Controls.Add(this.lab_exportPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar_export);
            this.Controls.Add(this.Btn_export);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_DetectBorder);
            this.Controls.Add(this.lb_curPic);
            this.Controls.Add(this.lab_folderPath);
            this.Controls.Add(this.Lb_imageNames);
            this.Controls.Add(this.Btn_import);
            this.Controls.Add(this.picShow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Button Btn_import;
        private System.Windows.Forms.ListBox Lb_imageNames;
        private System.Windows.Forms.Label lab_folderPath;
        private System.Windows.Forms.FolderBrowserDialog folderPathDialog;
        private System.Windows.Forms.Label lb_curPic;
        private System.Windows.Forms.Button Btn_DetectBorder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_export;
        private System.Windows.Forms.ProgressBar progressBar_export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderPexportDialog;
        private System.Windows.Forms.Label lab_exportPath;
    }
}

