namespace gestLivres
{
    partial class formCategories
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
            gbListerCategories = new GroupBox();
            lstCategories = new ListBox();
            gbModifierSupprimerCategorie = new GroupBox();
            btnSupprimerCategorie = new Button();
            btnModifierCategorie = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            gb = new GroupBox();
            btnAjouterCategorie = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            gbListerCategories.SuspendLayout();
            gbModifierSupprimerCategorie.SuspendLayout();
            gb.SuspendLayout();
            SuspendLayout();
            // 
            // gbListerCategories
            // 
            gbListerCategories.Controls.Add(lstCategories);
            gbListerCategories.Font = new Font("Segoe UI", 10F);
            gbListerCategories.Location = new Point(18, 51);
            gbListerCategories.Name = "gbListerCategories";
            gbListerCategories.Size = new Size(345, 396);
            gbListerCategories.TabIndex = 0;
            gbListerCategories.TabStop = false;
            gbListerCategories.Text = "Sélectionner une catégorie";
            // 
            // lstCategories
            // 
            lstCategories.FormattingEnabled = true;
            lstCategories.ItemHeight = 23;
            lstCategories.Location = new Point(2, 43);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(343, 326);
            lstCategories.TabIndex = 0;
            // 
            // gbModifierSupprimerCategorie
            // 
            gbModifierSupprimerCategorie.Controls.Add(btnSupprimerCategorie);
            gbModifierSupprimerCategorie.Controls.Add(btnModifierCategorie);
            gbModifierSupprimerCategorie.Controls.Add(textBox1);
            gbModifierSupprimerCategorie.Controls.Add(label1);
            gbModifierSupprimerCategorie.Font = new Font("Segoe UI", 10F);
            gbModifierSupprimerCategorie.Location = new Point(396, 52);
            gbModifierSupprimerCategorie.Name = "gbModifierSupprimerCategorie";
            gbModifierSupprimerCategorie.Size = new Size(380, 189);
            gbModifierSupprimerCategorie.TabIndex = 1;
            gbModifierSupprimerCategorie.TabStop = false;
            gbModifierSupprimerCategorie.Text = "Modifier / Supprimer une catégorie";
            // 
            // btnSupprimerCategorie
            // 
            btnSupprimerCategorie.BackColor = Color.Lavender;
            btnSupprimerCategorie.FlatAppearance.BorderColor = Color.Blue;
            btnSupprimerCategorie.FlatStyle = FlatStyle.Flat;
            btnSupprimerCategorie.Font = new Font("Segoe UI", 10F);
            btnSupprimerCategorie.Location = new Point(203, 129);
            btnSupprimerCategorie.Name = "btnSupprimerCategorie";
            btnSupprimerCategorie.Size = new Size(154, 35);
            btnSupprimerCategorie.TabIndex = 3;
            btnSupprimerCategorie.Text = "Supprimer";
            btnSupprimerCategorie.UseVisualStyleBackColor = false;
            // 
            // btnModifierCategorie
            // 
            btnModifierCategorie.BackColor = Color.Lavender;
            btnModifierCategorie.FlatAppearance.BorderColor = Color.Blue;
            btnModifierCategorie.FlatStyle = FlatStyle.Flat;
            btnModifierCategorie.Font = new Font("Segoe UI", 10F);
            btnModifierCategorie.Location = new Point(23, 129);
            btnModifierCategorie.Name = "btnModifierCategorie";
            btnModifierCategorie.Size = new Size(154, 35);
            btnModifierCategorie.TabIndex = 2;
            btnModifierCategorie.Text = "Modifier";
            btnModifierCategorie.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(23, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 34);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(23, 39);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 0;
            label1.Text = "Catégorie";
            // 
            // gb
            // 
            gb.Controls.Add(btnAjouterCategorie);
            gb.Controls.Add(textBox2);
            gb.Controls.Add(label2);
            gb.Font = new Font("Segoe UI", 10F);
            gb.Location = new Point(398, 260);
            gb.Name = "gb";
            gb.Size = new Size(378, 178);
            gb.TabIndex = 2;
            gb.TabStop = false;
            gb.Text = "Ajouter une catégorie";
            // 
            // btnAjouterCategorie
            // 
            btnAjouterCategorie.BackColor = Color.Lavender;
            btnAjouterCategorie.FlatAppearance.BorderColor = Color.Blue;
            btnAjouterCategorie.FlatStyle = FlatStyle.Flat;
            btnAjouterCategorie.Font = new Font("Segoe UI", 10F);
            btnAjouterCategorie.Location = new Point(201, 116);
            btnAjouterCategorie.Name = "btnAjouterCategorie";
            btnAjouterCategorie.Size = new Size(154, 35);
            btnAjouterCategorie.TabIndex = 4;
            btnAjouterCategorie.Text = "Ajouter";
            btnAjouterCategorie.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(21, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 34);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(21, 33);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 2;
            label2.Text = "Catégorie";
            // 
            // formCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gb);
            Controls.Add(gbModifierSupprimerCategorie);
            Controls.Add(gbListerCategories);
            Name = "formCategories";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Les catégories de livres";
            gbListerCategories.ResumeLayout(false);
            gbModifierSupprimerCategorie.ResumeLayout(false);
            gbModifierSupprimerCategorie.PerformLayout();
            gb.ResumeLayout(false);
            gb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbListerCategories;
        private GroupBox gbModifierSupprimerCategorie;
        private GroupBox gb;
        private ListBox lstCategories;
        private Button btnModifierCategorie;
        private TextBox textBox1;
        private Label label1;
        private Button btnSupprimerCategorie;
        private TextBox textBox2;
        private Label label2;
        private Button btnAjouterCategorie;
    }
}