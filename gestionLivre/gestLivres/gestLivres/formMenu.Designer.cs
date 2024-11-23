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
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.Window;
            panelMenu.Controls.Add(btnCategories);
            panelMenu.Controls.Add(btnAuteurs);
            panelMenu.Controls.Add(btnLivres);
            panelMenu.Location = new Point(-1, 1);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(267, 452);
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
            // 
            // btnAuteurs
            // 
            btnAuteurs.Location = new Point(0, 151);
            btnAuteurs.Name = "btnAuteurs";
            btnAuteurs.Size = new Size(267, 56);
            btnAuteurs.TabIndex = 1;
            btnAuteurs.Text = "Les Auteurs";
            btnAuteurs.UseVisualStyleBackColor = true;
            // 
            // btnLivres
            // 
            btnLivres.Location = new Point(0, 89);
            btnLivres.Name = "btnLivres";
            btnLivres.Size = new Size(267, 56);
            btnLivres.TabIndex = 0;
            btnLivres.Text = "Nos Livres";
            btnLivres.UseVisualStyleBackColor = true;
            // 
            // formMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Name = "formMenu";
            Text = "Accueil";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnCategories;
        private Button btnAuteurs;
        private Button btnLivres;
    }
}