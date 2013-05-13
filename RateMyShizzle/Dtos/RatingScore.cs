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
        public DbSet<RatingType> RatingTypes { get; set; }
    }

    [Table("RatingScore")]
    public class RatingScore
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RatingScoreId {get; protected set; }
        
        public virtual UserProfile RatedBy { get; set; }
        [ForeignKey("RatedBy")]
        public int RatedById { get; set; }
        public int Score { get; set; }
        
        public virtual RatingType RatingType { get; set; }
        [ForeignKey("RatingType")]
        public int RatingTypeId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
    [Table("RatingType")]
    public class RatingType
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RatingTypeId { get; protected set; }
        public int MaxScore { get; set; }
        public string Name { get; set; }
    }
}