﻿using System;
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
        }

        private void picMain_Click(object sender, EventArgs e)
        {
            if (picMain.Image == null)
            {
                return;
            }

            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            Bitmap b = new Bitmap(picMain.Image);
            Color color = b.GetPixel(coordinates.X, coordinates.Y);
            txtOutput.Text += String.Format(txtFormat.Text, System.Drawing.ColorTranslator.ToHtml(color)) + "\r\n";
            picLastColor.BackColor = color;
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

            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            Bitmap b = new Bitmap(picMain.Image);
            Color color = b.GetPixel(coordinates.X, coordinates.Y);
            picMouseColor.BackColor = color;
        }
    }
}