namespace SimpleCalendar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.eventsDisplayPanel = new System.Windows.Forms.Panel();
            this.eventsTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.eventsLabel = new System.Windows.Forms.Label();
            this.eventButtonsPanel = new System.Windows.Forms.Panel();
            this.createEventButton = new System.Windows.Forms.Button();
            this.createCategoryButton = new System.Windows.Forms.Button();
            this.eventModifyPanel = new System.Windows.Forms.Panel();
            this.eventModifyBody = new System.Windows.Forms.TableLayoutPanel();
            this.labelLabel = new System.Windows.Forms.Label();
            this.labelField = new System.Windows.Forms.TextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startingDate = new System.Windows.Forms.DateTimePicker();
            this.startingTime = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endingDate = new System.Windows.Forms.DateTimePicker();
            this.endingTime = new System.Windows.Forms.DateTimePicker();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryDropDown = new System.Windows.Forms.ComboBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationField = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.eventErrors = new System.Windows.Forms.TextBox();
            this.eventModifyLabel = new System.Windows.Forms.Label();
            this.eventModifyButtonsPanel = new System.Windows.Forms.Panel();
            this.saveEventModifyButton = new System.Windows.Forms.Button();
            this.cancelEventModifyButton = new System.Windows.Forms.Button();
            this.categoryModifyPanel = new System.Windows.Forms.Panel();
            this.categoryModifyBody = new System.Windows.Forms.TableLayoutPanel();
            this.nameField = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.symbolDropDown = new System.Windows.Forms.ComboBox();
            this.symbolLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.categoryErrors = new System.Windows.Forms.TextBox();
            this.categoryModifyLabel = new System.Windows.Forms.Label();
            this.categoryModifyButtonsPanel = new System.Windows.Forms.Panel();
            this.saveCategoryModifyButton = new System.Windows.Forms.Button();
            this.cancelCategoryModifyButton = new System.Windows.Forms.Button();
            this.calendarViewPanel = new System.Windows.Forms.Panel();
            this.indicatorPanelDayA = new System.Windows.Forms.Panel();
            this.IndicatorLabelDayA = new System.Windows.Forms.Label();
            this.indicatorPanelDayB = new System.Windows.Forms.Panel();
            this.IndicatorLabelDayB = new System.Windows.Forms.Label();
            this.spacerEventsPanel = new System.Windows.Forms.Label();
            this.remainingEventsLabel = new System.Windows.Forms.Label();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.spacerCalendarRemaining = new System.Windows.Forms.Label();
            this.twoDayViewPanel = new System.Windows.Forms.Panel();
            this.monthViewPanel = new System.Windows.Forms.Panel();
            this.viewSelectionPanel = new System.Windows.Forms.Panel();
            this.viewLabel = new System.Windows.Forms.Label();
            this.spacerLabelDay = new System.Windows.Forms.Label();
            this.dayViewButton = new System.Windows.Forms.Button();
            this.spacerDayTwoDay = new System.Windows.Forms.Label();
            this.twoDayViewButton = new System.Windows.Forms.Button();
            this.spacerTwoDayMonth = new System.Windows.Forms.Label();
            this.monthViewButton = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.dateSelector = new System.Windows.Forms.DateTimePicker();
            this.nextDayButton = new System.Windows.Forms.Label();
            this.prevDayButton = new System.Windows.Forms.Label();
            this.currentTimeDisplay = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.spacerFormTime = new System.Windows.Forms.Label();
            this.categoryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondClock = new System.Windows.Forms.Timer(this.components);
            this.minuteClock = new System.Windows.Forms.Timer(this.components);
            this.dailyCalendar2A = new SimpleCalendar.DailyCalendar();
            this.dailyCalendar2B = new SimpleCalendar.DailyCalendar();
            this.dailyCalendar = new SimpleCalendar.DailyCalendar();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.eventsDisplayPanel.SuspendLayout();
            this.eventButtonsPanel.SuspendLayout();
            this.eventModifyPanel.SuspendLayout();
            this.eventModifyBody.SuspendLayout();
            this.eventModifyButtonsPanel.SuspendLayout();
            this.categoryModifyPanel.SuspendLayout();
            this.categoryModifyBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.categoryModifyButtonsPanel.SuspendLayout();
            this.calendarViewPanel.SuspendLayout();
            this.indicatorPanelDayA.SuspendLayout();
            this.indicatorPanelDayB.SuspendLayout();
            this.viewSelectionPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.categoryContextMenu.SuspendLayout();
            this.eventContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.mainPanel.Controls.Add(this.splitContainer1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1024, 512);
            this.mainPanel.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.eventsDisplayPanel);
            this.splitContainer1.Panel1.Controls.Add(this.eventModifyPanel);
            this.splitContainer1.Panel1.Controls.Add(this.categoryModifyPanel);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.calendarViewPanel);
            this.splitContainer1.Panel2.Controls.Add(this.twoDayViewPanel);
            this.splitContainer1.Panel2.Controls.Add(this.monthViewPanel);
            this.splitContainer1.Panel2.Controls.Add(this.viewSelectionPanel);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 512);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 17;
            this.splitContainer1.TabStop = false;
            // 
            // eventsDisplayPanel
            // 
            this.eventsDisplayPanel.Controls.Add(this.eventsTreeView);
            this.eventsDisplayPanel.Controls.Add(this.eventsLabel);
            this.eventsDisplayPanel.Controls.Add(this.eventButtonsPanel);
            this.eventsDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsDisplayPanel.Location = new System.Drawing.Point(10, 10);
            this.eventsDisplayPanel.Name = "eventsDisplayPanel";
            this.eventsDisplayPanel.Size = new System.Drawing.Size(368, 490);
            this.eventsDisplayPanel.TabIndex = 21;
            // 
            // eventsTreeView
            // 
            this.eventsTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.eventsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsTreeView.FullRowSelect = true;
            this.eventsTreeView.ImageIndex = 0;
            this.eventsTreeView.ImageList = this.imageList1;
            this.eventsTreeView.Indent = 15;
            this.eventsTreeView.ItemHeight = 25;
            this.eventsTreeView.Location = new System.Drawing.Point(0, 28);
            this.eventsTreeView.Name = "eventsTreeView";
            this.eventsTreeView.SelectedImageIndex = 0;
            this.eventsTreeView.Size = new System.Drawing.Size(368, 430);
            this.eventsTreeView.TabIndex = 3;
            this.eventsTreeView.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bluSq.png");
            this.imageList1.Images.SetKeyName(1, "grStar.png");
            this.imageList1.Images.SetKeyName(2, "purCirc.png");
            this.imageList1.Images.SetKeyName(3, "redTri.png");
            this.imageList1.Images.SetKeyName(4, "whtDot.png");
            // 
            // eventsLabel
            // 
            this.eventsLabel.BackColor = System.Drawing.Color.Transparent;
            this.eventsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventsLabel.Font = new System.Drawing.Font("Tw Cen MT", 18F);
            this.eventsLabel.ForeColor = System.Drawing.Color.White;
            this.eventsLabel.Location = new System.Drawing.Point(0, 0);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(368, 28);
            this.eventsLabel.TabIndex = 1;
            this.eventsLabel.Text = "Events";
            this.eventsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventButtonsPanel
            // 
            this.eventButtonsPanel.Controls.Add(this.createEventButton);
            this.eventButtonsPanel.Controls.Add(this.createCategoryButton);
            this.eventButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eventButtonsPanel.Location = new System.Drawing.Point(0, 458);
            this.eventButtonsPanel.Name = "eventButtonsPanel";
            this.eventButtonsPanel.Size = new System.Drawing.Size(368, 32);
            this.eventButtonsPanel.TabIndex = 15;
            // 
            // createEventButton
            // 
            this.createEventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.createEventButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.createEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createEventButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.createEventButton.Location = new System.Drawing.Point(0, 0);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(160, 32);
            this.createEventButton.TabIndex = 50;
            this.createEventButton.TabStop = false;
            this.createEventButton.Text = "Create New Event";
            this.createEventButton.UseVisualStyleBackColor = false;
            // 
            // createCategoryButton
            // 
            this.createCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.createCategoryButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.createCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createCategoryButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.createCategoryButton.Location = new System.Drawing.Point(208, 0);
            this.createCategoryButton.Name = "createCategoryButton";
            this.createCategoryButton.Size = new System.Drawing.Size(160, 32);
            this.createCategoryButton.TabIndex = 51;
            this.createCategoryButton.TabStop = false;
            this.createCategoryButton.Text = "Create New Category";
            this.createCategoryButton.UseVisualStyleBackColor = false;
            // 
            // eventModifyPanel
            // 
            this.eventModifyPanel.Controls.Add(this.eventModifyBody);
            this.eventModifyPanel.Controls.Add(this.eventErrors);
            this.eventModifyPanel.Controls.Add(this.eventModifyLabel);
            this.eventModifyPanel.Controls.Add(this.eventModifyButtonsPanel);
            this.eventModifyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventModifyPanel.Location = new System.Drawing.Point(10, 10);
            this.eventModifyPanel.Name = "eventModifyPanel";
            this.eventModifyPanel.Size = new System.Drawing.Size(368, 490);
            this.eventModifyPanel.TabIndex = 22;
            this.eventModifyPanel.Visible = false;
            // 
            // eventModifyBody
            // 
            this.eventModifyBody.ColumnCount = 2;
            this.eventModifyBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.eventModifyBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.eventModifyBody.Controls.Add(this.labelLabel, 0, 0);
            this.eventModifyBody.Controls.Add(this.labelField, 1, 0);
            this.eventModifyBody.Controls.Add(this.startDateLabel, 0, 1);
            this.eventModifyBody.Controls.Add(this.startingDate, 1, 1);
            this.eventModifyBody.Controls.Add(this.startingTime, 1, 2);
            this.eventModifyBody.Controls.Add(this.endDateLabel, 0, 3);
            this.eventModifyBody.Controls.Add(this.endingDate, 1, 3);
            this.eventModifyBody.Controls.Add(this.endingTime, 1, 4);
            this.eventModifyBody.Controls.Add(this.categoryLabel, 0, 5);
            this.eventModifyBody.Controls.Add(this.categoryDropDown, 1, 5);
            this.eventModifyBody.Controls.Add(this.locationLabel, 0, 6);
            this.eventModifyBody.Controls.Add(this.locationField, 1, 6);
            this.eventModifyBody.Controls.Add(this.descriptionLabel, 0, 7);
            this.eventModifyBody.Controls.Add(this.descriptionField, 1, 7);
            this.eventModifyBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventModifyBody.Location = new System.Drawing.Point(0, 28);
            this.eventModifyBody.Name = "eventModifyBody";
            this.eventModifyBody.Padding = new System.Windows.Forms.Padding(8);
            this.eventModifyBody.RowCount = 8;
            this.eventModifyBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventModifyBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventModifyBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventModifyBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventModifyBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventModifyBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventModifyBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventModifyBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventModifyBody.Size = new System.Drawing.Size(368, 325);
            this.eventModifyBody.TabIndex = 64;
            // 
            // labelLabel
            // 
            this.labelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabel.ForeColor = System.Drawing.Color.White;
            this.labelLabel.Location = new System.Drawing.Point(11, 8);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(99, 31);
            this.labelLabel.TabIndex = 49;
            this.labelLabel.Text = "Label:";
            this.labelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelField
            // 
            this.labelField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelField.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.labelField.Location = new System.Drawing.Point(116, 11);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(241, 25);
            this.labelField.TabIndex = 50;
            // 
            // startDateLabel
            // 
            this.startDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDateLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.ForeColor = System.Drawing.Color.White;
            this.startDateLabel.Location = new System.Drawing.Point(11, 39);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(99, 31);
            this.startDateLabel.TabIndex = 51;
            this.startDateLabel.Text = "Start Date:";
            this.startDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startingDate
            // 
            this.startingDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingDate.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.startingDate.Location = new System.Drawing.Point(116, 42);
            this.startingDate.Name = "startingDate";
            this.startingDate.ShowUpDown = true;
            this.startingDate.Size = new System.Drawing.Size(241, 25);
            this.startingDate.TabIndex = 52;
            // 
            // startingTime
            // 
            this.startingTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingTime.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.startingTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startingTime.Location = new System.Drawing.Point(116, 73);
            this.startingTime.Name = "startingTime";
            this.startingTime.ShowUpDown = true;
            this.startingTime.Size = new System.Drawing.Size(241, 25);
            this.startingTime.TabIndex = 63;
            // 
            // endDateLabel
            // 
            this.endDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endDateLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.ForeColor = System.Drawing.Color.White;
            this.endDateLabel.Location = new System.Drawing.Point(11, 101);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(99, 31);
            this.endDateLabel.TabIndex = 55;
            this.endDateLabel.Text = "End Date:";
            this.endDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endingDate
            // 
            this.endingDate.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.endingDate.Location = new System.Drawing.Point(116, 104);
            this.endingDate.Name = "endingDate";
            this.endingDate.ShowUpDown = true;
            this.endingDate.Size = new System.Drawing.Size(241, 25);
            this.endingDate.TabIndex = 64;
            // 
            // endingTime
            // 
            this.endingTime.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.endingTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endingTime.Location = new System.Drawing.Point(116, 135);
            this.endingTime.Name = "endingTime";
            this.endingTime.ShowUpDown = true;
            this.endingTime.Size = new System.Drawing.Size(241, 25);
            this.endingTime.TabIndex = 65;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.White;
            this.categoryLabel.Location = new System.Drawing.Point(11, 163);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(99, 33);
            this.categoryLabel.TabIndex = 57;
            this.categoryLabel.Text = "Category:";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoryDropDown
            // 
            this.categoryDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDropDown.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.categoryDropDown.FormattingEnabled = true;
            this.categoryDropDown.Location = new System.Drawing.Point(116, 166);
            this.categoryDropDown.Name = "categoryDropDown";
            this.categoryDropDown.Size = new System.Drawing.Size(241, 27);
            this.categoryDropDown.TabIndex = 67;
            // 
            // locationLabel
            // 
            this.locationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.White;
            this.locationLabel.Location = new System.Drawing.Point(11, 196);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(99, 31);
            this.locationLabel.TabIndex = 66;
            this.locationLabel.Text = "Location:";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationField
            // 
            this.locationField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationField.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.locationField.Location = new System.Drawing.Point(116, 199);
            this.locationField.Name = "locationField";
            this.locationField.Size = new System.Drawing.Size(241, 25);
            this.locationField.TabIndex = 68;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(11, 227);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(99, 97);
            this.descriptionLabel.TabIndex = 59;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionField
            // 
            this.descriptionField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionField.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.descriptionField.Location = new System.Drawing.Point(116, 230);
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(241, 91);
            this.descriptionField.TabIndex = 69;
            // 
            // eventErrors
            // 
            this.eventErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.eventErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventErrors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eventErrors.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.eventErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.eventErrors.Location = new System.Drawing.Point(0, 353);
            this.eventErrors.Multiline = true;
            this.eventErrors.Name = "eventErrors";
            this.eventErrors.ReadOnly = true;
            this.eventErrors.Size = new System.Drawing.Size(368, 105);
            this.eventErrors.TabIndex = 65;
            this.eventErrors.TabStop = false;
            // 
            // eventModifyLabel
            // 
            this.eventModifyLabel.BackColor = System.Drawing.Color.Transparent;
            this.eventModifyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventModifyLabel.Font = new System.Drawing.Font("Tw Cen MT", 18F);
            this.eventModifyLabel.ForeColor = System.Drawing.Color.White;
            this.eventModifyLabel.Location = new System.Drawing.Point(0, 0);
            this.eventModifyLabel.Name = "eventModifyLabel";
            this.eventModifyLabel.Size = new System.Drawing.Size(368, 28);
            this.eventModifyLabel.TabIndex = 46;
            this.eventModifyLabel.Text = "Modify Event Panel";
            this.eventModifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventModifyButtonsPanel
            // 
            this.eventModifyButtonsPanel.Controls.Add(this.saveEventModifyButton);
            this.eventModifyButtonsPanel.Controls.Add(this.cancelEventModifyButton);
            this.eventModifyButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eventModifyButtonsPanel.Location = new System.Drawing.Point(0, 458);
            this.eventModifyButtonsPanel.Name = "eventModifyButtonsPanel";
            this.eventModifyButtonsPanel.Size = new System.Drawing.Size(368, 32);
            this.eventModifyButtonsPanel.TabIndex = 63;
            // 
            // saveEventModifyButton
            // 
            this.saveEventModifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.saveEventModifyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveEventModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveEventModifyButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.saveEventModifyButton.Location = new System.Drawing.Point(208, 0);
            this.saveEventModifyButton.Name = "saveEventModifyButton";
            this.saveEventModifyButton.Size = new System.Drawing.Size(160, 32);
            this.saveEventModifyButton.TabIndex = 50;
            this.saveEventModifyButton.TabStop = false;
            this.saveEventModifyButton.Text = "Save Changes";
            this.saveEventModifyButton.UseVisualStyleBackColor = false;
            // 
            // cancelEventModifyButton
            // 
            this.cancelEventModifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.cancelEventModifyButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancelEventModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelEventModifyButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.cancelEventModifyButton.Location = new System.Drawing.Point(0, 0);
            this.cancelEventModifyButton.Name = "cancelEventModifyButton";
            this.cancelEventModifyButton.Size = new System.Drawing.Size(160, 32);
            this.cancelEventModifyButton.TabIndex = 49;
            this.cancelEventModifyButton.TabStop = false;
            this.cancelEventModifyButton.Text = "Cancel";
            this.cancelEventModifyButton.UseVisualStyleBackColor = false;
            // 
            // categoryModifyPanel
            // 
            this.categoryModifyPanel.Controls.Add(this.categoryModifyBody);
            this.categoryModifyPanel.Controls.Add(this.categoryErrors);
            this.categoryModifyPanel.Controls.Add(this.categoryModifyLabel);
            this.categoryModifyPanel.Controls.Add(this.categoryModifyButtonsPanel);
            this.categoryModifyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryModifyPanel.Location = new System.Drawing.Point(10, 10);
            this.categoryModifyPanel.Name = "categoryModifyPanel";
            this.categoryModifyPanel.Size = new System.Drawing.Size(368, 490);
            this.categoryModifyPanel.TabIndex = 23;
            this.categoryModifyPanel.Visible = false;
            // 
            // categoryModifyBody
            // 
            this.categoryModifyBody.ColumnCount = 2;
            this.categoryModifyBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.categoryModifyBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.categoryModifyBody.Controls.Add(this.nameField, 1, 0);
            this.categoryModifyBody.Controls.Add(this.nameLabel, 0, 0);
            this.categoryModifyBody.Controls.Add(this.symbolDropDown, 1, 2);
            this.categoryModifyBody.Controls.Add(this.symbolLabel, 0, 1);
            this.categoryModifyBody.Controls.Add(this.pictureBox3, 1, 1);
            this.categoryModifyBody.Controls.Add(this.colorLabel, 0, 2);
            this.categoryModifyBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryModifyBody.Location = new System.Drawing.Point(0, 28);
            this.categoryModifyBody.Name = "categoryModifyBody";
            this.categoryModifyBody.Padding = new System.Windows.Forms.Padding(8);
            this.categoryModifyBody.RowCount = 3;
            this.categoryModifyBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.categoryModifyBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.categoryModifyBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.categoryModifyBody.Size = new System.Drawing.Size(368, 108);
            this.categoryModifyBody.TabIndex = 89;
            // 
            // nameField
            // 
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameField.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.nameField.Location = new System.Drawing.Point(116, 11);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(241, 25);
            this.nameField.TabIndex = 89;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(11, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(99, 32);
            this.nameLabel.TabIndex = 80;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // symbolDropDown
            // 
            this.symbolDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.symbolDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.symbolDropDown.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.symbolDropDown.FormattingEnabled = true;
            this.symbolDropDown.Location = new System.Drawing.Point(116, 75);
            this.symbolDropDown.Name = "symbolDropDown";
            this.symbolDropDown.Size = new System.Drawing.Size(241, 27);
            this.symbolDropDown.TabIndex = 90;
            // 
            // symbolLabel
            // 
            this.symbolLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.symbolLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.symbolLabel.ForeColor = System.Drawing.Color.White;
            this.symbolLabel.Location = new System.Drawing.Point(11, 40);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(99, 32);
            this.symbolLabel.TabIndex = 82;
            this.symbolLabel.Text = "Symbol:";
            this.symbolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(116, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(241, 26);
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // colorLabel
            // 
            this.colorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.colorLabel.ForeColor = System.Drawing.Color.White;
            this.colorLabel.Location = new System.Drawing.Point(11, 72);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(99, 33);
            this.colorLabel.TabIndex = 84;
            this.colorLabel.Text = "Color:";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoryErrors
            // 
            this.categoryErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.categoryErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryErrors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoryErrors.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.categoryErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.categoryErrors.Location = new System.Drawing.Point(0, 136);
            this.categoryErrors.Multiline = true;
            this.categoryErrors.Name = "categoryErrors";
            this.categoryErrors.ReadOnly = true;
            this.categoryErrors.Size = new System.Drawing.Size(368, 322);
            this.categoryErrors.TabIndex = 88;
            this.categoryErrors.TabStop = false;
            // 
            // categoryModifyLabel
            // 
            this.categoryModifyLabel.BackColor = System.Drawing.Color.Transparent;
            this.categoryModifyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryModifyLabel.Font = new System.Drawing.Font("Tw Cen MT", 18F);
            this.categoryModifyLabel.ForeColor = System.Drawing.Color.White;
            this.categoryModifyLabel.Location = new System.Drawing.Point(0, 0);
            this.categoryModifyLabel.Name = "categoryModifyLabel";
            this.categoryModifyLabel.Size = new System.Drawing.Size(368, 28);
            this.categoryModifyLabel.TabIndex = 77;
            this.categoryModifyLabel.Text = "Modify Category Panel";
            this.categoryModifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryModifyButtonsPanel
            // 
            this.categoryModifyButtonsPanel.Controls.Add(this.saveCategoryModifyButton);
            this.categoryModifyButtonsPanel.Controls.Add(this.cancelCategoryModifyButton);
            this.categoryModifyButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoryModifyButtonsPanel.Location = new System.Drawing.Point(0, 458);
            this.categoryModifyButtonsPanel.Name = "categoryModifyButtonsPanel";
            this.categoryModifyButtonsPanel.Size = new System.Drawing.Size(368, 32);
            this.categoryModifyButtonsPanel.TabIndex = 64;
            // 
            // saveCategoryModifyButton
            // 
            this.saveCategoryModifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.saveCategoryModifyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveCategoryModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveCategoryModifyButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.saveCategoryModifyButton.Location = new System.Drawing.Point(208, 0);
            this.saveCategoryModifyButton.Name = "saveCategoryModifyButton";
            this.saveCategoryModifyButton.Size = new System.Drawing.Size(160, 32);
            this.saveCategoryModifyButton.TabIndex = 80;
            this.saveCategoryModifyButton.TabStop = false;
            this.saveCategoryModifyButton.Text = "Save Changes";
            this.saveCategoryModifyButton.UseVisualStyleBackColor = false;
            // 
            // cancelCategoryModifyButton
            // 
            this.cancelCategoryModifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.cancelCategoryModifyButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancelCategoryModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelCategoryModifyButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.cancelCategoryModifyButton.Location = new System.Drawing.Point(0, 0);
            this.cancelCategoryModifyButton.Name = "cancelCategoryModifyButton";
            this.cancelCategoryModifyButton.Size = new System.Drawing.Size(160, 32);
            this.cancelCategoryModifyButton.TabIndex = 81;
            this.cancelCategoryModifyButton.TabStop = false;
            this.cancelCategoryModifyButton.Text = "Cancel";
            this.cancelCategoryModifyButton.UseVisualStyleBackColor = false;
            // 
            // calendarViewPanel
            // 
            this.calendarViewPanel.Controls.Add(this.indicatorPanelDayA);
            this.calendarViewPanel.Controls.Add(this.indicatorPanelDayB);
            this.calendarViewPanel.Controls.Add(this.spacerEventsPanel);
            this.calendarViewPanel.Controls.Add(this.remainingEventsLabel);
            this.calendarViewPanel.Controls.Add(this.remainingLabel);
            this.calendarViewPanel.Controls.Add(this.spacerCalendarRemaining);
            this.calendarViewPanel.Controls.Add(this.dailyCalendar);
            this.calendarViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarViewPanel.Location = new System.Drawing.Point(10, 10);
            this.calendarViewPanel.Name = "calendarViewPanel";
            this.calendarViewPanel.Size = new System.Drawing.Size(608, 458);
            this.calendarViewPanel.TabIndex = 23;
            // 
            // indicatorPanelDayA
            // 
            this.indicatorPanelDayA.Controls.Add(this.IndicatorLabelDayA);
            this.indicatorPanelDayA.Controls.Add(this.dailyCalendar2A);
            this.indicatorPanelDayA.Location = new System.Drawing.Point(0, 151);
            this.indicatorPanelDayA.Name = "indicatorPanelDayA";
            this.indicatorPanelDayA.Size = new System.Drawing.Size(605, 142);
            this.indicatorPanelDayA.TabIndex = 27;
            // 
            // IndicatorLabelDayA
            // 
            this.IndicatorLabelDayA.BackColor = System.Drawing.Color.Transparent;
            this.IndicatorLabelDayA.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.IndicatorLabelDayA.ForeColor = System.Drawing.Color.White;
            this.IndicatorLabelDayA.Location = new System.Drawing.Point(3, 54);
            this.IndicatorLabelDayA.Name = "IndicatorLabelDayA";
            this.IndicatorLabelDayA.Size = new System.Drawing.Size(74, 50);
            this.IndicatorLabelDayA.TabIndex = 26;
            this.IndicatorLabelDayA.Text = "Today";
            this.IndicatorLabelDayA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // indicatorPanelDayB
            // 
            this.indicatorPanelDayB.Controls.Add(this.IndicatorLabelDayB);
            this.indicatorPanelDayB.Controls.Add(this.dailyCalendar2B);
            this.indicatorPanelDayB.Location = new System.Drawing.Point(0, 3);
            this.indicatorPanelDayB.Name = "indicatorPanelDayB";
            this.indicatorPanelDayB.Size = new System.Drawing.Size(605, 142);
            this.indicatorPanelDayB.TabIndex = 26;
            // 
            // IndicatorLabelDayB
            // 
            this.IndicatorLabelDayB.BackColor = System.Drawing.Color.Transparent;
            this.IndicatorLabelDayB.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.IndicatorLabelDayB.ForeColor = System.Drawing.Color.White;
            this.IndicatorLabelDayB.Location = new System.Drawing.Point(3, 50);
            this.IndicatorLabelDayB.Name = "IndicatorLabelDayB";
            this.IndicatorLabelDayB.Size = new System.Drawing.Size(74, 42);
            this.IndicatorLabelDayB.TabIndex = 25;
            this.IndicatorLabelDayB.Text = "Tomorrow";
            this.IndicatorLabelDayB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spacerEventsPanel
            // 
            this.spacerEventsPanel.BackColor = System.Drawing.Color.Transparent;
            this.spacerEventsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spacerEventsPanel.Location = new System.Drawing.Point(0, 445);
            this.spacerEventsPanel.Name = "spacerEventsPanel";
            this.spacerEventsPanel.Size = new System.Drawing.Size(608, 13);
            this.spacerEventsPanel.TabIndex = 23;
            // 
            // remainingEventsLabel
            // 
            this.remainingEventsLabel.BackColor = System.Drawing.Color.Transparent;
            this.remainingEventsLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.remainingEventsLabel.ForeColor = System.Drawing.Color.White;
            this.remainingEventsLabel.Location = new System.Drawing.Point(0, 319);
            this.remainingEventsLabel.Name = "remainingEventsLabel";
            this.remainingEventsLabel.Size = new System.Drawing.Size(608, 139);
            this.remainingEventsLabel.TabIndex = 12;
            this.remainingEventsLabel.Text = "Nothing.";
            // 
            // remainingLabel
            // 
            this.remainingLabel.BackColor = System.Drawing.Color.Transparent;
            this.remainingLabel.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Underline);
            this.remainingLabel.ForeColor = System.Drawing.Color.White;
            this.remainingLabel.Location = new System.Drawing.Point(0, 296);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(608, 23);
            this.remainingLabel.TabIndex = 11;
            this.remainingLabel.Text = "Remaining Today";
            // 
            // spacerCalendarRemaining
            // 
            this.spacerCalendarRemaining.AutoSize = true;
            this.spacerCalendarRemaining.BackColor = System.Drawing.Color.Transparent;
            this.spacerCalendarRemaining.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerCalendarRemaining.Location = new System.Drawing.Point(0, 0);
            this.spacerCalendarRemaining.Name = "spacerCalendarRemaining";
            this.spacerCalendarRemaining.Size = new System.Drawing.Size(0, 13);
            this.spacerCalendarRemaining.TabIndex = 22;
            // 
            // twoDayViewPanel
            // 
            this.twoDayViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoDayViewPanel.Location = new System.Drawing.Point(10, 10);
            this.twoDayViewPanel.Name = "twoDayViewPanel";
            this.twoDayViewPanel.Size = new System.Drawing.Size(608, 458);
            this.twoDayViewPanel.TabIndex = 25;
            this.twoDayViewPanel.Visible = false;
            // 
            // monthViewPanel
            // 
            this.monthViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthViewPanel.Location = new System.Drawing.Point(10, 10);
            this.monthViewPanel.Name = "monthViewPanel";
            this.monthViewPanel.Size = new System.Drawing.Size(608, 458);
            this.monthViewPanel.TabIndex = 24;
            this.monthViewPanel.Visible = false;
            // 
            // viewSelectionPanel
            // 
            this.viewSelectionPanel.Controls.Add(this.viewLabel);
            this.viewSelectionPanel.Controls.Add(this.spacerLabelDay);
            this.viewSelectionPanel.Controls.Add(this.dayViewButton);
            this.viewSelectionPanel.Controls.Add(this.spacerDayTwoDay);
            this.viewSelectionPanel.Controls.Add(this.twoDayViewButton);
            this.viewSelectionPanel.Controls.Add(this.spacerTwoDayMonth);
            this.viewSelectionPanel.Controls.Add(this.monthViewButton);
            this.viewSelectionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewSelectionPanel.Location = new System.Drawing.Point(10, 468);
            this.viewSelectionPanel.Name = "viewSelectionPanel";
            this.viewSelectionPanel.Size = new System.Drawing.Size(608, 32);
            this.viewSelectionPanel.TabIndex = 22;
            // 
            // viewLabel
            // 
            this.viewLabel.BackColor = System.Drawing.Color.Transparent;
            this.viewLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.viewLabel.ForeColor = System.Drawing.Color.White;
            this.viewLabel.Location = new System.Drawing.Point(343, 0);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(49, 32);
            this.viewLabel.TabIndex = 18;
            this.viewLabel.Text = "View:";
            this.viewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spacerLabelDay
            // 
            this.spacerLabelDay.BackColor = System.Drawing.Color.Transparent;
            this.spacerLabelDay.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacerLabelDay.Location = new System.Drawing.Point(392, 0);
            this.spacerLabelDay.Name = "spacerLabelDay";
            this.spacerLabelDay.Size = new System.Drawing.Size(8, 32);
            this.spacerLabelDay.TabIndex = 22;
            // 
            // dayViewButton
            // 
            this.dayViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.dayViewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.dayViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dayViewButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.dayViewButton.Location = new System.Drawing.Point(400, 0);
            this.dayViewButton.Name = "dayViewButton";
            this.dayViewButton.Size = new System.Drawing.Size(64, 32);
            this.dayViewButton.TabIndex = 20;
            this.dayViewButton.TabStop = false;
            this.dayViewButton.Text = "Day";
            this.dayViewButton.UseVisualStyleBackColor = false;
            // 
            // spacerDayTwoDay
            // 
            this.spacerDayTwoDay.BackColor = System.Drawing.Color.Transparent;
            this.spacerDayTwoDay.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacerDayTwoDay.Location = new System.Drawing.Point(464, 0);
            this.spacerDayTwoDay.Name = "spacerDayTwoDay";
            this.spacerDayTwoDay.Size = new System.Drawing.Size(8, 32);
            this.spacerDayTwoDay.TabIndex = 24;
            // 
            // twoDayViewButton
            // 
            this.twoDayViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.twoDayViewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.twoDayViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twoDayViewButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.twoDayViewButton.Location = new System.Drawing.Point(472, 0);
            this.twoDayViewButton.Name = "twoDayViewButton";
            this.twoDayViewButton.Size = new System.Drawing.Size(64, 32);
            this.twoDayViewButton.TabIndex = 23;
            this.twoDayViewButton.TabStop = false;
            this.twoDayViewButton.Text = "2 Days";
            this.twoDayViewButton.UseVisualStyleBackColor = false;
            // 
            // spacerTwoDayMonth
            // 
            this.spacerTwoDayMonth.BackColor = System.Drawing.Color.Transparent;
            this.spacerTwoDayMonth.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacerTwoDayMonth.Location = new System.Drawing.Point(536, 0);
            this.spacerTwoDayMonth.Name = "spacerTwoDayMonth";
            this.spacerTwoDayMonth.Size = new System.Drawing.Size(8, 32);
            this.spacerTwoDayMonth.TabIndex = 21;
            // 
            // monthViewButton
            // 
            this.monthViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.monthViewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.monthViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.monthViewButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.monthViewButton.Location = new System.Drawing.Point(544, 0);
            this.monthViewButton.Name = "monthViewButton";
            this.monthViewButton.Size = new System.Drawing.Size(64, 32);
            this.monthViewButton.TabIndex = 19;
            this.monthViewButton.TabStop = false;
            this.monthViewButton.Text = "Month";
            this.monthViewButton.UseVisualStyleBackColor = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bottomPanel.Controls.Add(this.dateSelector);
            this.bottomPanel.Controls.Add(this.nextDayButton);
            this.bottomPanel.Controls.Add(this.prevDayButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 544);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1024, 32);
            this.bottomPanel.TabIndex = 16;
            // 
            // dateSelector
            // 
            this.dateSelector.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSelector.Location = new System.Drawing.Point(412, 2);
            this.dateSelector.Name = "dateSelector";
            this.dateSelector.ShowUpDown = true;
            this.dateSelector.Size = new System.Drawing.Size(200, 28);
            this.dateSelector.TabIndex = 10;
            this.dateSelector.TabStop = false;
            // 
            // nextDayButton
            // 
            this.nextDayButton.BackColor = System.Drawing.Color.Transparent;
            this.nextDayButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextDayButton.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDayButton.ForeColor = System.Drawing.Color.White;
            this.nextDayButton.Location = new System.Drawing.Point(992, 0);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(32, 32);
            this.nextDayButton.TabIndex = 1;
            this.nextDayButton.Text = ">";
            this.nextDayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prevDayButton
            // 
            this.prevDayButton.BackColor = System.Drawing.Color.Transparent;
            this.prevDayButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.prevDayButton.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevDayButton.ForeColor = System.Drawing.Color.White;
            this.prevDayButton.Location = new System.Drawing.Point(0, 0);
            this.prevDayButton.Name = "prevDayButton";
            this.prevDayButton.Size = new System.Drawing.Size(32, 32);
            this.prevDayButton.TabIndex = 4;
            this.prevDayButton.Text = "<";
            this.prevDayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTimeDisplay
            // 
            this.currentTimeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.currentTimeDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentTimeDisplay.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeDisplay.ForeColor = System.Drawing.Color.Transparent;
            this.currentTimeDisplay.Location = new System.Drawing.Point(23, 0);
            this.currentTimeDisplay.Name = "currentTimeDisplay";
            this.currentTimeDisplay.Size = new System.Drawing.Size(978, 32);
            this.currentTimeDisplay.TabIndex = 15;
            this.currentTimeDisplay.Text = "0:00 AM";
            this.currentTimeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.IndianRed;
            this.exitButton.Location = new System.Drawing.Point(1001, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.currentTimeDisplay);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.spacerFormTime);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1024, 32);
            this.topPanel.TabIndex = 24;
            // 
            // spacerFormTime
            // 
            this.spacerFormTime.BackColor = System.Drawing.Color.Transparent;
            this.spacerFormTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacerFormTime.Location = new System.Drawing.Point(0, 0);
            this.spacerFormTime.Name = "spacerFormTime";
            this.spacerFormTime.Size = new System.Drawing.Size(23, 32);
            this.spacerFormTime.TabIndex = 16;
            // 
            // categoryContextMenu
            // 
            this.categoryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyCategoryToolStripMenuItem,
            this.deleteCategoryToolStripMenuItem});
            this.categoryContextMenu.Name = "contextMenuStrip1";
            this.categoryContextMenu.Size = new System.Drawing.Size(164, 48);
            // 
            // modifyCategoryToolStripMenuItem
            // 
            this.modifyCategoryToolStripMenuItem.Name = "modifyCategoryToolStripMenuItem";
            this.modifyCategoryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.modifyCategoryToolStripMenuItem.Text = "Modify Category";
            // 
            // deleteCategoryToolStripMenuItem
            // 
            this.deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            this.deleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteCategoryToolStripMenuItem.Text = "Delete Category";
            // 
            // eventContextMenu
            // 
            this.eventContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyEventToolStripMenuItem,
            this.deleteEventToolStripMenuItem});
            this.eventContextMenu.Name = "contextMenuStrip1";
            this.eventContextMenu.Size = new System.Drawing.Size(145, 48);
            // 
            // modifyEventToolStripMenuItem
            // 
            this.modifyEventToolStripMenuItem.Name = "modifyEventToolStripMenuItem";
            this.modifyEventToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.modifyEventToolStripMenuItem.Text = "Modify Event";
            // 
            // deleteEventToolStripMenuItem
            // 
            this.deleteEventToolStripMenuItem.Name = "deleteEventToolStripMenuItem";
            this.deleteEventToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deleteEventToolStripMenuItem.Text = "Delete Event";
            // 
            // secondClock
            // 
            this.secondClock.Enabled = true;
            this.secondClock.Interval = 1000;
            // 
            // minuteClock
            // 
            this.minuteClock.Enabled = true;
            this.minuteClock.Interval = 60000;
            // 
            // dailyCalendar2A
            // 
            this.dailyCalendar2A.BackColor = System.Drawing.Color.White;
            this.dailyCalendar2A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyCalendar2A.Dock = System.Windows.Forms.DockStyle.Right;
            this.dailyCalendar2A.Location = new System.Drawing.Point(83, 0);
            this.dailyCalendar2A.Name = "dailyCalendar2A";
            this.dailyCalendar2A.Size = new System.Drawing.Size(522, 142);
            this.dailyCalendar2A.TabIndex = 25;
            // 
            // dailyCalendar2B
            // 
            this.dailyCalendar2B.BackColor = System.Drawing.Color.White;
            this.dailyCalendar2B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyCalendar2B.Dock = System.Windows.Forms.DockStyle.Right;
            this.dailyCalendar2B.Location = new System.Drawing.Point(83, 0);
            this.dailyCalendar2B.Name = "dailyCalendar2B";
            this.dailyCalendar2B.Size = new System.Drawing.Size(522, 142);
            this.dailyCalendar2B.TabIndex = 24;
            // 
            // dailyCalendar
            // 
            this.dailyCalendar.BackColor = System.Drawing.Color.White;
            this.dailyCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyCalendar.Location = new System.Drawing.Point(0, 3);
            this.dailyCalendar.Name = "dailyCalendar";
            this.dailyCalendar.Size = new System.Drawing.Size(218, 293);
            this.dailyCalendar.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.eventsDisplayPanel.ResumeLayout(false);
            this.eventButtonsPanel.ResumeLayout(false);
            this.eventModifyPanel.ResumeLayout(false);
            this.eventModifyPanel.PerformLayout();
            this.eventModifyBody.ResumeLayout(false);
            this.eventModifyBody.PerformLayout();
            this.eventModifyButtonsPanel.ResumeLayout(false);
            this.categoryModifyPanel.ResumeLayout(false);
            this.categoryModifyPanel.PerformLayout();
            this.categoryModifyBody.ResumeLayout(false);
            this.categoryModifyBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.categoryModifyButtonsPanel.ResumeLayout(false);
            this.calendarViewPanel.ResumeLayout(false);
            this.calendarViewPanel.PerformLayout();
            this.indicatorPanelDayA.ResumeLayout(false);
            this.indicatorPanelDayB.ResumeLayout(false);
            this.viewSelectionPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.categoryContextMenu.ResumeLayout(false);
            this.eventContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView eventsTreeView;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label nextDayButton;
        private System.Windows.Forms.Label prevDayButton;
        private System.Windows.Forms.Label remainingLabel;
        private System.Windows.Forms.Label remainingEventsLabel;
        private System.Windows.Forms.Label currentTimeDisplay;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.Button monthViewButton;
        private System.Windows.Forms.Button dayViewButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel eventModifyPanel;
        private System.Windows.Forms.Panel eventsDisplayPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker startingDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.TextBox labelField;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Label eventModifyLabel;
        private System.Windows.Forms.Panel categoryModifyPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label categoryModifyLabel;
        private DailyCalendar dailyCalendar;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label spacerFormTime;
        private System.Windows.Forms.Panel viewSelectionPanel;
        private System.Windows.Forms.Label spacerTwoDayMonth;
        private System.Windows.Forms.Label spacerLabelDay;
        private System.Windows.Forms.Panel calendarViewPanel;
        private System.Windows.Forms.Label spacerCalendarRemaining;
        private System.Windows.Forms.Label spacerEventsPanel;
        private System.Windows.Forms.DateTimePicker dateSelector;
        private System.Windows.Forms.Panel eventButtonsPanel;
        private System.Windows.Forms.ContextMenuStrip categoryContextMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCategoryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip eventContextMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEventToolStripMenuItem;
        private System.Windows.Forms.Panel monthViewPanel;
        private System.Windows.Forms.Panel eventModifyButtonsPanel;
        private System.Windows.Forms.Panel categoryModifyButtonsPanel;
        private System.Windows.Forms.TableLayoutPanel eventModifyBody;
        private System.Windows.Forms.DateTimePicker startingTime;
        private System.Windows.Forms.DateTimePicker endingDate;
        private System.Windows.Forms.DateTimePicker endingTime;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ComboBox categoryDropDown;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.TextBox locationField;
        private System.Windows.Forms.Timer secondClock;
        private System.Windows.Forms.Timer minuteClock;
        private System.Windows.Forms.TextBox eventErrors;
        private System.Windows.Forms.Button cancelEventModifyButton;
        private System.Windows.Forms.Button saveEventModifyButton;
        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.Button createCategoryButton;
        private System.Windows.Forms.Button saveCategoryModifyButton;
        private System.Windows.Forms.Button cancelCategoryModifyButton;
        private System.Windows.Forms.TextBox categoryErrors;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.ComboBox symbolDropDown;
        private System.Windows.Forms.TableLayoutPanel categoryModifyBody;
        private System.Windows.Forms.Label spacerDayTwoDay;
        private System.Windows.Forms.Button twoDayViewButton;
        private System.Windows.Forms.Panel twoDayViewPanel;
        private DailyCalendar dailyCalendar2A;
        private DailyCalendar dailyCalendar2B;
        private System.Windows.Forms.Panel indicatorPanelDayA;
        private System.Windows.Forms.Label IndicatorLabelDayA;
        private System.Windows.Forms.Panel indicatorPanelDayB;
        private System.Windows.Forms.Label IndicatorLabelDayB;
    }
}

