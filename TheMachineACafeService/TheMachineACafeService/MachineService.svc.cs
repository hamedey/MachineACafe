namespace TheMachineACafeService
{
    using System.Collections.Generic;
    using BusinessObjects;
    using DataLayer;

    /// <summary>
    /// Classe d'implémentation du service.
    /// </summary>
    /// <seealso cref="TheMachineACafeService.IMachineService" />
    public class MachineService : IMachineService
    {
        private readonly IDataAccess dataAccess;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="MachineService"/>.
        /// </summary>
        public MachineService()
        {
            this.dataAccess = new DataAccess();
        }

        /// <summary>
        /// Obtient la lites des types de boisson.
        /// </summary>
        /// <returns>Liste de string représentant les types de boisson.</returns>
        public List<string> GetListBoisson()
        {
            return this.dataAccess.GetListBoissonFromDataBase();
        }

        /// <summary>
        /// Obtient les preferences de l'utilisateur.
        /// </summary>
        /// <param name="numBadge">Le numéro de badge.</param>
        /// <returns><see cref="UserPreferences"/> représentant les préférences de l'utilisateur.</returns>
        public UserPreferences GetUserPreferences(string numBadge)
        {
            return this.dataAccess.GetUserPreferencesFromDataBase(numBadge);
        }

        /// <summary>
        /// Sauvegarde les préferences de l'utilisateur à chaque commande.
        /// </summary>
        /// <param name="userPreferences">Les préferences.</param>
        public void SetUserPreferences(UserPreferences userPreferences)
        {
            this.dataAccess.SetUserPreferences(userPreferences);
        }

        /// <summary>
        /// Vérifie la validité du numéro de badge de l'utilisateur.
        /// </summary>
        /// <param name="numBadge">Le numéro de badge.</param>
        /// <returns>true si numéro de badge valide; false sinon.</returns>
        public bool ValidateNumBadge(string numBadge)
        {
            return this.dataAccess.CheckNumBadge(numBadge);
        }
    }
}
