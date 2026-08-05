using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhotoViewer2_07
{
    public partial class ImageTile : UserControl
    {
        public string FilePath { get; private set; }
        public bool IsFolder { get; private set; }
        public event EventHandler TileClicked;

        public ImageTile()
        {
            InitializeComponent();
            SetupEvents();
        }

        private void SetupEvents()
        {
            this.Click += ImageTile_Click;
            pictureBoxIcon.Click += ImageTile_Click;
            lblTitle.Click += ImageTile_Click;

            this.MouseEnter += ImageTile_MouseEnter;
            pictureBoxIcon.MouseEnter += ImageTile_MouseEnter;
            lblTitle.MouseEnter += ImageTile_MouseEnter;

            this.MouseLeave += ImageTile_MouseLeave;
            pictureBoxIcon.MouseLeave += ImageTile_MouseLeave;
            lblTitle.MouseLeave += ImageTile_MouseLeave;
        }

        public void SetAsFolder(string folderPath, string folderName)
        {
            FilePath = folderPath;
            IsFolder = true;
            lblTitle.Text = folderName;
            pictureBoxIcon.Image = CreateFolderIcon();
        }

        public void SetAsImage(string filePath, Image thumbnail)
        {
            FilePath = filePath;
            IsFolder = false;
            lblTitle.Text = Path.GetFileName(filePath);

            if (thumbnail != null)
            {
                pictureBoxIcon.Image = thumbnail;
            }
            else
            {
                pictureBoxIcon.Image = CreateDefaultImageIcon();
            }
        }

        private Image CreateFolderIcon()
        {
            Bitmap bmp = new Bitmap(64, 64);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                using (Brush folderBrush = new SolidBrush(Color.FromArgb(0, 120, 215)))
                using (Brush tabBrush = new SolidBrush(Color.FromArgb(230, 160, 40)))
                {
                    g.FillRectangle(tabBrush, 8, 12, 20, 8);
                    g.FillRectangle(folderBrush, 8, 18, 48, 34);
                }
            }
            return bmp;
        }

        private Image CreateDefaultImageIcon()
        {
            Bitmap bmp = new Bitmap(64, 64);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                using (Pen pen = new Pen(Color.FromArgb(0, 150, 220), 2))
                using (Brush brush = new SolidBrush(Color.FromArgb(0, 120, 215)))
                {
                    g.DrawRectangle(pen, 10, 10, 44, 44);
                    g.FillPolygon(brush, new Point[] {
                        new Point(16, 46),
                        new Point(28, 28),
                        new Point(36, 38),
                        new Point(42, 32),
                        new Point(48, 46)
                    });
                }
            }
            return bmp;
        }

        private void ImageTile_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 60, 90);
        }

        private void ImageTile_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void ImageTile_Click(object sender, EventArgs e)
        {
            if (TileClicked != null)
            {
                TileClicked(this, EventArgs.Empty);
            }
        }
    }
}