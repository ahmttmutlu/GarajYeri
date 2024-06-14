using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeri.Models
{
    public class VehiclePhoto : BaseModel
    {
        public string Description { get; set; }
        public string Path { get; set; }//dosya yolu ya da adı 
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
