namespace TheMachineACafeService.BusinessObjects
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Représente la description d'une boisson.
    /// </summary>
    [DataContract]
    public class Boisson
    {
        /// <summary>
        /// Obtient ou définit l'identifiant d'une boisson.
        /// </summary>
        [DataMember]
        public int IdBoisson { get; set; }

        /// <summary>
        /// Obtient ou définit le type de boisson.
        /// </summary>
        [DataMember]
        public string TypeBoisson { get; set; }
    }
}