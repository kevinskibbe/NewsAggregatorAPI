using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using AllSides.Domain;

namespace AllSides.Services
{
    public class RssReader
    {
        public List<Article> GetArticles(string feed, int count)
        {
            List<Article> results = new List<Article>();
            XmlReader reader = XmlReader.Create(feed);
            SyndicationFeed syndicationFeed = SyndicationFeed.Load(reader);
            reader.Close();

            foreach(SyndicationItem item in syndicationFeed.Items.OrderBy(x => x.PublishDate.DateTime))
            {
                Article article = new Article();
                article.Headline = item.Title.Text;
                article.Link = item.Links[0].Uri.OriginalString;
                article.Dateline = item.PublishDate.DateTime;
                results.Add(article);

                if (results.Count == count)
                {
                    break;
                }
            }

            return results;
        }
    }
}
