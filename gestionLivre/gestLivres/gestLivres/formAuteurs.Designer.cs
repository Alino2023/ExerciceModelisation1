namespace gestLivres
{
    partial class formAuteurs
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
            gbAjouterLivre = new GroupBox();
            btnAjouterAuteur = new Button();
            textBoxAuteur = new TextBox();
            label2 = new Label();
            gbModifierSupprimerLivre = new GroupBox();
            btnSupprimerAuteur = new Button();
            btnModifierAuteur = new Button();
            txtAuteur = new TextBox();
            label1 = new Label();
            gbListerCategories = new GroupBox();
            lstAuteurs = new ListBox();
            gbAjouterLivre.SuspendLayout();
            gbModifierSupprimerLivre.SuspendLayout();
            gbListerCategories.SuspendLayout();
            SuspendLayout();
            // 
            // gbAjouterLivre
            // 
            gbAjouterLivre.Controls.Add(btnAjouterAuteur);
            gbAjouterLivre.Controls.Add(textBoxAuteur);
            gbAjouterLivre.Controls.Add(label2);
            gbAjouterLivre.Font = new Font("Segoe UI", 10F);
            gbAjouterLivre.Location = new Point(401, 236);
            gbAjouterLivre.Name = "gbAjouterLivre";
            gbAjouterLivre.Size = new Size(378, 178);
            gbAjouterLivre.TabIndex = 5;
            gbAjouterLivre.TabStop = false;
            gbAjouterLivre.Text = "Ajouter un auteur";
            // 
            // btnAjouterAuteur
            // 
            btnAjouterAuteur.BackColor = Color.Lavender;
            btnAjouterAuteur.FlatAppearance.BorderColor = Color.Blue;
            btnAjouterAuteur.FlatStyle = FlatStyle.Flat;
            btnAjouterAuteur.Font = new Font("Segoe UI", 10F);
            btnAjouterAuteur.Location = new Point(201, 116);
            btnAjouterAuteur.Name = "btnAjouterAuteur";
            btnAjouterAuteur.Size = new Size(154, 35);
            btnAjouterAuteur.TabIndex = 4;
            btnAjouterAuteur.Text = "Ajouter";
            btnAjouterAuteur.UseVisualStyleBackColor = false;
            // 
            // textBoxAuteur
            // 
            textBoxAuteur.Font = new Font("Segoe UI", 12F);
            textBoxAuteur.Location = new Point(21, 59);
            textBoxAuteur.Name = "textBoxAuteur";
            textBoxAuteur.Size = new Size(334, 34);
            textBoxAuteur.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(21, 33);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 2;
            label2.Text = "Auteur.s";
            // 
            // gbModifierSupprimerLivre
            // 
            gbModifierSupprimerLivre.Controls.Add(btnSupprimerAuteur);
            gbModifierSupprimerLivre.Controls.Add(btnModifierAuteur);
            gbModifierSupprimerLivre.Controls.Add(txtAuteur);
            gbModifierSupprimerLivre.Controls.Add(label1);
            gbModifierSupprimerLivre.Font = new Font("Segoe UI", 10F);
            gbModifierSupprimerLivre.Location = new Point(399, 28);
            gbModifierSupprimerLivre.Name = "gbModifierSupprimerLivre";
            gbModifierSupprimerLivre.Size = new Size(380, 189);
            gbModifierSupprimerLivre.TabIndex = 4;
            gbModifierSupprimerLivre.TabStop = false;
            gbModifierSupprimerLivre.Text = "Modifier / Supprimer un auteur";
            // 
            // btnSupprimerAuteur
            // 
            btnSupprimerAuteur.BackColor = Color.Lavender;
            btnSupprimerAuteur.FlatAppearance.BorderColor = Color.Blue;
            btnSupprimerAuteur.FlatStyle = FlatStyle.Flat;
            btnSupprimerAuteur.Font = new Font("Segoe UI", 10F);
            btnSupprimerAuteur.Location = new Point(203, 129);
            btnSupprimerAuteur.Name = "btnSupprimerAuteur";
            btnSupprimerAuteur.Size = new Size(154, 35);
            btnSupprimerAuteur.TabIndex = 3;
            btnSupprimerAuteur.Text = "Supprimer";
            btnSupprimerAuteur.UseVisualStyleBackColor = false;
            // 
            // btnModifierAuteur
            // 
            btnModifierAuteur.BackColor = Color.Lavender;
            btnModifierAuteur.FlatAppearance.BorderColor = Color.Blue;
            btnModifierAuteur.FlatStyle = FlatStyle.Flat;
            btnModifierAuteur.Font = new Font("Segoe UI", 10F);
            btnModifierAuteur.Location = new Point(23, 129);
            btnModifierAuteur.Name = "btnModifierAuteur";
            btnModifierAuteur.Size = new Size(154, 35);
            btnModifierAuteur.TabIndex = 2;
            btnModifierAuteur.Text = "Modifier";
            btnModifierAuteur.UseVisualStyleBackColor = false;
            // 
            // txtAuteur
            // 
            txtAuteur.Font = new Font("Segoe UI", 12F);
            txtAuteur.Location = new Point(23, 65);
            txtAuteur.Name = "txtAuteur";
            txtAuteur.Size = new Size(334, 34);
            txtAuteur.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(23, 39);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 0;
            label1.Text = "Auteur.s";
            // 
            // gbListerCategories
            // 
            gbListerCategories.Controls.Add(lstAuteurs);
            gbListerCategories.Font = new Font("Segoe UI", 10F);
            gbListerCategories.Location = new Point(21, 27);
            gbListerCategories.Name = "gbListerCategories";
            gbListerCategories.Size = new Size(345, 396);
            gbListerCategories.TabIndex = 3;
            gbListerCategories.TabStop = false;
            gbListerCategories.Text = "Sélectionner un auteur";
            // 
            // lstAuteurs
            // 
            lstAuteurs.FormattingEnabled = true;
            lstAuteurs.ItemHeight = 23;
            lstAuteurs.Location = new Point(2, 43);
            lstAuteurs.Name = "lstAuteurs";
            lstAuteurs.Size = new Size(343, 326);
            lstAuteurs.TabIndex = 0;
            // 
            // formAuteurs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbAjouterLivre);
            Controls.Add(gbModifierSupprimerLivre);
            Controls.Add(gbListerCategories);
            Name = "formAuteurs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nos auteurs";
            gbAjouterLivre.ResumeLayout(false);
            gbAjouterLivre.PerformLayout();
            gbModifierSupprimerLivre.ResumeLayout(false);
            gbModifierSupprimerLivre.PerformLayout();
            gbListerCategories.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAjouterLivre;
        private Button btnAjouterAuteur;
        private TextBox textBoxAuteur;
        private Label label2;
        private GroupBox gbModifierSupprimerLivre;
        private Button btnSupprimerAuteur;
        private Button btnModifierAuteur;
        private TextBox txtAuteur;
        private Label label1;
        private GroupBox gbListerCategories;
        private ListBox lstAuteurs;
    }
}