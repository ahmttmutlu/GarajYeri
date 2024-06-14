using GarajYeri.Models;
using GarajYeri.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeri.Repository.Abstract
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        IEnumerable<Vehicle> GetAll(bool isAdmin, int userId);

        void DeleteVehiclesByUserId(int userId);

    }
}
