namespace gestLivres
{
    partial class formLivre
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
            tabControlBibliotheque = new TabControl();
            tabLivres = new TabPage();
            btnAjoutLivre = new Button();
            txtLivre = new TextBox();
            lstLivres = new ListBox();
            tabAuteurs = new TabPage();
            tabCategories = new TabPage();
            tabControlBibliotheque.SuspendLayout();
            tabLivres.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlBibliotheque
            // 
            tabControlBibliotheque.Controls.Add(tabLivres);
            tabControlBibliotheque.Controls.Add(tabAuteurs);
            tabControlBibliotheque.Controls.Add(tabCategories);
            tabControlBibliotheque.Location = new Point(8, 11);
            tabControlBibliotheque.Name = "tabControlBibliotheque";
            tabControlBibliotheque.SelectedIndex = 0;
            tabControlBibliotheque.Size = new Size(788, 438);
            tabControlBibliotheque.TabIndex = 0;
            // 
            // tabLivres
            // 
            tabLivres.Controls.Add(btnAjoutLivre);
            tabLivres.Controls.Add(txtLivre);
            tabLivres.Controls.Add(lstLivres);
            tabLivres.Location = new Point(4, 29);
            tabLivres.Name = "tabLivres";
            tabLivres.Padding = new Padding(3);
            tabLivres.Size = new Size(780, 405);
            tabLivres.TabIndex = 0;
            tabLivres.Text = "Livres";
            tabLivres.UseVisualStyleBackColor = true;
            tabLivres.Click += tabLivres_Click;
            // 
            // btnAjoutLivre
            // 
            btnAjoutLivre.Location = new Point(221, 18);
            btnAjoutLivre.Name = "btnAjoutLivre";
            btnAjoutLivre.Size = new Size(106, 27);
            btnAjoutLivre.TabIndex = 2;
            btnAjoutLivre.Text = "Ajouter";
            btnAjoutLivre.UseVisualStyleBackColor = true;
            // 
            // txtLivre
            // 
            txtLivre.Location = new Point(21, 18);
            txtLivre.Name = "txtLivre";
            txtLivre.Size = new Size(194, 27);
            txtLivre.TabIndex = 1;
            // 
            // lstLivres
            // 
            lstLivres.FormattingEnabled = true;
            lstLivres.Location = new Point(6, 110);
            lstLivres.Name = "lstLivres";
            lstLivres.Size = new Size(768, 284);
            lstLivres.TabIndex = 0;
            // 
            // tabAuteurs
            // 
            tabAuteurs.Location = new Point(4, 29);
            tabAuteurs.Name = "tabAuteurs";
            tabAuteurs.Padding = new Padding(3);
            tabAuteurs.Size = new Size(780, 405);
            tabAuteurs.TabIndex = 1;
            tabAuteurs.Text = "Auteurs";
            tabAuteurs.UseVisualStyleBackColor = true;
            // 
            // tabCategories
            // 
            tabCategories.Location = new Point(4, 29);
            tabCategories.Name = "tabCategories";
            tabCategories.Padding = new Padding(3);
            tabCategories.Size = new Size(780, 405);
            tabCategories.TabIndex = 2;
            tabCategories.Text = "Categories";
            tabCategories.UseVisualStyleBackColor = true;
            tabCategories.Click += tabCategories_Click;
            // 
            // formLivre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlBibliotheque);
            Name = "formLivre";
            Text = "Bibliotheque";
            tabControlBibliotheque.ResumeLayout(false);
            tabLivres.ResumeLayout(false);
            tabLivres.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlBibliotheque;
        private TabPage tabLivres;
        private TabPage tabAuteurs;
        private ListBox lstLivres;
        private TabPage tabCategories;
        private Button btnAjoutLivre;
        private TextBox txtLivre;
    }
}