using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllSides.Domain;
using AllSides.Services;
using AllSides.Domain.Enums;
using AllSides.API.Controllers;
using System.Web.Http;

namespace AllSides.Tests
{
    [TestClass]
    public class Service
    {
        [TestMethod]
        public void GrabArticlesFromFeed()
        {
            RssReader reader = new RssReader();
            List<Article> articles = reader.GetArticles("http://rss.cnn.com/rss/edition.rss", 10);
            Assert.IsFalse(articles.Count == 0);
        }

        [TestMethod]
        public void GetSourcesFromSourceMap()
        {
            SourceMap map = new SourceMap();
            List<Source> sources = map.GetSources(Viewpoint.Left, Category.World);
            Assert.IsNotNull(sources);
            Assert.IsTrue(sources.Count > 0);
        }

        [TestMethod]
        public void GrabLeftWorldArticlesFromArticleService()
        {
            ArticleService articleService = new ArticleService();
            List<Article> articles = articleService.GetArticles(Viewpoint.Left, Category.World, 10);
            Assert.IsNotNull(articles);
            Assert.AreEqual(articles.Count, 10);
        }

        [TestMethod]
        public void GrabRightWorldArticlesFromArticleService()
        {
            ArticleService articleService = new ArticleService();
            List<Article> articles = articleService.GetArticles(Viewpoint.Right, Category.World, 10);
            Assert.IsNotNull(articles);
            Assert.AreEqual(articles.Count, 10);
        }

        [TestMethod]
        public void GrabLeftUSArticlesFromArticleService()
        {
            ArticleService articleService = new ArticleService();
            List<Article> articles = articleService.GetArticles(Viewpoint.Left, Category.US, 10);
            Assert.IsNotNull(articles);
            Assert.AreEqual(articles.Count, 10);
        }

        [TestMethod]
        public void GrabRightUSArticlesFromArticleService()
        {
            ArticleService articleService = new ArticleService();
            List<Article> articles = articleService.GetArticles(Viewpoint.Right, Category.US, 10);
            Assert.IsNotNull(articles);
            Assert.AreEqual(articles.Count, 10);
        }

        [TestMethod]
        public void GrabLeftEntertainmentArticlesFromArticleService()
        {
            ArticleService articleService = new ArticleService();
            List<Article> articles = articleService.GetArticles(Viewpoint.Left, Category.Entertainment, 10);
            Assert.IsNotNull(articles);
            Assert.AreEqual(articles.Count, 10);
        }

        [TestMethod]
        public void GrabRightEntertainmentArticlesFromArticleService()
        {
            ArticleService articleService = new ArticleService();
            List<Article> articles = articleService.GetArticles(Viewpoint.Right, Category.Entertainment, 10);
            Assert.IsNotNull(articles);
            Assert.AreEqual(articles.Count, 10);
        }

        [TestMethod]
        public void GrabLeftPoliticsArticlesFromArticleService()
        {
            ArticleService articleService = new ArticleService();
            List<Article> articles = articleService.GetArticles(Viewpoint.Left, Category.Politics, 10);
            Assert.IsNotNull(articles);
            Assert.AreEqual(articles.Count, 10);
        }

        [TestMethod]
        public void GrabRightPoliticsArticlesFromArticleService()
        {
            ArticleService articleService = new ArticleService();
            List<Article> articles = articleService.GetArticles(Viewpoint.Right, Category.Politics, 10);
            Assert.IsNotNull(articles);
            Assert.AreEqual(articles.Count, 10);
        }

        [TestMethod]
        public void EnsureArticlesAreInDescendingOrderByDateline()
        {
            ArticleService articleService = new ArticleService();
            List<Article> articles = articleService.GetArticles(Viewpoint.Left, Category.World, 10);

            DateTime? previousDate = null;

            foreach (Article article in articles)
            {
                if (previousDate.HasValue)
                {
                    Assert.IsTrue(DateTime.Compare(previousDate.Value, article.Dateline) == 1);
                }

                previousDate = article.Dateline;
            }
        }
    }
}
