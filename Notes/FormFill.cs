using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using Notes;

namespace Notes
{
	public partial class FormFill : Form
	{
		public FormFill()
		{
			InitializeComponent();
			bool firstStartName = true;
			bool firstStartText = true;
		}
		private void FormFill_Load(object sender, EventArgs e)
		{
			pictureBox1.Image = Properties.Resources.Download_150;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Properties.Resources.Download_150;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Properties.Resources.Download_150;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Properties.Resources.Download_150;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

        }
		private void textName_Click(object sender, EventArgs e)
		{
			if (textName.ForeColor == System.Drawing.Color.Gray)
			{
				textName.Text = "";
				textName.ForeColor = System.Drawing.Color.Black;
			}
			
		}
		private void textText_Click(object sender, EventArgs e)
		{
			if (textText.ForeColor == System.Drawing.Color.Gray)
			{
                textText.Text = "";
                textText.ForeColor = System.Drawing.Color.Black;
            }

		}
		private void textName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (textName.ForeColor == System.Drawing.Color.Gray)
			{
                textName.Text = "";
                textName.ForeColor = System.Drawing.Color.Black;
            }

            char ch = e.KeyChar;
            if (ch ==';')
			{
				e.Handled = true;
			}
		}
        private void textText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textText.ForeColor == System.Drawing.Color.Gray)
            {
                textText.Text = "";
                textText.ForeColor = System.Drawing.Color.Black;
            }

            char ch = e.KeyChar;
            if (ch == ';')
            {
                e.Handled = true;
            }
        }

        private void cancelButton_Click(object sender, MouseEventArgs e)
		{
			this.Close();
		}
		private void saveButton_Click(object sender, MouseEventArgs e)
		{
			string name = textName.Text;
			string text = textText.Text;
			using (StreamWriter writer = new StreamWriter("C:\\Users\\Creep\\source\\repos\\Notes\\Base\\Base.txt", true))
			{
				writer.WriteLine(name+";"+text);
			}
			pictureBox1.Image.Save(@"C:\Users\Creep\source\repos\Notes\Base\images\" + textName.Text + "1.jpg");
			pictureBox2.Image.Save(@"C:\Users\Creep\source\repos\Notes\Base\images\" + textName.Text + "2.jpg");
			pictureBox3.Image.Save(@"C:\Users\Creep\source\repos\Notes\Base\images\" + textName.Text + "3.jpg");
			pictureBox4.Image.Save(@"C:\Users\Creep\source\repos\Notes\Base\images\" + textName.Text + "4.jpg");
			this.Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openPicture1 = new OpenFileDialog();
			openPicture1.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";
			if (openPicture1.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(openPicture1.FileName);
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			}
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openPicture2 = new OpenFileDialog();
			openPicture2.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";
			if (openPicture2.ShowDialog() == DialogResult.OK)
			{
				pictureBox2.Image = Image.FromFile(openPicture2.FileName);
				pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			}
		}
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPicture3 = new OpenFileDialog();
            openPicture3.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";
            if (openPicture3.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(openPicture3.FileName);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPicture4 = new OpenFileDialog();
            openPicture4.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";
            if (openPicture4.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(openPicture4.FileName);
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


    }
}
