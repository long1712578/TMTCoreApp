using System;
using System.Collections.Generic;
using System.Text;

namespace TMTCoreApp.Data.Interfaces
{
    public interface IMutilLanguage<T>
    {
        T LanguageId { set; get; }
    }
}
