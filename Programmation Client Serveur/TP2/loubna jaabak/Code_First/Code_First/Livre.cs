namespace Code_First
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Livre")]
    public partial class Livre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string Titre { get; set; }

        [StringLength(50)]
        public string Categorie { get; set; }

        public int? idEdit { get; set; }

        public virtual Editeur Editeur { get; set; }
    }
}
