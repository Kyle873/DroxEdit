﻿namespace DroxEdit
{
    partial class FormMain
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
            this.listViewItems = new System.Windows.Forms.ListView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelRank = new System.Windows.Forms.Label();
            this.numericUpDownRank = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIdentified = new System.Windows.Forms.CheckBox();
            this.labelArmor = new System.Windows.Forms.Label();
            this.numericUpDownArmor = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDefense = new System.Windows.Forms.NumericUpDown();
            this.labelDefense = new System.Windows.Forms.Label();
            this.numericUpDownPowerLoad = new System.Windows.Forms.NumericUpDown();
            this.labelPowerLoad = new System.Windows.Forms.Label();
            this.numericUpDownDurability = new System.Windows.Forms.NumericUpDown();
            this.labelDurability = new System.Windows.Forms.Label();
            this.numericUpDownDurabilityMax = new System.Windows.Forms.NumericUpDown();
            this.labelDurabilityMax = new System.Windows.Forms.Label();
            this.numericUpDownMinLevel = new System.Windows.Forms.NumericUpDown();
            this.labelMinLevel = new System.Windows.Forms.Label();
            this.labelModifiers = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonModifierDatabase = new System.Windows.Forms.Button();
            this.buttonItemDatabase = new System.Windows.Forms.Button();
            this.buttonModifierAdd = new System.Windows.Forms.Button();
            this.buttonModifierRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArmor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPowerLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurabilityMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewItems
            // 
            this.listViewItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewItems.Location = new System.Drawing.Point(0, 0);
            this.listViewItems.MultiSelect = false;
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(127, 425);
            this.listViewItems.TabIndex = 0;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewItems_ItemSelectionChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelItemName
            // 
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.Location = new System.Drawing.Point(133, 9);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(325, 51);
            this.labelItemName.TabIndex = 1;
            this.labelItemName.Text = "Item Name";
            this.labelItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Location = new System.Drawing.Point(135, 83);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(33, 13);
            this.labelRank.TabIndex = 2;
            this.labelRank.Text = "Rank";
            // 
            // numericUpDownRank
            // 
            this.numericUpDownRank.Location = new System.Drawing.Point(226, 81);
            this.numericUpDownRank.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRank.Name = "numericUpDownRank";
            this.numericUpDownRank.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownRank.TabIndex = 3;
            this.numericUpDownRank.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxIdentified
            // 
            this.checkBoxIdentified.AutoSize = true;
            this.checkBoxIdentified.Location = new System.Drawing.Point(389, 110);
            this.checkBoxIdentified.Name = "checkBoxIdentified";
            this.checkBoxIdentified.Size = new System.Drawing.Size(69, 17);
            this.checkBoxIdentified.TabIndex = 4;
            this.checkBoxIdentified.Text = "Identified";
            this.checkBoxIdentified.UseVisualStyleBackColor = true;
            // 
            // labelArmor
            // 
            this.labelArmor.AutoSize = true;
            this.labelArmor.Location = new System.Drawing.Point(135, 109);
            this.labelArmor.Name = "labelArmor";
            this.labelArmor.Size = new System.Drawing.Size(34, 13);
            this.labelArmor.TabIndex = 5;
            this.labelArmor.Text = "Armor";
            // 
            // numericUpDownArmor
            // 
            this.numericUpDownArmor.Location = new System.Drawing.Point(226, 107);
            this.numericUpDownArmor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownArmor.Name = "numericUpDownArmor";
            this.numericUpDownArmor.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownArmor.TabIndex = 6;
            // 
            // numericUpDownDefense
            // 
            this.numericUpDownDefense.Location = new System.Drawing.Point(226, 133);
            this.numericUpDownDefense.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDefense.Name = "numericUpDownDefense";
            this.numericUpDownDefense.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownDefense.TabIndex = 8;
            // 
            // labelDefense
            // 
            this.labelDefense.AutoSize = true;
            this.labelDefense.Location = new System.Drawing.Point(135, 135);
            this.labelDefense.Name = "labelDefense";
            this.labelDefense.Size = new System.Drawing.Size(47, 13);
            this.labelDefense.TabIndex = 7;
            this.labelDefense.Text = "Defense";
            // 
            // numericUpDownPowerLoad
            // 
            this.numericUpDownPowerLoad.Location = new System.Drawing.Point(226, 159);
            this.numericUpDownPowerLoad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPowerLoad.Name = "numericUpDownPowerLoad";
            this.numericUpDownPowerLoad.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownPowerLoad.TabIndex = 10;
            // 
            // labelPowerLoad
            // 
            this.labelPowerLoad.AutoSize = true;
            this.labelPowerLoad.Location = new System.Drawing.Point(135, 161);
            this.labelPowerLoad.Name = "labelPowerLoad";
            this.labelPowerLoad.Size = new System.Drawing.Size(64, 13);
            this.labelPowerLoad.TabIndex = 9;
            this.labelPowerLoad.Text = "Power Load";
            // 
            // numericUpDownDurability
            // 
            this.numericUpDownDurability.Location = new System.Drawing.Point(226, 185);
            this.numericUpDownDurability.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDurability.Name = "numericUpDownDurability";
            this.numericUpDownDurability.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownDurability.TabIndex = 12;
            // 
            // labelDurability
            // 
            this.labelDurability.AutoSize = true;
            this.labelDurability.Location = new System.Drawing.Point(135, 187);
            this.labelDurability.Name = "labelDurability";
            this.labelDurability.Size = new System.Drawing.Size(50, 13);
            this.labelDurability.TabIndex = 11;
            this.labelDurability.Text = "Durability";
            // 
            // numericUpDownDurabilityMax
            // 
            this.numericUpDownDurabilityMax.Location = new System.Drawing.Point(226, 211);
            this.numericUpDownDurabilityMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDurabilityMax.Name = "numericUpDownDurabilityMax";
            this.numericUpDownDurabilityMax.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownDurabilityMax.TabIndex = 14;
            // 
            // labelDurabilityMax
            // 
            this.labelDurabilityMax.AutoSize = true;
            this.labelDurabilityMax.Location = new System.Drawing.Point(135, 213);
            this.labelDurabilityMax.Name = "labelDurabilityMax";
            this.labelDurabilityMax.Size = new System.Drawing.Size(73, 13);
            this.labelDurabilityMax.TabIndex = 13;
            this.labelDurabilityMax.Text = "Max Durability";
            // 
            // numericUpDownMinLevel
            // 
            this.numericUpDownMinLevel.Location = new System.Drawing.Point(226, 237);
            this.numericUpDownMinLevel.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMinLevel.Name = "numericUpDownMinLevel";
            this.numericUpDownMinLevel.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownMinLevel.TabIndex = 16;
            // 
            // labelMinLevel
            // 
            this.labelMinLevel.AutoSize = true;
            this.labelMinLevel.Location = new System.Drawing.Point(135, 239);
            this.labelMinLevel.Name = "labelMinLevel";
            this.labelMinLevel.Size = new System.Drawing.Size(77, 13);
            this.labelMinLevel.TabIndex = 15;
            this.labelMinLevel.Text = "Minimum Level";
            // 
            // labelModifiers
            // 
            this.labelModifiers.AutoSize = true;
            this.labelModifiers.Location = new System.Drawing.Point(135, 284);
            this.labelModifiers.Name = "labelModifiers";
            this.labelModifiers.Size = new System.Drawing.Size(49, 13);
            this.labelModifiers.TabIndex = 17;
            this.labelModifiers.Text = "Modifiers";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(138, 300);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(176, 125);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(386, 81);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(72, 26);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(383, 402);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonModifierDatabase
            // 
            this.buttonModifierDatabase.Enabled = false;
            this.buttonModifierDatabase.Location = new System.Drawing.Point(383, 358);
            this.buttonModifierDatabase.Name = "buttonModifierDatabase";
            this.buttonModifierDatabase.Size = new System.Drawing.Size(75, 38);
            this.buttonModifierDatabase.TabIndex = 21;
            this.buttonModifierDatabase.Text = "Modifier Database";
            this.buttonModifierDatabase.UseVisualStyleBackColor = true;
            // 
            // buttonItemDatabase
            // 
            this.buttonItemDatabase.Enabled = false;
            this.buttonItemDatabase.Location = new System.Drawing.Point(383, 314);
            this.buttonItemDatabase.Name = "buttonItemDatabase";
            this.buttonItemDatabase.Size = new System.Drawing.Size(75, 38);
            this.buttonItemDatabase.TabIndex = 22;
            this.buttonItemDatabase.Text = "Item Database";
            this.buttonItemDatabase.UseVisualStyleBackColor = true;
            // 
            // buttonModifierAdd
            // 
            this.buttonModifierAdd.Enabled = false;
            this.buttonModifierAdd.Location = new System.Drawing.Point(320, 300);
            this.buttonModifierAdd.Name = "buttonModifierAdd";
            this.buttonModifierAdd.Size = new System.Drawing.Size(28, 23);
            this.buttonModifierAdd.TabIndex = 23;
            this.buttonModifierAdd.Text = "+";
            this.buttonModifierAdd.UseVisualStyleBackColor = true;
            // 
            // buttonModifierRemove
            // 
            this.buttonModifierRemove.Enabled = false;
            this.buttonModifierRemove.Location = new System.Drawing.Point(320, 329);
            this.buttonModifierRemove.Name = "buttonModifierRemove";
            this.buttonModifierRemove.Size = new System.Drawing.Size(28, 23);
            this.buttonModifierRemove.TabIndex = 24;
            this.buttonModifierRemove.Text = "-";
            this.buttonModifierRemove.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 425);
            this.Controls.Add(this.buttonModifierRemove);
            this.Controls.Add(this.buttonModifierAdd);
            this.Controls.Add(this.buttonItemDatabase);
            this.Controls.Add(this.buttonModifierDatabase);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelModifiers);
            this.Controls.Add(this.numericUpDownMinLevel);
            this.Controls.Add(this.labelMinLevel);
            this.Controls.Add(this.numericUpDownDurabilityMax);
            this.Controls.Add(this.labelDurabilityMax);
            this.Controls.Add(this.numericUpDownDurability);
            this.Controls.Add(this.labelDurability);
            this.Controls.Add(this.numericUpDownPowerLoad);
            this.Controls.Add(this.labelPowerLoad);
            this.Controls.Add(this.numericUpDownDefense);
            this.Controls.Add(this.labelDefense);
            this.Controls.Add(this.numericUpDownArmor);
            this.Controls.Add(this.labelArmor);
            this.Controls.Add(this.checkBoxIdentified);
            this.Controls.Add(this.numericUpDownRank);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.listViewItems);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DroxEdit";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArmor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPowerLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurabilityMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.NumericUpDown numericUpDownRank;
        private System.Windows.Forms.CheckBox checkBoxIdentified;
        private System.Windows.Forms.Label labelArmor;
        private System.Windows.Forms.NumericUpDown numericUpDownArmor;
        private System.Windows.Forms.NumericUpDown numericUpDownDefense;
        private System.Windows.Forms.Label labelDefense;
        private System.Windows.Forms.NumericUpDown numericUpDownPowerLoad;
        private System.Windows.Forms.Label labelPowerLoad;
        private System.Windows.Forms.NumericUpDown numericUpDownDurability;
        private System.Windows.Forms.Label labelDurability;
        private System.Windows.Forms.NumericUpDown numericUpDownDurabilityMax;
        private System.Windows.Forms.Label labelDurabilityMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMinLevel;
        private System.Windows.Forms.Label labelMinLevel;
        private System.Windows.Forms.Label labelModifiers;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonModifierDatabase;
        private System.Windows.Forms.Button buttonItemDatabase;
        private System.Windows.Forms.Button buttonModifierAdd;
        private System.Windows.Forms.Button buttonModifierRemove;




    }
}

