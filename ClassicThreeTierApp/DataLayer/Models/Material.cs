using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Material : Identificator
    {
        public int DirectoryId { get; set; } //External key
        public Directory Directory { get; set; } //Navigation property
    }
}
