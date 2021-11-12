using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace colorPicker
{
    public partial class frmColorPicker : Form
    {
        Bitmap img;

        public frmColorPicker()
        {
            InitializeComponent();
        }

        private void cmdFolder_Click(object sender, EventArgs e)
        {
            if (txtSelectedFile.Text != "")
            {
                ofdImage.InitialDirectory = txtSelectedFile.Text;
            }

            ofdImage.ShowDialog();
        }

        private void ofdImage_FileOk(object sender, CancelEventArgs e)
        {
            txtSelectedFile.Text = ofdImage.FileName;
            picMain.ImageLocation = txtSelectedFile.Text;
            img = new Bitmap(txtSelectedFile.Text);
        }

        private void picMain_Click(object sender, EventArgs e)
        {
            if (picMain.Image == null)
            {
                return;
            }

            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            Point coordinates = mouseEvent.Location;


            if (coordinates.X > img.Width || coordinates.Y > img.Height)
            {
                return;
            }

            
            Color color = img.GetPixel(coordinates.X, coordinates.Y);
            txtOutput.AppendText(String.Format(txtFormat.Text, System.Drawing.ColorTranslator.ToHtml(color).Replace("#", "")) + "\r\n");
            txtLastColor.BackColor = color;
            txtLastColor.Text = System.Drawing.ColorTranslator.ToHtml(color);
        }

        private void frmColorPicker_Load(object sender, EventArgs e)
        {

        }

        private void picMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (picMain.Image == null)
            {
                return;
            }

            MouseEventArgs mouseEvent = e;
            Point coordinates = mouseEvent.Location;

            if (coordinates.X >= img.Width || coordinates.Y >= img.Height)
            {
                return;
            }
            
            Color color = img.GetPixel(coordinates.X, coordinates.Y);
            txtMouseColor.BackColor = color;
            txtMouseColor.Text = System.Drawing.ColorTranslator.ToHtml(color);
        }
    }
}
