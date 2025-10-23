using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NntDay09LabCF.Models;

namespace NntDay09LabCF.Controllers
{
    public class Nnt_LoaiSanPhamController : Controller
    {
        private readonly NntDay09LabCFContext _context;

        public Nnt_LoaiSanPhamController(NntDay09LabCFContext context)
        {
            _context = context;
        }

        // GET: Nnt_LoaiSanPham
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nnt_LoaiSanPhams.ToListAsync());
        }

        // GET: Nnt_LoaiSanPham/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nnt_LoaiSanPham = await _context.Nnt_LoaiSanPhams
                .FirstOrDefaultAsync(m => m.nntId == id);
            if (nnt_LoaiSanPham == null)
            {
                return NotFound();
            }

            return View(nnt_LoaiSanPham);
        }

        // GET: Nnt_LoaiSanPham/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nnt_LoaiSanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("nntId,nntMaLoai,nntTenLoai")] Nnt_LoaiSanPham nnt_LoaiSanPham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nnt_LoaiSanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nnt_LoaiSanPham);
        }

        // GET: Nnt_LoaiSanPham/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nnt_LoaiSanPham = await _context.Nnt_LoaiSanPhams.FindAsync(id);
            if (nnt_LoaiSanPham == null)
            {
                return NotFound();
            }
            return View(nnt_LoaiSanPham);
        }

        // POST: Nnt_LoaiSanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("nntId,nntMaLoai,nntTenLoai")] Nnt_LoaiSanPham nnt_LoaiSanPham)
        {
            if (id != nnt_LoaiSanPham.nntId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nnt_LoaiSanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Nnt_LoaiSanPhamExists(nnt_LoaiSanPham.nntId))
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
            return View(nnt_LoaiSanPham);
        }

        // GET: Nnt_LoaiSanPham/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nnt_LoaiSanPham = await _context.Nnt_LoaiSanPhams
                .FirstOrDefaultAsync(m => m.nntId == id);
            if (nnt_LoaiSanPham == null)
            {
                return NotFound();
            }

            return View(nnt_LoaiSanPham);
        }

        // POST: Nnt_LoaiSanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nnt_LoaiSanPham = await _context.Nnt_LoaiSanPhams.FindAsync(id);
            if (nnt_LoaiSanPham != null)
            {
                _context.Nnt_LoaiSanPhams.Remove(nnt_LoaiSanPham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Nnt_LoaiSanPhamExists(int id)
        {
            return _context.Nnt_LoaiSanPhams.Any(e => e.nntId == id);
        }
    }
}
