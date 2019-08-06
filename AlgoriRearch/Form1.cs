using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoriRearch
{
    public partial class Form1 : Form
    {
        string folderPath;
        string exportPath;
        private List<string> ImagePaths = new List<string>();
        AlgoriProcess ap = new AlgoriProcess();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_import_Click(object sender, EventArgs e)
        {
            if(folderPathDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                folderPath = folderPathDialog.SelectedPath;
                lab_folderPath.Text = folderPath;
              
                DirectoryInfo folder = new DirectoryInfo(folderPath);
                if(ImagePaths.Count!=0)
                {
                    ImagePaths.Clear();
                }
                foreach (FileInfo file in folder.GetFiles("*.jpg"))
                {
                    ImagePaths.Add(file.Name);
                }
                if (ImagePaths.Count != 0)
                {
                    Lb_imageNames.DataSource = null;
                    Lb_imageNames.DataSource=ImagePaths;
                }
                picShow.ImageLocation = folderPath + "\\" + ImagePaths[0];

            }

        }

        private void Lb_imageNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Lb_imageNames.SelectedItem!=null)
            {
                lb_curPic.Text = Lb_imageNames.SelectedItem.ToString();
                picShow.ImageLocation = lab_folderPath.Text + "\\" + lb_curPic.Text;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (picShow.Image != null)
            {
                Mat inputmat = BitmapConverter.ToMat((Bitmap)picShow.Image);//获取选择图片
                Mat outputmat = ap.Process_One(inputmat);//算法处理
                picShow.Image = BitmapConverter.ToBitmap(outputmat);//显示处理后图片
            }
            else
            {
                MessageBox.Show("未导入图片");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (picShow.Image != null)
            {
                Mat inputmat = BitmapConverter.ToMat((Bitmap)picShow.Image);//获取选择图片
                Mat outputmat = ap.Process_Two(inputmat);//算法处理
                picShow.Image = BitmapConverter.ToBitmap(outputmat);//显示处理后图片
            }
            else
            {
                MessageBox.Show("未导入图片");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (picShow.Image != null)
            {
                Mat inputmat = BitmapConverter.ToMat((Bitmap)picShow.Image);//获取选择图片
                Mat outputmat = ap.Process_Three(inputmat);//算法处理
                picShow.Image = BitmapConverter.ToBitmap(outputmat);//显示处理后图片
            }
            else
            {
                MessageBox.Show("未导入图片");
            }
        }

        private void Btn_DetectBorder_Click(object sender, EventArgs e)
        {
            if (picShow.Image != null)
            {
                Mat inputmat = BitmapConverter.ToMat((Bitmap)picShow.Image);//获取选择图片
                Mat outputmat = ap.Change_CI(inputmat);//检测边缘
                picShow.Image = BitmapConverter.ToBitmap(outputmat);//显示处理后图片
            }
            else
            {
                MessageBox.Show("未导入图片");
            }
        }

        private void Btn_export_Click(object sender, EventArgs e)
        {

         
            if(ImagePaths.Count!=0 && (folderPexportDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                
                exportPath = folderPexportDialog.SelectedPath;
                lab_exportPath.Text = exportPath;
                exportPath += "\\";
                Application.DoEvents();

                StringBuilder importpath = new StringBuilder(folderPath);
                importpath.Append("\\");

                int imgcounts = 0;         //基于内存考虑，不宜多，没想到怎么解决
                if(ImagePaths.Count>100)
                {
                    imgcounts = 100;
                }
                else
                {
                    imgcounts = ImagePaths.Count;
                }

                progressBar_export.Maximum = imgcounts;  
                for (int i = 0; i < imgcounts; i++)      
                {  
                    progressBar_export.Value = i + 1;
  
                    Mat curImg = Cv2.ImRead(importpath + ImagePaths[i], ImreadModes.Grayscale);
                    Mat outputmat = ap.Processes(curImg);//按顺序处理图片
                    Cv2.ImWrite(exportPath + ImagePaths[i], outputmat);
                    //ReduceMemory();
                }
                progressBar_export.Value = 0;
                MessageBox.Show("导出图片完毕");
            }
            else
            {
                if(ImagePaths.Count==0)
                {
                    MessageBox.Show("未导入图片");
                }
                else
                {
                    MessageBox.Show("未选择导出路径");
                }

            }
        }

        private void ReduceMemory()
        {
            Process A = Process.GetCurrentProcess();
            A.MaxWorkingSet = Process.GetCurrentProcess().MaxWorkingSet;
            A.Dispose();
        }
    }
}
