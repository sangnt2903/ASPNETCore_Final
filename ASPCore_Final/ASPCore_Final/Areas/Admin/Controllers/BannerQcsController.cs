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
    public class BannerQcsController : Controller
    {
        private readonly ESHOPContext _context;

        public BannerQcsController(ESHOPContext context)
        {
            _context = context;
        }

        // GET: Admin/BannerQcs
        [HttpGet("/admin/BannerQcs")]
        public async Task<IActionResult> Index(string searchString, int page = 1, string sortExpression = "NgayKetThucQc")
        {
            var eSHOPContext = _context.BannerQc.AsNoTracking().Include(n => n.LoaiQcNavigation).AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                eSHOPContext = eSHOPContext.Where(p => p.LoaiQc.Contains(searchString) || p.NoiDungQc.Contains(searchString));
            }
            var model = await PagingList.CreateAsync(eSHOPContext, 5, page, sortExpression, "NgayKetThucQc");
            model.RouteValue = new RouteValueDictionary {
                { "searchString", searchString}
            };
         
            return View(model);
            //var eSHOPContext = _context.BannerQc.Include(b => b.LoaiQcNavigation);
            //return View(await eSHOPContext.ToListAsync());
        }

        // GET: Admin/BannerQcs/Details/5
        [HttpGet("/admin/BannerQcs/Details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bannerQc = await _context.BannerQc
                .Include(b => b.LoaiQcNavigation)
                .FirstOrDefaultAsync(m => m.MaQc == id);
            if (bannerQc == null)
            {
                return NotFound();
            }

            return View(bannerQc);
        }

        // GET: Admin/BannerQcs/Create
        [HttpGet("/admin/BannerQcs/Create")]
        public IActionResult Create()
        {
            ViewData["LoaiQc"] = new SelectList(_context.LoaiQc, "LoaiQc1", "LoaiQc1");
            return View();
        }

        // POST: Admin/BannerQcs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaQc,NoiDungQc,NgayTao,Hinh,NgayKetThucQc,LoaiQc")] BannerQc bannerQc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bannerQc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LoaiQc"] = new SelectList(_context.LoaiQc, "LoaiQc1", "LoaiQc1", bannerQc.LoaiQc);
            return View(bannerQc);
        }

        // GET: Admin/BannerQcs/Edit/5
        [HttpGet("/admin/BannerQcs/Edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bannerQc = await _context.BannerQc.FindAsync(id);
            if (bannerQc == null)
            {
                return NotFound();
            }
            ViewData["LoaiQc"] = new SelectList(_context.LoaiQc, "LoaiQc1", "LoaiQc1", bannerQc.LoaiQc);
            return View(bannerQc);
        }

        // POST: Admin/BannerQcs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaQc,NoiDungQc,NgayTao,Hinh,NgayKetThucQc,LoaiQc")] BannerQc bannerQc)
        {
            if (id != bannerQc.MaQc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bannerQc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BannerQcExists(bannerQc.MaQc))
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
            ViewData["LoaiQc"] = new SelectList(_context.LoaiQc, "LoaiQc1", "LoaiQc1", bannerQc.LoaiQc);
            return View(bannerQc);
        }
        // DELETE: api/BannerQcs/5
        [HttpDelete("/api/BannerQcs/{id}")]
        public async Task<IActionResult> DeleteBanner(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bn = await _context.BannerQc.FindAsync(id);
            if (bn == null)
            {
                return NotFound();
            }

            _context.BannerQc.Remove(bn);
            await _context.SaveChangesAsync();

            return Ok(bn);
        }


        private bool BannerQcExists(int id)
        {
            return _context.BannerQc.Any(e => e.MaQc == id);
        }
    }
}
