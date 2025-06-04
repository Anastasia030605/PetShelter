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
            numericUpDownDailyWalks = new NumericUpDown();
            groupBoxBondingCompatible = new GroupBox();
            radioButtonNotBondingCompatible = new RadioButton();
            radioButtonBondingCompatible = new RadioButton();
            groupBoxDentalStatus = new GroupBox();
            radioButtonDentalStatusMacclusion = new RadioButton();
            radioButtonDentalStatusNormal = new RadioButton();
            buttonAddPet = new Button();
            DeletePet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSelectAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSelectWeight).BeginInit();
            groupBoxSelectDender.SuspendLayout();
            groupBoxSelectPhobia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHumanInteractionScore).BeginInit();
            groupBoxGroomingTolerant.SuspendLayout();
            groupBoxLeashReactivityLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDailyWalks).BeginInit();
            groupBoxBondingCompatible.SuspendLayout();
            groupBoxDentalStatus.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPets
            // 
            dataGridViewPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPets.Location = new Point(-2, -4);
            dataGridViewPets.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPets.Name = "dataGridViewPets";
            dataGridViewPets.RowHeadersWidth = 51;
            dataGridViewPets.Size = new Size(782, 244);
            dataGridViewPets.TabIndex = 0;
            // 
            // textBoxEnterName
            // 
            textBoxEnterName.BackColor = Color.FromArgb(255, 192, 192);
            textBoxEnterName.Location = new Point(177, 262);
            textBoxEnterName.Margin = new Padding(3, 2, 3, 2);
            textBoxEnterName.Name = "textBoxEnterName";
            textBoxEnterName.Size = new Size(120, 23);
            textBoxEnterName.TabIndex = 1;
            textBoxEnterName.TextChanged += textBoxEnterName_TextChanged;
            // 
            // comboBoxSelectType
            // 
            comboBoxSelectType.BackColor = Color.FromArgb(255, 192, 192);
            comboBoxSelectType.FormattingEnabled = true;
            comboBoxSelectType.Location = new Point(39, 261);
            comboBoxSelectType.Margin = new Padding(3, 2, 3, 2);
            comboBoxSelectType.Name = "comboBoxSelectType";
            comboBoxSelectType.Size = new Size(133, 23);
            comboBoxSelectType.TabIndex = 2;
            comboBoxSelectType.SelectedIndexChanged += comboBoxSelectType_SelectedIndexChanged;
            // 
            // numericUpDownSelectAge
            // 
            numericUpDownSelectAge.BackColor = Color.FromArgb(255, 192, 192);
            numericUpDownSelectAge.Location = new Point(438, 262);
            numericUpDownSelectAge.Margin = new Padding(3, 2, 3, 2);
            numericUpDownSelectAge.Name = "numericUpDownSelectAge";
            numericUpDownSelectAge.Size = new Size(50, 23);
            numericUpDownSelectAge.TabIndex = 4;
            numericUpDownSelectAge.ValueChanged += numericUpDownSelectAge_ValueChanged;
            // 
            // numericUpDownSelectWeight
            // 
            numericUpDownSelectWeight.BackColor = Color.FromArgb(255, 192, 192);
            numericUpDownSelectWeight.Location = new Point(494, 262);
            numericUpDownSelectWeight.Margin = new Padding(3, 2, 3, 2);
            numericUpDownSelectWeight.Name = "numericUpDownSelectWeight";
            numericUpDownSelectWeight.Size = new Size(48, 23);
            numericUpDownSelectWeight.TabIndex = 5;
            numericUpDownSelectWeight.ValueChanged += numericUpDownSelectWeight_ValueChanged;
            // 
            // groupBoxSelectDender
            // 
            groupBoxSelectDender.BackColor = Color.FromArgb(255, 192, 192);
            groupBoxSelectDender.Controls.Add(radioButtonSelectedGenderFemale);
            groupBoxSelectDender.Controls.Add(radioButtonSelectedGenderMale);
            groupBoxSelectDender.Location = new Point(301, 251);
            groupBoxSelectDender.Margin = new Padding(3, 2, 3, 2);
            groupBoxSelectDender.Name = "groupBoxSelectDender";
            groupBoxSelectDender.Padding = new Padding(3, 2, 3, 2);
            groupBoxSelectDender.Size = new Size(132, 67);
            groupBoxSelectDender.TabIndex = 6;
            groupBoxSelectDender.TabStop = false;
            groupBoxSelectDender.Text = "выберите пол";
            groupBoxSelectDender.Enter += groupBoxSelectDender_Enter;
            // 
            // radioButtonSelectedGenderFemale
            // 
            radioButtonSelectedGenderFemale.AutoSize = true;
            radioButtonSelectedGenderFemale.Location = new Point(15, 41);
            radioButtonSelectedGenderFemale.Margin = new Padding(3, 2, 3, 2);
            radioButtonSelectedGenderFemale.Name = "radioButtonSelectedGenderFemale";
            radioButtonSelectedGenderFemale.Size = new Size(63, 19);
            radioButtonSelectedGenderFemale.TabIndex = 1;
            radioButtonSelectedGenderFemale.TabStop = true;
            radioButtonSelectedGenderFemale.Text = "Female";
            radioButtonSelectedGenderFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonSelectedGenderMale
            // 
            radioButtonSelectedGenderMale.AutoSize = true;
            radioButtonSelectedGenderMale.Location = new Point(15, 19);
            radioButtonSelectedGenderMale.Margin = new Padding(3, 2, 3, 2);
            radioButtonSelectedGenderMale.Name = "radioButtonSelectedGenderMale";
            radioButtonSelectedGenderMale.Size = new Size(51, 19);
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
            groupBoxSelectPhobia.Location = new Point(547, 251);
            groupBoxSelectPhobia.Margin = new Padding(3, 2, 3, 2);
            groupBoxSelectPhobia.Name = "groupBoxSelectPhobia";
            groupBoxSelectPhobia.Padding = new Padding(3, 2, 3, 2);
            groupBoxSelectPhobia.Size = new Size(144, 85);
            groupBoxSelectPhobia.TabIndex = 7;
            groupBoxSelectPhobia.TabStop = false;
            groupBoxSelectPhobia.Text = "наличие клаустрофобии";
            groupBoxSelectPhobia.Enter += groupBoxSelectPhobia_Enter;
            // 
            // radioButtonHasNoPhobia
            // 
            radioButtonHasNoPhobia.AutoSize = true;
            radioButtonHasNoPhobia.Location = new Point(18, 64);
            radioButtonHasNoPhobia.Margin = new Padding(3, 2, 3, 2);
            radioButtonHasNoPhobia.Name = "radioButtonHasNoPhobia";
            radioButtonHasNoPhobia.Size = new Size(39, 19);
            radioButtonHasNoPhobia.TabIndex = 1;
            radioButtonHasNoPhobia.TabStop = true;
            radioButtonHasNoPhobia.Text = "no";
            radioButtonHasNoPhobia.UseVisualStyleBackColor = true;
            // 
            // radioButtonHasPhobia
            // 
            radioButtonHasPhobia.AutoSize = true;
            radioButtonHasPhobia.Location = new Point(18, 41);
            radioButtonHasPhobia.Margin = new Padding(3, 2, 3, 2);
            radioButtonHasPhobia.Name = "radioButtonHasPhobia";
            radioButtonHasPhobia.Size = new Size(59, 19);
            radioButtonHasPhobia.TabIndex = 0;
            radioButtonHasPhobia.TabStop = true;
            radioButtonHasPhobia.Text = "болен";
            radioButtonHasPhobia.UseVisualStyleBackColor = true;
            // 
            // numericUpDownHumanInteractionScore
            // 
            numericUpDownHumanInteractionScore.BackColor = Color.Fuchsia;
            numericUpDownHumanInteractionScore.Location = new Point(39, 382);
            numericUpDownHumanInteractionScore.Margin = new Padding(3, 2, 3, 2);
            numericUpDownHumanInteractionScore.Name = "numericUpDownHumanInteractionScore";
            numericUpDownHumanInteractionScore.Size = new Size(65, 23);
            numericUpDownHumanInteractionScore.TabIndex = 8;
            numericUpDownHumanInteractionScore.ValueChanged += numericUpDownHumanInteractionScore_ValueChanged;
            // 
            // groupBoxGroomingTolerant
            // 
            groupBoxGroomingTolerant.BackColor = Color.Fuchsia;
            groupBoxGroomingTolerant.Controls.Add(radioButtonNotTolerant);
            groupBoxGroomingTolerant.Controls.Add(radioButtonTolerant);
            groupBoxGroomingTolerant.Location = new Point(109, 352);
            groupBoxGroomingTolerant.Margin = new Padding(3, 2, 3, 2);
            groupBoxGroomingTolerant.Name = "groupBoxGroomingTolerant";
            groupBoxGroomingTolerant.Padding = new Padding(3, 2, 3, 2);
            groupBoxGroomingTolerant.Size = new Size(108, 92);
            groupBoxGroomingTolerant.TabIndex = 9;
            groupBoxGroomingTolerant.TabStop = false;
            groupBoxGroomingTolerant.Text = "груминг толерант?";
            groupBoxGroomingTolerant.Enter += groupBoxGroomingTolerant_Enter;
            // 
            // radioButtonNotTolerant
            // 
            radioButtonNotTolerant.AutoSize = true;
            radioButtonNotTolerant.Location = new Point(6, 53);
            radioButtonNotTolerant.Margin = new Padding(3, 2, 3, 2);
            radioButtonNotTolerant.Name = "radioButtonNotTolerant";
            radioButtonNotTolerant.Size = new Size(39, 19);
            radioButtonNotTolerant.TabIndex = 1;
            radioButtonNotTolerant.TabStop = true;
            radioButtonNotTolerant.Text = "no";
            radioButtonNotTolerant.UseVisualStyleBackColor = true;
            // 
            // radioButtonTolerant
            // 
            radioButtonTolerant.AutoSize = true;
            radioButtonTolerant.Location = new Point(5, 33);
            radioButtonTolerant.Margin = new Padding(3, 2, 3, 2);
            radioButtonTolerant.Name = "radioButtonTolerant";
            radioButtonTolerant.Size = new Size(42, 19);
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
            groupBoxLeashReactivityLevel.Location = new Point(237, 329);
            groupBoxLeashReactivityLevel.Margin = new Padding(3, 2, 3, 2);
            groupBoxLeashReactivityLevel.Name = "groupBoxLeashReactivityLevel";
            groupBoxLeashReactivityLevel.Padding = new Padding(3, 2, 3, 2);
            groupBoxLeashReactivityLevel.Size = new Size(210, 134);
            groupBoxLeashReactivityLevel.TabIndex = 10;
            groupBoxLeashReactivityLevel.TabStop = false;
            groupBoxLeashReactivityLevel.Text = "LeashReactivityLevel";
            groupBoxLeashReactivityLevel.Enter += groupBoxLeashReactivityLevel_Enter;
            // 
            // radioButtonFearful
            // 
            radioButtonFearful.AutoSize = true;
            radioButtonFearful.Location = new Point(31, 111);
            radioButtonFearful.Margin = new Padding(3, 2, 3, 2);
            radioButtonFearful.Name = "radioButtonFearful";
            radioButtonFearful.Size = new Size(61, 19);
            radioButtonFearful.TabIndex = 4;
            radioButtonFearful.TabStop = true;
            radioButtonFearful.Text = "Fearful";
            radioButtonFearful.UseVisualStyleBackColor = true;
            // 
            // radioButtonAggressiveToOtherDogs
            // 
            radioButtonAggressiveToOtherDogs.AutoSize = true;
            radioButtonAggressiveToOtherDogs.Location = new Point(31, 90);
            radioButtonAggressiveToOtherDogs.Margin = new Padding(3, 2, 3, 2);
            radioButtonAggressiveToOtherDogs.Name = "radioButtonAggressiveToOtherDogs";
            radioButtonAggressiveToOtherDogs.Size = new Size(152, 19);
            radioButtonAggressiveToOtherDogs.TabIndex = 3;
            radioButtonAggressiveToOtherDogs.TabStop = true;
            radioButtonAggressiveToOtherDogs.Text = "AggressiveToOtherDogs";
            radioButtonAggressiveToOtherDogs.UseVisualStyleBackColor = true;
            // 
            // radioButtonPulls
            // 
            radioButtonPulls.AutoSize = true;
            radioButtonPulls.Location = new Point(31, 68);
            radioButtonPulls.Margin = new Padding(3, 2, 3, 2);
            radioButtonPulls.Name = "radioButtonPulls";
            radioButtonPulls.Size = new Size(50, 19);
            radioButtonPulls.TabIndex = 2;
            radioButtonPulls.TabStop = true;
            radioButtonPulls.Text = "Pulls";
            radioButtonPulls.UseVisualStyleBackColor = true;
            // 
            // radioButtonCalm
            // 
            radioButtonCalm.AutoSize = true;
            radioButtonCalm.Location = new Point(31, 45);
            radioButtonCalm.Margin = new Padding(3, 2, 3, 2);
            radioButtonCalm.Name = "radioButtonCalm";
            radioButtonCalm.Size = new Size(53, 19);
            radioButtonCalm.TabIndex = 1;
            radioButtonCalm.TabStop = true;
            radioButtonCalm.Text = "Calm";
            radioButtonCalm.UseVisualStyleBackColor = true;
            // 
            // radioButtonUndefined
            // 
            radioButtonUndefined.AutoSize = true;
            radioButtonUndefined.Location = new Point(31, 22);
            radioButtonUndefined.Margin = new Padding(3, 2, 3, 2);
            radioButtonUndefined.Name = "radioButtonUndefined";
            radioButtonUndefined.Size = new Size(80, 19);
            radioButtonUndefined.TabIndex = 0;
            radioButtonUndefined.TabStop = true;
            radioButtonUndefined.Text = "Undefined";
            radioButtonUndefined.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDailyWalks
            // 
            numericUpDownDailyWalks.BackColor = Color.FromArgb(128, 128, 255);
            numericUpDownDailyWalks.Location = new Point(454, 390);
            numericUpDownDailyWalks.Margin = new Padding(3, 2, 3, 2);
            numericUpDownDailyWalks.Name = "numericUpDownDailyWalks";
            numericUpDownDailyWalks.Size = new Size(74, 23);
            numericUpDownDailyWalks.TabIndex = 11;
            numericUpDownDailyWalks.ValueChanged += numericUpDownDailyWalks_ValueChanged;
            // 
            // groupBoxBondingCompatible
            // 
            groupBoxBondingCompatible.BackColor = Color.FromArgb(0, 192, 192);
            groupBoxBondingCompatible.Controls.Add(radioButtonNotBondingCompatible);
            groupBoxBondingCompatible.Controls.Add(radioButtonBondingCompatible);
            groupBoxBondingCompatible.Location = new Point(547, 352);
            groupBoxBondingCompatible.Margin = new Padding(3, 2, 3, 2);
            groupBoxBondingCompatible.Name = "groupBoxBondingCompatible";
            groupBoxBondingCompatible.Padding = new Padding(3, 2, 3, 2);
            groupBoxBondingCompatible.Size = new Size(144, 86);
            groupBoxBondingCompatible.TabIndex = 12;
            groupBoxBondingCompatible.TabStop = false;
            groupBoxBondingCompatible.Text = "BondingCompatible";
            groupBoxBondingCompatible.Enter += groupBoxBondingCompatible_Enter;
            // 
            // radioButtonNotBondingCompatible
            // 
            radioButtonNotBondingCompatible.AutoSize = true;
            radioButtonNotBondingCompatible.Location = new Point(32, 56);
            radioButtonNotBondingCompatible.Margin = new Padding(3, 2, 3, 2);
            radioButtonNotBondingCompatible.Name = "radioButtonNotBondingCompatible";
            radioButtonNotBondingCompatible.Size = new Size(39, 19);
            radioButtonNotBondingCompatible.TabIndex = 1;
            radioButtonNotBondingCompatible.TabStop = true;
            radioButtonNotBondingCompatible.Text = "no";
            radioButtonNotBondingCompatible.UseVisualStyleBackColor = true;
            // 
            // radioButtonBondingCompatible
            // 
            radioButtonBondingCompatible.AutoSize = true;
            radioButtonBondingCompatible.Location = new Point(32, 31);
            radioButtonBondingCompatible.Margin = new Padding(3, 2, 3, 2);
            radioButtonBondingCompatible.Name = "radioButtonBondingCompatible";
            radioButtonBondingCompatible.Size = new Size(42, 19);
            radioButtonBondingCompatible.TabIndex = 0;
            radioButtonBondingCompatible.TabStop = true;
            radioButtonBondingCompatible.Text = "yes";
            radioButtonBondingCompatible.UseVisualStyleBackColor = true;
            // 
            // groupBoxDentalStatus
            // 
            groupBoxDentalStatus.BackColor = Color.FromArgb(0, 192, 192);
            groupBoxDentalStatus.Controls.Add(radioButtonDentalStatusMacclusion);
            groupBoxDentalStatus.Controls.Add(radioButtonDentalStatusNormal);
            groupBoxDentalStatus.Location = new Point(696, 352);
            groupBoxDentalStatus.Margin = new Padding(3, 2, 3, 2);
            groupBoxDentalStatus.Name = "groupBoxDentalStatus";
            groupBoxDentalStatus.Padding = new Padding(3, 2, 3, 2);
            groupBoxDentalStatus.Size = new Size(169, 86);
            groupBoxDentalStatus.TabIndex = 13;
            groupBoxDentalStatus.TabStop = false;
            groupBoxDentalStatus.Text = "DentalStatus";
            groupBoxDentalStatus.Enter += groupBoxDentalStatus_Enter;
            // 
            // radioButtonDentalStatusMacclusion
            // 
            radioButtonDentalStatusMacclusion.AutoSize = true;
            radioButtonDentalStatusMacclusion.Location = new Point(18, 53);
            radioButtonDentalStatusMacclusion.Margin = new Padding(3, 2, 3, 2);
            radioButtonDentalStatusMacclusion.Name = "radioButtonDentalStatusMacclusion";
            radioButtonDentalStatusMacclusion.Size = new Size(86, 19);
            radioButtonDentalStatusMacclusion.TabIndex = 1;
            radioButtonDentalStatusMacclusion.TabStop = true;
            radioButtonDentalStatusMacclusion.Text = "Macclusion";
            radioButtonDentalStatusMacclusion.UseVisualStyleBackColor = true;
            // 
            // radioButtonDentalStatusNormal
            // 
            radioButtonDentalStatusNormal.AutoSize = true;
            radioButtonDentalStatusNormal.Location = new Point(18, 22);
            radioButtonDentalStatusNormal.Margin = new Padding(3, 2, 3, 2);
            radioButtonDentalStatusNormal.Name = "radioButtonDentalStatusNormal";
            radioButtonDentalStatusNormal.Size = new Size(65, 19);
            radioButtonDentalStatusNormal.TabIndex = 0;
            radioButtonDentalStatusNormal.TabStop = true;
            radioButtonDentalStatusNormal.Text = "Normal";
            radioButtonDentalStatusNormal.UseVisualStyleBackColor = true;
            // 
            // buttonAddPet
            // 
            buttonAddPet.BackColor = Color.Maroon;
            buttonAddPet.ForeColor = Color.White;
            buttonAddPet.Location = new Point(760, 251);
            buttonAddPet.Margin = new Padding(3, 2, 3, 2);
            buttonAddPet.Name = "buttonAddPet";
            buttonAddPet.Size = new Size(121, 59);
            buttonAddPet.TabIndex = 14;
            buttonAddPet.Text = "добавить питомца в приют";
            buttonAddPet.UseVisualStyleBackColor = false;
            buttonAddPet.Click += buttonAddPet_Click;
            // 
            // DeletePet
            // 
            DeletePet.BackgroundImage = (Image)resources.GetObject("DeletePet.BackgroundImage");
            DeletePet.Location = new Point(816, 12);
            DeletePet.Name = "DeletePet";
            DeletePet.Size = new Size(164, 89);
            DeletePet.TabIndex = 15;
            DeletePet.Text = "Вышвырнуть";
            DeletePet.UseVisualStyleBackColor = true;
            DeletePet.Click += DeletePet_Click;
            // 
            // Pets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 581);
            Controls.Add(DeletePet);
            Controls.Add(buttonAddPet);
            Controls.Add(groupBoxDentalStatus);
            Controls.Add(groupBoxBondingCompatible);
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
            Margin = new Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownDailyWalks).EndInit();
            groupBoxBondingCompatible.ResumeLayout(false);
            groupBoxBondingCompatible.PerformLayout();
            groupBoxDentalStatus.ResumeLayout(false);
            groupBoxDentalStatus.PerformLayout();
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
        //private RadioButton radioButton1;
    }
}