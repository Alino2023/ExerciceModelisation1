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
            btnAjouterLivre = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            gbModifierSupprimerLivre = new GroupBox();
            btnSupprimerLivre = new Button();
            btnModifierLivre = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            gbListerCategories = new GroupBox();
            lstLivres = new ListBox();
            gbAjouterLivre.SuspendLayout();
            gbModifierSupprimerLivre.SuspendLayout();
            gbListerCategories.SuspendLayout();
            SuspendLayout();
            // 
            // gbAjouterLivre
            // 
            gbAjouterLivre.Controls.Add(btnAjouterLivre);
            gbAjouterLivre.Controls.Add(textBox2);
            gbAjouterLivre.Controls.Add(label2);
            gbAjouterLivre.Font = new Font("Segoe UI", 10F);
            gbAjouterLivre.Location = new Point(401, 236);
            gbAjouterLivre.Name = "gbAjouterLivre";
            gbAjouterLivre.Size = new Size(378, 178);
            gbAjouterLivre.TabIndex = 5;
            gbAjouterLivre.TabStop = false;
            gbAjouterLivre.Text = "Ajouter un livre";
            // 
            // btnAjouterLivre
            // 
            btnAjouterLivre.BackColor = Color.Lavender;
            btnAjouterLivre.FlatAppearance.BorderColor = Color.Blue;
            btnAjouterLivre.FlatStyle = FlatStyle.Flat;
            btnAjouterLivre.Font = new Font("Segoe UI", 10F);
            btnAjouterLivre.Location = new Point(201, 116);
            btnAjouterLivre.Name = "btnAjouterLivre";
            btnAjouterLivre.Size = new Size(154, 35);
            btnAjouterLivre.TabIndex = 4;
            btnAjouterLivre.Text = "Ajouter";
            btnAjouterLivre.UseVisualStyleBackColor = false;
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
            label2.Size = new Size(45, 23);
            label2.TabIndex = 2;
            label2.Text = "Livre";
            // 
            // gbModifierSupprimerLivre
            // 
            gbModifierSupprimerLivre.Controls.Add(btnSupprimerLivre);
            gbModifierSupprimerLivre.Controls.Add(btnModifierLivre);
            gbModifierSupprimerLivre.Controls.Add(textBox1);
            gbModifierSupprimerLivre.Controls.Add(label1);
            gbModifierSupprimerLivre.Font = new Font("Segoe UI", 10F);
            gbModifierSupprimerLivre.Location = new Point(399, 28);
            gbModifierSupprimerLivre.Name = "gbModifierSupprimerLivre";
            gbModifierSupprimerLivre.Size = new Size(380, 189);
            gbModifierSupprimerLivre.TabIndex = 4;
            gbModifierSupprimerLivre.TabStop = false;
            gbModifierSupprimerLivre.Text = "Modifier / Supprimer une catégorie";
            // 
            // btnSupprimerLivre
            // 
            btnSupprimerLivre.BackColor = Color.Lavender;
            btnSupprimerLivre.FlatAppearance.BorderColor = Color.Blue;
            btnSupprimerLivre.FlatStyle = FlatStyle.Flat;
            btnSupprimerLivre.Font = new Font("Segoe UI", 10F);
            btnSupprimerLivre.Location = new Point(203, 129);
            btnSupprimerLivre.Name = "btnSupprimerLivre";
            btnSupprimerLivre.Size = new Size(154, 35);
            btnSupprimerLivre.TabIndex = 3;
            btnSupprimerLivre.Text = "Supprimer";
            btnSupprimerLivre.UseVisualStyleBackColor = false;
            // 
            // btnModifierLivre
            // 
            btnModifierLivre.BackColor = Color.Lavender;
            btnModifierLivre.FlatAppearance.BorderColor = Color.Blue;
            btnModifierLivre.FlatStyle = FlatStyle.Flat;
            btnModifierLivre.Font = new Font("Segoe UI", 10F);
            btnModifierLivre.Location = new Point(23, 129);
            btnModifierLivre.Name = "btnModifierLivre";
            btnModifierLivre.Size = new Size(154, 35);
            btnModifierLivre.TabIndex = 2;
            btnModifierLivre.Text = "Modifier";
            btnModifierLivre.UseVisualStyleBackColor = false;
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
            label1.Size = new Size(45, 23);
            label1.TabIndex = 0;
            label1.Text = "Livre";
            // 
            // gbListerCategories
            // 
            gbListerCategories.Controls.Add(lstLivres);
            gbListerCategories.Font = new Font("Segoe UI", 10F);
            gbListerCategories.Location = new Point(21, 27);
            gbListerCategories.Name = "gbListerCategories";
            gbListerCategories.Size = new Size(345, 396);
            gbListerCategories.TabIndex = 3;
            gbListerCategories.TabStop = false;
            gbListerCategories.Text = "Sélectionner un livre";
            // 
            // lstLivres
            // 
            lstLivres.FormattingEnabled = true;
            lstLivres.ItemHeight = 23;
            lstLivres.Location = new Point(2, 43);
            lstLivres.Name = "lstLivres";
            lstLivres.Size = new Size(343, 326);
            lstLivres.TabIndex = 0;
            // 
            // formLivres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbAjouterLivre);
            Controls.Add(gbModifierSupprimerLivre);
            Controls.Add(gbListerCategories);
            Name = "formLivres";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nos Livres";
            Load += formLivres_Load;
            gbAjouterLivre.ResumeLayout(false);
            gbAjouterLivre.PerformLayout();
            gbModifierSupprimerLivre.ResumeLayout(false);
            gbModifierSupprimerLivre.PerformLayout();
            gbListerCategories.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAjouterLivre;
        private Button btnAjouterLivre;
        private TextBox textBox2;
        private Label label2;
        private GroupBox gbModifierSupprimerLivre;
        private Button btnSupprimerLivre;
        private Button btnModifierLivre;
        private TextBox textBox1;
        private Label label1;
        private GroupBox gbListerCategories;
        private ListBox lstLivres;
    }
}