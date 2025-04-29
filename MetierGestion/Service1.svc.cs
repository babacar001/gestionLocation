using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MetierGestion.Model;
using MetierGestion.Utils;

namespace MetierGestion
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        BdAppartementContext db = new BdAppartementContext();
        Helper helper = new Helper();

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
                helper.WriteDataError("Service1-AddAppartement", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Mise a jour d'un appartement
        /// </summary>
        /// <param name="appartement">Objet Appartement</param>
        /// <returns>oui; si fait</returns>
        public bool UpdateAppartement(Appartement appartement)
        {
            try
            {
                db.Entry(appartement).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-UpdateAppartement", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Methode pour supprimer un appartement 
        /// </summary>
        /// <param name="appartement">Objet appartement</param>
        /// <returns>oui; si fait</returns>

        public bool DeleteAppartement(Appartement appartement)
        {
            try
            {
                db.Entry(appartement).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-DeleteAppartement", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// cette  methode permet de recuperer la liste des appartements
        /// </summary>
        /// // <param name="adresse">adresse de recherche</param>
        /// // <param name="capacite">capacite de recherche</param>
        /// // <param name="disponible">disponible de recherche</param>
        /// <returns>liste des appartements respectant le critere de recherche</returns>
        public List<Appartement> GetListAppartements(string adresse, float? capacite, bool? disponible ) 
        {
            var liste = db.appartements.ToList();
            if (!string.IsNullOrEmpty(adresse))
            {
                liste = liste.Where(a => a.AdresseAppartement.ToLower().Contains(adresse.ToLower())).ToList();
            }

            if (capacite!=null)
            {
                liste = liste.Where(a => a.Capacite==capacite).ToList();
            }

            if (disponible != null)
            {
                liste = liste.Where(a => a.Disponible == disponible).ToList();
            }

            return liste;
        }
        /// <summary>
        /// renvoie un appartement
        /// </summary>
        /// <param name="id">identifiant appartement</param>
        /// <returns>objet appartement</returns>
        public Appartement GetAppartementById(int? id)
        {
            return db.appartements.Find(id);
        }
    }
}
