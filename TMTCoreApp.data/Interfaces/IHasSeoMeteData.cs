using System;
using System.Collections.Generic;
using System.Text;

namespace TMTCoreApp.Data.Interfaces
{
    public interface IHasSeoMeteData
    {
        string SeoPageTitle { set; get; }
        string SeoAlias { set; get; }
        string SeoKeywords { set; get; }
        string SeoDescription { get; set; }
    }
}
