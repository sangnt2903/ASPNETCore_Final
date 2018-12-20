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
    public class LoaiQCsController : Controller
    {
        private readonly ESHOPContext _context;

        public LoaiQCsController(ESHOPContext context)
        {
            _context = context;
        }

        // GET: Admin/LoaiQCs
        [HttpGet("/admin/LoaiQCs")]
        public async Task<IActionResult> Index(string searchString, int page = 1, string sortExpression = "TenQc")
        {
            var eSHOPContext = _context.LoaiQc.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                eSHOPContext = eSHOPContext.Where(p => p.TenQc.Contains(searchString) || p.LoaiQc1.Contains(searchString));
            }
            var model = await PagingList.CreateAsync(eSHOPContext, 5, page, sortExpression, "TenQc");
            model.RouteValue = new RouteValueDictionary {
                { "searchString", searchString}
            };
            // var qry = _context.NhanVien.AsNoTracking().OrderBy(p => p.Email);
            // var model = await PagingList.CreateAsync(qry, 1, page);
            return View(model);
        }

        // GET: Admin/LoaiQCs/Details/5
        [HttpGet("/admin/LoaiQCs/Details")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiQc = await _context.LoaiQc
                .FirstOrDefaultAsync(m => m.LoaiQc1 == id);
            if (loaiQc == null)
            {
                return NotFound();
            }

            return View(loaiQc);
        }

        // GET: Admin/LoaiQCs/Create
        [HttpGet("/admin/LoaiQCs/Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiQCs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoaiQc1,TenQc")] LoaiQc loaiQc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiQc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiQc);
        }

        // GET: Admin/LoaiQCs/Edit/5
        [HttpGet("/admin/LoaiQCs/Edit")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiQc = await _context.LoaiQc.FindAsync(id);
            if (loaiQc == null)
            {
                return NotFound();
            }
            return View(loaiQc);
        }

        // POST: Admin/LoaiQCs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LoaiQc1,TenQc")] LoaiQc loaiQc)
        {
            if (id != loaiQc.LoaiQc1)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiQc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiQcExists(loaiQc.LoaiQc1))
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
            return View(loaiQc);
        }
        // DELETE: api/LoaiQCs/5
        [HttpDelete("/api/LoaiQCs/{id}")]
        public async Task<IActionResult> DeleteLoaiQC(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loaiqc = await _context.LoaiQc.FindAsync(id);
            if (loaiqc == null)
            {
                return NotFound();
            }

            _context.LoaiQc.Remove(loaiqc);
            await _context.SaveChangesAsync();

            return Ok(loaiqc);
        }

        private bool LoaiQcExists(string id)
        {
            return _context.LoaiQc.Any(e => e.LoaiQc1 == id);
        }
    }
}
