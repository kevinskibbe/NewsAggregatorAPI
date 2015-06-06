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
    public class Domain
    {
        [TestMethod]
        public void NewUpArticle()
        {
            Article article = new Article();
            Assert.IsNotNull(article);
        }

        [TestMethod]
        public void EnsureOutletNameIsAvailable()
        {
            Source source = new Source { Outlet = Outlet.TheHuffingtonPost };
            Assert.AreEqual("The Huffington Post", source.OutletName);
        }
    }
}
