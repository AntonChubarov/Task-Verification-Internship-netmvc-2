using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLayer.Interfaces;
using DataLayer.Models;

namespace BuisnessLayer.Implementation
{
    public class DataManager : IDataManager
    {
        private IDyrectorysRepository _dyrectorysRepository;
        private IMaterialsRepository _materialsRepository;
        
        public DataManager(IDyrectorysRepository dyrectorysRepository, IMaterialsRepository materialsRepository)
        {
            _dyrectorysRepository = dyrectorysRepository;
            _materialsRepository = materialsRepository;
        }

        public IDyrectorysRepository Dyrectorys { get { return _dyrectorysRepository; } }
        public IMaterialsRepository Materials { get { return _materialsRepository; } }

        public IEnumerable<Directory> GetAllDirectories(bool includeMaterials = false)
        {
            return _dyrectorysRepository.GetAllDirectories(includeMaterials);
        }

        public Directory GetDyrectoryById(int directoryId, bool includeMaterials = false)
        {
            return _dyrectorysRepository.GetDyrectoryById(directoryId, includeMaterials);
        }
    }
}
