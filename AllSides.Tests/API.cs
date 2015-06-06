using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllSides.Domain;
using AllSides.Services;
using AllSides.Domain.Enums;
using AllSides.API.Controllers;
using System.Web.Http;
using System.Web.Http.Results;

namespace AllSides.Tests
{
    [TestClass]
    public class API
    {
        [TestMethod]
        public void GrabLeftWorldArticlesFromWebAPI()
        {
            ArticleController controller = new ArticleController();
            IHttpActionResult result = controller.Get(1, 1, 10);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GrabLeftWorldArticlesFromWebAPIWithNegativeCount()
        {
            ArticleController controller = new ArticleController();
            IHttpActionResult result = controller.Get(1, 1, -1);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void GrabLeftWorldArticlesFromWebAPIWithHighCount()
        {
            ArticleController controller = new ArticleController();
            IHttpActionResult result = controller.Get(1, 1, 1000000);
            Assert.IsInstanceOfType(result, typeof(OkNegotiatedContentResult<List<Article>>));
        }

        [TestMethod]
        public void GrabLeftWorldArticlesFromWebAPIWithInvalidViewpoint()
        {
            ArticleController controller = new ArticleController();
            IHttpActionResult result = controller.Get(-1, 1, 10);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void GrabLeftWorldArticlesFromWebAPIWithInvalidCategory()
        {
            ArticleController controller = new ArticleController();
            IHttpActionResult result = controller.Get(1, -1, 10);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}
