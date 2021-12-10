using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLayer.Interfaces;

namespace BuisnessLayer
{
    class DataManager
    {
        private IDyrectorysRepository _dyrectorysRepository;
        private IMaterialsRepository _materialsRepository;
        
        public DataManager(IDyrectorysRepository dyrectorysRepository, IMaterialsRepository materialsRepository)
        {
            _dyrectorysRepository = dyrectorysRepository;
            _materialsRepository = materialsRepository;
        }
    }
}
