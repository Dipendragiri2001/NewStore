using NewStore.Models;
using NewStore.ViewModels;
using Store.Model;
using Store.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewStore.Controllers
{
    public class GadgetController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IGadgetService _gadgetService;

        public GadgetController(ICategoryService categoryService, IGadgetService gadgetService)
        {
            _categoryService = categoryService;
            _gadgetService = gadgetService;
        }
        // GET: Gadget
        public ActionResult Index()
        {



            var categories = from x in _categoryService.GetCategories()
                             select new CategoryViewModel()
                             {
                                 CategoryId = x.CategoryId,
                                 Name = x.Name,


                             };
            return View(categories);
        }

        [HttpPost]
        public ActionResult Create(GadgetFormViewModel newGadget)
        {
            if(newGadget !=null && newGadget.File!=null)
            {
                var gadget = new Gadget();

                newGadget.GadgetTitle = gadget.Name;
                newGadget.GadgetPrice = gadget.Price;
                newGadget.GadgetDescription = gadget.Description;
                newGadget.GadgetCategory = gadget.CategoryId;

                string gadgetPicture = System.IO.Path.GetFileName(newGadget.File.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/images/"), gadgetPicture);

                _gadgetService.SaveGadget();
            }
            var category = _categoryService.GetCategory(newGadget.GadgetCategory);
            return RedirectToAction("Index", new { category = category.Name });
        }

        public ActionResult Filter( string category, string gadgetName)
        {
            
            IEnumerable<Gadget> gadgets = _gadgetService.GetCategoryGadgets(category,gadgetName);

            var cg = from x in gadgets
                     select new GadgetViewModel()
                     {
                         GadgetId= x.GadgetId,
                         CategoryId = x.CategoryId,
                         Name= x.Name
                     };

            return View(cg);
        }
    }
}