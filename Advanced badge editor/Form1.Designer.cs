﻿namespace Advanced_badge_editor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.uniqueBadgesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalBadgesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NNIDLabel = new System.Windows.Forms.Label();
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
            this.importBadgeImg = new System.Windows.Forms.Button();
            this.exportBadgeImg = new System.Windows.Forms.Button();
            this.exportBadgeShp = new System.Windows.Forms.Button();
            this.importBadgeShp = new System.Windows.Forms.Button();
            this.fillBadgeShp = new System.Windows.Forms.Button();
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
            this.exportSetImgButton = new System.Windows.Forms.Button();
            this.importSetImgButton = new System.Windows.Forms.Button();
            this.exportBadgeImg32 = new System.Windows.Forms.Button();
            this.importBadgeImg32 = new System.Windows.Forms.Button();
            this.importBadgeShp32 = new System.Windows.Forms.Button();
            this.exportBadgeShp32 = new System.Windows.Forms.Button();
            this.fillBadgeShp32 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.badgeSetIdNumer = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badgeIdNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgeSidNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgeQuantityNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedBadgeNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSetNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setIdNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setStartingNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgeSetIdNumer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDataToolStripMenuItem,
            this.saveDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openDataToolStripMenuItem
            // 
            this.openDataToolStripMenuItem.Name = "openDataToolStripMenuItem";
            this.openDataToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.openDataToolStripMenuItem.Text = "Open data";
            this.openDataToolStripMenuItem.Click += new System.EventHandler(this.openDataToolStripMenuItem_Click);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Enabled = false;
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.saveDataToolStripMenuItem.Text = "Save data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.saveDataToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unique badges:";
            // 
            // uniqueBadgesLabel
            // 
            this.uniqueBadgesLabel.AutoSize = true;
            this.uniqueBadgesLabel.Location = new System.Drawing.Point(94, 40);
            this.uniqueBadgesLabel.Name = "uniqueBadgesLabel";
            this.uniqueBadgesLabel.Size = new System.Drawing.Size(13, 13);
            this.uniqueBadgesLabel.TabIndex = 2;
            this.uniqueBadgesLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total badges:";
            // 
            // totalBadgesLabel
            // 
            this.totalBadgesLabel.AutoSize = true;
            this.totalBadgesLabel.Location = new System.Drawing.Point(94, 61);
            this.totalBadgesLabel.Name = "totalBadgesLabel";
            this.totalBadgesLabel.Size = new System.Drawing.Size(13, 13);
            this.totalBadgesLabel.TabIndex = 4;
            this.totalBadgesLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sets:";
            // 
            // setsLabel
            // 
            this.setsLabel.AutoSize = true;
            this.setsLabel.Location = new System.Drawing.Point(94, 82);
            this.setsLabel.Name = "setsLabel";
            this.setsLabel.Size = new System.Drawing.Size(13, 13);
            this.setsLabel.TabIndex = 6;
            this.setsLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "NNID:";
            // 
            // NNIDLabel
            // 
            this.NNIDLabel.AutoSize = true;
            this.NNIDLabel.Location = new System.Drawing.Point(94, 103);
            this.NNIDLabel.Name = "NNIDLabel";
            this.NNIDLabel.Size = new System.Drawing.Size(13, 13);
            this.NNIDLabel.TabIndex = 8;
            this.NNIDLabel.Text = "0";
            // 
            // createBadgeButton
            // 
            this.createBadgeButton.Enabled = false;
            this.createBadgeButton.Location = new System.Drawing.Point(15, 126);
            this.createBadgeButton.Name = "createBadgeButton";
            this.createBadgeButton.Size = new System.Drawing.Size(108, 23);
            this.createBadgeButton.TabIndex = 9;
            this.createBadgeButton.Text = "Create new badge";
            this.createBadgeButton.UseVisualStyleBackColor = true;
            this.createBadgeButton.Click += new System.EventHandler(this.createBadgeButton_Click);
            // 
            // createSetButton
            // 
            this.createSetButton.Enabled = false;
            this.createSetButton.Location = new System.Drawing.Point(15, 155);
            this.createSetButton.Name = "createSetButton";
            this.createSetButton.Size = new System.Drawing.Size(108, 23);
            this.createSetButton.TabIndex = 10;
            this.createSetButton.Text = "Create new set";
            this.createSetButton.UseVisualStyleBackColor = true;
            this.createSetButton.Click += new System.EventHandler(this.createSetButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select a badge:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Badge name:";
            // 
            // badgeNameInput
            // 
            this.badgeNameInput.Enabled = false;
            this.badgeNameInput.Location = new System.Drawing.Point(259, 87);
            this.badgeNameInput.MaxLength = 69;
            this.badgeNameInput.Name = "badgeNameInput";
            this.badgeNameInput.Size = new System.Drawing.Size(169, 20);
            this.badgeNameInput.TabIndex = 14;
            this.badgeNameInput.Text = "None";
            this.badgeNameInput.TextChanged += new System.EventHandler(this.badgeNameInput_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Badge ID:";
            // 
            // badgeIdNumer
            // 
            this.badgeIdNumer.Enabled = false;
            this.badgeIdNumer.Hexadecimal = true;
            this.badgeIdNumer.Increment = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.badgeIdNumer.Location = new System.Drawing.Point(259, 110);
            this.badgeIdNumer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.badgeIdNumer.Name = "badgeIdNumer";
            this.badgeIdNumer.Size = new System.Drawing.Size(169, 20);
            this.badgeIdNumer.TabIndex = 16;
            this.badgeIdNumer.ValueChanged += new System.EventHandler(this.badgeIdNumer_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Badge Sub ID:";
            // 
            // badgeSidNumer
            // 
            this.badgeSidNumer.Enabled = false;
            this.badgeSidNumer.Hexadecimal = true;
            this.badgeSidNumer.Increment = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.badgeSidNumer.Location = new System.Drawing.Point(259, 133);
            this.badgeSidNumer.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.badgeSidNumer.Name = "badgeSidNumer";
            this.badgeSidNumer.Size = new System.Drawing.Size(169, 20);
            this.badgeSidNumer.TabIndex = 18;
            this.badgeSidNumer.ValueChanged += new System.EventHandler(this.badgeSidNumer_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Quantity:";
            // 
            // badgeQuantityNumer
            // 
            this.badgeQuantityNumer.Enabled = false;
            this.badgeQuantityNumer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.badgeQuantityNumer.Location = new System.Drawing.Point(259, 179);
            this.badgeQuantityNumer.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.badgeQuantityNumer.Name = "badgeQuantityNumer";
            this.badgeQuantityNumer.Size = new System.Drawing.Size(169, 20);
            this.badgeQuantityNumer.TabIndex = 20;
            this.badgeQuantityNumer.ValueChanged += new System.EventHandler(this.badgeQuantityNumer_ValueChanged);
            // 
            // importBadgeImg
            // 
            this.importBadgeImg.Enabled = false;
            this.importBadgeImg.Location = new System.Drawing.Point(307, 227);
            this.importBadgeImg.Name = "importBadgeImg";
            this.importBadgeImg.Size = new System.Drawing.Size(121, 23);
            this.importBadgeImg.TabIndex = 21;
            this.importBadgeImg.Text = "Import badge image";
            this.importBadgeImg.UseVisualStyleBackColor = true;
            this.importBadgeImg.Click += new System.EventHandler(this.importBadgeImg_Click);
            // 
            // exportBadgeImg
            // 
            this.exportBadgeImg.Enabled = false;
            this.exportBadgeImg.Location = new System.Drawing.Point(179, 227);
            this.exportBadgeImg.Name = "exportBadgeImg";
            this.exportBadgeImg.Size = new System.Drawing.Size(121, 23);
            this.exportBadgeImg.TabIndex = 22;
            this.exportBadgeImg.Text = "Export badge image";
            this.exportBadgeImg.UseVisualStyleBackColor = true;
            this.exportBadgeImg.Click += new System.EventHandler(this.exportBadgeImg_Click);
            // 
            // exportBadgeShp
            // 
            this.exportBadgeShp.Enabled = false;
            this.exportBadgeShp.Location = new System.Drawing.Point(179, 253);
            this.exportBadgeShp.Name = "exportBadgeShp";
            this.exportBadgeShp.Size = new System.Drawing.Size(121, 23);
            this.exportBadgeShp.TabIndex = 23;
            this.exportBadgeShp.Text = "Export badge shape";
            this.exportBadgeShp.UseVisualStyleBackColor = true;
            this.exportBadgeShp.Click += new System.EventHandler(this.exportBadgeShp_Click);
            // 
            // importBadgeShp
            // 
            this.importBadgeShp.Enabled = false;
            this.importBadgeShp.Location = new System.Drawing.Point(307, 253);
            this.importBadgeShp.Name = "importBadgeShp";
            this.importBadgeShp.Size = new System.Drawing.Size(121, 23);
            this.importBadgeShp.TabIndex = 24;
            this.importBadgeShp.Text = "Import badge shape";
            this.importBadgeShp.UseVisualStyleBackColor = true;
            this.importBadgeShp.Click += new System.EventHandler(this.importBadgeShp_Click);
            // 
            // fillBadgeShp
            // 
            this.fillBadgeShp.Enabled = false;
            this.fillBadgeShp.Location = new System.Drawing.Point(179, 279);
            this.fillBadgeShp.Name = "fillBadgeShp";
            this.fillBadgeShp.Size = new System.Drawing.Size(249, 23);
            this.fillBadgeShp.TabIndex = 25;
            this.fillBadgeShp.Text = "Fill badge shape to image size";
            this.fillBadgeShp.UseVisualStyleBackColor = true;
            this.fillBadgeShp.Click += new System.EventHandler(this.fillBadgeShp_Click);
            // 
            // selectedBadgeNumer
            // 
            this.selectedBadgeNumer.Enabled = false;
            this.selectedBadgeNumer.Location = new System.Drawing.Point(179, 59);
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
            this.selectedBadgeNumer.Size = new System.Drawing.Size(249, 20);
            this.selectedBadgeNumer.TabIndex = 27;
            this.selectedBadgeNumer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectedBadgeNumer.ValueChanged += new System.EventHandler(this.selectedBadgeNumer_ValueChanged);
            // 
            // badge255each
            // 
            this.badge255each.Enabled = false;
            this.badge255each.Location = new System.Drawing.Point(15, 184);
            this.badge255each.Name = "badge255each";
            this.badge255each.Size = new System.Drawing.Size(108, 23);
            this.badge255each.TabIndex = 28;
            this.badge255each.Text = "255 of each badge";
            this.badge255each.UseVisualStyleBackColor = true;
            this.badge255each.Click += new System.EventHandler(this.badge255each_Click);
            // 
            // selectSetNumer
            // 
            this.selectSetNumer.Enabled = false;
            this.selectSetNumer.Location = new System.Drawing.Point(443, 59);
            this.selectSetNumer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectSetNumer.Name = "selectSetNumer";
            this.selectSetNumer.Size = new System.Drawing.Size(249, 20);
            this.selectSetNumer.TabIndex = 30;
            this.selectSetNumer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectSetNumer.ValueChanged += new System.EventHandler(this.selectSetNumer_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(534, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Select a set:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Set name:";
            // 
            // setNameInput
            // 
            this.setNameInput.Enabled = false;
            this.setNameInput.Location = new System.Drawing.Point(523, 87);
            this.setNameInput.Name = "setNameInput";
            this.setNameInput.Size = new System.Drawing.Size(169, 20);
            this.setNameInput.TabIndex = 33;
            this.setNameInput.Text = "None";
            this.setNameInput.TextChanged += new System.EventHandler(this.setNameInput_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(440, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Set ID:";
            // 
            // setIdNumer
            // 
            this.setIdNumer.Enabled = false;
            this.setIdNumer.Hexadecimal = true;
            this.setIdNumer.Increment = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.setIdNumer.Location = new System.Drawing.Point(523, 110);
            this.setIdNumer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.setIdNumer.Name = "setIdNumer";
            this.setIdNumer.Size = new System.Drawing.Size(169, 20);
            this.setIdNumer.TabIndex = 35;
            this.setIdNumer.ValueChanged += new System.EventHandler(this.setIdNumer_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(440, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Starting badge:";
            // 
            // setStartingNumer
            // 
            this.setStartingNumer.Enabled = false;
            this.setStartingNumer.Location = new System.Drawing.Point(523, 133);
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
            this.setStartingNumer.Size = new System.Drawing.Size(169, 20);
            this.setStartingNumer.TabIndex = 37;
            this.setStartingNumer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setStartingNumer.ValueChanged += new System.EventHandler(this.setStartingNumer_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Unique badges:";
            // 
            // setUniqueBadgesLabel
            // 
            this.setUniqueBadgesLabel.AutoSize = true;
            this.setUniqueBadgesLabel.Location = new System.Drawing.Point(523, 161);
            this.setUniqueBadgesLabel.Name = "setUniqueBadgesLabel";
            this.setUniqueBadgesLabel.Size = new System.Drawing.Size(13, 13);
            this.setUniqueBadgesLabel.TabIndex = 39;
            this.setUniqueBadgesLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(440, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Total badges:";
            // 
            // setTotalBadgesLabel
            // 
            this.setTotalBadgesLabel.AutoSize = true;
            this.setTotalBadgesLabel.Location = new System.Drawing.Point(523, 184);
            this.setTotalBadgesLabel.Name = "setTotalBadgesLabel";
            this.setTotalBadgesLabel.Size = new System.Drawing.Size(13, 13);
            this.setTotalBadgesLabel.TabIndex = 41;
            this.setTotalBadgesLabel.Text = "0";
            // 
            // exportSetImgButton
            // 
            this.exportSetImgButton.Enabled = false;
            this.exportSetImgButton.Location = new System.Drawing.Point(443, 204);
            this.exportSetImgButton.Name = "exportSetImgButton";
            this.exportSetImgButton.Size = new System.Drawing.Size(121, 23);
            this.exportSetImgButton.TabIndex = 42;
            this.exportSetImgButton.Text = "Export set image";
            this.exportSetImgButton.UseVisualStyleBackColor = true;
            this.exportSetImgButton.Click += new System.EventHandler(this.exportSetImgButton_Click);
            // 
            // importSetImgButton
            // 
            this.importSetImgButton.Enabled = false;
            this.importSetImgButton.Location = new System.Drawing.Point(571, 204);
            this.importSetImgButton.Name = "importSetImgButton";
            this.importSetImgButton.Size = new System.Drawing.Size(121, 23);
            this.importSetImgButton.TabIndex = 43;
            this.importSetImgButton.Text = "Import set image";
            this.importSetImgButton.UseVisualStyleBackColor = true;
            this.importSetImgButton.Click += new System.EventHandler(this.importSetImgButton_Click);
            // 
            // exportBadgeImg32
            // 
            this.exportBadgeImg32.Enabled = false;
            this.exportBadgeImg32.Location = new System.Drawing.Point(179, 330);
            this.exportBadgeImg32.Name = "exportBadgeImg32";
            this.exportBadgeImg32.Size = new System.Drawing.Size(121, 23);
            this.exportBadgeImg32.TabIndex = 22;
            this.exportBadgeImg32.Text = "Export badge image";
            this.exportBadgeImg32.UseVisualStyleBackColor = true;
            this.exportBadgeImg32.Click += new System.EventHandler(this.exportBadgeImg32_Click);
            // 
            // importBadgeImg32
            // 
            this.importBadgeImg32.Enabled = false;
            this.importBadgeImg32.Location = new System.Drawing.Point(307, 330);
            this.importBadgeImg32.Name = "importBadgeImg32";
            this.importBadgeImg32.Size = new System.Drawing.Size(121, 23);
            this.importBadgeImg32.TabIndex = 21;
            this.importBadgeImg32.Text = "Import badge image";
            this.importBadgeImg32.UseVisualStyleBackColor = true;
            this.importBadgeImg32.Click += new System.EventHandler(this.importBadgeImg32_Click);
            // 
            // importBadgeShp32
            // 
            this.importBadgeShp32.Enabled = false;
            this.importBadgeShp32.Location = new System.Drawing.Point(307, 356);
            this.importBadgeShp32.Name = "importBadgeShp32";
            this.importBadgeShp32.Size = new System.Drawing.Size(121, 23);
            this.importBadgeShp32.TabIndex = 24;
            this.importBadgeShp32.Text = "Import badge shape";
            this.importBadgeShp32.UseVisualStyleBackColor = true;
            this.importBadgeShp32.Click += new System.EventHandler(this.importBadgeShp32_Click);
            // 
            // exportBadgeShp32
            // 
            this.exportBadgeShp32.Enabled = false;
            this.exportBadgeShp32.Location = new System.Drawing.Point(179, 356);
            this.exportBadgeShp32.Name = "exportBadgeShp32";
            this.exportBadgeShp32.Size = new System.Drawing.Size(121, 23);
            this.exportBadgeShp32.TabIndex = 23;
            this.exportBadgeShp32.Text = "Export badge shape";
            this.exportBadgeShp32.UseVisualStyleBackColor = true;
            this.exportBadgeShp32.Click += new System.EventHandler(this.exportBadgeShp32_Click);
            // 
            // fillBadgeShp32
            // 
            this.fillBadgeShp32.Enabled = false;
            this.fillBadgeShp32.Location = new System.Drawing.Point(179, 382);
            this.fillBadgeShp32.Name = "fillBadgeShp32";
            this.fillBadgeShp32.Size = new System.Drawing.Size(249, 23);
            this.fillBadgeShp32.TabIndex = 25;
            this.fillBadgeShp32.Text = "Fill badge shape to image size";
            this.fillBadgeShp32.UseVisualStyleBackColor = true;
            this.fillBadgeShp32.Click += new System.EventHandler(this.fillBadgeShp32_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(254, 206);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "64px x 64px Image:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(254, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "32px x 32px Image:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(176, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Badge Set ID:";
            // 
            // badgeSetIdNumer
            // 
            this.badgeSetIdNumer.Enabled = false;
            this.badgeSetIdNumer.Hexadecimal = true;
            this.badgeSetIdNumer.Increment = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.badgeSetIdNumer.Location = new System.Drawing.Point(259, 156);
            this.badgeSetIdNumer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.badgeSetIdNumer.Name = "badgeSetIdNumer";
            this.badgeSetIdNumer.Size = new System.Drawing.Size(169, 20);
            this.badgeSetIdNumer.TabIndex = 46;
            this.badgeSetIdNumer.ValueChanged += new System.EventHandler(this.badgeSetIdNumer_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 435);
            this.Controls.Add(this.badgeSetIdNumer);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.importSetImgButton);
            this.Controls.Add(this.exportSetImgButton);
            this.Controls.Add(this.setTotalBadgesLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.setUniqueBadgesLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.setStartingNumer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.setIdNumer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.setNameInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.selectSetNumer);
            this.Controls.Add(this.badge255each);
            this.Controls.Add(this.selectedBadgeNumer);
            this.Controls.Add(this.fillBadgeShp32);
            this.Controls.Add(this.fillBadgeShp);
            this.Controls.Add(this.importBadgeShp32);
            this.Controls.Add(this.importBadgeShp);
            this.Controls.Add(this.exportBadgeShp32);
            this.Controls.Add(this.exportBadgeShp);
            this.Controls.Add(this.exportBadgeImg32);
            this.Controls.Add(this.exportBadgeImg);
            this.Controls.Add(this.importBadgeImg32);
            this.Controls.Add(this.importBadgeImg);
            this.Controls.Add(this.badgeQuantityNumer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.badgeSidNumer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.badgeIdNumer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.badgeNameInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createSetButton);
            this.Controls.Add(this.createBadgeButton);
            this.Controls.Add(this.NNIDLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalBadgesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uniqueBadgesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Advanced badge editor";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uniqueBadgesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalBadgesLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label setsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NNIDLabel;
        private System.Windows.Forms.Button createBadgeButton;
        private System.Windows.Forms.Button createSetButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox badgeNameInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown badgeIdNumer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown badgeSidNumer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown badgeQuantityNumer;
        private System.Windows.Forms.Button importBadgeImg;
        private System.Windows.Forms.Button exportBadgeImg;
        private System.Windows.Forms.Button exportBadgeShp;
        private System.Windows.Forms.Button importBadgeShp;
        private System.Windows.Forms.Button fillBadgeShp;
        private System.Windows.Forms.NumericUpDown selectedBadgeNumer;
        private System.Windows.Forms.Button badge255each;
        private System.Windows.Forms.NumericUpDown selectSetNumer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox setNameInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown setIdNumer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown setStartingNumer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label setUniqueBadgesLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label setTotalBadgesLabel;
        private System.Windows.Forms.Button exportSetImgButton;
        private System.Windows.Forms.Button importSetImgButton;
        private System.Windows.Forms.Button exportBadgeImg32;
        private System.Windows.Forms.Button importBadgeImg32;
        private System.Windows.Forms.Button importBadgeShp32;
        private System.Windows.Forms.Button exportBadgeShp32;
        private System.Windows.Forms.Button fillBadgeShp32;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown badgeSetIdNumer;
    }
}

