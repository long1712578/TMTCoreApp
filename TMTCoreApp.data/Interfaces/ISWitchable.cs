using System;
using System.Collections.Generic;
using System.Text;
using TMTCoreApp.Data.Enums;

namespace TMTCoreApp.Data.Interfaces
{
    public interface ISWitchable
    {
        Status Status { set; get; }
    }
}
