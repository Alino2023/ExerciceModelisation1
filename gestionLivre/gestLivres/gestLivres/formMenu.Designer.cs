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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            livresToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            catégoriesToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem2 = new ToolStripMenuItem();
            modifierToolStripMenuItem2 = new ToolStripMenuItem();
            auteursToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem1 = new ToolStripMenuItem();
            modifierToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(671, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { livresToolStripMenuItem, catégoriesToolStripMenuItem, auteursToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(671, 28);
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
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(161, 26);
            supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // catégoriesToolStripMenuItem
            // 
            catégoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem2, modifierToolStripMenuItem2 });
            catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            catégoriesToolStripMenuItem.Size = new Size(73, 24);
            catégoriesToolStripMenuItem.Text = "Auteurs";
            // 
            // ajouterToolStripMenuItem2
            // 
            ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            ajouterToolStripMenuItem2.Size = new Size(232, 26);
            ajouterToolStripMenuItem2.Text = "Ajouter";
            ajouterToolStripMenuItem2.Click += ajouterToolStripMenuItem2_Click;
            // 
            // modifierToolStripMenuItem2
            // 
            modifierToolStripMenuItem2.Name = "modifierToolStripMenuItem2";
            modifierToolStripMenuItem2.Size = new Size(232, 26);
            modifierToolStripMenuItem2.Text = "Modifier / Supprimer";
            modifierToolStripMenuItem2.Click += modifierToolStripMenuItem2_Click;
            // 
            // auteursToolStripMenuItem
            // 
            auteursToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem1, modifierToolStripMenuItem1 });
            auteursToolStripMenuItem.Name = "auteursToolStripMenuItem";
            auteursToolStripMenuItem.Size = new Size(94, 24);
            auteursToolStripMenuItem.Text = "Catégories";
            // 
            // ajouterToolStripMenuItem1
            // 
            ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            ajouterToolStripMenuItem1.Size = new Size(232, 26);
            ajouterToolStripMenuItem1.Text = "Ajouter";
            ajouterToolStripMenuItem1.Click += ajouterToolStripMenuItem1_Click;
            // 
            // modifierToolStripMenuItem1
            // 
            modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            modifierToolStripMenuItem1.Size = new Size(232, 26);
            modifierToolStripMenuItem1.Text = "Modifier / Supprimer";
            modifierToolStripMenuItem1.Click += modifierToolStripMenuItem1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(182, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // formMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "formMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accueil";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private ToolStripMenuItem ajouterToolStripMenuItem2;
        private ToolStripMenuItem modifierToolStripMenuItem2;
        private PictureBox pictureBox1;
    }
}