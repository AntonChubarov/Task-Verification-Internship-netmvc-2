using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace BuisnessLayer.Interfaces
{
    interface IDyrectorysRepository
    {
        IEnumerable<Directory> GetAllDirectories(bool includeMaterials = false);
        Directory GetDyrectoryById(int directoryId, bool includeMaterials = false);
        void SaveDirectory(Directory acheive);
        void DeleteDirectory(Directory acheive);
    }
}
