namespace TheMachineACafeService.BusinessObjects
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Représente les préférencces de l'utilisateur.
    /// </summary>
    [DataContract]
    public class UserPreferences
    {
        /// <summary>
        /// Obtient ou définit le numéro de badge de l'utilisateur.
        /// </summary>
        [DataMember]
        public string NumBadge { get; set; }

        /// <summary>
        /// Obtient ou définit le type de boisson.
        /// </summary>
        [DataMember]
        public string TypeBoisson { get; set; }

        /// <summary>
        /// Obtient ou définit la quantité de sucre.
        /// </summary>
        [DataMember]
        public int? QuantiteSucre { get; set; }

        /// <summary>
        /// Obtient ou définitt une valeur indiquant si l'on utilise son propre mug ou pas.
        /// </summary>
        /// <value>
        ///   <c>true</c> si on tuliser son propre mug; sinon <c>false</c>.
        /// </value>
        [DataMember]
        public bool UseMug { get; set; }
    }
}