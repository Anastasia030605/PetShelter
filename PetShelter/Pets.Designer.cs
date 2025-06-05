namespace PetShelter
{
    partial class Pets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pets));
            dataGridViewPets = new DataGridView();
            textBoxEnterName = new TextBox();
            comboBoxSelectType = new ComboBox();
            numericUpDownSelectAge = new NumericUpDown();
            numericUpDownSelectWeight = new NumericUpDown();
            groupBoxSelectDender = new GroupBox();
            radioButtonSelectedGenderFemale = new RadioButton();
            radioButtonSelectedGenderMale = new RadioButton();
            groupBoxSelectPhobia = new GroupBox();
            radioButtonHasNoPhobia = new RadioButton();
            radioButtonHasPhobia = new RadioButton();
            numericUpDownHumanInteractionScore = new NumericUpDown();
            groupBoxGroomingTolerant = new GroupBox();
            radioButtonNotTolerant = new RadioButton();
            radioButtonTolerant = new RadioButton();
            groupBoxLeashReactivityLevel = new GroupBox();
            radioButtonFearful = new RadioButton();
            radioButtonAggressiveToOtherDogs = new RadioButton();
            radioButtonPulls = new RadioButton();
            radioButtonCalm = new RadioButton();
            radioButtonUndefined = new RadioButton();
            groupBoxDentalStatus = new GroupBox();
            radioButtonDentalStatusMacclusion = new RadioButton();
            radioButtonDentalStatusNormal = new RadioButton();
            groupBoxBondingCompatible = new GroupBox();
            radioButtonNotBondingCompatible = new RadioButton();
            radioButtonBondingCompatible = new RadioButton();
            numericUpDownDailyWalks = new NumericUpDown();
            buttonAddPet = new Button();
            DeletePet = new Button();
            textBoxEnterAge = new TextBox();
            textBoxEnterWeight = new TextBox();
            textBoxHumanScore = new TextBox();
            textBoxDailyWalks = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSelectAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSelectWeight).BeginInit();
            groupBoxSelectDender.SuspendLayout();
            groupBoxSelectPhobia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHumanInteractionScore).BeginInit();
            groupBoxGroomingTolerant.SuspendLayout();
            groupBoxLeashReactivityLevel.SuspendLayout();
            groupBoxDentalStatus.SuspendLayout();
            groupBoxBondingCompatible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDailyWalks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPets
            // 
            dataGridViewPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPets.Location = new Point(-2, -5);
            dataGridViewPets.Name = "dataGridViewPets";
            dataGridViewPets.RowHeadersWidth = 51;
            dataGridViewPets.Size = new Size(894, 325);
            dataGridViewPets.TabIndex = 0;
            // 
            // textBoxEnterName
            // 
            textBoxEnterName.BackColor = Color.FromArgb(255, 192, 192);
            textBoxEnterName.Location = new Point(61, 410);
            textBoxEnterName.Name = "textBoxEnterName";
            textBoxEnterName.Size = new Size(151, 27);
            textBoxEnterName.TabIndex = 1;
            textBoxEnterName.Text = "Enter name";
            textBoxEnterName.TextChanged += textBoxEnterName_TextChanged;
            // 
            // comboBoxSelectType
            // 
            comboBoxSelectType.BackColor = Color.FromArgb(255, 192, 192);
            comboBoxSelectType.FormattingEnabled = true;
            comboBoxSelectType.Location = new Point(61, 349);
            comboBoxSelectType.Name = "comboBoxSelectType";
            comboBoxSelectType.Size = new Size(151, 28);
            comboBoxSelectType.TabIndex = 2;
            comboBoxSelectType.Text = "select Type";
            comboBoxSelectType.SelectedIndexChanged += comboBoxSelectType_SelectedIndexChanged;
            // 
            // numericUpDownSelectAge
            // 
            numericUpDownSelectAge.BackColor = Color.FromArgb(255, 192, 192);
            numericUpDownSelectAge.Location = new Point(549, 348);
            numericUpDownSelectAge.Name = "numericUpDownSelectAge";
            numericUpDownSelectAge.Size = new Size(57, 27);
            numericUpDownSelectAge.TabIndex = 4;
            numericUpDownSelectAge.ValueChanged += numericUpDownSelectAge_ValueChanged;
            // 
            // numericUpDownSelectWeight
            // 
            numericUpDownSelectWeight.BackColor = Color.FromArgb(255, 192, 192);
            numericUpDownSelectWeight.Location = new Point(549, 411);
            numericUpDownSelectWeight.Name = "numericUpDownSelectWeight";
            numericUpDownSelectWeight.Size = new Size(55, 27);
            numericUpDownSelectWeight.TabIndex = 5;
            numericUpDownSelectWeight.ValueChanged += numericUpDownSelectWeight_ValueChanged;
            // 
            // groupBoxSelectDender
            // 
            groupBoxSelectDender.BackColor = Color.FromArgb(255, 192, 192);
            groupBoxSelectDender.Controls.Add(radioButtonSelectedGenderFemale);
            groupBoxSelectDender.Controls.Add(radioButtonSelectedGenderMale);
            groupBoxSelectDender.Location = new Point(243, 348);
            groupBoxSelectDender.Name = "groupBoxSelectDender";
            groupBoxSelectDender.Size = new Size(151, 90);
            groupBoxSelectDender.TabIndex = 6;
            groupBoxSelectDender.TabStop = false;
            groupBoxSelectDender.Text = "выберите пол";
            groupBoxSelectDender.Enter += groupBoxSelectDender_Enter;
            // 
            // radioButtonSelectedGenderFemale
            // 
            radioButtonSelectedGenderFemale.AutoSize = true;
            radioButtonSelectedGenderFemale.Location = new Point(17, 55);
            radioButtonSelectedGenderFemale.Name = "radioButtonSelectedGenderFemale";
            radioButtonSelectedGenderFemale.Size = new Size(78, 24);
            radioButtonSelectedGenderFemale.TabIndex = 1;
            radioButtonSelectedGenderFemale.TabStop = true;
            radioButtonSelectedGenderFemale.Text = "Female";
            radioButtonSelectedGenderFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonSelectedGenderMale
            // 
            radioButtonSelectedGenderMale.AutoSize = true;
            radioButtonSelectedGenderMale.Location = new Point(17, 25);
            radioButtonSelectedGenderMale.Name = "radioButtonSelectedGenderMale";
            radioButtonSelectedGenderMale.Size = new Size(63, 24);
            radioButtonSelectedGenderMale.TabIndex = 0;
            radioButtonSelectedGenderMale.TabStop = true;
            radioButtonSelectedGenderMale.Text = "Male";
            radioButtonSelectedGenderMale.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelectPhobia
            // 
            groupBoxSelectPhobia.BackColor = Color.FromArgb(255, 192, 192);
            groupBoxSelectPhobia.Controls.Add(radioButtonHasNoPhobia);
            groupBoxSelectPhobia.Controls.Add(radioButtonHasPhobia);
            groupBoxSelectPhobia.Location = new Point(624, 347);
            groupBoxSelectPhobia.Name = "groupBoxSelectPhobia";
            groupBoxSelectPhobia.Size = new Size(187, 90);
            groupBoxSelectPhobia.TabIndex = 7;
            groupBoxSelectPhobia.TabStop = false;
            groupBoxSelectPhobia.Text = "наличие клаустрофобии";
            groupBoxSelectPhobia.Enter += groupBoxSelectPhobia_Enter;
            // 
            // radioButtonHasNoPhobia
            // 
            radioButtonHasNoPhobia.AutoSize = true;
            radioButtonHasNoPhobia.Location = new Point(118, 55);
            radioButtonHasNoPhobia.Name = "radioButtonHasNoPhobia";
            radioButtonHasNoPhobia.Size = new Size(47, 24);
            radioButtonHasNoPhobia.TabIndex = 1;
            radioButtonHasNoPhobia.TabStop = true;
            radioButtonHasNoPhobia.Text = "no";
            radioButtonHasNoPhobia.UseVisualStyleBackColor = true;
            // 
            // radioButtonHasPhobia
            // 
            radioButtonHasPhobia.AutoSize = true;
            radioButtonHasPhobia.Location = new Point(15, 55);
            radioButtonHasPhobia.Name = "radioButtonHasPhobia";
            radioButtonHasPhobia.Size = new Size(73, 24);
            radioButtonHasPhobia.TabIndex = 0;
            radioButtonHasPhobia.TabStop = true;
            radioButtonHasPhobia.Text = "болен";
            radioButtonHasPhobia.UseVisualStyleBackColor = true;
            // 
            // numericUpDownHumanInteractionScore
            // 
            numericUpDownHumanInteractionScore.BackColor = Color.Fuchsia;
            numericUpDownHumanInteractionScore.Location = new Point(281, 490);
            numericUpDownHumanInteractionScore.Name = "numericUpDownHumanInteractionScore";
            numericUpDownHumanInteractionScore.Size = new Size(74, 27);
            numericUpDownHumanInteractionScore.TabIndex = 8;
            numericUpDownHumanInteractionScore.ValueChanged += numericUpDownHumanInteractionScore_ValueChanged;
            // 
            // groupBoxGroomingTolerant
            // 
            groupBoxGroomingTolerant.Anchor = AnchorStyles.Top;
            groupBoxGroomingTolerant.BackColor = Color.Fuchsia;
            groupBoxGroomingTolerant.Controls.Add(radioButtonNotTolerant);
            groupBoxGroomingTolerant.Controls.Add(radioButtonTolerant);
            groupBoxGroomingTolerant.Location = new Point(61, 546);
            groupBoxGroomingTolerant.Name = "groupBoxGroomingTolerant";
            groupBoxGroomingTolerant.Size = new Size(208, 71);
            groupBoxGroomingTolerant.TabIndex = 9;
            groupBoxGroomingTolerant.TabStop = false;
            groupBoxGroomingTolerant.Text = "груминг толерант?";
            groupBoxGroomingTolerant.Enter += groupBoxGroomingTolerant_Enter;
            // 
            // radioButtonNotTolerant
            // 
            radioButtonNotTolerant.AutoSize = true;
            radioButtonNotTolerant.Location = new Point(115, 34);
            radioButtonNotTolerant.Name = "radioButtonNotTolerant";
            radioButtonNotTolerant.Size = new Size(47, 24);
            radioButtonNotTolerant.TabIndex = 1;
            radioButtonNotTolerant.TabStop = true;
            radioButtonNotTolerant.Text = "no";
            radioButtonNotTolerant.UseVisualStyleBackColor = true;
            radioButtonNotTolerant.CheckedChanged += radioButtonNotTolerant_CheckedChanged;
            // 
            // radioButtonTolerant
            // 
            radioButtonTolerant.AutoSize = true;
            radioButtonTolerant.Location = new Point(29, 34);
            radioButtonTolerant.Name = "radioButtonTolerant";
            radioButtonTolerant.Size = new Size(51, 24);
            radioButtonTolerant.TabIndex = 0;
            radioButtonTolerant.TabStop = true;
            radioButtonTolerant.Text = "yes";
            radioButtonTolerant.UseVisualStyleBackColor = true;
            // 
            // groupBoxLeashReactivityLevel
            // 
            groupBoxLeashReactivityLevel.BackColor = Color.FromArgb(128, 128, 255);
            groupBoxLeashReactivityLevel.Controls.Add(radioButtonFearful);
            groupBoxLeashReactivityLevel.Controls.Add(radioButtonAggressiveToOtherDogs);
            groupBoxLeashReactivityLevel.Controls.Add(radioButtonPulls);
            groupBoxLeashReactivityLevel.Controls.Add(radioButtonCalm);
            groupBoxLeashReactivityLevel.Controls.Add(radioButtonUndefined);
            groupBoxLeashReactivityLevel.Location = new Point(61, 490);
            groupBoxLeashReactivityLevel.Name = "groupBoxLeashReactivityLevel";
            groupBoxLeashReactivityLevel.Size = new Size(240, 179);
            groupBoxLeashReactivityLevel.TabIndex = 10;
            groupBoxLeashReactivityLevel.TabStop = false;
            groupBoxLeashReactivityLevel.Text = "LeashReactivityLevel";
            groupBoxLeashReactivityLevel.Enter += groupBoxLeashReactivityLevel_Enter;
            // 
            // radioButtonFearful
            // 
            radioButtonFearful.AutoSize = true;
            radioButtonFearful.Location = new Point(35, 148);
            radioButtonFearful.Name = "radioButtonFearful";
            radioButtonFearful.Size = new Size(75, 24);
            radioButtonFearful.TabIndex = 4;
            radioButtonFearful.TabStop = true;
            radioButtonFearful.Text = "Fearful";
            radioButtonFearful.UseVisualStyleBackColor = true;
            // 
            // radioButtonAggressiveToOtherDogs
            // 
            radioButtonAggressiveToOtherDogs.AutoSize = true;
            radioButtonAggressiveToOtherDogs.Location = new Point(35, 120);
            radioButtonAggressiveToOtherDogs.Name = "radioButtonAggressiveToOtherDogs";
            radioButtonAggressiveToOtherDogs.Size = new Size(190, 24);
            radioButtonAggressiveToOtherDogs.TabIndex = 3;
            radioButtonAggressiveToOtherDogs.TabStop = true;
            radioButtonAggressiveToOtherDogs.Text = "AggressiveToOtherDogs";
            radioButtonAggressiveToOtherDogs.UseVisualStyleBackColor = true;
            // 
            // radioButtonPulls
            // 
            radioButtonPulls.AutoSize = true;
            radioButtonPulls.Location = new Point(35, 91);
            radioButtonPulls.Name = "radioButtonPulls";
            radioButtonPulls.Size = new Size(60, 24);
            radioButtonPulls.TabIndex = 2;
            radioButtonPulls.TabStop = true;
            radioButtonPulls.Text = "Pulls";
            radioButtonPulls.UseVisualStyleBackColor = true;
            // 
            // radioButtonCalm
            // 
            radioButtonCalm.AutoSize = true;
            radioButtonCalm.Location = new Point(35, 60);
            radioButtonCalm.Name = "radioButtonCalm";
            radioButtonCalm.Size = new Size(64, 24);
            radioButtonCalm.TabIndex = 1;
            radioButtonCalm.TabStop = true;
            radioButtonCalm.Text = "Calm";
            radioButtonCalm.UseVisualStyleBackColor = true;
            // 
            // radioButtonUndefined
            // 
            radioButtonUndefined.AutoSize = true;
            radioButtonUndefined.Location = new Point(35, 29);
            radioButtonUndefined.Name = "radioButtonUndefined";
            radioButtonUndefined.Size = new Size(99, 24);
            radioButtonUndefined.TabIndex = 0;
            radioButtonUndefined.TabStop = true;
            radioButtonUndefined.Text = "Undefined";
            radioButtonUndefined.UseVisualStyleBackColor = true;
            // 
            // groupBoxDentalStatus
            // 
            groupBoxDentalStatus.BackColor = Color.FromArgb(0, 192, 192);
            groupBoxDentalStatus.Controls.Add(radioButtonDentalStatusMacclusion);
            groupBoxDentalStatus.Controls.Add(radioButtonDentalStatusNormal);
            groupBoxDentalStatus.Location = new Point(275, 470);
            groupBoxDentalStatus.Name = "groupBoxDentalStatus";
            groupBoxDentalStatus.Size = new Size(193, 115);
            groupBoxDentalStatus.TabIndex = 13;
            groupBoxDentalStatus.TabStop = false;
            groupBoxDentalStatus.Text = "DentalStatus";
            groupBoxDentalStatus.Enter += groupBoxDentalStatus_Enter;
            // 
            // radioButtonDentalStatusMacclusion
            // 
            radioButtonDentalStatusMacclusion.AutoSize = true;
            radioButtonDentalStatusMacclusion.Location = new Point(21, 71);
            radioButtonDentalStatusMacclusion.Name = "radioButtonDentalStatusMacclusion";
            radioButtonDentalStatusMacclusion.Size = new Size(104, 24);
            radioButtonDentalStatusMacclusion.TabIndex = 1;
            radioButtonDentalStatusMacclusion.TabStop = true;
            radioButtonDentalStatusMacclusion.Text = "Macclusion";
            radioButtonDentalStatusMacclusion.UseVisualStyleBackColor = true;
            // 
            // radioButtonDentalStatusNormal
            // 
            radioButtonDentalStatusNormal.AutoSize = true;
            radioButtonDentalStatusNormal.Location = new Point(21, 29);
            radioButtonDentalStatusNormal.Name = "radioButtonDentalStatusNormal";
            radioButtonDentalStatusNormal.Size = new Size(80, 24);
            radioButtonDentalStatusNormal.TabIndex = 0;
            radioButtonDentalStatusNormal.TabStop = true;
            radioButtonDentalStatusNormal.Text = "Normal";
            radioButtonDentalStatusNormal.UseVisualStyleBackColor = true;
            // 
            // groupBoxBondingCompatible
            // 
            groupBoxBondingCompatible.BackColor = Color.FromArgb(0, 192, 192);
            groupBoxBondingCompatible.Controls.Add(radioButtonNotBondingCompatible);
            groupBoxBondingCompatible.Controls.Add(radioButtonBondingCompatible);
            groupBoxBondingCompatible.Location = new Point(61, 470);
            groupBoxBondingCompatible.Name = "groupBoxBondingCompatible";
            groupBoxBondingCompatible.Size = new Size(165, 115);
            groupBoxBondingCompatible.TabIndex = 12;
            groupBoxBondingCompatible.TabStop = false;
            groupBoxBondingCompatible.Text = "BondingCompatible";
            groupBoxBondingCompatible.Enter += groupBoxBondingCompatible_Enter;
            // 
            // radioButtonNotBondingCompatible
            // 
            radioButtonNotBondingCompatible.AutoSize = true;
            radioButtonNotBondingCompatible.Location = new Point(37, 75);
            radioButtonNotBondingCompatible.Name = "radioButtonNotBondingCompatible";
            radioButtonNotBondingCompatible.Size = new Size(47, 24);
            radioButtonNotBondingCompatible.TabIndex = 1;
            radioButtonNotBondingCompatible.TabStop = true;
            radioButtonNotBondingCompatible.Text = "no";
            radioButtonNotBondingCompatible.UseVisualStyleBackColor = true;
            // 
            // radioButtonBondingCompatible
            // 
            radioButtonBondingCompatible.AutoSize = true;
            radioButtonBondingCompatible.Location = new Point(37, 41);
            radioButtonBondingCompatible.Name = "radioButtonBondingCompatible";
            radioButtonBondingCompatible.Size = new Size(51, 24);
            radioButtonBondingCompatible.TabIndex = 0;
            radioButtonBondingCompatible.TabStop = true;
            radioButtonBondingCompatible.Text = "yes";
            radioButtonBondingCompatible.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDailyWalks
            // 
            numericUpDownDailyWalks.BackColor = Color.FromArgb(128, 128, 255);
            numericUpDownDailyWalks.Location = new Point(408, 572);
            numericUpDownDailyWalks.Name = "numericUpDownDailyWalks";
            numericUpDownDailyWalks.Size = new Size(85, 27);
            numericUpDownDailyWalks.TabIndex = 11;
            numericUpDownDailyWalks.ValueChanged += numericUpDownDailyWalks_ValueChanged;
            // 
            // buttonAddPet
            // 
            buttonAddPet.BackColor = Color.Maroon;
            buttonAddPet.ForeColor = Color.White;
            buttonAddPet.Location = new Point(890, 358);
            buttonAddPet.Name = "buttonAddPet";
            buttonAddPet.Size = new Size(138, 79);
            buttonAddPet.TabIndex = 14;
            buttonAddPet.Text = "добавить питомца в приют";
            buttonAddPet.UseVisualStyleBackColor = false;
            buttonAddPet.Click += buttonAddPet_Click;
            // 
            // DeletePet
            // 
            DeletePet.BackgroundImage = (Image)resources.GetObject("DeletePet.BackgroundImage");
            DeletePet.Location = new Point(933, 16);
            DeletePet.Margin = new Padding(3, 4, 3, 4);
            DeletePet.Name = "DeletePet";
            DeletePet.Size = new Size(187, 119);
            DeletePet.TabIndex = 15;
            DeletePet.Text = "Вышвырнуть";
            DeletePet.UseVisualStyleBackColor = true;
            DeletePet.Click += DeletePet_Click;
            // 
            // textBoxEnterAge
            // 
            textBoxEnterAge.BackColor = Color.FromArgb(255, 192, 192);
            textBoxEnterAge.Location = new Point(418, 349);
            textBoxEnterAge.Name = "textBoxEnterAge";
            textBoxEnterAge.ReadOnly = true;
            textBoxEnterAge.Size = new Size(125, 27);
            textBoxEnterAge.TabIndex = 16;
            textBoxEnterAge.Text = "enter Age";
            // 
            // textBoxEnterWeight
            // 
            textBoxEnterWeight.BackColor = Color.FromArgb(255, 192, 192);
            textBoxEnterWeight.Location = new Point(418, 411);
            textBoxEnterWeight.Name = "textBoxEnterWeight";
            textBoxEnterWeight.ReadOnly = true;
            textBoxEnterWeight.Size = new Size(125, 27);
            textBoxEnterWeight.TabIndex = 17;
            textBoxEnterWeight.Text = "enter Weight";
            // 
            // textBoxHumanScore
            // 
            textBoxHumanScore.BackColor = Color.Fuchsia;
            textBoxHumanScore.Location = new Point(61, 490);
            textBoxHumanScore.Name = "textBoxHumanScore";
            textBoxHumanScore.ReadOnly = true;
            textBoxHumanScore.Size = new Size(208, 27);
            textBoxHumanScore.TabIndex = 18;
            textBoxHumanScore.Text = "enter human interaction score";
            textBoxHumanScore.TextChanged += textBoxHumanScore_TextChanged;
            // 
            // textBoxDailyWalks
            // 
            textBoxDailyWalks.BackColor = Color.FromArgb(128, 128, 255);
            textBoxDailyWalks.Location = new Point(386, 528);
            textBoxDailyWalks.Name = "textBoxDailyWalks";
            textBoxDailyWalks.ReadOnly = true;
            textBoxDailyWalks.Size = new Size(125, 27);
            textBoxDailyWalks.TabIndex = 19;
            textBoxDailyWalks.Text = "enter daily walks";
            // 
            // Pets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 775);
            Controls.Add(textBoxDailyWalks);
            Controls.Add(textBoxHumanScore);
            Controls.Add(textBoxEnterWeight);
            Controls.Add(textBoxEnterAge);
            Controls.Add(DeletePet);
            Controls.Add(groupBoxBondingCompatible);
            Controls.Add(groupBoxDentalStatus);
            Controls.Add(buttonAddPet);
            Controls.Add(numericUpDownDailyWalks);
            Controls.Add(groupBoxLeashReactivityLevel);
            Controls.Add(groupBoxGroomingTolerant);
            Controls.Add(numericUpDownHumanInteractionScore);
            Controls.Add(groupBoxSelectPhobia);
            Controls.Add(groupBoxSelectDender);
            Controls.Add(numericUpDownSelectWeight);
            Controls.Add(numericUpDownSelectAge);
            Controls.Add(comboBoxSelectType);
            Controls.Add(textBoxEnterName);
            Controls.Add(dataGridViewPets);
            Name = "Pets";
            Text = "Pets";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPets).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSelectAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSelectWeight).EndInit();
            groupBoxSelectDender.ResumeLayout(false);
            groupBoxSelectDender.PerformLayout();
            groupBoxSelectPhobia.ResumeLayout(false);
            groupBoxSelectPhobia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHumanInteractionScore).EndInit();
            groupBoxGroomingTolerant.ResumeLayout(false);
            groupBoxGroomingTolerant.PerformLayout();
            groupBoxLeashReactivityLevel.ResumeLayout(false);
            groupBoxLeashReactivityLevel.PerformLayout();
            groupBoxDentalStatus.ResumeLayout(false);
            groupBoxDentalStatus.PerformLayout();
            groupBoxBondingCompatible.ResumeLayout(false);
            groupBoxBondingCompatible.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDailyWalks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPets;
        private TextBox textBoxEnterName;
        private ComboBox comboBoxSelectType;
        private NumericUpDown numericUpDownSelectAge;
        private NumericUpDown numericUpDownSelectWeight;
        private GroupBox groupBoxSelectDender;
        private RadioButton radioButtonSelectedGenderFemale;
        private RadioButton radioButtonSelectedGenderMale;
        private GroupBox groupBoxSelectPhobia;
        private RadioButton radioButtonHasPhobia;
        private NumericUpDown numericUpDownHumanInteractionScore;
        private GroupBox groupBoxGroomingTolerant;
        private RadioButton radioButtonTolerant;
        private GroupBox groupBoxLeashReactivityLevel;
        private RadioButton radioButtonCalm;
        private RadioButton radioButtonUndefined;
        private RadioButton radioButtonPulls;
        private RadioButton radioButtonFearful;
        private RadioButton radioButtonAggressiveToOtherDogs;
        private NumericUpDown numericUpDownDailyWalks;
        private GroupBox groupBoxBondingCompatible;
        private RadioButton radioButtonBondingCompatible;
        private GroupBox groupBoxDentalStatus;
        private RadioButton radioButtonDentalStatusNormal;
        private RadioButton radioButtonDentalStatusMacclusion;
        private RadioButton radioButtonHasNoPhobia;
        private RadioButton radioButtonNotTolerant;
        private RadioButton radioButtonNotBondingCompatible;
        private Button buttonAddPet;
        private Button DeletePet;
        private TextBox textBoxEnterAge;
        private TextBox textBoxEnterWeight;
        private TextBox textBoxHumanScore;
        private TextBox textBoxDailyWalks;
        //private RadioButton radioButton1;
    }
}