using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Sitecore.Services;
using SSC_PoC2.Models;
using SSC_PoC2.Repository;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace SSC_PoC2.Controller
{
    [ValidateAntiForgeryToken]
    [Sitecore.Services.Core.ServicesController]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NewsArticleController : EntityService<NewsArticle>
    {
        public NewsArticleController(IRepository<NewsArticle> repository) : base(repository)
        {
        }
        public NewsArticleController() : this(new NewsArticleRepository())
        {
        }
    }
}
