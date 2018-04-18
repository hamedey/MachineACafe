namespace TheMachineACafeService.DataLayer
{
    using Modele;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using BusinessObjects;

    public class DataAccess : IDataAccess
    {
        private MachineAcafeEntities machineAcafeEntities;

        /// <summary>
        /// Vérifie la validité du numéro de badge de l'utilisateur à partir des données en base.
        /// </summary>
        /// <param name="numBadge">Le numéro de badge.</param>
        /// <returns>
        /// true si numéro de badge valide; false sinon.
        /// </returns>
        public bool CheckNumBadge(string numBadge)
        {
            bool result = false;

            using (this.machineAcafeEntities = new MachineAcafeEntities())
            {
                var data = this.machineAcafeEntities.userchoices.Where(p => p.NumBadge.Equals(numBadge));

                result = data.Count() == 1;
            }

            return result;
        }

        /// <summary>
        /// Obtient la lites des types de boisson.
        /// </summary>
        /// <returns>
        /// Liste de string représentant les types de boisson.
        /// </returns>
        public List<string> GetListBoissonFromDataBase()
        {
            List<string> result;

            using (this.machineAcafeEntities = new Modele.MachineAcafeEntities())
            {
                result = this.machineAcafeEntities.boisson.Select(b => b.TypeBoisson).ToList();
            }

            return result;
        }

        /// <summary>
        /// Récupère les preferences de l'utilisateur en fonction du numéro de badge stocké en base.
        /// </summary>
        /// <param name="numBadge">Le numéro de badge.</param>
        /// <returns>
        ///   <see cref="UserPreferences" /> représentant les préférences de l'utilisateur.
        /// </returns>
        public UserPreferences GetUserPreferencesFromDataBase(string numBadge)
        {
            UserPreferences result = new UserPreferences();

            using (this.machineAcafeEntities = new MachineAcafeEntities())
            {
                var data = this.machineAcafeEntities.userchoices.FirstOrDefault(p => p.NumBadge.Equals(numBadge));

                result.TypeBoisson = data.TypeBoisson;
                result.QuantiteSucre = data.QuantiteSucre;
                result.UseMug = data.UtiliserSonMug == 1;                
            }

            return result;
        }

        /// <summary>
        /// Sauvegarde les préferences de l'utilisateur à chaque commande.
        /// </summary>
        /// <param name="userPreferences">Les préferences.</param>
        public void SetUserPreferences(UserPreferences userPreferences)
        {
            using (this.machineAcafeEntities = new MachineAcafeEntities())
            {
                var data = this.machineAcafeEntities.userchoices.SingleOrDefault(u => u.NumBadge.Equals(userPreferences.NumBadge));

                if (data != null)
                {
                    data.TypeBoisson = userPreferences.TypeBoisson;
                    data.QuantiteSucre = userPreferences.QuantiteSucre;
                    data.UtiliserSonMug = userPreferences.UseMug ? 1 : 0;

                    this.machineAcafeEntities.SaveChanges();
                }
            }
        }
    }
}