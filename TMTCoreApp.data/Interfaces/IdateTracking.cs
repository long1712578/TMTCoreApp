using System;
using System.Collections.Generic;
using System.Text;

namespace TMTCoreApp.Data.Interfaces
{
   public interface IdateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DateModified { set; get; }
    }
}
