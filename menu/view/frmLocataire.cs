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
    public partial class frmLocataire : Form
    {
        public frmLocataire()
        {
            InitializeComponent();
        }

        BdAppartementContext db = new BdAppartementContext();

        private void resetForm()
        {
            txtEmail.Text = string.Empty;
            txtNomPrenom.Text = string.Empty;
            txtCNI.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            dgLocataire.DataSource = db.proprietaires.Select(a => new { a.IdPersonne, a.NomPrenom, a.Telephone, a.Email, a.CNI}).ToList();
            txtNomPrenom.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Locataire p = new Locataire();
            p.NomPrenom = txtNomPrenom.Text;
            p.CNI = txtCNI.Text;
            p.Telephone = txtTelephone.Text;
            p.Email = txtEmail.Text;
            db.locataires.Add(p);
            db.SaveChanges();
            resetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgLocataire.CurrentRow.Cells[1].Value.ToString();
            txtTelephone.Text = dgLocataire.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgLocataire.CurrentRow.Cells[3].Value.ToString();
            txtCNI.Text = dgLocataire.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgLocataire.CurrentRow.Cells[0].Value.ToString());
            var p = db.locataires.Find(id);
            p.NomPrenom = txtNomPrenom.Text;
            p.Telephone = txtTelephone.Text;
            p.Email = txtEmail.Text;
            p.CNI = txtCNI.Text;
            db.SaveChanges();
            resetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {         
            int? id = int.Parse(dgLocataire.CurrentRow.Cells[0].Value.ToString());
            var p = db.locataires.Find(id);
            db.locataires.Remove(p);
            db.SaveChanges();
            resetForm();
        }

        private void btnContrat_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgLocataire.CurrentRow.Cells[0].Value.ToString());
            var p = db.locataires.Find(id);
            frmContratLocation frm = new frmContratLocation();
            frm.Appartement = string.Format("Adresse");
        }
    }
}
