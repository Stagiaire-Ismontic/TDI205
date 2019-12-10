namespace Tp2_codefirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employe")]
    public partial class Employe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(20)]
        public string Nom { get; set; }

        [StringLength(20)]
        public string Prenom { get; set; }

        [StringLength(50)]
        public string Adress { get; set; }
    }
}
