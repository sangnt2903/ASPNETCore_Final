using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPCore_Final.Models;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;

namespace ASPCore_Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class NhanViensController : Controller
    {
        private readonly ESHOPContext _context;

        public NhanViensController(ESHOPContext context)
        {
            _context = context;
        }

        // GET: Admin/NhanViens
        [HttpGet("/admin/NhanViens")]
        public async Task<IActionResult> Index(string searchString, int page = 1, string sortExpression = "Email")
        {
                    var eSHOPContext = _context.NhanVien.AsNoTracking().Include(n => n.MaPqNavigation).AsQueryable();
                    if (!string.IsNullOrEmpty(searchString))
                    {
                        eSHOPContext = eSHOPContext.Where(p => p.Email.Contains(searchString) || p.HoTen.Contains(searchString));
                    }
                    var model = await PagingList.CreateAsync(eSHOPContext, 1, page, sortExpression, "Email");
                    model.RouteValue = new RouteValueDictionary {
                { "searchString", searchString}
            };
           // var qry = _context.NhanVien.AsNoTracking().OrderBy(p => p.Email);
           // var model = await PagingList.CreateAsync(qry, 1, page);
            return View(model);
        }

        // GET: Admin/NhanViens/Details/5
        [HttpGet("/admin/NhanViens/Details")]
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien
                .Include(n => n.MaPqNavigation)
                .FirstOrDefaultAsync(m => m.MaNv == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }

        // GET: Admin/NhanViens/Create
        [HttpGet("/admin/NhanViens/Create")]
        public IActionResult Create()
        {
            ViewData["MaPq"] = new SelectList(_context.PhanQuyen, "MaPq", "MaPq");
            return View();
        }

        // POST: Admin/NhanViens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaNv,HoTen,Email,MatKhau,MaPq,TrangThaiHd")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaPq"] = new SelectList(_context.PhanQuyen, "MaPq", "MaPq", nhanVien.MaPq);
            return View(nhanVien);
        }

        // GET: Admin/NhanViens/Edit/5
        [HttpGet("/admin/NhanViens/Edit")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            ViewData["MaPq"] = new SelectList(_context.PhanQuyen, "MaPq", "MaPq", nhanVien.MaPq);
            return View(nhanVien);
        }

        // POST: Admin/NhanViens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaNv,HoTen,Email,MatKhau,MaPq,TrangThaiHd")] NhanVien nhanVien)
        {
         

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhanVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhanVienExists(nhanVien.MaNv))
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
            ViewData["MaPq"] = new SelectList(_context.PhanQuyen, "MaPq", "MaPq", nhanVien.MaPq);
            return View(nhanVien);
        }

        // GET: Admin/NhanViens/Delete/5
        [HttpGet("/admin/Nhanviens/Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien
                .Include(n => n.MaPqNavigation)
                .FirstOrDefaultAsync(m => m.MaNv == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }

        // POST: Admin/NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nhanVien = await _context.NhanVien.FindAsync(id);
            _context.NhanVien.Remove(nhanVien);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhanVienExists(int id)
        {
            return _context.NhanVien.Any(e => e.MaNv == id);
        }
    }
}
