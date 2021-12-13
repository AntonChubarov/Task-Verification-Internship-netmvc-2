using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuisnessLayer.Implementation;
using DataLayer.Models;
using BuisnessLayer.Interfaces;

namespace ClassicThreeTierApp.Controllers
{
    //[Route("Directories")]
    public class DirectoriesController : Controller
    {
        private IDataManager _dataManager;

        public DirectoriesController(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        // GET: Directories
        [HttpGet]
        [Route("Directories")]
        public IActionResult Index()
        {
            return View(_dataManager.GetAllDirectories());
        }

        // GET: Directories/Details/5
        [Route("Directories/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            return View(_dataManager.GetDyrectoryById((int)id, true));
        }

        // GET: Directories/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Directories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Title,Html")] Directory directory)
        //{
        //    _repository.SaveDirectory(directory);
        //    return View(directory);
        //}

        //// GET: Directories/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    _repository.SaveDirectory(directory);
        //    return View(directory);
        //}

        // POST: Directories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Html")] Directory directory)
        //{
        //    _repository.SaveDirectory(directory);
        //    return View(directory);
        //}

        //// GET: Directories/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var directory = await _context.Directories
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (directory == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(directory);
        //}

        //// POST: Directories/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var directory = await _context.Directories.FindAsync(id);
        //    _context.Directories.Remove(directory);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool DirectoryExists(int id)
        //{
        //    return _context.Directories.Any(e => e.Id == id);
        //}
    }
}
