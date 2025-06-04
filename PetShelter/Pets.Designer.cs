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
            dataGridViewPets = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPets).BeginInit();
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
            // Pets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 497);
            Controls.Add(dataGridViewPets);
            Name = "Pets";
            Text = "Pets";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPets;
    }
}