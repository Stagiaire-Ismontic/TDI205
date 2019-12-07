namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Etablissement1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(30)]
        public string Etab_Name { get; set; }

        [StringLength(30)]
        public string Etab_Desc { get; set; }

        public virtual Etudiant Etudiant { get; set; }
    }
}
