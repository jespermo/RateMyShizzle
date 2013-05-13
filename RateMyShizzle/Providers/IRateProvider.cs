using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RateMyShizzle.Models;

namespace RateMyShizzle.Providers
{
    public interface IRateProvider
    {
        List<RatingScoreDto> Scores { get; }
        List<RatingType> GetRatingTypes();
    }

    public class RateProvider: IRateProvider
    {
        public List<RatingScoreDto> Scores
        {
            get
            {
                using (var context = new RatingContext())
                {
                    return
                        new List<RatingScoreDto>(
                            context
                            .RatingScores
                            .Include("RatedBy")
                            .Include("RatingType")
                            .ToList()
                            .Select(CreateDto));
                }
            }
        }

        private RatingScoreDto CreateDto(RatingScore entity)
        {
            var dto = new RatingScoreDto {Name = entity.RatedBy.UserName, Score = entity.Score, RatingScoreId = entity.RatingScoreId};
            return dto;
        }

        public List<RatingType> GetRatingTypes()
        {
            using (var context = new RatingContext())
            {
                return new List<RatingType>(context.RatingTypes);
            }
        }
    }

    public class RatingScoreDto
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public int RatingScoreId { get; set; }
    }
}