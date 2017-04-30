namespace Tourist
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.detailView = new System.Windows.Forms.ListView();
            this.columnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCreateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastWriteTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastAccessTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TouristMenu = new System.Windows.Forms.MenuStrip();
            this.분석ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExifLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TouristDirBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label_targetdir = new System.Windows.Forms.Label();
            this.label_selectedPath = new System.Windows.Forms.Label();
            this.TouristTabControl = new System.Windows.Forms.TabControl();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.TouristGmap = new GMap.NET.WindowsForms.GMapControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.grp_gps = new System.Windows.Forms.GroupBox();
            this.lbgps_location_title = new System.Windows.Forms.Label();
            this.lbgps_long_title = new System.Windows.Forms.Label();
            this.lbgps_lat_title = new System.Windows.Forms.Label();
            this.grp_ImageViewer = new System.Windows.Forms.GroupBox();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.detailViewLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grp_alert = new System.Windows.Forms.GroupBox();
            this.lb_alert = new System.Windows.Forms.Label();
            this.imageViewer = new System.Windows.Forms.PictureBox();
            this.ImageAlertViewer = new System.Windows.Forms.PictureBox();
            this.TouristMenu.SuspendLayout();
            this.TouristTabControl.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.grp_gps.SuspendLayout();
            this.grp_ImageViewer.SuspendLayout();
            this.grp_alert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAlertViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // detailView
            // 
            this.detailView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFileName,
            this.columnSize,
            this.columnCreateTime,
            this.columnLastWriteTime,
            this.columnLastAccessTime});
            this.detailView.Location = new System.Drawing.Point(12, 396);
            this.detailView.Name = "detailView";
            this.detailView.Size = new System.Drawing.Size(754, 260);
            this.detailView.TabIndex = 0;
            this.detailView.UseCompatibleStateImageBehavior = false;
            this.detailView.View = System.Windows.Forms.View.Details;
            this.detailView.Click += new System.EventHandler(this.detailView_Click);
            // 
            // columnFileName
            // 
            this.columnFileName.Text = "파일이름";
            this.columnFileName.Width = 120;
            // 
            // columnSize
            // 
            this.columnSize.Text = "파일크기";
            this.columnSize.Width = 80;
            // 
            // columnCreateTime
            // 
            this.columnCreateTime.Text = "최초 생성 시간";
            this.columnCreateTime.Width = 170;
            // 
            // columnLastWriteTime
            // 
            this.columnLastWriteTime.Text = "마지막 수정시간";
            this.columnLastWriteTime.Width = 170;
            // 
            // columnLastAccessTime
            // 
            this.columnLastAccessTime.Text = "마지막 접근시간";
            this.columnLastAccessTime.Width = 170;
            // 
            // TouristMenu
            // 
            this.TouristMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.분석ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.TouristMenu.Location = new System.Drawing.Point(0, 0);
            this.TouristMenu.Name = "TouristMenu";
            this.TouristMenu.Size = new System.Drawing.Size(778, 24);
            this.TouristMenu.TabIndex = 1;
            this.TouristMenu.Text = "TouristMenu";
            // 
            // 분석ToolStripMenuItem
            // 
            this.분석ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExifLoadToolStripMenuItem});
            this.분석ToolStripMenuItem.Name = "분석ToolStripMenuItem";
            this.분석ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.분석ToolStripMenuItem.Text = "분석";
            // 
            // ExifLoadToolStripMenuItem
            // 
            this.ExifLoadToolStripMenuItem.Name = "ExifLoadToolStripMenuItem";
            this.ExifLoadToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ExifLoadToolStripMenuItem.Text = "불러오기";
            this.ExifLoadToolStripMenuItem.Click += new System.EventHandler(this.ExifLoadToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeveloperToolStripMenuItem,
            this.gitHubToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // DeveloperToolStripMenuItem
            // 
            this.DeveloperToolStripMenuItem.Name = "DeveloperToolStripMenuItem";
            this.DeveloperToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.DeveloperToolStripMenuItem.Text = "Credit";
            this.DeveloperToolStripMenuItem.Click += new System.EventHandler(this.DeveloperToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // label_targetdir
            // 
            this.label_targetdir.AutoSize = true;
            this.label_targetdir.Location = new System.Drawing.Point(12, 378);
            this.label_targetdir.Name = "label_targetdir";
            this.label_targetdir.Size = new System.Drawing.Size(122, 15);
            this.label_targetdir.TabIndex = 2;
            this.label_targetdir.Text = "분석 대상 디렉터리 : ";
            // 
            // label_selectedPath
            // 
            this.label_selectedPath.AutoSize = true;
            this.label_selectedPath.Location = new System.Drawing.Point(134, 378);
            this.label_selectedPath.Name = "label_selectedPath";
            this.label_selectedPath.Size = new System.Drawing.Size(0, 15);
            this.label_selectedPath.TabIndex = 3;
            // 
            // TouristTabControl
            // 
            this.TouristTabControl.Controls.Add(this.tabMap);
            this.TouristTabControl.Controls.Add(this.tabDetail);
            this.TouristTabControl.Controls.Add(this.tabSetting);
            this.TouristTabControl.Location = new System.Drawing.Point(12, 27);
            this.TouristTabControl.Name = "TouristTabControl";
            this.TouristTabControl.SelectedIndex = 0;
            this.TouristTabControl.Size = new System.Drawing.Size(751, 348);
            this.TouristTabControl.TabIndex = 4;
            this.TouristTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TouristTabControl_Selected);
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.TouristGmap);
            this.tabMap.Location = new System.Drawing.Point(4, 24);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMap.Size = new System.Drawing.Size(743, 320);
            this.tabMap.TabIndex = 0;
            this.tabMap.Text = "Maps";
            this.tabMap.UseVisualStyleBackColor = true;
            // 
            // TouristGmap
            // 
            this.TouristGmap.Bearing = 0F;
            this.TouristGmap.CanDragMap = true;
            this.TouristGmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.TouristGmap.GrayScaleMode = false;
            this.TouristGmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.TouristGmap.LevelsKeepInMemmory = 5;
            this.TouristGmap.Location = new System.Drawing.Point(3, 3);
            this.TouristGmap.MarkersEnabled = true;
            this.TouristGmap.MaxZoom = 30;
            this.TouristGmap.MinZoom = 2;
            this.TouristGmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.TouristGmap.Name = "TouristGmap";
            this.TouristGmap.NegativeMode = false;
            this.TouristGmap.PolygonsEnabled = true;
            this.TouristGmap.RetryLoadTile = 0;
            this.TouristGmap.RoutesEnabled = true;
            this.TouristGmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.TouristGmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.TouristGmap.ShowTileGridLines = false;
            this.TouristGmap.Size = new System.Drawing.Size(737, 314);
            this.TouristGmap.TabIndex = 0;
            this.TouristGmap.Zoom = 5D;
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.grp_gps);
            this.tabDetail.Controls.Add(this.grp_ImageViewer);
            this.tabDetail.Controls.Add(this.grp_alert);
            this.tabDetail.Location = new System.Drawing.Point(4, 24);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(743, 320);
            this.tabDetail.TabIndex = 1;
            this.tabDetail.Text = "FileDetail";
            this.tabDetail.UseVisualStyleBackColor = true;
            // 
            // grp_gps
            // 
            this.grp_gps.Controls.Add(this.lbgps_location_title);
            this.grp_gps.Controls.Add(this.lbgps_long_title);
            this.grp_gps.Controls.Add(this.lbgps_lat_title);
            this.grp_gps.Location = new System.Drawing.Point(288, 12);
            this.grp_gps.Name = "grp_gps";
            this.grp_gps.Size = new System.Drawing.Size(241, 100);
            this.grp_gps.TabIndex = 2;
            this.grp_gps.TabStop = false;
            this.grp_gps.Text = "위치정보";
            // 
            // lbgps_location_title
            // 
            this.lbgps_location_title.AutoSize = true;
            this.lbgps_location_title.Location = new System.Drawing.Point(17, 69);
            this.lbgps_location_title.Name = "lbgps_location_title";
            this.lbgps_location_title.Size = new System.Drawing.Size(66, 15);
            this.lbgps_location_title.TabIndex = 5;
            this.lbgps_location_title.Text = "상세위치 : ";
            // 
            // lbgps_long_title
            // 
            this.lbgps_long_title.AutoSize = true;
            this.lbgps_long_title.Location = new System.Drawing.Point(17, 22);
            this.lbgps_long_title.Name = "lbgps_long_title";
            this.lbgps_long_title.Size = new System.Drawing.Size(42, 15);
            this.lbgps_long_title.TabIndex = 3;
            this.lbgps_long_title.Text = "경도 : ";
            // 
            // lbgps_lat_title
            // 
            this.lbgps_lat_title.AutoSize = true;
            this.lbgps_lat_title.Location = new System.Drawing.Point(17, 45);
            this.lbgps_lat_title.Name = "lbgps_lat_title";
            this.lbgps_lat_title.Size = new System.Drawing.Size(42, 15);
            this.lbgps_lat_title.TabIndex = 4;
            this.lbgps_lat_title.Text = "위도 : ";
            // 
            // grp_ImageViewer
            // 
            this.grp_ImageViewer.Controls.Add(this.imageViewer);
            this.grp_ImageViewer.Location = new System.Drawing.Point(15, 12);
            this.grp_ImageViewer.Name = "grp_ImageViewer";
            this.grp_ImageViewer.Size = new System.Drawing.Size(267, 296);
            this.grp_ImageViewer.TabIndex = 1;
            this.grp_ImageViewer.TabStop = false;
            this.grp_ImageViewer.Text = "이미지 뷰어";
            // 
            // tabSetting
            // 
            this.tabSetting.Location = new System.Drawing.Point(4, 24);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetting.Size = new System.Drawing.Size(743, 320);
            this.tabSetting.TabIndex = 2;
            this.tabSetting.Text = "설정";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // detailViewLabel
            // 
            this.detailViewLabel.AutoSize = true;
            this.detailViewLabel.Location = new System.Drawing.Point(289, 525);
            this.detailViewLabel.Name = "detailViewLabel";
            this.detailViewLabel.Size = new System.Drawing.Size(178, 15);
            this.detailViewLabel.TabIndex = 5;
            this.detailViewLabel.Text = "분석 가능한 이미지가 없습니다.";
            this.detailViewLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_alert
            // 
            this.grp_alert.Controls.Add(this.lb_alert);
            this.grp_alert.Controls.Add(this.ImageAlertViewer);
            this.grp_alert.Location = new System.Drawing.Point(192, 81);
            this.grp_alert.Name = "grp_alert";
            this.grp_alert.Size = new System.Drawing.Size(363, 148);
            this.grp_alert.TabIndex = 4;
            this.grp_alert.TabStop = false;
            this.grp_alert.Text = "알림";
            // 
            // lb_alert
            // 
            this.lb_alert.AutoSize = true;
            this.lb_alert.Location = new System.Drawing.Point(132, 70);
            this.lb_alert.Name = "lb_alert";
            this.lb_alert.Size = new System.Drawing.Size(140, 15);
            this.lb_alert.TabIndex = 4;
            this.lb_alert.Text = "잠시만 기다려주십시오...";
            // 
            // imageViewer
            // 
            this.imageViewer.Location = new System.Drawing.Point(15, 22);
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.Size = new System.Drawing.Size(235, 257);
            this.imageViewer.TabIndex = 0;
            this.imageViewer.TabStop = false;
            // 
            // ImageAlertViewer
            // 
            this.ImageAlertViewer.Image = global::Tourist.Properties.Resources.ring;
            this.ImageAlertViewer.Location = new System.Drawing.Point(56, 41);
            this.ImageAlertViewer.Name = "ImageAlertViewer";
            this.ImageAlertViewer.Size = new System.Drawing.Size(70, 70);
            this.ImageAlertViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageAlertViewer.TabIndex = 3;
            this.ImageAlertViewer.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 668);
            this.Controls.Add(this.label_selectedPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_targetdir);
            this.Controls.Add(this.TouristMenu);
            this.Controls.Add(this.TouristTabControl);
            this.Controls.Add(this.detailViewLabel);
            this.Controls.Add(this.detailView);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TouristMenu;
            this.Name = "Main";
            this.Text = "Tourist - Image Analyzer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TouristMenu.ResumeLayout(false);
            this.TouristMenu.PerformLayout();
            this.TouristTabControl.ResumeLayout(false);
            this.tabMap.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.grp_gps.ResumeLayout(false);
            this.grp_gps.PerformLayout();
            this.grp_ImageViewer.ResumeLayout(false);
            this.grp_alert.ResumeLayout(false);
            this.grp_alert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAlertViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView detailView;
        private System.Windows.Forms.ColumnHeader columnFileName;
        private System.Windows.Forms.MenuStrip TouristMenu;
        private System.Windows.Forms.ToolStripMenuItem 분석ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExifLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeveloperToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog TouristDirBrowser;
        private System.Windows.Forms.Label label_targetdir;
        private System.Windows.Forms.Label label_selectedPath;
        private System.Windows.Forms.TabControl TouristTabControl;
        private System.Windows.Forms.TabPage tabMap;
        private System.Windows.Forms.TabPage tabDetail;
        private GMap.NET.WindowsForms.GMapControl TouristGmap;
        private System.Windows.Forms.Label detailViewLabel;
        private System.Windows.Forms.PictureBox imageViewer;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ColumnHeader columnCreateTime;
        private System.Windows.Forms.ColumnHeader columnLastWriteTime;
        private System.Windows.Forms.ColumnHeader columnLastAccessTime;
        private System.Windows.Forms.GroupBox grp_ImageViewer;
        private System.Windows.Forms.GroupBox grp_gps;
        private System.Windows.Forms.Label lbgps_location_title;
        private System.Windows.Forms.Label lbgps_long_title;
        private System.Windows.Forms.Label lbgps_lat_title;
        private System.Windows.Forms.PictureBox ImageAlertViewer;
        private System.Windows.Forms.GroupBox grp_alert;
        private System.Windows.Forms.Label lb_alert;
    }
}

