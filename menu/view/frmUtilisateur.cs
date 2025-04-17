﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_location.Model;
using menu.Model;
using menu.Utils;

namespace menu.view
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
        }

        BdAppartementContext db = new BdAppartementContext();
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                Utilisateur ut = new Utilisateur();
                ut.Email = txtEmail.Text;
                ut.MotDePasse = CryptApp.GetMd5Hash(md5Hash, "P@sser123");
                ut.NomPrenom = txtNomPrenom.Text;
                ut.Identifiant = txtIdentifiant.Text;
                ut.Telephone = txtTelephone.Text;
                db.utilisateurs.Add(ut);
                db.SaveChanges();
                ResetForm();
                GMailer.senMail(ut.Email, "Creation compte", string.Format("Bonjour Votre compte est bien cree /n  avec identifiant{0} et mot de passe{1} ", ut.Identifiant, "P@sser123"));
            }
        }

        private void ResetForm()
        {
            txtEmail.Text = string.Empty;
            txtIdentifiant.Text = string.Empty;
            txtNomPrenom.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            dgUtilisateur.DataSource = db.utilisateurs.Select(a => new {a.IdPersonne, a.NomPrenom, a.Identifiant, a.Telephone}).ToList();
            txtNomPrenom.Focus();
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            txtIdentifiant.Text = txtEmail.Text;
        }

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
