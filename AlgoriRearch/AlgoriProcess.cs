using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgoriRearch
{
    class AlgoriProcess
    {
        //Mat srcimg;

        public  Mat Process_One(Mat srcIamge)
        {
            Mat dstIamge = new Mat();
           // Mat srcIamge = new Mat();
            //inputImg.CopyTo(srcIamge);

            //填入算法

            return dstIamge;
        }

        public  Mat Process_Two(Mat srcIamge)
        {
            Mat dstIamge = new Mat();
           // Mat srcIamge = new Mat();
            //inputImg.CopyTo(srcIamge);

            //填入算法

            return dstIamge;
        }
        public  Mat Process_Three(Mat srcIamge)
        {
            Mat dstIamge = new Mat();
            //Mat srcIamge = new Mat();
            //inputImg.CopyTo(srcIamge);

            //填入算法

            return dstIamge;
        }

        public  Mat Processes(Mat srcIamge)
        {
            Mat dstIamge = new Mat();
            //Mat srcIamge = new Mat();
            //inputImg.CopyTo(srcIamge);

            /*
            Mat mat1 = Process_One(srcIamge);
            Mat mat2 = Process_Two(mat1);
            Mat mat3 = Process_Three(mat2);
            dstIamge = Change_CI(mat3);
            */

            dstIamge = Change_CI(srcIamge);

            return dstIamge;
        }

        public  Mat Change_CI(Mat srcIamge)
        {
           
            Mat dstIamge = new Mat();
            Mat grad_x=new Mat(), grad_y=new Mat(), abs_grad_x=new Mat(), abs_grad_y= new Mat();
           // Mat srcIamge = new Mat();
           // inputImg.CopyTo(srcIamge);

            //imshow("原始图", srcIamge);
            //Cv2.CvtColor(srcIamge, srcIamge, ColorConversionCodes.RGB2GRAY);
            //求 X方向梯度
            Cv2.Sobel(srcIamge, grad_x, MatType.CV_16S, 1, 0, 3, 1, 1);
            Cv2.ConvertScaleAbs(grad_x, abs_grad_x);//使用线性变换转换输入数组元素成8位无符号整型
            //imshow("X方向Sobel", abs_grad_x);

            //求Y方向梯度
            Cv2.Sobel(srcIamge, grad_y, MatType.CV_16S, 0, 1, 3, 1, 1);
            Cv2.ConvertScaleAbs(grad_y, abs_grad_y);
            //imshow("Y方向Sobel", abs_grad_y);

            //合并梯度(近似)
            Cv2.AddWeighted(abs_grad_x, 0.5, abs_grad_y, 0.5, 0, dstIamge);
            // imshow("整体方向Sobel", dstIamge);

           // Cv2.ImWrite("F://1.jpg", dstIamge);

            return dstIamge;
        }
    }
}
