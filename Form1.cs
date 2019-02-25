using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Dithering
{
    public partial class Form1 : MetroForm
    {
        private string pathToImage = null;
        private Thread ditheringImageThread;

        private int saturated_add(int val1, int val2)
        {
            int val1_int = val1;
            int val2_int = val2;
            int tmp = val1_int + val2_int;

            if (tmp > 255)
            {
                return 255;
            }
            else if (tmp < 0)
            {
                return 0;
            }
            else
            {
                return tmp;
            }
        }

        private void DitheringImage()
        {
            Bitmap bitmap = _PictureBox1.Image as Bitmap;
            Bitmap modifiedBitmap = _PictureBox1.Image as Bitmap;

            Invoke((Action)(() =>
            {
                _ProgressBar.Maximum = bitmap.Size.Width * bitmap.Size.Height - 1;
                _ProgressBar.Show();

                int[][] buffer = new int[bitmap.Size.Height][];

                for (int i = 0; i < bitmap.Size.Height; i++)
                    buffer[i] = new int[bitmap.Size.Width];

                for (int y = 0; y < bitmap.Size.Height; y++)
                {
                    for (int x = 0; x < bitmap.Size.Width; x++)
                    {
                        buffer[y][x] = bitmap.GetPixel(x, y).R;
                    }
                }

                int err = 0, a = 0, b = 0, c = 0, d = 0;

                for (int y = 0; y < bitmap.Size.Height; y++)
                {
                    err = 0;

                    for (int x = 0; x < bitmap.Size.Width; x++)
                    {
                        _ProgressBar.Value += 1;

                        buffer[y][x] = bitmap.GetPixel(x, y).R;

                        if ((bitmap.GetPixel(x, y).R + buffer[y][x]) - err > 127)
                        {
                            err = 255 - bitmap.GetPixel(x, y).R + buffer[y][x];
                            bitmap.SetPixel(x, y, Color.White);
                        }
                        else
                        {
                            err = 0 - bitmap.GetPixel(x, y).R + buffer[y][x];
                            bitmap.SetPixel(x, y, Color.Black);
                        }

                        a = (err * 7) / 16;
                        b = (err * 1) / 16;
                        c = (err * 5) / 16;
                        d = (err * 3) / 16;

                        if ((y != 0) && (y != (bitmap.Size.Height - 1)) && (x != 0) && (x != (bitmap.Size.Width - 1)))
                        {
                            buffer[y + 0][x + 1] = saturated_add(bitmap.GetPixel(x + 0, y + 1).R + buffer[y + 0][x + 1], a);
                            buffer[y + 1][x + 1] = saturated_add(bitmap.GetPixel(x + 1, y + 1).R + buffer[y + 1][x + 1], b);
                            buffer[y + 1][x + 0] = saturated_add(bitmap.GetPixel(x + 1, y + 0).R + buffer[y + 1][x + 0], c);
                            buffer[y + 1][x - 1] = saturated_add(bitmap.GetPixel(x + 1, y - 1).R + buffer[y + 1][x - 1], d);
                        }
                    }
                }

                _ProgressBar.Hide();
                _ProgressBar.Value = 0;
                _PictureBox2.Image = bitmap;
            }));

            ditheringImageThread.Abort();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _PictureBox1.Load("images/image.jpg");
            _PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            _PictureBox2.Load("images/image.jpg");
            _PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            _ProgressBar.Hide();
        }

        private void _ButtonImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pathToImage = fileDialog.FileName;
            }

            _PictureBox1.Load(pathToImage);
        }

        private void _ButtonDithering_Click(object sender, EventArgs e)
        {
            ditheringImageThread = new Thread(DitheringImage);
            ditheringImageThread.Start();
        }
    }
}
