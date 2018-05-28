using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_editor_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image file;
        public Boolean open = false; //to check image is opened or not
        public void OpenImage()
        {
            DialogResult check = new DialogResult();
            check = openFileDialog1.ShowDialog();
            if (check == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                open = true;
            }
        }
        public void SaveImage()
        {
            if (!open)
            {
                MessageBox.Show("No image was selected");
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                ImageFormat format = ImageFormat.Png;
                save.Filter = "Images|*.png;*.bmp;*.jpg";

                if(save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(save.FileName);
                    switch(ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(save.FileName, format);
                    MessageBox.Show("Image has been saved successfully");
                }
            }
        }

        public void reopen()
        {
            if (!open)
            {
                //MessageBox.Show("No image was selected");
            }
            else
            {
                if (open)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = file;
                    open = true;
                }
            }
        }
        public void none()
        {
            if (!open)
            {
                MessageBox.Show("No image was selected");
            }
            else
            {
                if (open)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = file;
                    open = true;
                }
            }
        }
        public void sepia()
        {
            if (!open)
            {
                MessageBox.Show("Select an image and then apply filter");
            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ .385f, .356f+0.5f, .280f, 0, 0},
                    new float[]{ .769f+.3f, .686f, .534f, 0, 0},
                    new float[]{ .189f, .168f, .131f+0.5f, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ 0, 0, 0, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);
           
                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void suji()
        {
            if (!open)
            {
                MessageBox.Show("Select an image and then apply filter");
            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ .270f, .112f, .56f, 0, 0},
                    new float[]{ .212f, .402f, .534f, 0, 0},
                    new float[]{ .189f, .168f, .131f+0.5f, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ 0, 0, 0, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);

                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void flash()
        {
            if (!open)
            {
                MessageBox.Show("Select an image and then apply filter");
            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ .359f, .302f, .56f, 0, 0},
                    new float[]{ .336f, .545f, .98f, 0, 0},
                    new float[]{ .356f, .198f, .431f, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ 0, 0, 0, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);

                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void dramatic()
        {
            if (!open)
            {
                MessageBox.Show("Select an image and then apply filter");
            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ .689f, .596f, .499f, 0, 0},
                    new float[]{ .509f, .686f, .346f, 0, 0},
                    new float[]{ .545f, .632f, .963f, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ 0, 0, 0, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);

                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void artistic()
        {
            if (!open)
            {
                MessageBox.Show("Select an image and then apply filter");
            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ .232f, .356f, .280f+264f, 0, 0},
                    new float[]{ .169f, .686f, .534f, 0, 0},
                    new float[]{ .189f, .168f, .131f+0.5f, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ 0, 0, 0, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);

                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void gray()
        {
            if (!open)
            {
                MessageBox.Show("Select an image and then apply filter");
            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ .299f, .299f, .299f, 0, 0},
                    new float[]{ .587f, .587f, .587f, 0, 0},
                    new float[]{ .114f, .114f, .114f, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ 0, 0, 0, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);

                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void kakao()
        {
            if (!open)
            {
                MessageBox.Show("Select an image and then apply filter");

            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ .365f, .340f, .78f, 0, 0},
                    new float[]{ .299f, .510f, .352f, 0, 0},
                    new float[]{ .341f, .450f, .431f, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ 0, 0, 0, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);

                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void frozen()
        {
            if (!open)
            {
                MessageBox.Show("Select an image and then apply filter");
            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ .612f, .326f, .345f, 0, 0},
                    new float[]{ .930f, .732f, .496f, 0, 0},
                    new float[]{ .896f, .318f, .980f, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ 0, 0, 0, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);

                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void spike()
        {
            if (!open)
            {
                MessageBox.Show("Select an image and then apply filter");
            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ .345f, .596f, .654f, 0, 0},
                    new float[]{ .111f, .596f, .345f, 0, 0},
                    new float[]{ .596f, .345f, .302f, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ 0, 0, 0, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);

                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void RGB()
        {
            float changered = redbar.Value * 0.001f;
            float changegreen = greenbar.Value * 0.001f;
            float changeblue = bluebar.Value * 0.001f;
            reopen();
            if (!open)
            {
                MessageBox.Show("Select an image first");
            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ 1+changered, 0, 0, 0, 0},
                    new float[]{ 0, 1+changegreen, 0, 0, 0},
                    new float[]{ 0, 0, 1+changeblue, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ 0, 0, 0, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);

                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void Brightness()
        {
            float changebrightness = brightnessbar.Value * 0.002f;
            reopen();
            if (!open)
            {
                MessageBox.Show("Select an image first");
            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ 1, 0, 0, 0, 0},
                    new float[]{ 0, 1, 0, 0, 0},
                    new float[]{ 0, 0, 1, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ changebrightness, changebrightness, changebrightness, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);

                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void Contrast()
        {
            float changecontrast = contrastbar.Value * 0.02f;
            reopen();
            if (!open)
            {
                MessageBox.Show("Select an image first");
            }
            else
            {
                Image img = pictureBox1.Image;
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix colmat = new ColorMatrix(new float[][]
                {
                    new float[]{ changecontrast, 0, 0, 0, 0},
                    new float[]{ 0, changecontrast, 0, 0, 0},
                    new float[]{ 0, 0, changecontrast, 0, 0},
                    new float[]{ 0, 0, 0, 1, 0},
                    new float[]{ 0.001f, 0.001f, 0.001f, 0, 1}
                });
                attributes.SetColorMatrix(colmat);
                Bitmap bmpinvert = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmpinvert);
                graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);

                graphics.Dispose();
                pictureBox1.Image = bmpinvert;
            }
        }
        public void RotateRight()
        {
            if (!open)
            {
                MessageBox.Show("Select an Image first");
            }
            else
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = img;
            }
        }
        public void RotateLeft()
        {
            if (!open)
            {
                MessageBox.Show("Select an Image first");
            }
            else
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Image = img;
            }
        }
        public void FlipLeftRight()
        {
            if (!open)
            {
                MessageBox.Show("Select an Image first");
            }
            else
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Image = img;
            }
        }
        public void FlipUpDown()
        {
            if(!open)
            {
                MessageBox.Show("Select an Image first");
            }
            else
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Image = img;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reopen();
            sepia();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            none();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reopen();
            suji();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reopen();
            flash();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reopen();
            dramatic();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reopen();
            artistic();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reopen();
            gray();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reopen();
            kakao();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reopen();
            frozen();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reopen();
            spike();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            RGB();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            RGB();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            RGB();
        }

        private void brightnessbar_ValueChanged(object sender, EventArgs e)
        {
            Brightness();
        }

        private void contrastbar_ValueChanged(object sender, EventArgs e)
        {
            Contrast();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RotateRight();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            RotateLeft();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FlipLeftRight();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FlipUpDown();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            none();
        }
    }
}
