using System.Collections.Generic;
using System.Linq;
using BuisnessLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace BuisnessLayer.Implementation
{
    class MaterialsRepository : IMaterialsRepository
    {
        private PosgreContext _context;

        public MaterialsRepository(PosgreContext context)
        {
            _context = context;
        }

        public void DeleteMaterial(Material material)
        {
            _context.Materials.Remove(material);
            _context.SaveChanges();
        }

        public IEnumerable<Material> GetAllMaterials(bool includeDirectory = false)
        {
            var materials = _context.Materials.ToList<Material>();
            if (!includeDirectory)
            {
                foreach (Material material in materials) {
                    material.Directory = null;
                    material.DirectoryId = 0;
                }
            }
            return materials;
        }

        public Material GetMaterialById(int materialId, bool includeDirectory = false)
        {
            var material = _context.Materials.Find(materialId);
            if (!includeDirectory)
            {
                material.Directory = null;
                material.DirectoryId = 0;
            }
            return material;
        }

        public void SaveMaterial(Material material)
        {
            _context.Entry(material).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
