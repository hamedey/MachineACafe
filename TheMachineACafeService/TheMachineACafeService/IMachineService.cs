namespace TheMachineACafeService
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using BusinessObjects;

    /// <summary>
    /// Expose des méthodes pour le traitement de l'utilisation de la machine à café.
    /// </summary>
    [ServiceContract]
    public interface IMachineService
    {
        /// <summary>
        /// Obtient la lites des types de boisson.
        /// </summary>
        /// <returns>Liste de string représentant les types de boisson.</returns>
        [OperationContract]
        List<string> GetListBoisson();

        /// <summary>
        /// Obtient les preferences de l'utilisateur.
        /// </summary>
        /// <param name="numBadge">Le numéro de badge.</param>
        /// <returns><see cref="UserPreferences"/> représentant les préférences de l'utilisateur.</returns>
        [OperationContract]
        UserPreferences GetUserPreferences(string numBadge);

        /// <summary>
        /// Sauvegarde les préferences de l'utilisateur à chaque commande.
        /// </summary>
        /// <param name="userPreferences">Les préferences.</param>
        [OperationContract]
        void SetUserPreferences(UserPreferences userPreferences);

        /// <summary>
        /// Vérifie la validité du numéro de badge de l'utilisateur.
        /// </summary>
        /// <param name="numBadge">Le numéro de badge.</param>
        /// <returns>true si numéro de badge valide; false sinon.</returns>
        [OperationContract]
        bool ValidateNumBadge(string numBadge);
    }
}
