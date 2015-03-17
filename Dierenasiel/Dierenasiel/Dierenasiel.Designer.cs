namespace Dierenasiel
{
    partial class Dierenasiel
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
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.gbCat = new System.Windows.Forms.GroupBox();
            this.lblBadhabit = new System.Windows.Forms.Label();
            this.txBadHabit = new System.Windows.Forms.TextBox();
            this.gbDog = new System.Windows.Forms.GroupBox();
            this.lblLastWalkDate = new System.Windows.Forms.Label();
            this.dtpLastWalkDate = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblChip = new System.Windows.Forms.Label();
            this.cbAnimalNames = new System.Windows.Forms.ComboBox();
            this.lblInfoChip = new System.Windows.Forms.Label();
            this.lblInfoDOB = new System.Windows.Forms.Label();
            this.lblInfoName = new System.Windows.Forms.Label();
            this.lblInfoExtra = new System.Windows.Forms.Label();
            this.lblpInfoChip = new System.Windows.Forms.Label();
            this.lblpInfoDOB = new System.Windows.Forms.Label();
            this.lblpInfoName = new System.Windows.Forms.Label();
            this.lblpInfoExtra = new System.Windows.Forms.Label();
            this.btnDeleteAnimal = new System.Windows.Forms.Button();
            this.chbReserved = new System.Windows.Forms.CheckBox();
            this.lbReserved = new System.Windows.Forms.ListBox();
            this.lbNotReserved = new System.Windows.Forms.ListBox();
            this.lblShowInfo = new System.Windows.Forms.Label();
            this.nupChip = new System.Windows.Forms.NumericUpDown();
            this.lblpInfoPrice = new System.Windows.Forms.Label();
            this.lblInfoPrice = new System.Windows.Forms.Label();
            this.gbCat.SuspendLayout();
            this.gbDog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupChip)).BeginInit();
            this.SuspendLayout();
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(155, 19);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 4;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Location = new System.Drawing.Point(28, 21);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalTypeComboBox.TabIndex = 3;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // gbCat
            // 
            this.gbCat.Controls.Add(this.lblBadhabit);
            this.gbCat.Controls.Add(this.txBadHabit);
            this.gbCat.Location = new System.Drawing.Point(12, 164);
            this.gbCat.Name = "gbCat";
            this.gbCat.Size = new System.Drawing.Size(367, 56);
            this.gbCat.TabIndex = 6;
            this.gbCat.TabStop = false;
            this.gbCat.Text = "Cat";
            // 
            // lblBadhabit
            // 
            this.lblBadhabit.AutoSize = true;
            this.lblBadhabit.Location = new System.Drawing.Point(16, 26);
            this.lblBadhabit.Name = "lblBadhabit";
            this.lblBadhabit.Size = new System.Drawing.Size(51, 13);
            this.lblBadhabit.TabIndex = 15;
            this.lblBadhabit.Text = "BadHabit";
            // 
            // txBadHabit
            // 
            this.txBadHabit.Enabled = false;
            this.txBadHabit.Location = new System.Drawing.Point(143, 19);
            this.txBadHabit.MaxLength = 99999;
            this.txBadHabit.Name = "txBadHabit";
            this.txBadHabit.Size = new System.Drawing.Size(200, 20);
            this.txBadHabit.TabIndex = 12;
            // 
            // gbDog
            // 
            this.gbDog.Controls.Add(this.lblLastWalkDate);
            this.gbDog.Controls.Add(this.dtpLastWalkDate);
            this.gbDog.Location = new System.Drawing.Point(12, 236);
            this.gbDog.Name = "gbDog";
            this.gbDog.Size = new System.Drawing.Size(367, 66);
            this.gbDog.TabIndex = 7;
            this.gbDog.TabStop = false;
            this.gbDog.Text = "Dog";
            // 
            // lblLastWalkDate
            // 
            this.lblLastWalkDate.AutoSize = true;
            this.lblLastWalkDate.Location = new System.Drawing.Point(13, 28);
            this.lblLastWalkDate.Name = "lblLastWalkDate";
            this.lblLastWalkDate.Size = new System.Drawing.Size(81, 13);
            this.lblLastWalkDate.TabIndex = 13;
            this.lblLastWalkDate.Text = "Last Walk Date";
            // 
            // dtpLastWalkDate
            // 
            this.dtpLastWalkDate.Enabled = false;
            this.dtpLastWalkDate.Location = new System.Drawing.Point(143, 28);
            this.dtpLastWalkDate.Name = "dtpLastWalkDate";
            this.dtpLastWalkDate.Size = new System.Drawing.Size(200, 20);
            this.dtpLastWalkDate.TabIndex = 12;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(155, 57);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 8;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(155, 92);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(28, 99);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(68, 13);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblChip
            // 
            this.lblChip.AutoSize = true;
            this.lblChip.Location = new System.Drawing.Point(25, 130);
            this.lblChip.Name = "lblChip";
            this.lblChip.Size = new System.Drawing.Size(42, 13);
            this.lblChip.TabIndex = 14;
            this.lblChip.Text = "ChipNr.";
            // 
            // cbAnimalNames
            // 
            this.cbAnimalNames.Location = new System.Drawing.Point(607, 25);
            this.cbAnimalNames.Name = "cbAnimalNames";
            this.cbAnimalNames.Size = new System.Drawing.Size(121, 21);
            this.cbAnimalNames.TabIndex = 0;
            this.cbAnimalNames.SelectedIndexChanged += new System.EventHandler(this.cbAnimalNames_SelectedIndexChanged);
            // 
            // lblInfoChip
            // 
            this.lblInfoChip.AutoSize = true;
            this.lblInfoChip.Location = new System.Drawing.Point(513, 130);
            this.lblInfoChip.Name = "lblInfoChip";
            this.lblInfoChip.Size = new System.Drawing.Size(42, 13);
            this.lblInfoChip.TabIndex = 19;
            this.lblInfoChip.Text = "ChipNr.";
            // 
            // lblInfoDOB
            // 
            this.lblInfoDOB.AutoSize = true;
            this.lblInfoDOB.Location = new System.Drawing.Point(513, 96);
            this.lblInfoDOB.Name = "lblInfoDOB";
            this.lblInfoDOB.Size = new System.Drawing.Size(68, 13);
            this.lblInfoDOB.TabIndex = 17;
            this.lblInfoDOB.Text = "Date Of Birth";
            // 
            // lblInfoName
            // 
            this.lblInfoName.AutoSize = true;
            this.lblInfoName.Location = new System.Drawing.Point(513, 64);
            this.lblInfoName.Name = "lblInfoName";
            this.lblInfoName.Size = new System.Drawing.Size(35, 13);
            this.lblInfoName.TabIndex = 16;
            this.lblInfoName.Text = "Name";
            // 
            // lblInfoExtra
            // 
            this.lblInfoExtra.AutoSize = true;
            this.lblInfoExtra.Location = new System.Drawing.Point(520, 192);
            this.lblInfoExtra.Name = "lblInfoExtra";
            this.lblInfoExtra.Size = new System.Drawing.Size(0, 13);
            this.lblInfoExtra.TabIndex = 20;
            // 
            // lblpInfoChip
            // 
            this.lblpInfoChip.AutoSize = true;
            this.lblpInfoChip.Location = new System.Drawing.Point(664, 130);
            this.lblpInfoChip.Name = "lblpInfoChip";
            this.lblpInfoChip.Size = new System.Drawing.Size(0, 13);
            this.lblpInfoChip.TabIndex = 23;
            // 
            // lblpInfoDOB
            // 
            this.lblpInfoDOB.AutoSize = true;
            this.lblpInfoDOB.Location = new System.Drawing.Point(664, 96);
            this.lblpInfoDOB.Name = "lblpInfoDOB";
            this.lblpInfoDOB.Size = new System.Drawing.Size(0, 13);
            this.lblpInfoDOB.TabIndex = 22;
            // 
            // lblpInfoName
            // 
            this.lblpInfoName.AutoSize = true;
            this.lblpInfoName.Location = new System.Drawing.Point(664, 64);
            this.lblpInfoName.Name = "lblpInfoName";
            this.lblpInfoName.Size = new System.Drawing.Size(0, 13);
            this.lblpInfoName.TabIndex = 21;
            // 
            // lblpInfoExtra
            // 
            this.lblpInfoExtra.AutoSize = true;
            this.lblpInfoExtra.Location = new System.Drawing.Point(671, 192);
            this.lblpInfoExtra.Name = "lblpInfoExtra";
            this.lblpInfoExtra.Size = new System.Drawing.Size(0, 13);
            this.lblpInfoExtra.TabIndex = 24;
            // 
            // btnDeleteAnimal
            // 
            this.btnDeleteAnimal.Enabled = false;
            this.btnDeleteAnimal.Location = new System.Drawing.Point(516, 254);
            this.btnDeleteAnimal.Name = "btnDeleteAnimal";
            this.btnDeleteAnimal.Size = new System.Drawing.Size(212, 23);
            this.btnDeleteAnimal.TabIndex = 25;
            this.btnDeleteAnimal.Text = "Delete Animal!";
            this.btnDeleteAnimal.UseVisualStyleBackColor = true;
            this.btnDeleteAnimal.Click += new System.EventHandler(this.btnDeleteAnimal_Click);
            // 
            // chbReserved
            // 
            this.chbReserved.AutoSize = true;
            this.chbReserved.Enabled = false;
            this.chbReserved.Location = new System.Drawing.Point(516, 220);
            this.chbReserved.Name = "chbReserved";
            this.chbReserved.Size = new System.Drawing.Size(72, 17);
            this.chbReserved.TabIndex = 26;
            this.chbReserved.Text = "Reserved";
            this.chbReserved.UseVisualStyleBackColor = true;
            this.chbReserved.CheckedChanged += new System.EventHandler(this.chbReserved_CheckedChanged);
            // 
            // lbReserved
            // 
            this.lbReserved.FormattingEnabled = true;
            this.lbReserved.Location = new System.Drawing.Point(12, 324);
            this.lbReserved.Name = "lbReserved";
            this.lbReserved.Size = new System.Drawing.Size(367, 199);
            this.lbReserved.TabIndex = 27;
            // 
            // lbNotReserved
            // 
            this.lbNotReserved.FormattingEnabled = true;
            this.lbNotReserved.Location = new System.Drawing.Point(417, 324);
            this.lbNotReserved.Name = "lbNotReserved";
            this.lbNotReserved.Size = new System.Drawing.Size(339, 199);
            this.lbNotReserved.TabIndex = 28;
            // 
            // lblShowInfo
            // 
            this.lblShowInfo.AutoSize = true;
            this.lblShowInfo.Location = new System.Drawing.Point(516, 28);
            this.lblShowInfo.Name = "lblShowInfo";
            this.lblShowInfo.Size = new System.Drawing.Size(57, 13);
            this.lblShowInfo.TabIndex = 29;
            this.lblShowInfo.Text = "Show info:";
            // 
            // nupChip
            // 
            this.nupChip.Location = new System.Drawing.Point(155, 130);
            this.nupChip.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nupChip.Name = "nupChip";
            this.nupChip.Size = new System.Drawing.Size(200, 20);
            this.nupChip.TabIndex = 30;
            // 
            // lblpInfoPrice
            // 
            this.lblpInfoPrice.AutoSize = true;
            this.lblpInfoPrice.Location = new System.Drawing.Point(664, 164);
            this.lblpInfoPrice.Name = "lblpInfoPrice";
            this.lblpInfoPrice.Size = new System.Drawing.Size(0, 13);
            this.lblpInfoPrice.TabIndex = 32;
            // 
            // lblInfoPrice
            // 
            this.lblInfoPrice.AutoSize = true;
            this.lblInfoPrice.Location = new System.Drawing.Point(513, 164);
            this.lblInfoPrice.Name = "lblInfoPrice";
            this.lblInfoPrice.Size = new System.Drawing.Size(31, 13);
            this.lblInfoPrice.TabIndex = 31;
            this.lblInfoPrice.Text = "Price";
            // 
            // Dierenasiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.lblpInfoPrice);
            this.Controls.Add(this.lblInfoPrice);
            this.Controls.Add(this.nupChip);
            this.Controls.Add(this.lblShowInfo);
            this.Controls.Add(this.lbNotReserved);
            this.Controls.Add(this.lbReserved);
            this.Controls.Add(this.chbReserved);
            this.Controls.Add(this.btnDeleteAnimal);
            this.Controls.Add(this.lblpInfoChip);
            this.Controls.Add(this.lblpInfoDOB);
            this.Controls.Add(this.lblpInfoName);
            this.Controls.Add(this.lblpInfoExtra);
            this.Controls.Add(this.lblInfoChip);
            this.Controls.Add(this.lblInfoDOB);
            this.Controls.Add(this.lblInfoName);
            this.Controls.Add(this.lblInfoExtra);
            this.Controls.Add(this.cbAnimalNames);
            this.Controls.Add(this.lblChip);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.gbDog);
            this.Controls.Add(this.gbCat);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Name = "Dierenasiel";
            this.Text = "Admin ";
            this.gbCat.ResumeLayout(false);
            this.gbCat.PerformLayout();
            this.gbDog.ResumeLayout(false);
            this.gbDog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupChip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.GroupBox gbCat;
        private System.Windows.Forms.GroupBox gbDog;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txBadHabit;
        private System.Windows.Forms.DateTimePicker dtpLastWalkDate;
        private System.Windows.Forms.Label lblBadhabit;
        private System.Windows.Forms.Label lblLastWalkDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblChip;
        private System.Windows.Forms.ComboBox cbAnimalNames;
        private System.Windows.Forms.Label lblInfoChip;
        private System.Windows.Forms.Label lblInfoDOB;
        private System.Windows.Forms.Label lblInfoName;
        private System.Windows.Forms.Label lblInfoExtra;
        private System.Windows.Forms.Label lblpInfoChip;
        private System.Windows.Forms.Label lblpInfoDOB;
        private System.Windows.Forms.Label lblpInfoName;
        private System.Windows.Forms.Label lblpInfoExtra;
        private System.Windows.Forms.Button btnDeleteAnimal;
        private System.Windows.Forms.CheckBox chbReserved;
        private System.Windows.Forms.ListBox lbReserved;
        private System.Windows.Forms.ListBox lbNotReserved;
        private System.Windows.Forms.Label lblShowInfo;
        private System.Windows.Forms.NumericUpDown nupChip;
        private System.Windows.Forms.Label lblpInfoPrice;
        private System.Windows.Forms.Label lblInfoPrice;
    }
}

