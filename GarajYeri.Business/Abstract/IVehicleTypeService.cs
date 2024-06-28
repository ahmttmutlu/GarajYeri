using GarajYeri.Models;
using GarajYeri.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeri.Business.Abstract
{
    public interface IVehicleTypeService 
    {
        IQueryable<VehicleType> GetAll();
        VehicleType Add(VehicleType vehicleType);
        VehicleType Update(VehicleType vehicleType);
        bool Delete(int vehicleTypeId);
        VehicleType GetById(int vehicleTypeId);

    }
}
