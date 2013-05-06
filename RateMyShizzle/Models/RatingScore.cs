using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RateMyShizzle.Models
{
    public class RatingContext : DbContext
    {
        public RatingContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<RatingScore> RatingScores { get; set; }
        
    }


    [Table("RatingScore")]
    public class RatingScore
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RatingScoreId { get; set; }
        public int RatedBy { get; set; }

        public int Score { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}