using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using menu.Utils;
using menu.Model;
using gestion_location.Model;
using menu.view;

namespace menu
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

      
        BdAppartementContext db = new BdAppartementContext();

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                var leuser = db.utilisateurs
                    .FirstOrDefault(a => a.Identifiant.ToLower() == txtIdentifiant.Text.ToLower());

                if (leuser == null)
                {
                    MessageBox.Show("Identifiant ou Mot de Passe Incorrect !!!");
                    return;
                }

                // Vérifier si le mot de passe est null et rediriger vers le formulaire de réinitialisation
                if (string.IsNullOrEmpty(leuser.MotDePasse))
                {
                    var resetForm = new frmResetPassword { IdUser = leuser.IdPersonne };
                    resetForm.Show();
                    this.Hide();
                    return;
                }

                // Vérifier si le mot de passe entré correspond
                if (!CryptApp.VerifyMd5Hash(MD5.Create(), txtMotDePasse.Text, leuser.MotDePasse))
                {
                    MessageBox.Show("Identifiant ou Mot de Passe Incorrect !!!");
                    return;
                }

                // Vérifier le statut de l'utilisateur
                if (leuser.Statut == "Enabled")
                {
                    frmMDI f = new frmMDI();
                    var le = db.admins.Find(leuser.IdPersonne);
                    if (le != null)
                    {
                        f.profil = "admin";
                    }
                    else
                    {
                        var leGes = db.gestionnaires.Find(leuser.IdPersonne);
                        if (leGes != null)
                        {
                            f.profil = "Gestionnaire";
                        }
                    }
                    f.Show();
                }
                else
                {
                    var resetForm = new frmResetPassword { IdUser = leuser.IdPersonne };
                    resetForm.Show();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }


        private void frmConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
