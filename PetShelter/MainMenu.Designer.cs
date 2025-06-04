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
            comboBoxShelters.Location = new Point(212, 41);
            comboBoxShelters.Name = "comboBoxShelters";
            comboBoxShelters.Size = new Size(151, 28);
            comboBoxShelters.TabIndex = 0;
            comboBoxShelters.Text = "имя приюта";
            comboBoxShelters.SelectedIndexChanged += comboBoxShelters_SelectedIndexChanged;
            // 
            // textBoxSelectShelter
            // 
            textBoxSelectShelter.Location = new Point(68, 42);
            textBoxSelectShelter.Name = "textBoxSelectShelter";
            textBoxSelectShelter.Size = new Size(127, 27);
            textBoxSelectShelter.TabIndex = 1;
            textBoxSelectShelter.Text = "Выберите приют";
            // 
            // textBoxSelectPetType
            // 
            textBoxSelectPetType.Location = new Point(12, 119);
            textBoxSelectPetType.Name = "textBoxSelectPetType";
            textBoxSelectPetType.Size = new Size(183, 27);
            textBoxSelectPetType.TabIndex = 2;
            textBoxSelectPetType.Text = "Выберите вид животного";
            // 
            // comboBoxPetType
            // 
            comboBoxPetType.FormattingEnabled = true;
            comboBoxPetType.Location = new Point(212, 118);
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
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 504);
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
    }
}