using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AllSides.Services;
using AllSides.Domain;
using AllSides.Domain.Enums;

namespace AllSides.API.Controllers
{
    public class ArticleController : ApiController
    {
        private ArticleService _articleService;

        public ArticleController()
        {
            _articleService = new ArticleService();
        }

        public ArticleController(ArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public IHttpActionResult Get(int viewpoint, int category, int count)
        {
            try
            {
                List<Article> articles = _articleService.GetArticles((Viewpoint)viewpoint, (Category)category, count);
                
                if (articles != null && articles.Any())
                {
                    return Ok(articles);
                }
                else
                {
                    return NotFound();
                }
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
