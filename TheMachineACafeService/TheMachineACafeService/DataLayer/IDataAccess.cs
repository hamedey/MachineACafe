namespace TheMachineACafeService.DataLayer
{
    using System.Collections.Generic;
    using BusinessObjects;

    /// <summary>
    /// Expose l'ensemble des méthodes d'accès aux données.
    /// </summary>
    public interface IDataAccess
    {
        /// <summary>
        /// Obtient la lites des types de boisson.
        /// </summary>
        /// <returns>Liste de string représentant les types de boisson.</returns>
        List<string> GetListBoissonFromDataBase();

        /// <summary>
        /// Vérifie la validité du numéro de badge de l'utilisateur à partir des données en base.
        /// </summary>
        /// <param name="numBadge">Le numéro de badge.</param>
        /// <returns>true si numéro de badge valide; false sinon.</returns>
        bool CheckNumBadge(string numBadge);

        /// <summary>
        /// Récupère les preferences de l'utilisateur en fonction du numéro de badge stocké en base.
        /// </summary>
        /// <param name="numBadge">Le numéro de badge.</param>
        /// <returns><see cref="UserPreferences"/> représentant les préférences de l'utilisateur.</returns>
        UserPreferences GetUserPreferencesFromDataBase(string numBadge);

        /// <summary>
        /// Sauvegarde les préferences de l'utilisateur à chaque commande.
        /// </summary>
        /// <param name="userPreferences">Les préferences.</param>
        void SetUserPreferences(UserPreferences userPreferences);
    }
}
