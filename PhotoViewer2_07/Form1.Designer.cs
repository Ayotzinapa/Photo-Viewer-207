namespace PhotoViewer2_07
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelThumbnailView = new System.Windows.Forms.Panel();
            this.flowLayoutPanelThumbnails = new System.Windows.Forms.FlowLayoutPanel();
            this.panelImageViewer = new System.Windows.Forms.Panel();
            this.pictureBoxFull = new System.Windows.Forms.PictureBox();
            this.panelViewerControls = new System.Windows.Forms.Panel();
            this.btnBackToThumbnails = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.btnOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.lblSort = new System.Windows.Forms.ToolStripLabel();
            this.cmbSort = new System.Windows.Forms.ToolStripComboBox();
            this.lblSearch = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelTitleBar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelThumbnailView.SuspendLayout();
            this.panelImageViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFull)).BeginInit();
            this.panelViewerControls.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(800, 25);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PhotoViewer 2.07  \\Windows";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(744, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 22);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(772, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelThumbnailView);
            this.panelMain.Controls.Add(this.panelImageViewer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 430);
            this.panelMain.TabIndex = 1;
            // 
            // panelThumbnailView
            // 
            this.panelThumbnailView.Controls.Add(this.flowLayoutPanelThumbnails);
            this.panelThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThumbnailView.Location = new System.Drawing.Point(0, 0);
            this.panelThumbnailView.Name = "panelThumbnailView";
            this.panelThumbnailView.Size = new System.Drawing.Size(800, 430);
            this.panelThumbnailView.TabIndex = 0;
            // 
            // flowLayoutPanelThumbnails
            // 
            this.flowLayoutPanelThumbnails.AutoScroll = true;
            this.flowLayoutPanelThumbnails.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanelThumbnails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelThumbnails.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelThumbnails.Name = "flowLayoutPanelThumbnails";
            this.flowLayoutPanelThumbnails.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelThumbnails.Size = new System.Drawing.Size(800, 430);
            this.flowLayoutPanelThumbnails.TabIndex = 0;
            // 
            // panelImageViewer
            // 
            this.panelImageViewer.Controls.Add(this.pictureBoxFull);
            this.panelImageViewer.Controls.Add(this.panelViewerControls);
            this.panelImageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageViewer.Location = new System.Drawing.Point(0, 0);
            this.panelImageViewer.Name = "panelImageViewer";
            this.panelImageViewer.Size = new System.Drawing.Size(800, 430);
            this.panelImageViewer.TabIndex = 1;
            this.panelImageViewer.Visible = false;
            // 
            // pictureBoxFull
            // 
            this.pictureBoxFull.BackColor = System.Drawing.Color.Black;
            this.pictureBoxFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFull.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFull.Name = "pictureBoxFull";
            this.pictureBoxFull.Size = new System.Drawing.Size(800, 394);
            this.pictureBoxFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFull.TabIndex = 0;
            this.pictureBoxFull.TabStop = false;
            // 
            // panelViewerControls
            // 
            this.panelViewerControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelViewerControls.Controls.Add(this.btnBackToThumbnails);
            this.panelViewerControls.Controls.Add(this.btnPrev);
            this.panelViewerControls.Controls.Add(this.btnNext);
            this.panelViewerControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelViewerControls.Location = new System.Drawing.Point(0, 394);
            this.panelViewerControls.Name = "panelViewerControls";
            this.panelViewerControls.Size = new System.Drawing.Size(800, 36);
            this.panelViewerControls.TabIndex = 1;
            // 
            // btnBackToThumbnails
            // 
            this.btnBackToThumbnails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToThumbnails.ForeColor = System.Drawing.Color.White;
            this.btnBackToThumbnails.Location = new System.Drawing.Point(12, 6);
            this.btnBackToThumbnails.Name = "btnBackToThumbnails";
            this.btnBackToThumbnails.Size = new System.Drawing.Size(120, 24);
            this.btnBackToThumbnails.TabIndex = 0;
            this.btnBackToThumbnails.Text = "Back to Gallery";
            this.btnBackToThumbnails.UseVisualStyleBackColor = true;
            this.btnBackToThumbnails.Click += new System.EventHandler(this.btnBackToThumbnails_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(632, 6);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 24);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "< Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(713, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 24);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.statusStrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenFolder,
            this.lblSort,
            this.cmbSort,
            this.lblSearch,
            this.txtSearch,
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 455);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 25);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(86, 23);
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // lblSort
            // 
            this.lblSort.ForeColor = System.Drawing.Color.White;
            this.lblSort.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(39, 22);
            this.lblSort.Text = "Sort:";
            // 
            // cmbSort
            // 
            this.cmbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSort.ForeColor = System.Drawing.Color.White;
            this.cmbSort.Items.AddRange(new object[] {
            "Newest",
            "Oldest",
            "Name (A-Z)",
            "Name (Z-A)"});
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(100, 25);
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 22);
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(329, 20);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Ready";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoViewer 2.07";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelThumbnailView.ResumeLayout(false);
            this.panelImageViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFull)).EndInit();
            this.panelViewerControls.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelThumbnailView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelThumbnails;
        private System.Windows.Forms.Panel panelImageViewer;
        private System.Windows.Forms.PictureBox pictureBoxFull;
        private System.Windows.Forms.Panel panelViewerControls;
        private System.Windows.Forms.Button btnBackToThumbnails;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripButton btnOpenFolder;
        private System.Windows.Forms.ToolStripLabel lblSort;
        private System.Windows.Forms.ToolStripComboBox cmbSort;
        private System.Windows.Forms.ToolStripLabel lblSearch;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
    }
}