using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Suppliers.DataModel;
using SuppliersINV.App.Models;
using SuppliersINV.App.Models.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace SuppliersINV.App.Controllers
{
    [Authorize]

    public class ProductController : Controller
    {
        private readonly IProductRepo repo;
        private readonly IMapper mapper;
        private readonly AppDbContext context;


        public ProductController(IProductRepo repo, IMapper mapper, AppDbContext context)
        {
            this.repo = repo;
            this.mapper = mapper;
            this.context = context;

        }
        public async Task<IActionResult> Index()
        {

            return View(mapper.Map<List<ProductVM>>(await repo.GetAllAsync()));
        }

        public IActionResult Add()
        {
            return View(new ProductVM());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        //public async Task<IActionResult> Add(ProductVM model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await repo.AddAsync(mapper.Map<Product>(model));
        //        return RedirectToAction("Index");

        //    }
        //    else
        //    {
        //        return View(model);
        //    }
        //}

        public async Task<IActionResult> Add(ProductVM model)
        {
            if (ModelState.IsValid)
            {
                var product = mapper.Map<Product>(model);
                // Set other properties of the product as needed

                await repo.AddAsync(product);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(int ProductID)
        {
            await repo.DeleteAsync(ProductID);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ProductVM product = mapper.Map<ProductVM>(await repo.GetAsync((int)id));
            return View(product);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(ProductVM model)
        {
            if (ModelState.IsValid)
            {
                var existingProduct = await repo.GetAsync(model.ProductID);
                if (existingProduct == null)
                {
                    return RedirectToAction("Index");
                }

                // Exclude the DateAdded property from being modified
                model.DateAdded = existingProduct.DateAdded;

                // Update the other properties of the existing product
                existingProduct.Name = model.Name; // Replace with actual properties
                existingProduct.Description = model.Description;
                existingProduct.Qty = model.Qty;
                existingProduct.Unit = model.Unit;
                existingProduct.DateModified = model.DateModified;
                await repo.UpdateAsync(existingProduct);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }


    }
}


