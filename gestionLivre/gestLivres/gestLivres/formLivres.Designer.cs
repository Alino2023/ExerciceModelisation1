namespace gestLivres
{
    partial class formLivres
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
            txtDescription = new TextBox();
            label6 = new Label();
            btnAjouterLivre = new Button();
            label3 = new Label();
            cbAuteur = new ComboBox();
            txtIsbn = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtTitre = new TextBox();
            cbCategorie = new ComboBox();
            label2 = new Label();
            gbListerCategories = new GroupBox();
            lstLivres = new ListBox();
            gbAjouterLivre.SuspendLayout();
            gbListerCategories.SuspendLayout();
            SuspendLayout();
            // 
            // gbAjouterLivre
            // 
            gbAjouterLivre.Controls.Add(txtDescription);
            gbAjouterLivre.Controls.Add(label6);
            gbAjouterLivre.Controls.Add(btnAjouterLivre);
            gbAjouterLivre.Controls.Add(label3);
            gbAjouterLivre.Controls.Add(cbAuteur);
            gbAjouterLivre.Controls.Add(txtIsbn);
            gbAjouterLivre.Controls.Add(label5);
            gbAjouterLivre.Controls.Add(label4);
            gbAjouterLivre.Controls.Add(txtTitre);
            gbAjouterLivre.Controls.Add(cbCategorie);
            gbAjouterLivre.Controls.Add(label2);
            gbAjouterLivre.Font = new Font("Segoe UI", 10F);
            gbAjouterLivre.Location = new Point(404, 27);
            gbAjouterLivre.Name = "gbAjouterLivre";
            gbAjouterLivre.Size = new Size(359, 473);
            gbAjouterLivre.TabIndex = 5;
            gbAjouterLivre.TabStop = false;
            gbAjouterLivre.Text = "Ajouter un livre";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F);
            txtDescription.Location = new Point(21, 215);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(312, 34);
            txtDescription.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(21, 189);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 11;
            label6.Text = "Description";
            // 
            // btnAjouterLivre
            // 
            btnAjouterLivre.BackColor = Color.Lavender;
            btnAjouterLivre.FlatAppearance.BorderColor = Color.Blue;
            btnAjouterLivre.FlatStyle = FlatStyle.Flat;
            btnAjouterLivre.Font = new Font("Segoe UI", 10F);
            btnAjouterLivre.Location = new Point(201, 423);
            btnAjouterLivre.Name = "btnAjouterLivre";
            btnAjouterLivre.Size = new Size(132, 35);
            btnAjouterLivre.TabIndex = 4;
            btnAjouterLivre.Text = "Ajouter";
            btnAjouterLivre.UseVisualStyleBackColor = false;
            btnAjouterLivre.Click += btnAjouterLivre_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(21, 260);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 7;
            label3.Text = "Auteur";
            // 
            // cbAuteur
            // 
            cbAuteur.Font = new Font("Segoe UI", 12F);
            cbAuteur.FormattingEnabled = true;
            cbAuteur.Location = new Point(21, 286);
            cbAuteur.Name = "cbAuteur";
            cbAuteur.Size = new Size(312, 36);
            cbAuteur.TabIndex = 5;
            // 
            // txtIsbn
            // 
            txtIsbn.Font = new Font("Segoe UI", 12F);
            txtIsbn.Location = new Point(21, 131);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(312, 34);
            txtIsbn.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(21, 105);
            label5.Name = "label5";
            label5.Size = new Size(47, 23);
            label5.TabIndex = 9;
            label5.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(21, 330);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 8;
            label4.Text = "Catégorie";
            // 
            // txtTitre
            // 
            txtTitre.Font = new Font("Segoe UI", 12F);
            txtTitre.Location = new Point(21, 59);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(312, 34);
            txtTitre.TabIndex = 3;
            // 
            // cbCategorie
            // 
            cbCategorie.Font = new Font("Segoe UI", 12F);
            cbCategorie.FormattingEnabled = true;
            cbCategorie.Location = new Point(21, 356);
            cbCategorie.Name = "cbCategorie";
            cbCategorie.Size = new Size(312, 36);
            cbCategorie.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(21, 33);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 2;
            label2.Text = "Titre";
            // 
            // gbListerCategories
            // 
            gbListerCategories.Controls.Add(lstLivres);
            gbListerCategories.Font = new Font("Segoe UI", 10F);
            gbListerCategories.Location = new Point(21, 27);
            gbListerCategories.Name = "gbListerCategories";
            gbListerCategories.Size = new Size(359, 473);
            gbListerCategories.TabIndex = 3;
            gbListerCategories.TabStop = false;
            gbListerCategories.Text = "Sélectionner un livre";
            // 
            // lstLivres
            // 
            lstLivres.FormattingEnabled = true;
            lstLivres.ItemHeight = 23;
            lstLivres.Location = new Point(6, 23);
            lstLivres.Name = "lstLivres";
            lstLivres.Size = new Size(347, 441);
            lstLivres.TabIndex = 0;
            // 
            // formLivres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 751);
            Controls.Add(gbAjouterLivre);
            Controls.Add(gbListerCategories);
            Name = "formLivres";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nos Livres";
            Load += formLivres_Load;
            gbAjouterLivre.ResumeLayout(false);
            gbAjouterLivre.PerformLayout();
            gbListerCategories.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAjouterLivre;
        private Button btnAjouterLivre;
        private TextBox txtTitre;
        private Label label2;
        private GroupBox gbListerCategories;
        private ListBox lstLivres;
        private Label label4;
        private Label label3;
        private ComboBox cbCategorie;
        private ComboBox cbAuteur;
        private TextBox txtDescription;
        private Label label6;
        private TextBox txtIsbn;
        private Label label5;
    }
}