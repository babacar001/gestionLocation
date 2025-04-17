namespace menu.view
{
    partial class frmContratLocation
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
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnRevoquer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgLocataire = new System.Windows.Forms.DataGridView();
            this.lblAppartement = new System.Windows.Forms.Label();
            this.txtDateDebut = new System.Windows.Forms.DateTimePicker();
            this.txtDateFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbModePaiement = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocataire)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(273, 31);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(88, 45);
            this.btnChoisir.TabIndex = 44;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            // 
            // btnRevoquer
            // 
            this.btnRevoquer.Location = new System.Drawing.Point(242, 558);
            this.btnRevoquer.Name = "btnRevoquer";
            this.btnRevoquer.Size = new System.Drawing.Size(110, 45);
            this.btnRevoquer.TabIndex = 43;
            this.btnRevoquer.Text = "Revoquer";
            this.btnRevoquer.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(130, 558);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(110, 45);
            this.btnValider.TabIndex = 42;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(18, 558);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(110, 45);
            this.btnEnregistrer.TabIndex = 41;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(27, 396);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(268, 26);
            this.txtMontant.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Montant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Date de fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Date de debut";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(27, 133);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(268, 26);
            this.txtNumero.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Numero";
            // 
            // dgLocataire
            // 
            this.dgLocataire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocataire.Location = new System.Drawing.Point(449, 16);
            this.dgLocataire.Name = "dgLocataire";
            this.dgLocataire.RowHeadersWidth = 62;
            this.dgLocataire.RowTemplate.Height = 28;
            this.dgLocataire.Size = new System.Drawing.Size(320, 664);
            this.dgLocataire.TabIndex = 32;
            // 
            // lblAppartement
            // 
            this.lblAppartement.AutoSize = true;
            this.lblAppartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppartement.Location = new System.Drawing.Point(52, 47);
            this.lblAppartement.Name = "lblAppartement";
            this.lblAppartement.Size = new System.Drawing.Size(0, 29);
            this.lblAppartement.TabIndex = 45;
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateDebut.Location = new System.Drawing.Point(27, 217);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(268, 26);
            this.txtDateDebut.TabIndex = 46;
            // 
            // txtDateFin
            // 
            this.txtDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateFin.Location = new System.Drawing.Point(27, 311);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(268, 26);
            this.txtDateFin.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Mode de paiement";
            // 
            // cbbModePaiement
            // 
            this.cbbModePaiement.FormattingEnabled = true;
            this.cbbModePaiement.Location = new System.Drawing.Point(27, 499);
            this.cbbModePaiement.Name = "cbbModePaiement";
            this.cbbModePaiement.Size = new System.Drawing.Size(268, 28);
            this.cbbModePaiement.TabIndex = 49;
            // 
            // frmContratLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 692);
            this.ControlBox = false;
            this.Controls.Add(this.cbbModePaiement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateFin);
            this.Controls.Add(this.txtDateDebut);
            this.Controls.Add(this.lblAppartement);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnRevoquer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgLocataire);
            this.Name = "frmContratLocation";
            this.Text = "Contrat de location";
            this.Load += new System.EventHandler(this.frmContratLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLocataire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnRevoquer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgLocataire;
        private System.Windows.Forms.Label lblAppartement;
        private System.Windows.Forms.DateTimePicker txtDateDebut;
        private System.Windows.Forms.DateTimePicker txtDateFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbModePaiement;
    }
}