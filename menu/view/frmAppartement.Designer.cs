﻿namespace menu.view
{
    partial class frmAppartement
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
            this.dgAppartement = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePiece = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapacite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbDisponible = new System.Windows.Forms.ComboBox();
            this.cbbProprietaire = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnContrat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppartement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAppartement
            // 
            this.dgAppartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppartement.Location = new System.Drawing.Point(352, 66);
            this.dgAppartement.Name = "dgAppartement";
            this.dgAppartement.RowHeadersWidth = 62;
            this.dgAppartement.RowTemplate.Height = 28;
            this.dgAppartement.Size = new System.Drawing.Size(783, 608);
            this.dgAppartement.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(16, 46);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(279, 26);
            this.txtAdresse.TabIndex = 2;
            // 
            // txtSurface
            // 
            this.txtSurface.Location = new System.Drawing.Point(16, 134);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(279, 26);
            this.txtSurface.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surface";
            // 
            // txtNombrePiece
            // 
            this.txtNombrePiece.Location = new System.Drawing.Point(16, 214);
            this.txtNombrePiece.Name = "txtNombrePiece";
            this.txtNombrePiece.Size = new System.Drawing.Size(279, 26);
            this.txtNombrePiece.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "nombre de pieces";
            // 
            // txtCapacite
            // 
            this.txtCapacite.Location = new System.Drawing.Point(16, 299);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(279, 26);
            this.txtCapacite.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Capacite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Disponible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Proprietaire";
            // 
            // cbbDisponible
            // 
            this.cbbDisponible.FormattingEnabled = true;
            this.cbbDisponible.Items.AddRange(new object[] {
            "Selectionner...",
            "Oui",
            "Non"});
            this.cbbDisponible.Location = new System.Drawing.Point(16, 381);
            this.cbbDisponible.Name = "cbbDisponible";
            this.cbbDisponible.Size = new System.Drawing.Size(279, 28);
            this.cbbDisponible.TabIndex = 13;
            // 
            // cbbProprietaire
            // 
            this.cbbProprietaire.FormattingEnabled = true;
            this.cbbProprietaire.Location = new System.Drawing.Point(16, 459);
            this.cbbProprietaire.Name = "cbbProprietaire";
            this.cbbProprietaire.Size = new System.Drawing.Size(279, 28);
            this.cbbProprietaire.TabIndex = 14;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(236, 511);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(110, 45);
            this.btnSupprimer.TabIndex = 18;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(124, 511);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(110, 45);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 511);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(110, 45);
            this.btnAjouter.TabIndex = 16;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(352, 9);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(88, 45);
            this.btnChoisir.TabIndex = 19;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnContrat
            // 
            this.btnContrat.Location = new System.Drawing.Point(480, 12);
            this.btnContrat.Name = "btnContrat";
            this.btnContrat.Size = new System.Drawing.Size(88, 45);
            this.btnContrat.TabIndex = 20;
            this.btnContrat.Text = "Contrat";
            this.btnContrat.UseVisualStyleBackColor = true;
            this.btnContrat.Click += new System.EventHandler(this.btnContrat_Click);
            // 
            // frmAppartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 686);
            this.ControlBox = false;
            this.Controls.Add(this.btnContrat);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbbProprietaire);
            this.Controls.Add(this.cbbDisponible);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCapacite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombrePiece);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurface);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAppartement);
            this.Name = "frmAppartement";
            this.Text = "Appartement";
            this.Load += new System.EventHandler(this.frmAppartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppartement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAppartement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePiece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapacite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbDisponible;
        private System.Windows.Forms.ComboBox cbbProprietaire;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnContrat;
    }
}