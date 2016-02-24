using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace prorr
{
    public partial class Form1 : Form
    {

        Bitmap zrodlo;
        private int bytesPerPixel;

        public Form1()
        {
            InitializeComponent();
        }






        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "lake")
            {
                obraz.Image = Properties.Resources.lake;
                zrodlo = Properties.Resources.lake;
            }
            if (comboBox2.SelectedItem.ToString() == "city")
            {
                obraz.Image = Properties.Resources.city;
                zrodlo = Properties.Resources.city;
            }
            if (comboBox2.SelectedItem.ToString() == "(wybierz tło")
            {
                MessageBox.Show("wybierz tło");//, MessageBoxButtons.OK);

            }
        }
        private void trackF_Scroll(object sender, EventArgs e)
        {
            f1.Text = trackF.Value.ToString();
           
        }

        private void trackFocal_Scroll(object sender, EventArgs e)
        {
            focal.Text = trackFocal.Value.ToString();
        }

        

       


            private double[] gaussianArray(double factor, int width)
        {
            double[] result = new double[width];
            for (var i = 0; i < width; i++)
            {
                result[i] = (1 / (Math.Sqrt(2.0 * Math.PI) * factor)) * Math.Exp(-(i * i) / (2.0 * factor * factor));
                if (result[i] < 0.003)
                {
                    double[] subArray = new double[i];
                    for (int j = 0; j < i; j++)
                    {
                        subArray[j] = result[j];
                    }
                    return subArray;
                }
            }
            return result;
        }

        
        private void blurHorizontal(int y, double[] blurArray, byte[] pixelValues, int stride, int width)
        {
            bytesPerPixel = Image.GetPixelFormatSize(zrodlo.PixelFormat) / 8;
            double[] pixelBytes = new double[bytesPerPixel];
            for (var x = 0; x < width; x++)
            {
                int index = y * stride + x * bytesPerPixel;
                for (int i = 0; i < bytesPerPixel; i++)
                {
                    pixelBytes[i] = pixelValues[index + i] * blurArray[0];
                }
                double sum = blurArray[0];
                for (var k = 1; k < blurArray.Length; k++)
                {
                    if (x + k >= width)
                    {
                        index = y * stride + (x + k + 1 - width) * bytesPerPixel;
                    }
                    else
                    {
                        index = y * stride + (x + k) * bytesPerPixel;
                    }
                    for (int i = 0; i < bytesPerPixel; i++)
                    {
                        pixelBytes[i] += pixelValues[index + i] * blurArray[k];
                    }
                    if (x - k < 0)
                    {
                        index = y * stride + Math.Abs(x - k) * bytesPerPixel;
                    }
                    else
                    {
                        index = y * stride + (x - k) * bytesPerPixel;
                    }
                    for (int i = 0; i < bytesPerPixel; i++)
                    {
                        pixelBytes[i] += pixelValues[index + i] * blurArray[k];
                    }
                    sum += 2 * blurArray[k];
                }
                index = y * stride + x * bytesPerPixel;
                for (int i = 0; i < bytesPerPixel; i++)
                {
                    pixelValues[index + i] = (byte)(pixelBytes[i] / sum);
                }
            }
        }

       
        private void blurVertical(int y, double[] blurArray, byte[] pixelValues, int stride, int width, int height)
        {
            bytesPerPixel = Image.GetPixelFormatSize(zrodlo.PixelFormat) / 8;
            double[] pixelBytes = new double[bytesPerPixel];
            for (var x = 0; x < width; x++)
            {
                int index = y * stride + x * bytesPerPixel;
                for (int i = 0; i < bytesPerPixel; i++)
                {
                    pixelBytes[i] = pixelValues[index + i] * blurArray[0];
                }
                double sum = blurArray[0];
                for (var k = 1; k < blurArray.Length; k++)
                {
                    if (y + k >= height)
                    {
                        index = (y + k + 1 - height) * stride + x * bytesPerPixel;
                    }
                    else
                    {
                        index = (y + k) * stride + x * bytesPerPixel;
                    }
                    for (int i = 0; i < bytesPerPixel; i++)
                    {
                        pixelBytes[i] += pixelValues[index + i] * blurArray[k];
                    }
                    if (y - k < 0)
                    {
                        index = Math.Abs(y - k) * stride + x * bytesPerPixel;
                    }
                    else
                    {
                        index = (y - k) * stride + x * bytesPerPixel;
                    }
                    for (int i = 0; i < bytesPerPixel; i++)
                    {
                        pixelBytes[i] += pixelValues[index + i] * blurArray[k];
                    }
                    sum += 2 * blurArray[k];
                }
                index = y * stride + x * bytesPerPixel;
                for (int i = 0; i < bytesPerPixel; i++)
                {
                    pixelValues[index + i] = (byte)(pixelBytes[i] / sum);
                }
            }
        }
        private void resultDOF_Click(object sender, EventArgs e)
        {
            int f = int.Parse(f1.Text);
            int F = int.Parse(focal.Text);
            double c = 0.0170;
            double Dn, Df;
            double hiper;
            double proc;
            double h;
            double ratio;

            if (zrodlo == null) { MessageBox.Show("Wybierz tło"); }
            else {

                hiper = (F * F) / (f * c);
                hip.Text = Math.Round((hiper / 1000),2).ToString();

                Dn = ((hiper / 1000) * (double.Parse(distance.Text)) / ((hiper / 1000) + (double.Parse(distance.Text))));
                Df = ((hiper / 1000) * (double.Parse(distance.Text)) / ((hiper / 1000) - (double.Parse(distance.Text))));

                dof.Text = Math.Round((Df - Dn),2).ToString();
                DOFn.Text = Math.Round(Dn,2).ToString();
                DOFf.Text = Math.Round(Df,2).ToString();
                h = Math.Round(hiper / 1000, 2);
                proc = Math.Round((Math.Round(Df - (double.Parse(distance.Text)), 5) / (Df - Dn)), 3);



                if (proc <= 0.50)
                {
                    proc = 0.50;
                }

                ratio = (Math.Abs(54 - (proc * 100)) / 4);


                procent.Text = (proc*100).ToString();

                obraz.Height = obraz.Image.Height;
                obraz.Width = obraz.Image.Width;


                //Kopiuj obrazek zrodlowy
                Bitmap bitmap = (Bitmap)zrodlo.Clone();
                obraz.Image = bitmap;



                //Pobierz wartosc wszystkich punktow obrazu
                BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, obraz.Width, obraz.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                byte[] pixelValues = new byte[Math.Abs(bmpData.Stride) * obraz.Height];
                System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixelValues, 0, pixelValues.Length);

                //Dane obszarów
                int width = obraz.Width;
                int height = obraz.Height;

                double outFocusBlur;


                if (proc >= 0.54)
                {
                    outFocusBlur = 0.3;
                }
                else
                {
                    outFocusBlur = 19.7 * ratio;
                    //blur.Text = outFocusBlur.ToString();
                }
                //Rozmyj w poziomie obraz pod obszarem ostrym
                for (int y = 0; y < height; y++)
                {
                    // double factor = (y - outFocusStartDown) / outFocusHeight;
                    double[] blurArray = gaussianArray(outFocusBlur, width);
                    blurHorizontal(y, blurArray, pixelValues, bmpData.Stride, width);
                }


                //Rozmyj w pionie obraz pod obszarem ostrym
                for (int y = 0; y < height; y++)
                {
                    //double factor = (y - outFocusStartDown) / outFocusHeight;
                    double[] blurArray = gaussianArray(outFocusBlur, width);
                    //double[] blurArray = null;
                    blurVertical(y, blurArray, pixelValues, bmpData.Stride, width, height);
                }

                System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, bmpData.Scan0, pixelValues.Length);
                bitmap.UnlockBits(bmpData);






            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DOFf_Click(object sender, EventArgs e)
        {

        }
    }
}
