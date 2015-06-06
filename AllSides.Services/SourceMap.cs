using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllSides.Domain;
using AllSides.Domain.Enums;

namespace AllSides.Services
{
    public class SourceMap
    {
        public List<Source> GetSources(Viewpoint viewpoint, Category category)
        {
            return _sources.Where(x => x.Viewpoint == viewpoint && x.Category == category).ToList();
        }

        private static List<Source> _sources = new List<Source> {
            // world news articles
            new Source { Viewpoint = Viewpoint.Left, Category = Category.World, Outlet = Outlet.NPR, Uri = "http://www.npr.org/rss/rss.php?id=1004" },
            new Source { Viewpoint = Viewpoint.Left, Category = Category.World, Outlet = Outlet.TheHuffingtonPost, Uri = "http://www.huffingtonpost.com/feeds/verticals/world/index.xml" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.World, Outlet = Outlet.FoxNews, Uri = "http://feeds.foxnews.com/foxnews/world" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.World, Outlet = Outlet.TheDailyCaller, Uri = "http://feeds.feedburner.com/dailycaller-world?format=xml" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.World, Outlet = Outlet.Townhall, Uri = "http://townhall.com/xml/news/category/world/" },

            // US news articles
            new Source { Viewpoint = Viewpoint.Left, Category = Category.US, Outlet = Outlet.NPR, Uri = "http://www.npr.org/rss/rss.php?id=1003" },
            new Source { Viewpoint = Viewpoint.Left, Category = Category.US, Outlet = Outlet.MotherJones, Uri = "http://feeds.feedburner.com/motherjones/radio?format=xml" },
            new Source { Viewpoint = Viewpoint.Left, Category = Category.US, Outlet = Outlet.MSNBC, Uri = "http://www.msnbc.com/feeds/latest" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.US, Outlet = Outlet.FoxNews, Uri = "http://feeds.foxnews.com/foxnews/national" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.US, Outlet = Outlet.TheDailyCaller, Uri = "http://feeds.feedburner.com/dailycaller-us?format=xml" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.US, Outlet = Outlet.Townhall, Uri = "http://townhall.com/xml/news/category/us/" },

            // entertainment news articles
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Entertainment, Outlet = Outlet.TheHuffingtonPost, Uri = "http://www.huffingtonpost.com/feeds/verticals/entertainment/index.xml" },
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Entertainment, Outlet = Outlet.NPR, Uri = "http://www.npr.org/rss/rss.php?id=1008" },
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Entertainment, Outlet = Outlet.TheSlate, Uri = "http://feeds.slate.com/slate-3184" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Entertainment, Outlet = Outlet.FoxNews, Uri = "http://feeds.foxnews.com/foxnews/entertainment" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Entertainment, Outlet = Outlet.TheDailyCaller, Uri = "http://feeds.feedburner.com/dailycaller-entertainment?format=xml" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Entertainment, Outlet = Outlet.NYPost, Uri = "http://nypost.com/entertainment/feed/" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Entertainment, Outlet = Outlet.Townhall, Uri = "http://townhall.com/xml/news/category/entertainment/" },

            // political news articles
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Politics, Outlet = Outlet.TheHuffingtonPost, Uri = "http://www.huffingtonpost.com/feeds/verticals/politics/index.xml" },
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Politics, Outlet = Outlet.MotherJones, Uri = "http://feeds.feedburner.com/motherjones/Politics?format=xml" },
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Politics, Outlet = Outlet.NPR, Uri = "http://www.npr.org/rss/rss.php?id=1014" },
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Politics, Outlet = Outlet.Politico, Uri = "http://www.politico.com/rss/congress.xml" },
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Politics, Outlet = Outlet.TheSlate, Uri = "http://feeds.slate.com/slate-101526" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Politics, Outlet = Outlet.FoxNews, Uri = "http://feeds.foxnews.com/foxnews/politics" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Politics, Outlet = Outlet.TheDailyCaller, Uri = "http://feeds.feedburner.com/dailycaller-politics?format=xml" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Politics, Outlet = Outlet.Townhall, Uri = "http://townhall.com/xml/news/category/politics-elections/" },

            // sports news articles
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Sports, Outlet = Outlet.NPR, Uri = "http://www.npr.org/rss/rss.php?id=1055"},
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Sports, Outlet = Outlet.FoxNews, Uri = "http://feeds.foxnews.com/foxnews/sports" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Sports, Outlet = Outlet.TheDailyCaller, Uri = "http://feeds.feedburner.com/dailycaller-sports?format=xml" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Sports, Outlet = Outlet.NYPost, Uri = "http://nypost.com/sports/feed/" },

            // opinion pieces
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Opinion, Outlet = Outlet.NPR, Uri = "http://www.npr.org/rss/rss.php?id=1057" },
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Opinion, Outlet = Outlet.Politico, Uri = "http://www.politico.com/rss/media.xml" },
            new Source { Viewpoint = Viewpoint.Left, Category = Category.Opinion, Outlet = Outlet.Politico, Uri = "http://www.politico.com/rss/undertheradar.xml" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Opinion, Outlet = Outlet.FoxNews, Uri = "http://feeds.foxnews.com/foxnews/opinion" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Opinion, Outlet = Outlet.TheDailyCaller, Uri = "http://feeds.feedburner.com/dailycaller-opinion?format=xml" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Opinion, Outlet = Outlet.NYPost, Uri = "http://nypost.com/opinion/feed/" },
            new Source { Viewpoint = Viewpoint.Right, Category = Category.Opinion, Outlet = Outlet.Townhall, Uri = "http://townhall.com/xml/columnists/" }
        };
    }
}
