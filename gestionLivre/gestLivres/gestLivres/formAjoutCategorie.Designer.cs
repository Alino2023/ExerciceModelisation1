namespace gestLivres
{
    partial class formAjoutCategorie
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
            btnAjouterCategorie = new Button();
            txtAjoutCatégorie = new TextBox();
            label2 = new Label();
            gbListerCatégories = new GroupBox();
            lstCategories = new ListBox();
            gbAjouterLivre.SuspendLayout();
            gbListerCatégories.SuspendLayout();
            SuspendLayout();
            // 
            // gbAjouterLivre
            // 
            gbAjouterLivre.Controls.Add(btnAjouterCategorie);
            gbAjouterLivre.Controls.Add(txtAjoutCatégorie);
            gbAjouterLivre.Controls.Add(label2);
            gbAjouterLivre.Font = new Font("Segoe UI", 10F);
            gbAjouterLivre.Location = new Point(12, 372);
            gbAjouterLivre.Name = "gbAjouterLivre";
            gbAjouterLivre.Size = new Size(378, 178);
            gbAjouterLivre.TabIndex = 6;
            gbAjouterLivre.TabStop = false;
            gbAjouterLivre.Text = "Ajouter une catégorie";
            // 
            // btnAjouterCategorie
            // 
            btnAjouterCategorie.BackColor = Color.Lavender;
            btnAjouterCategorie.FlatAppearance.BorderColor = Color.Blue;
            btnAjouterCategorie.FlatStyle = FlatStyle.Flat;
            btnAjouterCategorie.Font = new Font("Segoe UI", 10F);
            btnAjouterCategorie.Location = new Point(201, 116);
            btnAjouterCategorie.Name = "btnAjouterCategorie";
            btnAjouterCategorie.Size = new Size(154, 35);
            btnAjouterCategorie.TabIndex = 4;
            btnAjouterCategorie.Text = "Ajouter";
            btnAjouterCategorie.UseVisualStyleBackColor = false;
            btnAjouterCategorie.Click += btnAjouterCategorie_Click;
            // 
            // txtAjoutCatégorie
            // 
            txtAjoutCatégorie.Font = new Font("Segoe UI", 12F);
            txtAjoutCatégorie.Location = new Point(21, 59);
            txtAjoutCatégorie.Name = "txtAjoutCatégorie";
            txtAjoutCatégorie.Size = new Size(334, 34);
            txtAjoutCatégorie.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(21, 33);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 2;
            label2.Text = "Catégorie";
            // 
            // gbListerCatégories
            // 
            gbListerCatégories.Controls.Add(lstCategories);
            gbListerCatégories.Font = new Font("Segoe UI", 10F);
            gbListerCatégories.Location = new Point(15, 12);
            gbListerCatégories.Name = "gbListerCatégories";
            gbListerCatégories.Size = new Size(380, 338);
            gbListerCatégories.TabIndex = 7;
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
            // formAjoutCategorie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 562);
            Controls.Add(gbListerCatégories);
            Controls.Add(gbAjouterLivre);
            Name = "formAjoutCategorie";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajouter catégories";
            Load += formAjoutCategorie_Load;
            gbAjouterLivre.ResumeLayout(false);
            gbAjouterLivre.PerformLayout();
            gbListerCatégories.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAjouterLivre;
        private Button btnAjouterCategorie;
        private TextBox txtAjoutCatégorie;
        private Label label2;
        private GroupBox gbListerCatégories;
        private ListBox lstCategories;
    }
}