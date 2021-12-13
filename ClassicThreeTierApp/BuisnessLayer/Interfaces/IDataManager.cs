using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace BuisnessLayer.Interfaces
{
    public interface IDataManager
    {
        IEnumerable<Directory> GetAllDirectories(bool includeMaterials = false);
        Directory GetDyrectoryById(int directoryId, bool includeMaterials = false);
    }
}
