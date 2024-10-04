using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AdvancedBadgeEditor
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.badgeFileprbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFilecabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importEntireSetData = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.uniqueBadgesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalBadgesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createBadgeButton = new System.Windows.Forms.Button();
            this.createSetButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.badgeNameInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.badgeIdNumer = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.badgeSidNumer = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.badgeQuantityNumer = new System.Windows.Forms.NumericUpDown();
            this.selectedBadgeNumer = new System.Windows.Forms.NumericUpDown();
            this.badge255each = new System.Windows.Forms.Button();
            this.selectSetNumer = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.setNameInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.setIdNumer = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.setStartingNumer = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.setUniqueBadgesLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.setTotalBadgesLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.badgeSetIdNumer = new System.Windows.Forms.NumericUpDown();
            this.prevBadgeImg64 = new System.Windows.Forms.PictureBox();
            this.prevBadgeLabel = new System.Windows.Forms.Label();
            this.importBadgeImage = new System.Windows.Forms.Button();
            this.prevBadgeImg32 = new System.Windows.Forms.PictureBox();
            this.exportBadgeImage = new System.Windows.Forms.Button();
            this.titleHighNumer = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.titleIDnumer = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.prevSetImg = new System.Windows.Forms.PictureBox();
            this.exportSetImage = new System.Windows.Forms.Button();
            this.importSetImage = new System.Windows.Forms.Button();
            this.pixelBadgeMode = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.titleIDdropdown = new System.Windows.Forms.ComboBox();
            this.regionDropdown = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.NNIDnumer = new System.Windows.Forms.NumericUpDown();
            this.delBadge = new System.Windows.Forms.Button();
            this.delSet = new System.Windows.Forms.Button();
            this.delAll = new System.Windows.Forms.Button();
            this.fixBadgeSetIds = new System.Windows.Forms.Button();
            this.loading = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.importBadgeButton = new System.Windows.Forms.Button();
            this.importSetButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badgeIdNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgeSidNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgeQuantityNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedBadgeNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSetNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setIdNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setStartingNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgeSetIdNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBadgeImg64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBadgeImg32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleHighNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleIDnumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevSetImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NNIDnumer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.importToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDataToolStripMenuItem,
            this.openDataToolStripMenuItem,
            this.saveDataToolStripMenuItem,
            this.saveDataToToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newDataToolStripMenuItem
            // 
            this.newDataToolStripMenuItem.Name = "newDataToolStripMenuItem";
            this.newDataToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newDataToolStripMenuItem.Text = "New data";
            this.newDataToolStripMenuItem.Click += new System.EventHandler(this.NewDataToolStripMenuItem_Click);
            // 
            // openDataToolStripMenuItem
            // 
            this.openDataToolStripMenuItem.Name = "openDataToolStripMenuItem";
            this.openDataToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.openDataToolStripMenuItem.Text = "Open data";
            this.openDataToolStripMenuItem.Click += new System.EventHandler(this.OpenDataToolStripMenuItem_Click);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Enabled = false;
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveDataToolStripMenuItem.Text = "Save data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.SaveDataToolStripMenuItem_Click);
            // 
            // saveDataToToolStripMenuItem
            // 
            this.saveDataToToolStripMenuItem.Enabled = false;
            this.saveDataToToolStripMenuItem.Name = "saveDataToToolStripMenuItem";
            this.saveDataToToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveDataToToolStripMenuItem.Text = "Save data to...";
            this.saveDataToToolStripMenuItem.Click += new System.EventHandler(this.SaveDataToToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.badgeFileprbToolStripMenuItem,
            this.setFilecabToolStripMenuItem,
            this.importEntireSetData});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // badgeFileprbToolStripMenuItem
            // 
            this.badgeFileprbToolStripMenuItem.Enabled = false;
            this.badgeFileprbToolStripMenuItem.Name = "badgeFileprbToolStripMenuItem";
            this.badgeFileprbToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.badgeFileprbToolStripMenuItem.Text = "Badge file(s) (*.prb)";
            this.badgeFileprbToolStripMenuItem.Click += new System.EventHandler(this.BadgeFilePrbToolStripMenuItem_Click);
            // 
            // setFilecabToolStripMenuItem
            // 
            this.setFilecabToolStripMenuItem.Enabled = false;
            this.setFilecabToolStripMenuItem.Name = "setFilecabToolStripMenuItem";
            this.setFilecabToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.setFilecabToolStripMenuItem.Text = "Set file (*.cab)";
            this.setFilecabToolStripMenuItem.Click += new System.EventHandler(this.SetFileCabToolStripMenuItem_Click);
            // 
            // importEntireSetData
            // 
            this.importEntireSetData.Enabled = false;
            this.importEntireSetData.Name = "importEntireSetData";
            this.importEntireSetData.Size = new System.Drawing.Size(238, 22);
            this.importEntireSetData.Text = "Entire set data (*.prb and *.cab)";
            this.importEntireSetData.Click += new System.EventHandler(this.ImportEntireSetData_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Unique badges:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uniqueBadgesLabel
            // 
            this.uniqueBadgesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uniqueBadgesLabel.AutoSize = true;
            this.uniqueBadgesLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uniqueBadgesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uniqueBadgesLabel.Location = new System.Drawing.Point(93, 3);
            this.uniqueBadgesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.uniqueBadgesLabel.Name = "uniqueBadgesLabel";
            this.uniqueBadgesLabel.Size = new System.Drawing.Size(54, 19);
            this.uniqueBadgesLabel.TabIndex = 100;
            this.uniqueBadgesLabel.Text = "0";
            this.uniqueBadgesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Total badges:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalBadgesLabel
            // 
            this.totalBadgesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalBadgesLabel.AutoSize = true;
            this.totalBadgesLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalBadgesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalBadgesLabel.Location = new System.Drawing.Point(93, 28);
            this.totalBadgesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.totalBadgesLabel.Name = "totalBadgesLabel";
            this.totalBadgesLabel.Size = new System.Drawing.Size(54, 19);
            this.totalBadgesLabel.TabIndex = 100;
            this.totalBadgesLabel.Text = "0";
            this.totalBadgesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Sets:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // setsLabel
            // 
            this.setsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setsLabel.AutoSize = true;
            this.setsLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.setsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setsLabel.Location = new System.Drawing.Point(93, 53);
            this.setsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.setsLabel.Name = "setsLabel";
            this.setsLabel.Size = new System.Drawing.Size(54, 19);
            this.setsLabel.TabIndex = 100;
            this.setsLabel.Text = "0";
            this.setsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "NNID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createBadgeButton
            // 
            this.createBadgeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.createBadgeButton.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.createBadgeButton, 2);
            this.createBadgeButton.Enabled = false;
            this.createBadgeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createBadgeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.createBadgeButton.Location = new System.Drawing.Point(175, 38);
            this.createBadgeButton.Name = "createBadgeButton";
            this.createBadgeButton.Size = new System.Drawing.Size(124, 24);
            this.createBadgeButton.TabIndex = 5;
            this.createBadgeButton.Text = "Create new";
            this.createBadgeButton.UseVisualStyleBackColor = true;
            this.createBadgeButton.Click += new System.EventHandler(this.CreateBadgeButton_Click);
            // 
            // createSetButton
            // 
            this.createSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.createSetButton.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.createSetButton, 2);
            this.createSetButton.Enabled = false;
            this.createSetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createSetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.createSetButton.Location = new System.Drawing.Point(445, 38);
            this.createSetButton.Name = "createSetButton";
            this.createSetButton.Size = new System.Drawing.Size(124, 24);
            this.createSetButton.TabIndex = 20;
            this.createSetButton.Text = "Create new";
            this.createSetButton.UseVisualStyleBackColor = true;
            this.createSetButton.Click += new System.EventHandler(this.CreateSetButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.label5, 3);
            this.label5.Location = new System.Drawing.Point(175, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 19);
            this.label5.TabIndex = 100;
            this.label5.Text = "Badges";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "Name:";
            // 
            // badgeNameInput
            // 
            this.badgeNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.badgeNameInput, 2);
            this.badgeNameInput.Enabled = false;
            this.badgeNameInput.Location = new System.Drawing.Point(265, 122);
            this.badgeNameInput.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.badgeNameInput.MaxLength = 69;
            this.badgeNameInput.Name = "badgeNameInput";
            this.badgeNameInput.Size = new System.Drawing.Size(164, 20);
            this.badgeNameInput.TabIndex = 8;
            this.badgeNameInput.Text = "None";
            this.badgeNameInput.TextChanged += new System.EventHandler(this.BadgeNameInput_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "ID:";
            // 
            // badgeIdNumer
            // 
            this.badgeIdNumer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.badgeIdNumer, 2);
            this.badgeIdNumer.Enabled = false;
            this.badgeIdNumer.Hexadecimal = true;
            this.badgeIdNumer.Increment = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.badgeIdNumer.Location = new System.Drawing.Point(265, 147);
            this.badgeIdNumer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.badgeIdNumer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.badgeIdNumer.Name = "badgeIdNumer";
            this.badgeIdNumer.Size = new System.Drawing.Size(164, 20);
            this.badgeIdNumer.TabIndex = 9;
            this.badgeIdNumer.ValueChanged += new System.EventHandler(this.BadgeIdNumer_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 100;
            this.label8.Text = "Sub ID:";
            // 
            // badgeSidNumer
            // 
            this.badgeSidNumer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.badgeSidNumer, 2);
            this.badgeSidNumer.Enabled = false;
            this.badgeSidNumer.Hexadecimal = true;
            this.badgeSidNumer.Increment = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.badgeSidNumer.Location = new System.Drawing.Point(265, 172);
            this.badgeSidNumer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.badgeSidNumer.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.badgeSidNumer.Name = "badgeSidNumer";
            this.badgeSidNumer.Size = new System.Drawing.Size(164, 20);
            this.badgeSidNumer.TabIndex = 10;
            this.badgeSidNumer.ValueChanged += new System.EventHandler(this.BadgeSubIDNumer_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "Quantity:";
            // 
            // badgeQuantityNumer
            // 
            this.badgeQuantityNumer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.badgeQuantityNumer, 2);
            this.badgeQuantityNumer.Enabled = false;
            this.badgeQuantityNumer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.badgeQuantityNumer.Location = new System.Drawing.Point(265, 222);
            this.badgeQuantityNumer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.badgeQuantityNumer.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.badgeQuantityNumer.Name = "badgeQuantityNumer";
            this.badgeQuantityNumer.Size = new System.Drawing.Size(164, 20);
            this.badgeQuantityNumer.TabIndex = 12;
            this.badgeQuantityNumer.ValueChanged += new System.EventHandler(this.BadgeQuantityNumer_ValueChanged);
            // 
            // selectedBadgeNumer
            // 
            this.selectedBadgeNumer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.selectedBadgeNumer, 2);
            this.selectedBadgeNumer.Enabled = false;
            this.selectedBadgeNumer.Location = new System.Drawing.Point(265, 97);
            this.selectedBadgeNumer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.selectedBadgeNumer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.selectedBadgeNumer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectedBadgeNumer.Name = "selectedBadgeNumer";
            this.selectedBadgeNumer.Size = new System.Drawing.Size(164, 20);
            this.selectedBadgeNumer.TabIndex = 7;
            this.selectedBadgeNumer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectedBadgeNumer.ValueChanged += new System.EventHandler(this.SelectedBadgeNumer_ValueChanged);
            // 
            // badge255each
            // 
            this.badge255each.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.badge255each.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.badge255each, 3);
            this.badge255each.Enabled = false;
            this.badge255each.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.badge255each.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.badge255each.Location = new System.Drawing.Point(3, 153);
            this.badge255each.Name = "badge255each";
            this.badge255each.Size = new System.Drawing.Size(144, 24);
            this.badge255each.TabIndex = 3;
            this.badge255each.Text = "255 of each badge";
            this.badge255each.UseVisualStyleBackColor = true;
            this.badge255each.Click += new System.EventHandler(this.Badge255Each_Click);
            // 
            // selectSetNumer
            // 
            this.selectSetNumer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.selectSetNumer, 2);
            this.selectSetNumer.Enabled = false;
            this.selectSetNumer.Location = new System.Drawing.Point(535, 98);
            this.selectSetNumer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectSetNumer.Name = "selectSetNumer";
            this.selectSetNumer.Size = new System.Drawing.Size(164, 20);
            this.selectSetNumer.TabIndex = 22;
            this.selectSetNumer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectSetNumer.ValueChanged += new System.EventHandler(this.SelectSetNumer_ValueChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.label11, 3);
            this.label11.Location = new System.Drawing.Point(445, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 19);
            this.label11.TabIndex = 100;
            this.label11.Text = "Collections";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(445, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 100;
            this.label12.Text = "Name:";
            // 
            // setNameInput
            // 
            this.setNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.setNameInput, 2);
            this.setNameInput.Enabled = false;
            this.setNameInput.Location = new System.Drawing.Point(535, 123);
            this.setNameInput.Name = "setNameInput";
            this.setNameInput.Size = new System.Drawing.Size(164, 20);
            this.setNameInput.TabIndex = 23;
            this.setNameInput.Text = "None";
            this.setNameInput.TextChanged += new System.EventHandler(this.SetNameInput_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(445, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 100;
            this.label13.Text = "ID:";
            // 
            // setIdNumer
            // 
            this.setIdNumer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.setIdNumer, 2);
            this.setIdNumer.Enabled = false;
            this.setIdNumer.Hexadecimal = true;
            this.setIdNumer.Increment = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.setIdNumer.Location = new System.Drawing.Point(535, 148);
            this.setIdNumer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.setIdNumer.Name = "setIdNumer";
            this.setIdNumer.Size = new System.Drawing.Size(164, 20);
            this.setIdNumer.TabIndex = 24;
            this.setIdNumer.ValueChanged += new System.EventHandler(this.SetIDNumer_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(445, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 100;
            this.label14.Text = "Starting badge:";
            // 
            // setStartingNumer
            // 
            this.setStartingNumer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.setStartingNumer, 2);
            this.setStartingNumer.Enabled = false;
            this.setStartingNumer.Location = new System.Drawing.Point(535, 173);
            this.setStartingNumer.Maximum = new decimal(new int[] {
            0,
            1,
            0,
            0});
            this.setStartingNumer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setStartingNumer.Name = "setStartingNumer";
            this.setStartingNumer.Size = new System.Drawing.Size(164, 20);
            this.setStartingNumer.TabIndex = 25;
            this.setStartingNumer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setStartingNumer.ValueChanged += new System.EventHandler(this.SetStartingNumer_ValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Unique badges:";
            // 
            // setUniqueBadgesLabel
            // 
            this.setUniqueBadgesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setUniqueBadgesLabel.AutoSize = true;
            this.setUniqueBadgesLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.setUniqueBadgesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.setUniqueBadgesLabel, 2);
            this.setUniqueBadgesLabel.Location = new System.Drawing.Point(535, 198);
            this.setUniqueBadgesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.setUniqueBadgesLabel.Name = "setUniqueBadgesLabel";
            this.setUniqueBadgesLabel.Size = new System.Drawing.Size(164, 19);
            this.setUniqueBadgesLabel.TabIndex = 100;
            this.setUniqueBadgesLabel.Text = "0";
            this.setUniqueBadgesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(445, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 100;
            this.label15.Text = "Total badges:";
            // 
            // setTotalBadgesLabel
            // 
            this.setTotalBadgesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTotalBadgesLabel.AutoSize = true;
            this.setTotalBadgesLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.setTotalBadgesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.setTotalBadgesLabel, 2);
            this.setTotalBadgesLabel.Location = new System.Drawing.Point(535, 223);
            this.setTotalBadgesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.setTotalBadgesLabel.Name = "setTotalBadgesLabel";
            this.setTotalBadgesLabel.Size = new System.Drawing.Size(164, 19);
            this.setTotalBadgesLabel.TabIndex = 100;
            this.setTotalBadgesLabel.Text = "0";
            this.setTotalBadgesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(175, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 100;
            this.label18.Text = "Collection ID:";
            // 
            // badgeSetIdNumer
            // 
            this.badgeSetIdNumer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.badgeSetIdNumer, 2);
            this.badgeSetIdNumer.Enabled = false;
            this.badgeSetIdNumer.Hexadecimal = true;
            this.badgeSetIdNumer.Increment = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.badgeSetIdNumer.Location = new System.Drawing.Point(265, 197);
            this.badgeSetIdNumer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.badgeSetIdNumer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.badgeSetIdNumer.Name = "badgeSetIdNumer";
            this.badgeSetIdNumer.Size = new System.Drawing.Size(164, 20);
            this.badgeSetIdNumer.TabIndex = 11;
            this.badgeSetIdNumer.ValueChanged += new System.EventHandler(this.BadgeSetIdNumer_ValueChanged);
            // 
            // prevBadgeImg64
            // 
            this.prevBadgeImg64.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevBadgeImg64.BackColor = System.Drawing.Color.Gainsboro;
            this.prevBadgeImg64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prevBadgeImg64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.prevBadgeImg64, 2);
            this.prevBadgeImg64.Location = new System.Drawing.Point(203, 336);
            this.prevBadgeImg64.Margin = new System.Windows.Forms.Padding(0);
            this.prevBadgeImg64.Name = "prevBadgeImg64";
            this.prevBadgeImg64.Size = new System.Drawing.Size(68, 68);
            this.prevBadgeImg64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.prevBadgeImg64.TabIndex = 100;
            this.prevBadgeImg64.TabStop = false;
            // 
            // prevBadgeLabel
            // 
            this.prevBadgeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prevBadgeLabel.AutoSize = true;
            this.prevBadgeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.prevBadgeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.prevBadgeLabel, 7);
            this.prevBadgeLabel.Location = new System.Drawing.Point(175, 308);
            this.prevBadgeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.prevBadgeLabel.Name = "prevBadgeLabel";
            this.prevBadgeLabel.Size = new System.Drawing.Size(524, 19);
            this.prevBadgeLabel.TabIndex = 100;
            this.prevBadgeLabel.Text = "Images";
            this.prevBadgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // importBadgeImage
            // 
            this.importBadgeImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importBadgeImage.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.importBadgeImage, 2);
            this.importBadgeImage.Enabled = false;
            this.importBadgeImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.importBadgeImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.importBadgeImage.Location = new System.Drawing.Point(175, 413);
            this.importBadgeImage.Name = "importBadgeImage";
            this.importBadgeImage.Size = new System.Drawing.Size(124, 23);
            this.importBadgeImage.TabIndex = 16;
            this.importBadgeImage.Text = "Import";
            this.importBadgeImage.UseVisualStyleBackColor = true;
            this.importBadgeImage.Click += new System.EventHandler(this.ImportBadgeImage_Click);
            // 
            // prevBadgeImg32
            // 
            this.prevBadgeImg32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevBadgeImg32.BackColor = System.Drawing.Color.Gainsboro;
            this.prevBadgeImg32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevBadgeImg32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prevBadgeImg32.Location = new System.Drawing.Point(333, 336);
            this.prevBadgeImg32.Margin = new System.Windows.Forms.Padding(0);
            this.prevBadgeImg32.Name = "prevBadgeImg32";
            this.prevBadgeImg32.Size = new System.Drawing.Size(68, 68);
            this.prevBadgeImg32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.prevBadgeImg32.TabIndex = 100;
            this.prevBadgeImg32.TabStop = false;
            // 
            // exportBadgeImage
            // 
            this.exportBadgeImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportBadgeImage.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.exportBadgeImage, 2);
            this.exportBadgeImage.Enabled = false;
            this.exportBadgeImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exportBadgeImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.exportBadgeImage.Location = new System.Drawing.Point(175, 443);
            this.exportBadgeImage.Name = "exportBadgeImage";
            this.exportBadgeImage.Size = new System.Drawing.Size(124, 23);
            this.exportBadgeImage.TabIndex = 17;
            this.exportBadgeImage.Text = "Export";
            this.exportBadgeImage.UseVisualStyleBackColor = true;
            this.exportBadgeImage.Click += new System.EventHandler(this.ExportBadgeImage_Click);
            // 
            // titleHighNumer
            // 
            this.titleHighNumer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleHighNumer.Enabled = false;
            this.titleHighNumer.Hexadecimal = true;
            this.titleHighNumer.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.titleHighNumer.Location = new System.Drawing.Point(305, 533);
            this.titleHighNumer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.titleHighNumer.Name = "titleHighNumer";
            this.titleHighNumer.Size = new System.Drawing.Size(124, 20);
            this.titleHighNumer.TabIndex = 19;
            this.titleHighNumer.ValueChanged += new System.EventHandler(this.TitleHighNumer_ValueChanged);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label24.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label24, 2);
            this.label24.Location = new System.Drawing.Point(175, 536);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(118, 13);
            this.label24.TabIndex = 100;
            this.label24.Text = "Title Shortcut (High ID):";
            // 
            // titleIDnumer
            // 
            this.titleIDnumer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleIDnumer.Enabled = false;
            this.titleIDnumer.Hexadecimal = true;
            this.titleIDnumer.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.titleIDnumer.Location = new System.Drawing.Point(305, 558);
            this.titleIDnumer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.titleIDnumer.Name = "titleIDnumer";
            this.titleIDnumer.Size = new System.Drawing.Size(124, 20);
            this.titleIDnumer.TabIndex = 18;
            this.titleIDnumer.ValueChanged += new System.EventHandler(this.TitleIDnumer_ValueChanged);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label22.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label22, 2);
            this.label22.Location = new System.Drawing.Point(175, 561);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 13);
            this.label22.TabIndex = 100;
            this.label22.Text = "Title Shortcut (Low ID):";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.label19, 7);
            this.label19.Location = new System.Drawing.Point(175, 508);
            this.label19.Margin = new System.Windows.Forms.Padding(3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(524, 19);
            this.label19.TabIndex = 100;
            this.label19.Text = "Advanced options";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prevSetImg
            // 
            this.prevSetImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevSetImg.BackColor = System.Drawing.Color.Gainsboro;
            this.prevSetImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevSetImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.prevSetImg, 3);
            this.prevSetImg.Location = new System.Drawing.Point(538, 336);
            this.prevSetImg.Margin = new System.Windows.Forms.Padding(0);
            this.prevSetImg.Name = "prevSetImg";
            this.prevSetImg.Size = new System.Drawing.Size(68, 68);
            this.prevSetImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.prevSetImg.TabIndex = 100;
            this.prevSetImg.TabStop = false;
            // 
            // exportSetImage
            // 
            this.exportSetImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportSetImage.BackColor = System.Drawing.Color.White;
            this.exportSetImage.Enabled = false;
            this.exportSetImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exportSetImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.exportSetImage.Location = new System.Drawing.Point(575, 413);
            this.exportSetImage.Name = "exportSetImage";
            this.exportSetImage.Size = new System.Drawing.Size(124, 23);
            this.exportSetImage.TabIndex = 27;
            this.exportSetImage.Text = "Export";
            this.exportSetImage.UseVisualStyleBackColor = true;
            this.exportSetImage.Click += new System.EventHandler(this.ExportSetImage_Click);
            // 
            // importSetImage
            // 
            this.importSetImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importSetImage.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.importSetImage, 2);
            this.importSetImage.Enabled = false;
            this.importSetImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.importSetImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.importSetImage.Location = new System.Drawing.Point(445, 413);
            this.importSetImage.Name = "importSetImage";
            this.importSetImage.Size = new System.Drawing.Size(124, 23);
            this.importSetImage.TabIndex = 26;
            this.importSetImage.Text = "Import";
            this.importSetImage.UseVisualStyleBackColor = true;
            this.importSetImage.Click += new System.EventHandler(this.ImportSetImage_Click);
            // 
            // pixelBadgeMode
            // 
            this.pixelBadgeMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pixelBadgeMode.AutoSize = true;
            this.pixelBadgeMode.Location = new System.Drawing.Point(328, 474);
            this.pixelBadgeMode.Name = "pixelBadgeMode";
            this.pixelBadgeMode.Size = new System.Drawing.Size(78, 17);
            this.pixelBadgeMode.TabIndex = 15;
            this.pixelBadgeMode.Text = "Pixel Mode";
            this.pixelBadgeMode.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(175, 276);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 100;
            this.label21.Text = "Title Shortcut:";
            // 
            // titleIDdropdown
            // 
            this.titleIDdropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.titleIDdropdown, 6);
            this.titleIDdropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleIDdropdown.Enabled = false;
            this.titleIDdropdown.FormattingEnabled = true;
            this.titleIDdropdown.Items.AddRange(new object[] {
            "None / Unknown",
            "System Settings",
            "Download Play",
            "Activity Log",
            "Health and Safety Information",
            "Health and Safety Information [NEW 3DS]",
            "Nintendo 3DS Camera",
            "Nintendo 3DS Sound",
            "Mii Maker",
            "StreetPass Mii Plaza",
            "eShop",
            "System Transfer",
            "Nintendo Zone",
            "Face Raiders",
            "Face Raiders [NEW 3DS]",
            "AR Games"});
            this.titleIDdropdown.Location = new System.Drawing.Point(265, 272);
            this.titleIDdropdown.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.titleIDdropdown.Name = "titleIDdropdown";
            this.titleIDdropdown.Size = new System.Drawing.Size(434, 21);
            this.titleIDdropdown.TabIndex = 14;
            this.titleIDdropdown.SelectedIndexChanged += new System.EventHandler(this.TitleIDdropdown_SelectedIndexChanged);
            // 
            // regionDropdown
            // 
            this.regionDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.regionDropdown, 2);
            this.regionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionDropdown.Enabled = false;
            this.regionDropdown.FormattingEnabled = true;
            this.regionDropdown.Items.AddRange(new object[] {
            "???",
            "JPN",
            "USA",
            "EUR",
            "CHN",
            "KOR",
            "TWN"});
            this.regionDropdown.Location = new System.Drawing.Point(265, 247);
            this.regionDropdown.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.regionDropdown.Name = "regionDropdown";
            this.regionDropdown.Size = new System.Drawing.Size(164, 21);
            this.regionDropdown.TabIndex = 13;
            this.regionDropdown.DropDown += new System.EventHandler(this.RegionDropdown_DropDown);
            this.regionDropdown.SelectedIndexChanged += new System.EventHandler(this.RegionDropdown_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(175, 251);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 100;
            this.label23.Text = "Region:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NNIDnumer
            // 
            this.NNIDnumer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.NNIDnumer, 2);
            this.NNIDnumer.Enabled = false;
            this.NNIDnumer.Hexadecimal = true;
            this.NNIDnumer.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NNIDnumer.Location = new System.Drawing.Point(51, 77);
            this.NNIDnumer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.NNIDnumer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.NNIDnumer.Name = "NNIDnumer";
            this.NNIDnumer.Size = new System.Drawing.Size(96, 20);
            this.NNIDnumer.TabIndex = 1;
            this.NNIDnumer.ValueChanged += new System.EventHandler(this.NNIDnumer_ValueChanged);
            // 
            // delBadge
            // 
            this.delBadge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delBadge.BackColor = System.Drawing.Color.White;
            this.delBadge.Enabled = false;
            this.delBadge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delBadge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.delBadge.Location = new System.Drawing.Point(305, 38);
            this.delBadge.Name = "delBadge";
            this.delBadge.Size = new System.Drawing.Size(124, 24);
            this.delBadge.TabIndex = 6;
            this.delBadge.Text = "Delete selected";
            this.delBadge.UseVisualStyleBackColor = true;
            this.delBadge.Click += new System.EventHandler(this.DelBadge_Click);
            // 
            // delSet
            // 
            this.delSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delSet.BackColor = System.Drawing.Color.White;
            this.delSet.Enabled = false;
            this.delSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.delSet.Location = new System.Drawing.Point(575, 38);
            this.delSet.Name = "delSet";
            this.delSet.Size = new System.Drawing.Size(124, 24);
            this.delSet.TabIndex = 21;
            this.delSet.Text = "Delete selected";
            this.delSet.UseVisualStyleBackColor = true;
            this.delSet.Click += new System.EventHandler(this.DelSet_Click);
            // 
            // delAll
            // 
            this.delAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delAll.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.delAll, 3);
            this.delAll.Enabled = false;
            this.delAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.delAll.Location = new System.Drawing.Point(3, 203);
            this.delAll.Name = "delAll";
            this.delAll.Size = new System.Drawing.Size(144, 24);
            this.delAll.TabIndex = 4;
            this.delAll.Text = "Delete everything";
            this.delAll.UseVisualStyleBackColor = true;
            this.delAll.Click += new System.EventHandler(this.DelAll_Click);
            // 
            // fixBadgeSetIds
            // 
            this.fixBadgeSetIds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fixBadgeSetIds.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.fixBadgeSetIds, 3);
            this.fixBadgeSetIds.Enabled = false;
            this.fixBadgeSetIds.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fixBadgeSetIds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.fixBadgeSetIds.Location = new System.Drawing.Point(3, 123);
            this.fixBadgeSetIds.Name = "fixBadgeSetIds";
            this.fixBadgeSetIds.Size = new System.Drawing.Size(144, 24);
            this.fixBadgeSetIds.TabIndex = 2;
            this.fixBadgeSetIds.Text = "Fix Badge Set IDs";
            this.fixBadgeSetIds.UseVisualStyleBackColor = true;
            this.fixBadgeSetIds.Click += new System.EventHandler(this.FixBadgeSetIds_Click);
            // 
            // loading
            // 
            this.loading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.loading, 9);
            this.loading.Location = new System.Drawing.Point(15, 593);
            this.loading.Maximum = 1000;
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(684, 24);
            this.loading.Step = 1;
            this.loading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loading.TabIndex = 100;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NNIDnumer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.uniqueBadgesLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalBadgesLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.setsLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.badge255each, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.fixBadgeSetIds, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.delAll, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel1, 13);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 230);
            this.tableLayoutPanel1.TabIndex = 100;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.loading, 1, 23);
            this.tableLayoutPanel2.Controls.Add(this.label11, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.selectSetNumer, 8, 4);
            this.tableLayoutPanel2.Controls.Add(this.badgeQuantityNumer, 4, 9);
            this.tableLayoutPanel2.Controls.Add(this.badgeSetIdNumer, 4, 8);
            this.tableLayoutPanel2.Controls.Add(this.setNameInput, 8, 5);
            this.tableLayoutPanel2.Controls.Add(this.badgeSidNumer, 4, 7);
            this.tableLayoutPanel2.Controls.Add(this.delSet, 9, 2);
            this.tableLayoutPanel2.Controls.Add(this.createSetButton, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.badgeIdNumer, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.badgeNameInput, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.label15, 7, 9);
            this.tableLayoutPanel2.Controls.Add(this.label10, 7, 8);
            this.tableLayoutPanel2.Controls.Add(this.selectedBadgeNumer, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.label14, 7, 7);
            this.tableLayoutPanel2.Controls.Add(this.label9, 3, 9);
            this.tableLayoutPanel2.Controls.Add(this.label13, 7, 6);
            this.tableLayoutPanel2.Controls.Add(this.prevSetImg, 7, 14);
            this.tableLayoutPanel2.Controls.Add(this.label12, 7, 5);
            this.tableLayoutPanel2.Controls.Add(this.createBadgeButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.prevBadgeImg32, 5, 14);
            this.tableLayoutPanel2.Controls.Add(this.prevBadgeLabel, 3, 13);
            this.tableLayoutPanel2.Controls.Add(this.delBadge, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.label18, 3, 8);
            this.tableLayoutPanel2.Controls.Add(this.label8, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.prevBadgeImg64, 3, 14);
            this.tableLayoutPanel2.Controls.Add(this.label7, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.label6, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.label16, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.setIdNumer, 8, 6);
            this.tableLayoutPanel2.Controls.Add(this.setStartingNumer, 8, 7);
            this.tableLayoutPanel2.Controls.Add(this.setUniqueBadgesLabel, 8, 8);
            this.tableLayoutPanel2.Controls.Add(this.setTotalBadgesLabel, 8, 9);
            this.tableLayoutPanel2.Controls.Add(this.label17, 7, 4);
            this.tableLayoutPanel2.Controls.Add(this.label19, 3, 19);
            this.tableLayoutPanel2.Controls.Add(this.label23, 3, 10);
            this.tableLayoutPanel2.Controls.Add(this.titleIDdropdown, 4, 11);
            this.tableLayoutPanel2.Controls.Add(this.regionDropdown, 4, 10);
            this.tableLayoutPanel2.Controls.Add(this.label21, 3, 11);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.importBadgeImage, 3, 15);
            this.tableLayoutPanel2.Controls.Add(this.importSetImage, 7, 15);
            this.tableLayoutPanel2.Controls.Add(this.exportSetImage, 9, 15);
            this.tableLayoutPanel2.Controls.Add(this.label22, 3, 21);
            this.tableLayoutPanel2.Controls.Add(this.titleIDnumer, 5, 21);
            this.tableLayoutPanel2.Controls.Add(this.titleHighNumer, 5, 20);
            this.tableLayoutPanel2.Controls.Add(this.label24, 3, 20);
            this.tableLayoutPanel2.Controls.Add(this.label20, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.exportBadgeImage, 3, 16);
            this.tableLayoutPanel2.Controls.Add(this.pixelBadgeMode, 5, 17);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 3, 17);
            this.tableLayoutPanel2.Controls.Add(this.button1, 5, 15);
            this.tableLayoutPanel2.Controls.Add(this.button2, 5, 16);
            this.tableLayoutPanel2.Controls.Add(this.importBadgeButton, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.importSetButton, 7, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 25;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(714, 632);
            this.tableLayoutPanel2.TabIndex = 100;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(175, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 100;
            this.label16.Text = "Selected:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(445, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 100;
            this.label17.Text = "Selected:";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(15, 13);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 19);
            this.label20.TabIndex = 101;
            this.label20.Text = "General";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel2.SetColumnSpan(this.checkBox1, 2);
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(198, 474);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 102;
            this.checkBox1.Text = "Auto Scale";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(305, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 24);
            this.button1.TabIndex = 103;
            this.button1.Text = "Import (Small)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(305, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 24);
            this.button2.TabIndex = 103;
            this.button2.Text = "Export (Small)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // importBadgeButton
            // 
            this.importBadgeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importBadgeButton.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.importBadgeButton, 3);
            this.importBadgeButton.Enabled = false;
            this.importBadgeButton.Location = new System.Drawing.Point(175, 68);
            this.importBadgeButton.Name = "importBadgeButton";
            this.importBadgeButton.Size = new System.Drawing.Size(254, 24);
            this.importBadgeButton.TabIndex = 103;
            this.importBadgeButton.Text = "Import (*.prb)";
            this.importBadgeButton.UseVisualStyleBackColor = true;
            this.importBadgeButton.Click += new System.EventHandler(this.BadgeFilePrbToolStripMenuItem_Click);
            // 
            // importSetButton
            // 
            this.importSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importSetButton.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.importSetButton, 3);
            this.importSetButton.Enabled = false;
            this.importSetButton.Location = new System.Drawing.Point(445, 68);
            this.importSetButton.Name = "importSetButton";
            this.importSetButton.Size = new System.Drawing.Size(254, 24);
            this.importSetButton.TabIndex = 103;
            this.importSetButton.Text = "Import (*.cab)";
            this.importSetButton.UseVisualStyleBackColor = true;
            this.importSetButton.Click += new System.EventHandler(this.SetFileCabToolStripMenuItem_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 656);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(730, 695);
            this.Name = "EditorForm";
            this.Text = "Advanced Badge Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badgeIdNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgeSidNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgeQuantityNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedBadgeNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSetNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setIdNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setStartingNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgeSetIdNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBadgeImg64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBadgeImg32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleHighNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleIDnumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevSetImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NNIDnumer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button badge255each;
        private System.Windows.Forms.Button createBadgeButton;
        private System.Windows.Forms.Button createSetButton;
        private System.Windows.Forms.Button delAll;
        private System.Windows.Forms.Button delBadge;
        private System.Windows.Forms.Button delSet;
        private System.Windows.Forms.Button exportBadgeImage;
        private System.Windows.Forms.Button exportSetImage;
        private System.Windows.Forms.Button fixBadgeSetIds;
        private System.Windows.Forms.Button importBadgeImage;
        private System.Windows.Forms.Button importSetImage;
        private System.Windows.Forms.CheckBox pixelBadgeMode;
        private System.Windows.Forms.ComboBox regionDropdown;
        private System.Windows.Forms.ComboBox titleIDdropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label prevBadgeLabel;
        private System.Windows.Forms.Label setsLabel;
        private System.Windows.Forms.Label setTotalBadgesLabel;
        private System.Windows.Forms.Label setUniqueBadgesLabel;
        private System.Windows.Forms.Label totalBadgesLabel;
        private System.Windows.Forms.Label uniqueBadgesLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NumericUpDown badgeIdNumer;
        private System.Windows.Forms.NumericUpDown badgeQuantityNumer;
        private System.Windows.Forms.NumericUpDown badgeSetIdNumer;
        private System.Windows.Forms.NumericUpDown badgeSidNumer;
        private System.Windows.Forms.NumericUpDown NNIDnumer;
        private System.Windows.Forms.NumericUpDown selectedBadgeNumer;
        private System.Windows.Forms.NumericUpDown selectSetNumer;
        private System.Windows.Forms.NumericUpDown setIdNumer;
        private System.Windows.Forms.NumericUpDown setStartingNumer;
        private System.Windows.Forms.NumericUpDown titleHighNumer;
        private System.Windows.Forms.NumericUpDown titleIDnumer;
        private System.Windows.Forms.PictureBox prevBadgeImg32;
        private System.Windows.Forms.PictureBox prevBadgeImg64;
        private System.Windows.Forms.PictureBox prevSetImg;
        private System.Windows.Forms.ProgressBar loading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox badgeNameInput;
        private System.Windows.Forms.TextBox setNameInput;
        private System.Windows.Forms.ToolStripMenuItem badgeFileprbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importEntireSetData;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setFilecabToolStripMenuItem;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button importBadgeButton;
        private Button importSetButton;
    }
}

