namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Etudiant")]
    public partial class Etudiant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(30)]
        public string Etud_Name { get; set; }

        [StringLength(30)]
        public string Etud_Tel { get; set; }

   
    }
}
