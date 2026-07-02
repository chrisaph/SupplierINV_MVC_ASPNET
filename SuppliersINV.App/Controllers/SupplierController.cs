using Suppliers.DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuppliersINV.App.Models;
using Microsoft.AspNetCore.Authorization;

namespace SuppliersINV.App.Controllers
{
    [Authorize]

    public class SupplierController : Controller
    {

        private readonly AppDbContext context;

        public SupplierController(AppDbContext context) 
        {
            this.context = context;
        }

        //[AllowAnonymous]

        public IActionResult Index() => View(context.SuppliersINV.ToList());
        public IActionResult Add()
        {

            return View(new Supplier());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Supplier model)
        {
            
             try
            {
                if (ModelState.IsValid == false)
                {   //Data annotation was violeted
                    return View(model);
                }
                else
                {
                    context.Add(model);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                return View(model);
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int SupplierID)
        {
            var supplier = context.SuppliersINV.Find(SupplierID);
            context.Set<Supplier>().Remove(supplier);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var suppliers = context.SuppliersINV.Find(id);
            return View(suppliers);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Supplier datePresent)
        {
            try
            {
                if (ModelState.IsValid == false)
                {   //Data annotation was violeted
                    return View(datePresent);
                }
                else
                {
                    var datePast = context.Set<Supplier>().AsNoTracking().FirstOrDefault(s => s.SupplierID == datePresent.SupplierID);
                    if (datePast == null)
                    {
                        return RedirectToAction("Index");
                    }
                    datePresent.DateAdded = datePast.DateAdded;
                    context.Set<Supplier>().Update(datePresent);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                return View(datePresent);
            }
        }

    }
}
    
