using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PhotoViewer2_07
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private List<FileInfo> allFilesInfo = new List<FileInfo>();
        private List<FileInfo> displayedFilesInfo = new List<FileInfo>();
        private int currentImageIndex = -1;
        private string currentFolderPath = string.Empty;

        private readonly string[] supportedExtensions = new string[] { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

        public Form1()
        {
            InitializeComponent();
            cmbSort.SelectedIndex = 0; // this is default select: "Newest"
            ShowThumbnailView();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    LoadFolder(fbd.SelectedPath);
                }
            }
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySortAndFilter();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySortAndFilter();
        }

        private void LoadFolder(string path)
        {
            if (!Directory.Exists(path))
                return;

            currentFolderPath = path;
            lblTitle.Text = string.Format("PhotoViewer 2.07  {0}", path);

            allFilesInfo.Clear();

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                FileInfo[] files = dirInfo.GetFiles();

                foreach (FileInfo file in files)
                {
                    if (supportedExtensions.Contains(file.Extension.ToLower()))
                    {
                        allFilesInfo.Add(file);
                    }
                }

                ApplySortAndFilter();
            }
            catch (Exception ex)
            {
                lblStatus.Text = string.Format("Error loading directory: {0}", ex.Message);
            }
        }

        private void ApplySortAndFilter()
        {
            string query = txtSearch.Text.Trim();

           
            if (string.IsNullOrEmpty(query))
            {
                displayedFilesInfo = new List<FileInfo>(allFilesInfo);
            }
            else
            {
                displayedFilesInfo = allFilesInfo.Where(f => f.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            
            string sortOption = cmbSort.SelectedItem != null ? cmbSort.SelectedItem.ToString() : "Newest";

            switch (sortOption)
            {
                case "Oldest":
                    displayedFilesInfo = displayedFilesInfo.OrderBy(f => f.LastWriteTime).ToList();
                    break;
                case "Name (A-Z)":
                    displayedFilesInfo = displayedFilesInfo.OrderBy(f => f.Name).ToList();
                    break;
                case "Name (Z-A)":
                    displayedFilesInfo = displayedFilesInfo.OrderByDescending(f => f.Name).ToList();
                    break;
                case "Newest":
                default:
                    displayedFilesInfo = displayedFilesInfo.OrderByDescending(f => f.LastWriteTime).ToList();
                    break;
            }

            RebuildThumbnailGrid();
        }

        private void RebuildThumbnailGrid()
        {
            flowLayoutPanelThumbnails.Controls.Clear();

            foreach (FileInfo file in displayedFilesInfo)
            {
                ImageTile tile = new ImageTile();
                Image thumb = CreateThumbnail(file.FullName, 64, 64);
                tile.SetAsImage(file.FullName, thumb);
                tile.TileClicked += Tile_TileClicked;
                flowLayoutPanelThumbnails.Controls.Add(tile);
            }

            lblStatus.Text = string.Format("{0} item(s) loaded", displayedFilesInfo.Count);
            ShowThumbnailView();
        }

        private Image CreateThumbnail(string filePath, int width, int height)
        {
            try
            {
                using (Image original = Image.FromFile(filePath))
                {
                    return original.GetThumbnailImage(width, height, () => false, IntPtr.Zero);
                }
            }
            catch
            {
                return null;
            }
        }

        private void Tile_TileClicked(object sender, EventArgs e)
        {
            ImageTile tile = sender as ImageTile;
            if (tile == null)
                return;

            if (!tile.IsFolder)
            {
                int index = displayedFilesInfo.FindIndex(f => f.FullName == tile.FilePath);
                if (index >= 0)
                {
                    DisplayImage(index);
                }
            }
        }

        private void DisplayImage(int index)
        {
            if (index < 0 || index >= displayedFilesInfo.Count)
                return;

            currentImageIndex = index;
            string filePath = displayedFilesInfo[currentImageIndex].FullName;

            if (pictureBoxFull.Image != null)
            {
                pictureBoxFull.Image.Dispose();
                pictureBoxFull.Image = null;
            }

            try
            {
                pictureBoxFull.Image = Image.FromFile(filePath);

                lblStatus.Text = string.Format(
                    "[{0}/{1}] {2}",
                    currentImageIndex + 1,
                    displayedFilesInfo.Count,
                    Path.GetFileName(filePath));

                ShowImageViewer();
            }
            catch (Exception ex)
            {
                lblStatus.Text = string.Format("Error opening file: {0}", ex.Message);
            }
        }

        private void ShowThumbnailView()
        {
            panelThumbnailView.Visible = true;
            panelImageViewer.Visible = false;
        }

        private void ShowImageViewer()
        {
            panelThumbnailView.Visible = false;
            panelImageViewer.Visible = true;
        }

        private void btnBackToThumbnails_Click(object sender, EventArgs e)
        {
            ShowThumbnailView();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            NavigatePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NavigateNext();
        }

        private void NavigatePrevious()
        {
            if (displayedFilesInfo.Count == 0)
                return;

            if (currentImageIndex > 0)
            {
                DisplayImage(currentImageIndex - 1);
            }
            else
            {
                DisplayImage(displayedFilesInfo.Count - 1);
            }
        }

        private void NavigateNext()
        {
            if (displayedFilesInfo.Count == 0)
                return;

            if (currentImageIndex < displayedFilesInfo.Count - 1)
            {
                DisplayImage(currentImageIndex + 1);
            }
            else
            {
                DisplayImage(0);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (panelImageViewer.Visible)
            {
                if (e.KeyCode == Keys.Left)
                {
                    NavigatePrevious();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    NavigateNext();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Back)
                {
                    ShowThumbnailView();
                    e.Handled = true;
                }
            }
        }
    }
}