//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entityFrameWorke
{
    using System;
    using System.Collections.Generic;
    
    public partial class lecon
    {
        public int id { get; set; }
        public Nullable<System.DateTime> datelecon { get; set; }
        public Nullable<int> heur { get; set; }
        public Nullable<int> duree { get; set; }
        public Nullable<int> efectuee { get; set; }
        public Nullable<int> idelive { get; set; }
        public Nullable<int> idvehicule { get; set; }
    
        public virtual elive elive { get; set; }
        public virtual vehicule vehicule { get; set; }
    }
}
