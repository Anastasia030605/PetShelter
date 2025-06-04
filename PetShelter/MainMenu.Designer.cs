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
            comboBoxShelters.Location = new Point(186, 31);
            comboBoxShelters.Margin = new Padding(3, 2, 3, 2);
            comboBoxShelters.Name = "comboBoxShelters";
            comboBoxShelters.Size = new Size(133, 23);
            comboBoxShelters.TabIndex = 0;
            comboBoxShelters.Text = "имя приюта";
            comboBoxShelters.SelectedIndexChanged += comboBoxShelters_SelectedIndexChanged;
            // 
            // textBoxSelectShelter
            // 
            textBoxSelectShelter.Location = new Point(10, 32);
            textBoxSelectShelter.Margin = new Padding(3, 2, 3, 2);
            textBoxSelectShelter.Name = "textBoxSelectShelter";
            textBoxSelectShelter.Size = new Size(162, 23);
            textBoxSelectShelter.TabIndex = 1;
            textBoxSelectShelter.Text = "Выберите приют";
            // 
            // textBoxSelectPetType
            // 
            textBoxSelectPetType.Location = new Point(10, 89);
            textBoxSelectPetType.Margin = new Padding(3, 2, 3, 2);
            textBoxSelectPetType.Name = "textBoxSelectPetType";
            textBoxSelectPetType.Size = new Size(161, 23);
            textBoxSelectPetType.TabIndex = 2;
            textBoxSelectPetType.Text = "Выберите вид животного";
            // 
            // comboBoxPetType
            // 
            comboBoxPetType.FormattingEnabled = true;
            comboBoxPetType.Location = new Point(186, 88);
            comboBoxPetType.Margin = new Padding(3, 2, 3, 2);
            comboBoxPetType.Name = "comboBoxPetType";
            comboBoxPetType.Size = new Size(133, 23);
            comboBoxPetType.TabIndex = 3;
            comboBoxPetType.Text = "вид животного";
            comboBoxPetType.SelectedIndexChanged += comboBoxPetType_SelectedIndexChanged;
            // 
            // buttonShowPets
            // 
            buttonShowPets.Location = new Point(509, 207);
            buttonShowPets.Margin = new Padding(3, 2, 3, 2);
            buttonShowPets.Name = "buttonShowPets";
            buttonShowPets.Size = new Size(124, 48);
            buttonShowPets.TabIndex = 4;
            buttonShowPets.Text = "Показать питомцев";
            buttonShowPets.UseVisualStyleBackColor = true;
            buttonShowPets.Click += buttonShowPets_Click;
            // 
            // comboBoxClaustrophobiaFilter
            // 
            comboBoxClaustrophobiaFilter.FormattingEnabled = true;
            comboBoxClaustrophobiaFilter.Location = new Point(325, 89);
            comboBoxClaustrophobiaFilter.Name = "comboBoxClaustrophobiaFilter";
            comboBoxClaustrophobiaFilter.Size = new Size(171, 23);
            comboBoxClaustrophobiaFilter.TabIndex = 5;
            comboBoxClaustrophobiaFilter.Text = "наличие клаустрофобии";
            comboBoxClaustrophobiaFilter.SelectedIndexChanged += comboBoxClaustrophobiaFilter_SelectedIndexChanged;
            // 
            // comboBoxOpenSpace
            // 
            comboBoxOpenSpace.FormattingEnabled = true;
            comboBoxOpenSpace.Location = new Point(325, 31);
            comboBoxOpenSpace.Name = "comboBoxOpenSpace";
            comboBoxOpenSpace.Size = new Size(171, 23);
            comboBoxOpenSpace.TabIndex = 6;
            comboBoxOpenSpace.Text = "наличие открытого места";
            comboBoxOpenSpace.SelectedIndexChanged += comboBoxOpenSpace_SelectedIndexChanged;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 378);
            Controls.Add(comboBoxOpenSpace);
            Controls.Add(comboBoxClaustrophobiaFilter);
            Controls.Add(buttonShowPets);
            Controls.Add(comboBoxPetType);
            Controls.Add(textBoxSelectPetType);
            Controls.Add(textBoxSelectShelter);
            Controls.Add(comboBoxShelters);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}