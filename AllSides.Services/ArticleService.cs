using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllSides.Domain;
using AllSides.Domain.Enums;

namespace AllSides.Services
{
    public class ArticleService
    {
        private SourceMap _sourceMap;
        private RssReader _rssReader;

        public ArticleService()
        {
            _sourceMap = new SourceMap();
            _rssReader = new RssReader();
        }

        public ArticleService(SourceMap sourceMap, RssReader rssReader)
        {
            _sourceMap = sourceMap;
            _rssReader = rssReader;
        }

        public List<Article> GetArticles(Viewpoint viewpoint, Category category, int count)
        {
            List<Article> results = new List<Article>();
            List<Source> sources = _sourceMap.GetSources(viewpoint, category);

            foreach(Source source in sources)
            {
                List<Article> articlesFromSource = _rssReader.GetArticles(source.Uri, count);
                articlesFromSource.ForEach(x => x.Source = source);
                results.AddRange(articlesFromSource);
            }

            return results.OrderByDescending(x => x.Dateline).Take(count).ToList();
            
        }
    }
}
