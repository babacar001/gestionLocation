using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_location.Model;
using menu.Model;


namespace menu
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CreateAdmin();
            Application.Run(new frmConnexion());
        }

        static void CreateAdmin()
        {
            BdAppartementContext db = new BdAppartementContext();
            var admin = db.admins.FirstOrDefault();
            if (admin==null)
            {
                admin = new Admin();
                admin.NomPrenom = "Administrateur";
                admin.Telephone = "777777777";
                admin.Identifiant = "admin";
                admin.Email = "admin@yopmail.com";
                db.admins.Add(admin);
                db.SaveChanges();
            }

        }
    }
}
