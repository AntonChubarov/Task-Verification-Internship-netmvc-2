using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Directory : Identificator
    {
        public List<Material> Materials { get; set; }
    }
}
