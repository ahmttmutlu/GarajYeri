using GarajYeri.Models;
using GarajYeri.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeri.Repository.Abstract
{
    public interface IVehiclePhotoRepository : IRepository<VehiclePhoto>
    {
        IEnumerable<VehiclePhoto> GetAll(Guid vehicleGuid);
    }
}
