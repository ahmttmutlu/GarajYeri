﻿using GarajYeri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeri.Business.Abstract
{
    public interface IVehiclePhotoService
    {
        IQueryable<VehiclePhoto> GetAll(Guid guid);
        bool Delete(int id);
        VehiclePhoto Update(VehiclePhoto vehiclePhoto);
    }
}
