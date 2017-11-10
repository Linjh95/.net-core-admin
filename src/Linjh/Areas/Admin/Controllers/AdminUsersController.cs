using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Linjh.DBcontext;
using Linjh.Models;

namespace Linjh.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminUsersController : Controller
    {
        private readonly LinDbcontext _context;

        public AdminUsersController(LinDbcontext context)
        {
            _context = context;
        }

        // GET: Admin/AdminUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdminUser.ToListAsync());
        }

        // GET: Admin/AdminUsers/Details/5
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var adminUser = await _context.AdminUser
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    if (adminUser == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(adminUser);
        //}

        // GET: Admin/AdminUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("UserName,Name,Email,Password,Remarks,CreateTime,Id")] AdminUser adminUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        adminUser.Id = Guid.NewGuid();
        //        _context.Add(adminUser);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(adminUser);
        //}

        // GET: Admin/AdminUsers/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var adminUser = await _context.AdminUser.SingleOrDefaultAsync(m => m.Id == id);
        //    if (adminUser == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(adminUser);
        //}

        // POST: Admin/AdminUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("UserName,Name,Email,Password,Remarks,CreateTime,Id")] AdminUser adminUser)
        //{
        //    if (id != adminUser.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(adminUser);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!AdminUserExists(adminUser.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(adminUser);
        //}

        // GET: Admin/AdminUsers/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var adminUser = await _context.AdminUser
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    if (adminUser == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(adminUser);
        //}

        // POST: Admin/AdminUsers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var adminUser = await _context.AdminUser.SingleOrDefaultAsync(m => m.Id == id);
        //    _context.AdminUser.Remove(adminUser);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool AdminUserExists(Guid id)
        //{
        //    return _context.AdminUser.Any(e => e.Id == id);
        //}
    }
}
