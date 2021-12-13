using System.Collections.Generic;
using System.Linq;
using BuisnessLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace BuisnessLayer.Implementation
{
    public class DirectorysRepository : IDyrectorysRepository
    {
        private PosgreContext _context;

        public DirectorysRepository(PosgreContext context)
        {
            _context = context;
        }

        public void DeleteDirectory(Directory acheive)
        {
            _context.Directories.Remove(acheive);
            _context.SaveChanges();
        }

        public IEnumerable<Directory> GetAllDirectories(bool includeMaterials = false)
        {
            var directories = _context.Directories.ToList<Directory>();
            if (!includeMaterials)
            {
                foreach (Directory directory in directories)
                {
                    directory.Materials = null;
                }
            }
            return directories;
        }

        public Directory GetDyrectoryById(int directoryId, bool includeMaterials = false)
        {
            var directory = new Directory();
            if (includeMaterials)
            {
                directory = _context.Directories
                    .Include(m => m.Materials)
                    .Where(d => d.Id == directoryId).FirstOrDefault();
            }
            else
            {
                directory = _context.Directories.Where(d => d.Id == directoryId).FirstOrDefault();
            }
            return directory;
        }

        public void SaveDirectory(Directory acheive)
        {
            _context.Entry(acheive).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
