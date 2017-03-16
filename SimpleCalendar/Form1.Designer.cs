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
            this.eventModifyLabel = new System.Windows.Forms.Label();
            this.eventModifyButtonsPanel = new System.Windows.Forms.Panel();
            this.cancelEventModifyButton = new System.Windows.Forms.Label();
            this.saveEventModifyButton = new System.Windows.Forms.Label();
            this.categoryModifyPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.categoryModifyLabel = new System.Windows.Forms.Label();
            this.categoryModifyButtonsPanel = new System.Windows.Forms.Panel();
            this.cancelCategoryModifyButton = new System.Windows.Forms.Label();
            this.saveCategoryModifyButton = new System.Windows.Forms.Label();
            this.eventsDisplayPanel = new System.Windows.Forms.Panel();
            this.eventsTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.eventsLabel = new System.Windows.Forms.Label();
            this.eventButtonsPanel = new System.Windows.Forms.Panel();
            this.createEventButton = new System.Windows.Forms.Label();
            this.createCategoryButton = new System.Windows.Forms.Label();
            this.dayViewPanel = new System.Windows.Forms.Panel();
            this.spacerEventsPanel = new System.Windows.Forms.Label();
            this.remainingEventsLabel = new System.Windows.Forms.Label();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.spacerCalendarRemaining = new System.Windows.Forms.Label();
            this.dailyCalendar = new SimpleCalendar.DailyCalendar();
            this.monthViewPanel = new System.Windows.Forms.Panel();
            this.viewSelectionPanel = new System.Windows.Forms.Panel();
            this.viewLabel = new System.Windows.Forms.Label();
            this.spacerLabelDay = new System.Windows.Forms.Label();
            this.dayViewButton = new System.Windows.Forms.Button();
            this.spacerDayMonth = new System.Windows.Forms.Label();
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
            this.editEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondClock = new System.Windows.Forms.Timer(this.components);
            this.minuteClock = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.eventModifyPanel.SuspendLayout();
            this.eventModifyBody.SuspendLayout();
            this.eventModifyButtonsPanel.SuspendLayout();
            this.categoryModifyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.categoryModifyButtonsPanel.SuspendLayout();
            this.eventsDisplayPanel.SuspendLayout();
            this.eventButtonsPanel.SuspendLayout();
            this.dayViewPanel.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.eventModifyPanel);
            this.splitContainer1.Panel1.Controls.Add(this.categoryModifyPanel);
            this.splitContainer1.Panel1.Controls.Add(this.eventsDisplayPanel);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dayViewPanel);
            this.splitContainer1.Panel2.Controls.Add(this.monthViewPanel);
            this.splitContainer1.Panel2.Controls.Add(this.viewSelectionPanel);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 512);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 17;
            this.splitContainer1.TabStop = false;
            // 
            // eventModifyPanel
            // 
            this.eventModifyPanel.Controls.Add(this.eventModifyBody);
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
            this.eventModifyBody.Size = new System.Drawing.Size(368, 437);
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
            this.locationField.TabIndex = 69;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(11, 227);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(99, 202);
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
            this.descriptionField.Size = new System.Drawing.Size(241, 196);
            this.descriptionField.TabIndex = 68;
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
            this.eventModifyLabel.Text = "Create/Modify Event...";
            this.eventModifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventModifyButtonsPanel
            // 
            this.eventModifyButtonsPanel.Controls.Add(this.cancelEventModifyButton);
            this.eventModifyButtonsPanel.Controls.Add(this.saveEventModifyButton);
            this.eventModifyButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eventModifyButtonsPanel.Location = new System.Drawing.Point(0, 465);
            this.eventModifyButtonsPanel.Name = "eventModifyButtonsPanel";
            this.eventModifyButtonsPanel.Size = new System.Drawing.Size(368, 25);
            this.eventModifyButtonsPanel.TabIndex = 63;
            // 
            // cancelEventModifyButton
            // 
            this.cancelEventModifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.cancelEventModifyButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cancelEventModifyButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancelEventModifyButton.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEventModifyButton.Location = new System.Drawing.Point(0, 0);
            this.cancelEventModifyButton.Name = "cancelEventModifyButton";
            this.cancelEventModifyButton.Size = new System.Drawing.Size(160, 25);
            this.cancelEventModifyButton.TabIndex = 47;
            this.cancelEventModifyButton.Text = "Cancel";
            this.cancelEventModifyButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveEventModifyButton
            // 
            this.saveEventModifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.saveEventModifyButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveEventModifyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveEventModifyButton.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEventModifyButton.Location = new System.Drawing.Point(208, 0);
            this.saveEventModifyButton.Name = "saveEventModifyButton";
            this.saveEventModifyButton.Size = new System.Drawing.Size(160, 25);
            this.saveEventModifyButton.TabIndex = 48;
            this.saveEventModifyButton.Text = "Save Changes";
            this.saveEventModifyButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryModifyPanel
            // 
            this.categoryModifyPanel.Controls.Add(this.pictureBox3);
            this.categoryModifyPanel.Controls.Add(this.textBox7);
            this.categoryModifyPanel.Controls.Add(this.label25);
            this.categoryModifyPanel.Controls.Add(this.textBox8);
            this.categoryModifyPanel.Controls.Add(this.label26);
            this.categoryModifyPanel.Controls.Add(this.textBox9);
            this.categoryModifyPanel.Controls.Add(this.label27);
            this.categoryModifyPanel.Controls.Add(this.categoryModifyLabel);
            this.categoryModifyPanel.Controls.Add(this.categoryModifyButtonsPanel);
            this.categoryModifyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryModifyPanel.Location = new System.Drawing.Point(10, 10);
            this.categoryModifyPanel.Name = "categoryModifyPanel";
            this.categoryModifyPanel.Size = new System.Drawing.Size(368, 490);
            this.categoryModifyPanel.TabIndex = 23;
            this.categoryModifyPanel.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(274, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(182)))), ((int)(((byte)(201)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.textBox7.Location = new System.Drawing.Point(122, 214);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(88, 22);
            this.textBox7.TabIndex = 85;
            this.textBox7.Text = "      Green    v";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tw Cen MT", 11F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(58, 214);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 17);
            this.label25.TabIndex = 84;
            this.label25.Text = "  *Color:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(182)))), ((int)(((byte)(201)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.textBox8.Location = new System.Drawing.Point(122, 187);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(88, 22);
            this.textBox8.TabIndex = 83;
            this.textBox8.Text = "        Star     v";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tw Cen MT", 11F);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(54, 190);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 17);
            this.label26.TabIndex = 82;
            this.label26.Text = "*Symbol:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(182)))), ((int)(((byte)(201)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(122, 161);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(228, 20);
            this.textBox9.TabIndex = 81;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tw Cen MT", 11F);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(63, 164);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 17);
            this.label27.TabIndex = 80;
            this.label27.Text = "*Name:";
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
            this.categoryModifyLabel.Text = "Create/Modify Category...";
            this.categoryModifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryModifyButtonsPanel
            // 
            this.categoryModifyButtonsPanel.Controls.Add(this.cancelCategoryModifyButton);
            this.categoryModifyButtonsPanel.Controls.Add(this.saveCategoryModifyButton);
            this.categoryModifyButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoryModifyButtonsPanel.Location = new System.Drawing.Point(0, 465);
            this.categoryModifyButtonsPanel.Name = "categoryModifyButtonsPanel";
            this.categoryModifyButtonsPanel.Size = new System.Drawing.Size(368, 25);
            this.categoryModifyButtonsPanel.TabIndex = 64;
            // 
            // cancelCategoryModifyButton
            // 
            this.cancelCategoryModifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.cancelCategoryModifyButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cancelCategoryModifyButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancelCategoryModifyButton.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.cancelCategoryModifyButton.Location = new System.Drawing.Point(0, 0);
            this.cancelCategoryModifyButton.Name = "cancelCategoryModifyButton";
            this.cancelCategoryModifyButton.Size = new System.Drawing.Size(160, 25);
            this.cancelCategoryModifyButton.TabIndex = 78;
            this.cancelCategoryModifyButton.Text = "Cancel";
            this.cancelCategoryModifyButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveCategoryModifyButton
            // 
            this.saveCategoryModifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.saveCategoryModifyButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveCategoryModifyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveCategoryModifyButton.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.saveCategoryModifyButton.Location = new System.Drawing.Point(208, 0);
            this.saveCategoryModifyButton.Name = "saveCategoryModifyButton";
            this.saveCategoryModifyButton.Size = new System.Drawing.Size(160, 25);
            this.saveCategoryModifyButton.TabIndex = 79;
            this.saveCategoryModifyButton.Text = "Save Changes";
            this.saveCategoryModifyButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.eventsTreeView.Size = new System.Drawing.Size(368, 437);
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
            this.eventButtonsPanel.Location = new System.Drawing.Point(0, 465);
            this.eventButtonsPanel.Name = "eventButtonsPanel";
            this.eventButtonsPanel.Size = new System.Drawing.Size(368, 25);
            this.eventButtonsPanel.TabIndex = 15;
            // 
            // createEventButton
            // 
            this.createEventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.createEventButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createEventButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.createEventButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.createEventButton.Location = new System.Drawing.Point(0, 0);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(160, 25);
            this.createEventButton.TabIndex = 13;
            this.createEventButton.Text = "Create New Event";
            this.createEventButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createCategoryButton
            // 
            this.createCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.createCategoryButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createCategoryButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.createCategoryButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.createCategoryButton.Location = new System.Drawing.Point(208, 0);
            this.createCategoryButton.Name = "createCategoryButton";
            this.createCategoryButton.Size = new System.Drawing.Size(160, 25);
            this.createCategoryButton.TabIndex = 14;
            this.createCategoryButton.Text = "Create New Category";
            this.createCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayViewPanel
            // 
            this.dayViewPanel.Controls.Add(this.spacerEventsPanel);
            this.dayViewPanel.Controls.Add(this.remainingEventsLabel);
            this.dayViewPanel.Controls.Add(this.remainingLabel);
            this.dayViewPanel.Controls.Add(this.spacerCalendarRemaining);
            this.dayViewPanel.Controls.Add(this.dailyCalendar);
            this.dayViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayViewPanel.Location = new System.Drawing.Point(10, 10);
            this.dayViewPanel.Name = "dayViewPanel";
            this.dayViewPanel.Size = new System.Drawing.Size(608, 458);
            this.dayViewPanel.TabIndex = 23;
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
            this.remainingEventsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.remainingLabel.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.spacerCalendarRemaining.Location = new System.Drawing.Point(0, 283);
            this.spacerCalendarRemaining.Name = "spacerCalendarRemaining";
            this.spacerCalendarRemaining.Size = new System.Drawing.Size(0, 13);
            this.spacerCalendarRemaining.TabIndex = 22;
            // 
            // dailyCalendar
            // 
            this.dailyCalendar.BackColor = System.Drawing.Color.White;
            this.dailyCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dailyCalendar.Location = new System.Drawing.Point(0, 0);
            this.dailyCalendar.Name = "dailyCalendar";
            this.dailyCalendar.Size = new System.Drawing.Size(608, 283);
            this.dailyCalendar.TabIndex = 21;
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
            this.viewSelectionPanel.Controls.Add(this.spacerDayMonth);
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
            this.viewLabel.Location = new System.Drawing.Point(479, 0);
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
            this.spacerLabelDay.Location = new System.Drawing.Point(528, 0);
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
            this.dayViewButton.Location = new System.Drawing.Point(536, 0);
            this.dayViewButton.Name = "dayViewButton";
            this.dayViewButton.Size = new System.Drawing.Size(32, 32);
            this.dayViewButton.TabIndex = 20;
            this.dayViewButton.TabStop = false;
            this.dayViewButton.Text = "D";
            this.dayViewButton.UseVisualStyleBackColor = false;
            // 
            // spacerDayMonth
            // 
            this.spacerDayMonth.BackColor = System.Drawing.Color.Transparent;
            this.spacerDayMonth.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacerDayMonth.Location = new System.Drawing.Point(568, 0);
            this.spacerDayMonth.Name = "spacerDayMonth";
            this.spacerDayMonth.Size = new System.Drawing.Size(8, 32);
            this.spacerDayMonth.TabIndex = 21;
            // 
            // monthViewButton
            // 
            this.monthViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.monthViewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.monthViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.monthViewButton.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.monthViewButton.Location = new System.Drawing.Point(576, 0);
            this.monthViewButton.Name = "monthViewButton";
            this.monthViewButton.Size = new System.Drawing.Size(32, 32);
            this.monthViewButton.TabIndex = 19;
            this.monthViewButton.TabStop = false;
            this.monthViewButton.Text = "M";
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
            this.editEventToolStripMenuItem,
            this.deleteEventToolStripMenuItem});
            this.eventContextMenu.Name = "contextMenuStrip1";
            this.eventContextMenu.Size = new System.Drawing.Size(145, 48);
            // 
            // editEventToolStripMenuItem
            // 
            this.editEventToolStripMenuItem.Name = "editEventToolStripMenuItem";
            this.editEventToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.editEventToolStripMenuItem.Text = "Modify Event";
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
            this.eventModifyPanel.ResumeLayout(false);
            this.eventModifyBody.ResumeLayout(false);
            this.eventModifyBody.PerformLayout();
            this.eventModifyButtonsPanel.ResumeLayout(false);
            this.categoryModifyPanel.ResumeLayout(false);
            this.categoryModifyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.categoryModifyButtonsPanel.ResumeLayout(false);
            this.eventsDisplayPanel.ResumeLayout(false);
            this.eventButtonsPanel.ResumeLayout(false);
            this.dayViewPanel.ResumeLayout(false);
            this.dayViewPanel.PerformLayout();
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
        private System.Windows.Forms.Label createEventButton;
        private System.Windows.Forms.Label createCategoryButton;
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
        private System.Windows.Forms.Label saveEventModifyButton;
        private System.Windows.Forms.Label cancelEventModifyButton;
        private System.Windows.Forms.Label eventModifyLabel;
        private System.Windows.Forms.Panel categoryModifyPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label saveCategoryModifyButton;
        private System.Windows.Forms.Label cancelCategoryModifyButton;
        private System.Windows.Forms.Label categoryModifyLabel;
        private DailyCalendar dailyCalendar;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label spacerFormTime;
        private System.Windows.Forms.Panel viewSelectionPanel;
        private System.Windows.Forms.Label spacerDayMonth;
        private System.Windows.Forms.Label spacerLabelDay;
        private System.Windows.Forms.Panel dayViewPanel;
        private System.Windows.Forms.Label spacerCalendarRemaining;
        private System.Windows.Forms.Label spacerEventsPanel;
        private System.Windows.Forms.DateTimePicker dateSelector;
        private System.Windows.Forms.Panel eventButtonsPanel;
        private System.Windows.Forms.ContextMenuStrip categoryContextMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCategoryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip eventContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editEventToolStripMenuItem;
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
    }
}

