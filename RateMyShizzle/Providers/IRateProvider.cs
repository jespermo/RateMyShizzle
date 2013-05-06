using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RateMyShizzle.Models;

namespace RateMyShizzle.Providers
{
    public interface IRateProvider
    {
        List<RatingScore> Scores { get; }
    }

    public class RateProvider: IRateProvider
    {
        private readonly List<RatingScore> _scores;

        public RateProvider()
        {
            _scores = new List<RatingScore>();
            _scores.Add(new RatingScore{CreatedDate = DateTime.Now,LastModifiedDate = DateTime.Now,});
        }
        public List<RatingScore> Scores
        {
            get
            {
                using (var context = new RatingContext())
                {
                    return new List<RatingScore>(context.RatingScores);
                }
            }
        }
    }
}