namespace tp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("editeur")]
    public partial class editeur
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string nom { get; set; }

        [StringLength(50)]
        public string prenom { get; set; }

        public int? numero_inscription { get; set; }

        public int? id_livre { get; set; }

        public virtual Livre Livre { get; set; }

        public override string ToString()
        {
            return this.id+"  "+this.nom+"  "+this.prenom+" "+this.numero_inscription+"  "+this.id_livre;
        }

    }
}
