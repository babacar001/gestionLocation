using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_location.Model;

namespace menu.view
{
    public partial class frmProprietaire : Form
    {
        public frmProprietaire()
        {
            InitializeComponent();
        }

        BdAppartementContext db = new BdAppartementContext();

        private void resetForm()
        {
 
            txtEmail.Text = string.Empty;
            txtNINEA.Text = string.Empty;
            txtNomPrenom.Text = string.Empty;
            txtRCCM.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            dgProprietaire.DataSource = db.proprietaires.Select(a=> new { a.IdPersonne, a.NomPrenom, a.Telephone, a.Email, a.Ninea, a.Rccm }).ToList();
            txtNomPrenom.Focus();
           
        }

        private void frmProprietaire_Load(object sender, EventArgs e)
        {
            resetForm();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Proprietaire p = new Proprietaire();
            p.NomPrenom = txtNomPrenom.Text;
            p.Rccm = txtRCCM.Text;
            p.Telephone = txtTelephone.Text;
            p.Email = txtEmail.Text;
            p.Ninea = txtNINEA.Text;
            db.proprietaires.Add(p);
            db.SaveChanges();
            resetForm();

        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgProprietaire.CurrentRow.Cells[1].Value.ToString();
            txtTelephone.Text = dgProprietaire.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgProprietaire.CurrentRow.Cells[3].Value.ToString();           
            txtNINEA.Text = dgProprietaire.CurrentRow.Cells[4].Value.ToString();
            txtRCCM.Text = dgProprietaire.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
           int? id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = db.proprietaires.Find (id);
            p.NomPrenom = txtNomPrenom.Text;
            p.Rccm = txtRCCM.Text;
            p.Telephone = txtTelephone.Text;
            p.Email = txtEmail.Text;
            p.Ninea = txtNINEA.Text;
            db.SaveChanges();
            resetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = db.proprietaires.Find(id);
            db.proprietaires.Remove(p);
            db.SaveChanges();
            resetForm();
        }

        private void txtNomPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            frmPrintListeProprietaire f = new frmPrintListeProprietaire();
            f.Show();
            f.Close();
            this.Enabled = false;
        }

        public void Activer()
        {
            this.Enabled = true;
        }
    }
}
