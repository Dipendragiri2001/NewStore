using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Data;
using Store.Model;
using Store.Repositories;

namespace Store.Service
{
    public class GadgetService : IGadgetService
    {
        private readonly IGadgetRepository _gadgetsRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IUnitOfWork _unitOfWork;

        public GadgetService(IGadgetRepository gadgetRepository,ICategoryRepository categoryRepository,IUnitOfWork unitOfWork)
        {
            _gadgetsRepo = gadgetRepository;
            _categoryRepo = categoryRepository;
            _unitOfWork = unitOfWork;
        }
        public void CreateGadget(Gadget gadget)
        {
            _gadgetsRepo.Add(gadget);
        }

        public IEnumerable<Gadget> GetGadgets()
        {
            var gadgets = _gadgetsRepo.GetAll();
            return gadgets;
        }

        public IEnumerable<Gadget> GetCategoryGadgets(string categoryName, string gadgetName = null)
        {
            var category = _categoryRepo.GetCategoryByName(categoryName);
            return category.Gadgets.Where(x => x.Name.ToLower().Contains(gadgetName));
            
        }

        public Gadget GetGadget(int id)
        {
            var gadget = _gadgetsRepo.GetById(id);
            return gadget;
        }

        public void SaveGadget()
        {
            _unitOfWork.Commit();
        }
    }
}
