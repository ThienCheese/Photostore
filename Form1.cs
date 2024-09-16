using System.Numerics;
using System.Windows.Forms;

namespace Photostore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image[] img = new Image[10];
        int i = 0;
        int index = 0;
        private void OpenBtt_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (pictureBox1.Image == null)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Load(openFileDialog1.FileName);

                }


                foreach (String file in openFileDialog1.FileNames)
                {
                    PictureBox sample = new PictureBox();
                    sample.Height = 100;
                    sample.Width = 100;
                    PictureBox pb = new PictureBox();
                    Image loadedImage = Image.FromFile(file);
                    img[i] = loadedImage;
                    pb.Height = sample.Height;
                    pb.Width = sample.Width;
                    pb.Image = loadedImage;
                    flowLayoutPanel1.Controls.Add(pb);
                    i++;
                    if (i == 10)
                        i = 0;
                }
            }
        }
        private void ClearPic()
        {
            this.pictureBox1.Image = null;
        }

        private void CloseBtt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextBtt_Click(object sender, EventArgs e)
        {
            index++;
            this.pictureBox1.Image = img[index];
            if (index >= i)
                MessageBox.Show("Error: Unvalid Image");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PrevBtt_Click(object sender, EventArgs e)
        {
            index--;
            this.pictureBox1.Image = img[index];
            if (index < 0 )
                MessageBox.Show("Error: Unvalid Image");
        }
    }
}
