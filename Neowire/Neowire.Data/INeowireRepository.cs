using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neowire.Data
{
    public interface INeowireRepository
    {
        PathLandingPageModel RequestLandingPage(Guid pathId);
        PathTypeModel GetPathTypeById(Guid pathTypeId);
    }
}
