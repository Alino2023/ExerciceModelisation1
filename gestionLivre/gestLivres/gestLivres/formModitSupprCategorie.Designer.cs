namespace gestLivres
{
    partial class formModitSupprCategorie
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
            gbModifierSupprimerLivre = new GroupBox();
            btnSupprimerAuteur = new Button();
            btnMofierAuteur = new Button();
            txtAuteurModifSup = new TextBox();
            label1 = new Label();
            gbListerCatégories = new GroupBox();
            lstCategories = new ListBox();
            gbModifierSupprimerLivre.SuspendLayout();
            gbListerCatégories.SuspendLayout();
            SuspendLayout();
            // 
            // gbModifierSupprimerLivre
            // 
            gbModifierSupprimerLivre.Controls.Add(btnSupprimerAuteur);
            gbModifierSupprimerLivre.Controls.Add(btnMofierAuteur);
            gbModifierSupprimerLivre.Controls.Add(txtAuteurModifSup);
            gbModifierSupprimerLivre.Controls.Add(label1);
            gbModifierSupprimerLivre.Font = new Font("Segoe UI", 10F);
            gbModifierSupprimerLivre.Location = new Point(18, 382);
            gbModifierSupprimerLivre.Name = "gbModifierSupprimerLivre";
            gbModifierSupprimerLivre.Size = new Size(380, 189);
            gbModifierSupprimerLivre.TabIndex = 5;
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
            btnSupprimerAuteur.Click += btnSupprimerAuteur_Click;
            // 
            // btnMofierAuteur
            // 
            btnMofierAuteur.BackColor = Color.Lavender;
            btnMofierAuteur.FlatAppearance.BorderColor = Color.Blue;
            btnMofierAuteur.FlatStyle = FlatStyle.Flat;
            btnMofierAuteur.Font = new Font("Segoe UI", 10F);
            btnMofierAuteur.Location = new Point(23, 129);
            btnMofierAuteur.Name = "btnMofierAuteur";
            btnMofierAuteur.Size = new Size(154, 35);
            btnMofierAuteur.TabIndex = 2;
            btnMofierAuteur.Text = "Modifier";
            btnMofierAuteur.UseVisualStyleBackColor = false;
            btnMofierAuteur.Click += btnMofierAuteur_Click;
            // 
            // txtAuteurModifSup
            // 
            txtAuteurModifSup.Font = new Font("Segoe UI", 12F);
            txtAuteurModifSup.Location = new Point(23, 65);
            txtAuteurModifSup.Name = "txtAuteurModifSup";
            txtAuteurModifSup.Size = new Size(334, 34);
            txtAuteurModifSup.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(23, 39);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 0;
            label1.Text = "Auteur";
            // 
            // gbListerCatégories
            // 
            gbListerCatégories.Controls.Add(lstCategories);
            gbListerCatégories.Font = new Font("Segoe UI", 10F);
            gbListerCatégories.Location = new Point(12, 12);
            gbListerCatégories.Name = "gbListerCatégories";
            gbListerCatégories.Size = new Size(380, 338);
            gbListerCatégories.TabIndex = 6;
            gbListerCatégories.TabStop = false;
            gbListerCatégories.Text = "Sélectionner une catégorie";
            // 
            // lstCategories
            // 
            lstCategories.FormattingEnabled = true;
            lstCategories.ItemHeight = 23;
            lstCategories.Location = new Point(6, 23);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(368, 303);
            lstCategories.TabIndex = 0;
            // 
            // formModitSupprCategorie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 601);
            Controls.Add(gbListerCatégories);
            Controls.Add(gbModifierSupprimerLivre);
            Name = "formModitSupprCategorie";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modifier/Supprimer Catégorie";
            Load += formModitSupprAuteur_Load;
            gbModifierSupprimerLivre.ResumeLayout(false);
            gbModifierSupprimerLivre.PerformLayout();
            gbListerCatégories.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbModifierSupprimerLivre;
        private Button btnSupprimerAuteur;
        private Button btnMofierAuteur;
        private TextBox txtAuteurModifSup;
        private Label label1;
        private GroupBox gbListerCatégories;
        private ListBox lstCategories;
    }
}