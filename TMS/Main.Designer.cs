namespace TMS
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.Utils.Animation.Transition transition1 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.PushFadeTransition pushFadeTransition1 = new DevExpress.Utils.Animation.PushFadeTransition();
            this.colNoteDes = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colNoteUser = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colNoteManger = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_help = new DevExpress.XtraEditors.SimpleButton();
            this.btn_users = new DevExpress.XtraEditors.SimpleButton();
            this.btn_project = new DevExpress.XtraEditors.SimpleButton();
            this.btn_task = new DevExpress.XtraEditors.SimpleButton();
            this.pn_statebar = new System.Windows.Forms.Panel();
            this.btn_shownote = new DevExpress.XtraEditors.SimpleButton();
            this.lb_roll = new System.Windows.Forms.Label();
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_state = new System.Windows.Forms.Label();
            this.pn_cont = new System.Windows.Forms.Panel();
            this.transitionManager1 = new DevExpress.Utils.Animation.TransitionManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.pn_navbar.SuspendLayout();
            this.pn_statebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // colNoteDes
            // 
            this.colNoteDes.FieldName = "NoteDes";
            this.colNoteDes.MinWidth = 61;
            this.colNoteDes.Name = "colNoteDes";
            this.colNoteDes.Visible = true;
            this.colNoteDes.VisibleIndex = 0;
            this.colNoteDes.Width = 227;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.DataSource = typeof(TMS.TB_Note);
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(8);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(406, 774);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            this.gridControl1.Visible = false;
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.MouseLeave += new System.EventHandler(this.gridControl1_MouseLeave);
            // 
            // tileView1
            // 
            this.tileView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tileView1.Appearance.EmptySpace.Options.UseBackColor = true;
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNoteDes,
            this.colNoteUser,
            this.colNoteManger});
            this.tileView1.DetailHeight = 852;
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.IndentBetweenItems = 0;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(248, 84);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            tableSpan1.ColumnSpan = 2;
            tableSpan1.RowSpan = 2;
            this.tileView1.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Appearance.Pressed.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Pressed.Options.UseFont = true;
            tileViewItemElement1.Appearance.Selected.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Selected.Options.UseFont = true;
            tileViewItemElement1.Column = this.colNoteDes;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "colNoteDes";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.DoubleClick += new System.EventHandler(this.tileView1_DoubleClick);
            // 
            // colNoteUser
            // 
            this.colNoteUser.FieldName = "NoteUser";
            this.colNoteUser.MinWidth = 61;
            this.colNoteUser.Name = "colNoteUser";
            this.colNoteUser.Visible = true;
            this.colNoteUser.VisibleIndex = 1;
            this.colNoteUser.Width = 227;
            // 
            // colNoteManger
            // 
            this.colNoteManger.FieldName = "NoteManger";
            this.colNoteManger.MinWidth = 61;
            this.colNoteManger.Name = "colNoteManger";
            this.colNoteManger.Visible = true;
            this.colNoteManger.VisibleIndex = 2;
            this.colNoteManger.Width = 227;
            // 
            // pn_navbar
            // 
            this.pn_navbar.AutoScroll = true;
            this.pn_navbar.Controls.Add(this.simpleButton1);
            this.pn_navbar.Controls.Add(this.btn_help);
            this.pn_navbar.Controls.Add(this.btn_users);
            this.pn_navbar.Controls.Add(this.btn_project);
            this.pn_navbar.Controls.Add(this.btn_task);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_navbar.Location = new System.Drawing.Point(0, 0);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(1062, 86);
            this.pn_navbar.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(849, 13);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton1.Size = new System.Drawing.Size(199, 59);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "الرئيسة";
            this.simpleButton1.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_help
            // 
            this.btn_help.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_help.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Appearance.Options.UseFont = true;
            this.btn_help.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_help.ImageOptions.SvgImage")));
            this.btn_help.Location = new System.Drawing.Point(15, 13);
            this.btn_help.Margin = new System.Windows.Forms.Padding(8);
            this.btn_help.Name = "btn_help";
            this.btn_help.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_help.Size = new System.Drawing.Size(197, 59);
            this.btn_help.TabIndex = 0;
            this.btn_help.Text = "الاعدادات";
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_users
            // 
            this.btn_users.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_users.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Appearance.Options.UseFont = true;
            this.btn_users.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_users.ImageOptions.SvgImage")));
            this.btn_users.Location = new System.Drawing.Point(226, 13);
            this.btn_users.Margin = new System.Windows.Forms.Padding(6);
            this.btn_users.Name = "btn_users";
            this.btn_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_users.Size = new System.Drawing.Size(197, 59);
            this.btn_users.TabIndex = 0;
            this.btn_users.Text = "المستخدمين";
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_project
            // 
            this.btn_project.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_project.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_project.Appearance.Options.UseFont = true;
            this.btn_project.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_project.ImageOptions.SvgImage")));
            this.btn_project.Location = new System.Drawing.Point(434, 13);
            this.btn_project.Margin = new System.Windows.Forms.Padding(5);
            this.btn_project.Name = "btn_project";
            this.btn_project.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_project.Size = new System.Drawing.Size(198, 59);
            this.btn_project.TabIndex = 0;
            this.btn_project.Text = "المشاريع";
            this.btn_project.Click += new System.EventHandler(this.btn_project_Click);
            // 
            // btn_task
            // 
            this.btn_task.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_task.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_task.Appearance.Options.UseFont = true;
            this.btn_task.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_task.ImageOptions.Image")));
            this.btn_task.Location = new System.Drawing.Point(641, 13);
            this.btn_task.Margin = new System.Windows.Forms.Padding(4);
            this.btn_task.Name = "btn_task";
            this.btn_task.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_task.Size = new System.Drawing.Size(199, 59);
            this.btn_task.TabIndex = 0;
            this.btn_task.Text = "المهام";
            this.btn_task.Click += new System.EventHandler(this.btn_task_Click);
            // 
            // pn_statebar
            // 
            this.pn_statebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_statebar.Controls.Add(this.btn_shownote);
            this.pn_statebar.Controls.Add(this.lb_roll);
            this.pn_statebar.Controls.Add(this.lb_userName);
            this.pn_statebar.Controls.Add(this.lb_state);
            this.pn_statebar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_statebar.Location = new System.Drawing.Point(0, 619);
            this.pn_statebar.Name = "pn_statebar";
            this.pn_statebar.Size = new System.Drawing.Size(1062, 54);
            this.pn_statebar.TabIndex = 1;
            // 
            // btn_shownote
            // 
            this.btn_shownote.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shownote.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_shownote.Appearance.Options.UseFont = true;
            this.btn_shownote.Appearance.Options.UseForeColor = true;
            this.btn_shownote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_shownote.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_shownote.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_shownote.ImageOptions.SvgImage")));
            this.btn_shownote.Location = new System.Drawing.Point(0, 0);
            this.btn_shownote.Margin = new System.Windows.Forms.Padding(10);
            this.btn_shownote.Name = "btn_shownote";
            this.btn_shownote.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_shownote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_shownote.Size = new System.Drawing.Size(80, 54);
            this.btn_shownote.TabIndex = 1;
            this.btn_shownote.Text = "12";
            this.btn_shownote.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // lb_roll
            // 
            this.lb_roll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_roll.AutoSize = true;
            this.lb_roll.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_roll.ForeColor = System.Drawing.Color.White;
            this.lb_roll.Location = new System.Drawing.Point(451, 12);
            this.lb_roll.Name = "lb_roll";
            this.lb_roll.Size = new System.Drawing.Size(61, 31);
            this.lb_roll.TabIndex = 0;
            this.lb_roll.Text = "مدير";
            // 
            // lb_userName
            // 
            this.lb_userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userName.ForeColor = System.Drawing.Color.White;
            this.lb_userName.Location = new System.Drawing.Point(548, 12);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(64, 31);
            this.lb_userName.TabIndex = 0;
            this.lb_userName.Text = "رياض";
            // 
            // lb_state
            // 
            this.lb_state.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_state.ForeColor = System.Drawing.Color.White;
            this.lb_state.Location = new System.Drawing.Point(926, 0);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(136, 54);
            this.lb_state.TabIndex = 0;
            this.lb_state.Text = "مستعد";
            this.lb_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pn_cont
            // 
            this.pn_cont.BackColor = System.Drawing.Color.White;
            this.pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cont.Location = new System.Drawing.Point(0, 86);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(1062, 533);
            this.pn_cont.TabIndex = 2;
            this.pn_cont.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // transitionManager1
            // 
            this.transitionManager1.FrameInterval = 3000;
            this.transitionManager1.ShowWaitingIndicator = false;
            transition1.BarWaitingIndicatorProperties.Caption = "";
            transition1.BarWaitingIndicatorProperties.Description = "";
            transition1.Control = this.gridControl1;
            transition1.EasingMode = DevExpress.Data.Utils.EasingMode.EaseInOut;
            transition1.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.LineWaitingIndicatorProperties.Caption = "";
            transition1.LineWaitingIndicatorProperties.Description = "";
            transition1.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.RingWaitingIndicatorProperties.Caption = "";
            transition1.RingWaitingIndicatorProperties.Description = "";
            transition1.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.False;
            transition1.TransitionType = pushFadeTransition1;
            transition1.WaitingIndicatorProperties.Caption = "";
            transition1.WaitingIndicatorProperties.Description = "";
            this.transitionManager1.Transitions.Add(transition1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = global::TMS.Properties.Settings.Default.GetNotTimer;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pn_cont);
            this.Controls.Add(this.pn_statebar);
            this.Controls.Add(this.pn_navbar);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Leave += new System.EventHandler(this.Main_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.pn_navbar.ResumeLayout(false);
            this.pn_statebar.ResumeLayout(false);
            this.pn_statebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Panel pn_statebar;
        private System.Windows.Forms.Label lb_state;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_help;
        private DevExpress.XtraEditors.SimpleButton btn_project;
        private DevExpress.XtraEditors.SimpleButton btn_task;
        private DevExpress.XtraEditors.SimpleButton btn_shownote;
        private System.Windows.Forms.Panel pn_cont;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Utils.Animation.TransitionManager transitionManager1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNoteDes;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNoteUser;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNoteManger;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public DevExpress.XtraEditors.SimpleButton btn_users;
        public System.Windows.Forms.Label lb_roll;
        public System.Windows.Forms.Label lb_userName;
    }
}

