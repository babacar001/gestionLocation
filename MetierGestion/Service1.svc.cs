using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MetierGestion.Model;

namespace MetierGestion
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        BdAppartementContext db = new BdAppartementContext();

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        /// <summary>
        /// cette methode permet d'enregistrer un nouveau appartement
        /// </summary>
        /// <param name="appartement">un appartement </param>
        /// <returns> true si fait; sinn false; </returns>
        public bool AddAppartement(Appartement appartement)
        {
            try
            {
                db.appartements.Add(appartement);
                db.SaveChanges();
            }
            catch (Exception ex) { 
                return false;
            }
            return true;
        }

        /// <summary>
        /// cette  methode permet de recuperer la liste des appartements
        /// </summary>
        /// <returns></returns>
        public List<Appartement> GetListAppartements() 
        { 
            return db.appartements.ToList();
        }

        public Appartement GetAppartementById(int? id)
        {
            return db.appartements.Find(id);
        }
    }
}
