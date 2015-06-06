using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AllSides.Domain.Enums
{
    public enum Outlet
    {
        [Description("Fox News")]
        FoxNews,

        [Description("CNN")]
        CNN,

        [Description("MSNBC")]
        MSNBC,

        [Description("The Huffington Post")]
        TheHuffingtonPost,

        [Description("The Wall Street Journal")]
        TheWallStreetJournal,

        [Description("Mother Jones")]
        MotherJones,

        [Description("The Daily Caller")]
        TheDailyCaller,

        [Description("NPR")]
        NPR,

        [Description("New York Post")]
        NYPost,

        [Description("Politico")]
        Politico,

        [Description("The Slate")]
        TheSlate,

        [Description("Townhall.com")]
        Townhall,

        Other
    }
}
