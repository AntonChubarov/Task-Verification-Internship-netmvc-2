using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLayer.Interfaces;

namespace BuisnessLayer
{
    public class DataManager
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
    }
}
