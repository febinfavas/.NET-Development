using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCCricketApp.Data;
using MVCCricketApp.Models;

namespace MVCCricketApp.Controllers
{
    public class CricketsController : Controller
    {
        private readonly MVCCricketAppContext _context;

        public CricketsController(MVCCricketAppContext context)
        {
            _context = context;
        }

        // GET: Crickets
        public async Task<IActionResult> Index(string searchString )
        {
            var cricket = from m in _context.Cricket
                          select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                cricket = cricket.Where(s => s.Position.Contains(searchString));
            }


            return View(await cricket.ToListAsync());

            //return View(await _context.Cricket.ToListAsync());
        }


        // GET: Crickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cricket = await _context.Cricket
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cricket == null)
            {
                return NotFound();
            }

            return View(cricket);
        }

        // GET: Crickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Crickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PlayerNum,PlayerName,Position,IplTeam")] Cricket cricket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cricket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cricket);
        }

        // GET: Crickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cricket = await _context.Cricket.FindAsync(id);
            if (cricket == null)
            {
                return NotFound();
            }
            return View(cricket);
        }

        // POST: Crickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PlayerNum,PlayerName,Position,IplTeam")] Cricket cricket)
        {
            if (id != cricket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cricket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CricketExists(cricket.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cricket);
        }

        // GET: Crickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cricket = await _context.Cricket
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cricket == null)
            {
                return NotFound();
            }

            return View(cricket);
        }

        // POST: Crickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cricket = await _context.Cricket.FindAsync(id);
            _context.Cricket.Remove(cricket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CricketExists(int id)
        {
            return _context.Cricket.Any(e => e.Id == id);
        }
    }
}
