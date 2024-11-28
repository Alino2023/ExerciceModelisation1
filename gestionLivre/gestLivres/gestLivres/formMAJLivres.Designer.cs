namespace gestLivres
{
    partial class formMAJLivres
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
            btnSupprimerLivre = new Button();
            btnModifierLivre = new Button();
            txtLivre = new TextBox();
            label1 = new Label();
            gbListerCategories = new GroupBox();
            lstCategories = new ListBox();
            gbModifierSupprimerLivre.SuspendLayout();
            gbListerCategories.SuspendLayout();
            SuspendLayout();
            // 
            // gbModifierSupprimerLivre
            // 
            gbModifierSupprimerLivre.Controls.Add(btnSupprimerLivre);
            gbModifierSupprimerLivre.Controls.Add(btnModifierLivre);
            gbModifierSupprimerLivre.Controls.Add(txtLivre);
            gbModifierSupprimerLivre.Controls.Add(label1);
            gbModifierSupprimerLivre.Font = new Font("Segoe UI", 10F);
            gbModifierSupprimerLivre.Location = new Point(18, 382);
            gbModifierSupprimerLivre.Name = "gbModifierSupprimerLivre";
            gbModifierSupprimerLivre.Size = new Size(380, 189);
            gbModifierSupprimerLivre.TabIndex = 5;
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
            btnModifierLivre.Click += btnModifierLivre_Click;
            // 
            // txtLivre
            // 
            txtLivre.Font = new Font("Segoe UI", 12F);
            txtLivre.Location = new Point(23, 65);
            txtLivre.Name = "txtLivre";
            txtLivre.Size = new Size(334, 34);
            txtLivre.TabIndex = 1;
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
            gbListerCategories.Controls.Add(lstCategories);
            gbListerCategories.Font = new Font("Segoe UI", 10F);
            gbListerCategories.Location = new Point(12, 12);
            gbListerCategories.Name = "gbListerCategories";
            gbListerCategories.Size = new Size(380, 338);
            gbListerCategories.TabIndex = 6;
            gbListerCategories.TabStop = false;
            gbListerCategories.Text = "Sélectionner un livre";
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
            // formMAJLivres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 601);
            Controls.Add(gbListerCategories);
            Controls.Add(gbModifierSupprimerLivre);
            Name = "formMAJLivres";
            Text = "formMAJLivres";
            Load += formMAJLivres_Load;
            gbModifierSupprimerLivre.ResumeLayout(false);
            gbModifierSupprimerLivre.PerformLayout();
            gbListerCategories.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbModifierSupprimerLivre;
        private Button btnSupprimerLivre;
        private Button btnModifierLivre;
        private TextBox txtLivre;
        private Label label1;
        private GroupBox gbListerCategories;
        private ListBox lstCategories;
    }
}