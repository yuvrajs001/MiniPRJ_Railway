namespace CodeChallange9_ques2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Mid { get; set; }

        [StringLength(50)]
        public string Moviename { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateofRelease { get; set; }
    }
}
