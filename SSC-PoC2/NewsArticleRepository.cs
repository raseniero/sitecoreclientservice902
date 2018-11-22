using SSC_PoC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSC_PoC2.Repository
{
    public class NewsArticleRepository : Sitecore.Services.Core.IRepository<NewsArticle>
    {
        public void Add(NewsArticle entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(NewsArticle entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(NewsArticle entity)
        {
            throw new NotImplementedException();
        }

        public NewsArticle FindById(string id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<NewsArticle> GetAll()
        {
            List<NewsArticle> list = new List<NewsArticle>();

            list.Add(new NewsArticle { Id="1", Title = "News1", Description = "Description1" });

            IQueryable<NewsArticle> news = list.AsQueryable();

            return news;
        }

        public void Update(NewsArticle entity)
        {
            throw new NotImplementedException();
        }
    }
}
