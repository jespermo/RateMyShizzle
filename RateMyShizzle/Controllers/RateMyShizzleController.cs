using System.Linq;
using System.Web.Mvc;
using RateMyShizzle.Providers;
using log4net;

namespace RateMyShizzle.Controllers
{
    public class RateMyShizzleController : Controller
    {
        private readonly IRateProvider _rateProvider;
        public static readonly ILog Logger = LogManager.GetLogger(typeof (RateMyShizzleController));

        public RateMyShizzleController(IRateProvider rateProvider)
        {
            _rateProvider = rateProvider;
        }

        //
        // GET: /RateMyShizzle/
        [Authorize]
        public ActionResult Index()
        {
            //Get user polls and add to viewbag
            Logger.InfoFormat("name: {0}",User.Identity);
            return View(User.Identity);
        }

        public ActionResult GetRating(int? id)
        {
            var valueOrDefault = id.GetValueOrDefault(0);
            var ratingScores = _rateProvider.Scores.Where(s => s.RatingScoreId == valueOrDefault);

            return View(ratingScores);
        }
        
        public ActionResult GetRatingTypes()
        {
            ViewBag.RatingTypes = _rateProvider.GetRatingTypes();
            return View();

        }

    }
}
