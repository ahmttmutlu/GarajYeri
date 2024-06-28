using GarajYeri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeri.Business.Abstract
{
    public interface IUserService
    {
        IQueryable<AppUser> GetAll();
        AppUser Add(AppUser user);
        AppUser Update(AppUser user);
        bool Delete(int userId);
        AppUser GetById(int userId);
        AppUser CheckLogin(string username,string password);
    }
}
