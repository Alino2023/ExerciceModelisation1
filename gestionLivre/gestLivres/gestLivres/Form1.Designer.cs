namespace gestLivres
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnListeLivres = new Button();
            btnAjoutLivre = new Button();
            btnSupLivre = new Button();
            btnModifierLivre = new Button();
            gbLivres = new GroupBox();
            gbAuteurs = new GroupBox();
            btnListeAuteurs = new Button();
            btnSupAuteur = new Button();
            btnAjoutAuteur = new Button();
            btnModifierAuteur = new Button();
            gbCategories = new GroupBox();
            btnListeCatégories = new Button();
            btnSupCategorie = new Button();
            button7 = new Button();
            btnModifierCategorie = new Button();
            gbLivres.SuspendLayout();
            gbAuteurs.SuspendLayout();
            gbCategories.SuspendLayout();
            SuspendLayout();
            // 
            // btnListeLivres
            // 
            btnListeLivres.Location = new Point(17, 37);
            btnListeLivres.Name = "btnListeLivres";
            btnListeLivres.Size = new Size(141, 29);
            btnListeLivres.TabIndex = 0;
            btnListeLivres.Text = "Afficher Livres";
            btnListeLivres.UseVisualStyleBackColor = true;
            btnListeLivres.Click += btnListeLivres_Click;
            // 
            // btnAjoutLivre
            // 
            btnAjoutLivre.Location = new Point(17, 72);
            btnAjoutLivre.Name = "btnAjoutLivre";
            btnAjoutLivre.Size = new Size(141, 29);
            btnAjoutLivre.TabIndex = 1;
            btnAjoutLivre.Text = "Enregistrer Livre(s)";
            btnAjoutLivre.UseVisualStyleBackColor = true;
            // 
            // btnSupLivre
            // 
            btnSupLivre.Location = new Point(17, 142);
            btnSupLivre.Name = "btnSupLivre";
            btnSupLivre.Size = new Size(141, 29);
            btnSupLivre.TabIndex = 3;
            btnSupLivre.Text = "Supprimer Livre";
            btnSupLivre.UseVisualStyleBackColor = true;
            // 
            // btnModifierLivre
            // 
            btnModifierLivre.Location = new Point(17, 107);
            btnModifierLivre.Name = "btnModifierLivre";
            btnModifierLivre.Size = new Size(141, 29);
            btnModifierLivre.TabIndex = 2;
            btnModifierLivre.Text = "Modifier Livre";
            btnModifierLivre.UseVisualStyleBackColor = true;
            // 
            // gbLivres
            // 
            gbLivres.Controls.Add(btnListeLivres);
            gbLivres.Controls.Add(btnSupLivre);
            gbLivres.Controls.Add(btnAjoutLivre);
            gbLivres.Controls.Add(btnModifierLivre);
            gbLivres.Location = new Point(91, 66);
            gbLivres.Name = "gbLivres";
            gbLivres.Size = new Size(179, 184);
            gbLivres.TabIndex = 4;
            gbLivres.TabStop = false;
            gbLivres.Text = "Les Livres";
            // 
            // gbAuteurs
            // 
            gbAuteurs.Controls.Add(btnListeAuteurs);
            gbAuteurs.Controls.Add(btnSupAuteur);
            gbAuteurs.Controls.Add(btnAjoutAuteur);
            gbAuteurs.Controls.Add(btnModifierAuteur);
            gbAuteurs.Location = new Point(307, 66);
            gbAuteurs.Name = "gbAuteurs";
            gbAuteurs.Size = new Size(198, 184);
            gbAuteurs.TabIndex = 5;
            gbAuteurs.TabStop = false;
            gbAuteurs.Text = "Les Auteurs";
            // 
            // btnListeAuteurs
            // 
            btnListeAuteurs.Location = new Point(17, 37);
            btnListeAuteurs.Name = "btnListeAuteurs";
            btnListeAuteurs.Size = new Size(159, 29);
            btnListeAuteurs.TabIndex = 0;
            btnListeAuteurs.Text = "Afficher Auteurs";
            btnListeAuteurs.UseVisualStyleBackColor = true;
            // 
            // btnSupAuteur
            // 
            btnSupAuteur.Location = new Point(17, 142);
            btnSupAuteur.Name = "btnSupAuteur";
            btnSupAuteur.Size = new Size(159, 29);
            btnSupAuteur.TabIndex = 3;
            btnSupAuteur.Text = "Supprimer Auteur";
            btnSupAuteur.UseVisualStyleBackColor = true;
            // 
            // btnAjoutAuteur
            // 
            btnAjoutAuteur.Location = new Point(17, 72);
            btnAjoutAuteur.Name = "btnAjoutAuteur";
            btnAjoutAuteur.Size = new Size(159, 29);
            btnAjoutAuteur.TabIndex = 1;
            btnAjoutAuteur.Text = "Enregistrer Auteur(s)";
            btnAjoutAuteur.UseVisualStyleBackColor = true;
            // 
            // btnModifierAuteur
            // 
            btnModifierAuteur.Location = new Point(17, 107);
            btnModifierAuteur.Name = "btnModifierAuteur";
            btnModifierAuteur.Size = new Size(159, 29);
            btnModifierAuteur.TabIndex = 2;
            btnModifierAuteur.Text = "Modifier Auteur";
            btnModifierAuteur.UseVisualStyleBackColor = true;
            // 
            // gbCategories
            // 
            gbCategories.Controls.Add(btnListeCatégories);
            gbCategories.Controls.Add(btnSupCategorie);
            gbCategories.Controls.Add(button7);
            gbCategories.Controls.Add(btnModifierCategorie);
            gbCategories.Location = new Point(528, 66);
            gbCategories.Name = "gbCategories";
            gbCategories.Size = new Size(210, 184);
            gbCategories.TabIndex = 5;
            gbCategories.TabStop = false;
            gbCategories.Text = "Les Catégories";
            // 
            // btnListeCatégories
            // 
            btnListeCatégories.Location = new Point(17, 37);
            btnListeCatégories.Name = "btnListeCatégories";
            btnListeCatégories.Size = new Size(175, 29);
            btnListeCatégories.TabIndex = 0;
            btnListeCatégories.Text = "Afficher Catégories";
            btnListeCatégories.UseVisualStyleBackColor = true;
            // 
            // btnSupCategorie
            // 
            btnSupCategorie.Location = new Point(17, 142);
            btnSupCategorie.Name = "btnSupCategorie";
            btnSupCategorie.Size = new Size(175, 29);
            btnSupCategorie.TabIndex = 3;
            btnSupCategorie.Text = "Supprimer Catégorie";
            btnSupCategorie.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(17, 72);
            button7.Name = "button7";
            button7.Size = new Size(175, 29);
            button7.TabIndex = 1;
            button7.Text = "Enregistrer Catégorie(s)";
            button7.UseVisualStyleBackColor = true;
            // 
            // btnModifierCategorie
            // 
            btnModifierCategorie.Location = new Point(17, 107);
            btnModifierCategorie.Name = "btnModifierCategorie";
            btnModifierCategorie.Size = new Size(175, 29);
            btnModifierCategorie.TabIndex = 2;
            btnModifierCategorie.Text = "Modifier Catégorie";
            btnModifierCategorie.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 302);
            Controls.Add(gbCategories);
            Controls.Add(gbAuteurs);
            Controls.Add(gbLivres);
            Name = "Form1";
            Text = "Form1";
            gbLivres.ResumeLayout(false);
            gbAuteurs.ResumeLayout(false);
            gbCategories.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnListeLivres;
        private Button btnAjoutLivre;
        private Button btnSupLivre;
        private Button btnModifierLivre;
        private GroupBox gbLivres;
        private GroupBox gbAuteurs;
        private Button btnListeAuteurs;
        private Button btnSupAuteur;
        private Button btnAjoutAuteur;
        private Button btnModifierAuteur;
        private GroupBox gbCategories;
        private Button btnListeCatégories;
        private Button btnSupCategorie;
        private Button button7;
        private Button btnModifierCategorie;
    }
}
