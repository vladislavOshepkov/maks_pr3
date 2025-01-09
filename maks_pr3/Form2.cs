using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maks_pr3
{
    public partial class paint : Form
    {
        public paint()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }
        Color DefaultColor
        {
            get { return Color.White; }
        }
        int _x;
        int _y;
        bool _mouseClicked = false;
        Color SelectedColor
        {
            get { return Color.Purple; }
        }
        int SelectedSize
        {
            get { return trbBrushSize.Value; }
        }
        Brush _selectedBrush;
        void CreateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
                pictureBox1.Image = bmp;
                if (oldImage != null) oldImage.Dispose();
            }
        }

        private void btnFigure_square_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null) return;
            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            _mouseClicked = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFigure_circle_Click(object sender, EventArgs e)
        {
            _selectedBrush = new CircleBrush(SelectedColor, SelectedSize);
        }

        private void btnFigure_rectangle_Click(object sender, EventArgs e)
        {
            _selectedBrush = new RingBrush(SelectedColor, SelectedSize);
        }

        private void btnFigure_slash_Click(object sender, EventArgs e)
        {
            _selectedBrush = new SlashBrush(SelectedColor, SelectedSize);
        }

        private void btnFigure_backSlash_Click(object sender, EventArgs e)
        {
            _selectedBrush = new BackSlashBrush(SelectedColor, SelectedSize);
        }
    }
}
