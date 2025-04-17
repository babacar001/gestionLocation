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
using gestion_location.Model;
using menu.Model;
using menu.Utils;

namespace menu.view
{
    public partial class frmResetPassword : Form
    {
        public int IdUser;
        public frmResetPassword()
        {
            InitializeComponent();
        }
        BdAppartementContext db = new BdAppartementContext();
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == txtConfirmerMotDePasse.Text)
            {
                var leuser = db.utilisateurs.Find(IdUser);
                if (leuser != null)
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        leuser.MotDePasse = CryptApp.GetMd5Hash(md5Hash, txtMotDePasse.Text);
                        leuser.Statut = "Enabled";
                        db.SaveChanges();
                    }
                    frmMDI f = new frmMDI();
                    f.Show();
                    this.Close();
                }
              
            }
            else
            {
                MessageBox.Show("Les mots de passe ne sont pas identiques");
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
