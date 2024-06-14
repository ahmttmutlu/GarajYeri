using GarajYeri.Models;
using GarajYeri.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeri.Repository.Abstract
{
    public interface IPolicyRepository:IRepository<Policy>
    {
        IEnumerable<Policy> GetAll(Guid vehicleId);
    }

}
