namespace gestLivres
{
    partial class formMenu
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
            panelMenu = new Panel();
            btnCategories = new Button();
            btnAuteurs = new Button();
            btnLivres = new Button();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            livresToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            auteursToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem1 = new ToolStripMenuItem();
            modifierToolStripMenuItem1 = new ToolStripMenuItem();
            supprimerToolStripMenuItem1 = new ToolStripMenuItem();
            catégoriesToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem2 = new ToolStripMenuItem();
            modifierToolStripMenuItem2 = new ToolStripMenuItem();
            supprimerToolStripMenuItem2 = new ToolStripMenuItem();
            panelMenu.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.Window;
            panelMenu.Controls.Add(btnCategories);
            panelMenu.Controls.Add(btnAuteurs);
            panelMenu.Controls.Add(btnLivres);
            panelMenu.Location = new Point(-1, 91);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(267, 362);
            panelMenu.TabIndex = 0;
            // 
            // btnCategories
            // 
            btnCategories.Location = new Point(0, 213);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(267, 56);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "Catégories de livres";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnAuteurs
            // 
            btnAuteurs.Location = new Point(0, 151);
            btnAuteurs.Name = "btnAuteurs";
            btnAuteurs.Size = new Size(267, 56);
            btnAuteurs.TabIndex = 1;
            btnAuteurs.Text = "Les Auteurs";
            btnAuteurs.UseVisualStyleBackColor = true;
            btnAuteurs.Click += btnAuteurs_Click;
            // 
            // btnLivres
            // 
            btnLivres.Location = new Point(0, 89);
            btnLivres.Name = "btnLivres";
            btnLivres.Size = new Size(267, 56);
            btnLivres.TabIndex = 0;
            btnLivres.Text = "Nos Livres";
            btnLivres.UseVisualStyleBackColor = true;
            btnLivres.Click += btnLivres_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { livresToolStripMenuItem, auteursToolStripMenuItem, catégoriesToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // livresToolStripMenuItem
            // 
            livresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem, modifierToolStripMenuItem, supprimerToolStripMenuItem });
            livresToolStripMenuItem.Name = "livresToolStripMenuItem";
            livresToolStripMenuItem.Size = new Size(60, 24);
            livresToolStripMenuItem.Text = "Livres";
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(161, 26);
            ajouterToolStripMenuItem.Text = "Ajouter";
            ajouterToolStripMenuItem.Click += ajouterToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(161, 26);
            modifierToolStripMenuItem.Text = "Modifier";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(161, 26);
            supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // auteursToolStripMenuItem
            // 
            auteursToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem1, modifierToolStripMenuItem1, supprimerToolStripMenuItem1 });
            auteursToolStripMenuItem.Name = "auteursToolStripMenuItem";
            auteursToolStripMenuItem.Size = new Size(73, 24);
            auteursToolStripMenuItem.Text = "Auteurs";
            // 
            // ajouterToolStripMenuItem1
            // 
            ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            ajouterToolStripMenuItem1.Size = new Size(224, 26);
            ajouterToolStripMenuItem1.Text = "Ajouter";
            ajouterToolStripMenuItem1.Click += ajouterToolStripMenuItem1_Click;
            // 
            // modifierToolStripMenuItem1
            // 
            modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            modifierToolStripMenuItem1.Size = new Size(224, 26);
            modifierToolStripMenuItem1.Text = "Modifier";
            modifierToolStripMenuItem1.Click += modifierToolStripMenuItem1_Click;
            // 
            // supprimerToolStripMenuItem1
            // 
            supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            supprimerToolStripMenuItem1.Size = new Size(224, 26);
            supprimerToolStripMenuItem1.Text = "Supprimer";
            // 
            // catégoriesToolStripMenuItem
            // 
            catégoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem2, modifierToolStripMenuItem2, supprimerToolStripMenuItem2 });
            catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            catégoriesToolStripMenuItem.Size = new Size(94, 24);
            catégoriesToolStripMenuItem.Text = "Catégories";
            // 
            // ajouterToolStripMenuItem2
            // 
            ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            ajouterToolStripMenuItem2.Size = new Size(224, 26);
            ajouterToolStripMenuItem2.Text = "Ajouter";
            ajouterToolStripMenuItem2.Click += ajouterToolStripMenuItem2_Click;
            // 
            // modifierToolStripMenuItem2
            // 
            modifierToolStripMenuItem2.Name = "modifierToolStripMenuItem2";
            modifierToolStripMenuItem2.Size = new Size(224, 26);
            modifierToolStripMenuItem2.Text = "Modifier";
            modifierToolStripMenuItem2.Click += modifierToolStripMenuItem2_Click;
            // 
            // supprimerToolStripMenuItem2
            // 
            supprimerToolStripMenuItem2.Name = "supprimerToolStripMenuItem2";
            supprimerToolStripMenuItem2.Size = new Size(224, 26);
            supprimerToolStripMenuItem2.Text = "Supprimer";
            // 
            // formMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "formMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accueil";
            panelMenu.ResumeLayout(false);
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button btnCategories;
        private Button btnAuteurs;
        private Button btnLivres;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem livresToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private ToolStripMenuItem auteursToolStripMenuItem;
        private ToolStripMenuItem catégoriesToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem1;
        private ToolStripMenuItem modifierToolStripMenuItem1;
        private ToolStripMenuItem supprimerToolStripMenuItem1;
        private ToolStripMenuItem ajouterToolStripMenuItem2;
        private ToolStripMenuItem modifierToolStripMenuItem2;
        private ToolStripMenuItem supprimerToolStripMenuItem2;
    }
}