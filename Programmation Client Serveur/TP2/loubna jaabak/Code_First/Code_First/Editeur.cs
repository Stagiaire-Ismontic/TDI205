namespace Code_First
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Editeur")]
    public partial class Editeur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Editeur()
        {
            Livres = new HashSet<Livre>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string nom { get; set; }

        [StringLength(50)]
        public string categorie { get; set; }

        public int? id_livre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livre> Livres { get; set; }


        public override string ToString()
        {
            return this.id + "  /  " + this.nom + "  /  " + this.categorie + "  /  " + this.id_livre;
        }
    }
}
