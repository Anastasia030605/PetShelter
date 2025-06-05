namespace PetShelter
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            dataBaseBindingSource = new BindingSource(components);
            comboBoxShelters = new ComboBox();
            textBoxSelectShelter = new TextBox();
            textBoxSelectPetType = new TextBox();
            comboBoxPetType = new ComboBox();
            buttonShowPets = new Button();
            comboBoxClaustrophobiaFilter = new ComboBox();
            comboBoxOpenSpace = new ComboBox();
            comboBoxSelectExtention = new ComboBox();
            buttonSerializer = new Button();
            buttonConvert = new Button();
            ((System.ComponentModel.ISupportInitialize)dataBaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataBaseBindingSource
            // 
            dataBaseBindingSource.DataSource = typeof(Model.Core.DataBase);
            // 
            // comboBoxShelters
            // 
            comboBoxShelters.FormattingEnabled = true;
            comboBoxShelters.Location = new Point(213, 41);
            comboBoxShelters.Name = "comboBoxShelters";
            comboBoxShelters.Size = new Size(151, 28);
            comboBoxShelters.TabIndex = 0;
            comboBoxShelters.Text = "имя приюта";
            comboBoxShelters.SelectedIndexChanged += comboBoxShelters_SelectedIndexChanged;
            // 
            // textBoxSelectShelter
            // 
            textBoxSelectShelter.Location = new Point(11, 43);
            textBoxSelectShelter.Name = "textBoxSelectShelter";
            textBoxSelectShelter.Size = new Size(185, 27);
            textBoxSelectShelter.TabIndex = 1;
            textBoxSelectShelter.Text = "Выберите приют";
            // 
            // textBoxSelectPetType
            // 
            textBoxSelectPetType.Location = new Point(11, 119);
            textBoxSelectPetType.Name = "textBoxSelectPetType";
            textBoxSelectPetType.Size = new Size(183, 27);
            textBoxSelectPetType.TabIndex = 2;
            textBoxSelectPetType.Text = "Выберите вид животного";
            // 
            // comboBoxPetType
            // 
            comboBoxPetType.FormattingEnabled = true;
            comboBoxPetType.Location = new Point(213, 117);
            comboBoxPetType.Name = "comboBoxPetType";
            comboBoxPetType.Size = new Size(151, 28);
            comboBoxPetType.TabIndex = 3;
            comboBoxPetType.Text = "вид животного";
            comboBoxPetType.SelectedIndexChanged += comboBoxPetType_SelectedIndexChanged;
            // 
            // buttonShowPets
            // 
            buttonShowPets.Location = new Point(582, 276);
            buttonShowPets.Name = "buttonShowPets";
            buttonShowPets.Size = new Size(142, 64);
            buttonShowPets.TabIndex = 4;
            buttonShowPets.Text = "Показать питомцев";
            buttonShowPets.UseVisualStyleBackColor = true;
            buttonShowPets.Click += buttonShowPets_Click;
            // 
            // comboBoxClaustrophobiaFilter
            // 
            comboBoxClaustrophobiaFilter.FormattingEnabled = true;
            comboBoxClaustrophobiaFilter.Location = new Point(371, 119);
            comboBoxClaustrophobiaFilter.Margin = new Padding(3, 4, 3, 4);
            comboBoxClaustrophobiaFilter.Name = "comboBoxClaustrophobiaFilter";
            comboBoxClaustrophobiaFilter.Size = new Size(195, 28);
            comboBoxClaustrophobiaFilter.TabIndex = 5;
            comboBoxClaustrophobiaFilter.Text = "наличие клаустрофобии";
            comboBoxClaustrophobiaFilter.SelectedIndexChanged += comboBoxClaustrophobiaFilter_SelectedIndexChanged;
            // 
            // comboBoxOpenSpace
            // 
            comboBoxOpenSpace.FormattingEnabled = true;
            comboBoxOpenSpace.Location = new Point(371, 41);
            comboBoxOpenSpace.Margin = new Padding(3, 4, 3, 4);
            comboBoxOpenSpace.Name = "comboBoxOpenSpace";
            comboBoxOpenSpace.Size = new Size(195, 28);
            comboBoxOpenSpace.TabIndex = 6;
            comboBoxOpenSpace.Text = "наличие открытого места";
            comboBoxOpenSpace.SelectedIndexChanged += comboBoxOpenSpace_SelectedIndexChanged;
            // 
            // comboBoxSelectExtention
            // 
            comboBoxSelectExtention.BackColor = Color.MediumPurple;
            comboBoxSelectExtention.FormattingEnabled = true;
            comboBoxSelectExtention.Location = new Point(307, 185);
            comboBoxSelectExtention.Name = "comboBoxSelectExtention";
            comboBoxSelectExtention.Size = new Size(196, 28);
            comboBoxSelectExtention.TabIndex = 7;
            comboBoxSelectExtention.Text = "выберите расширение";
            comboBoxSelectExtention.SelectedIndexChanged += comboBoxSelectExtention_SelectedIndexChanged;
            // 
            // buttonSerializer
            // 
            buttonSerializer.BackColor = SystemColors.Info;
            buttonSerializer.Location = new Point(195, 276);
            buttonSerializer.Name = "buttonSerializer";
            buttonSerializer.Size = new Size(106, 64);
            buttonSerializer.TabIndex = 8;
            buttonSerializer.Text = "Сохранить изменения";
            buttonSerializer.UseVisualStyleBackColor = false;
            buttonSerializer.Click += buttonSerializer_Click;
            // 
            // buttonConvert
            // 
            buttonConvert.BackColor = Color.SlateBlue;
            buttonConvert.Location = new Point(105, 184);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(196, 29);
            buttonConvert.TabIndex = 9;
            buttonConvert.Text = "Convert All Files To";
            buttonConvert.UseVisualStyleBackColor = false;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 504);
            Controls.Add(buttonConvert);
            Controls.Add(buttonSerializer);
            Controls.Add(comboBoxSelectExtention);
            Controls.Add(comboBoxOpenSpace);
            Controls.Add(comboBoxClaustrophobiaFilter);
            Controls.Add(buttonShowPets);
            Controls.Add(comboBoxPetType);
            Controls.Add(textBoxSelectPetType);
            Controls.Add(textBoxSelectShelter);
            Controls.Add(comboBoxShelters);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)dataBaseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource dataBaseBindingSource;
        protected ComboBox comboBoxShelters;
        private TextBox textBoxSelectShelter;
        private TextBox textBoxSelectPetType;
        private ComboBox comboBoxPetType;
        private Button buttonShowPets;
        private ComboBox comboBoxClaustrophobiaFilter;
        private ComboBox comboBoxOpenSpace;
        private ComboBox comboBoxSelectExtention;
        private Button buttonSerializer;
        private Button buttonConvert;
    }
}