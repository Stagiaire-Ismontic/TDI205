//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tp1Ef1
{
    using System;
    using System.Collections.Generic;
    
    public partial class livraison
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Datelivraison { get; set; }
        public Nullable<int> IdCommande { get; set; }
    
        public virtual commande commande { get; set; }
    }
}