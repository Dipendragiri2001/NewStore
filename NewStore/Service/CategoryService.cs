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
    class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository,IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }
        public void CreateCategory(Category category)
        {
            _categoryRepository.Add(category);
        }

        public IEnumerable<Category> GetCategories()
        {
            
                return _categoryRepository.GetAll();
            
            
            
        }

        public Category GetCategory(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category GetCategory(string name)
        {
            return _categoryRepository.GetCategoryByName(name);
        }

        public void SaveCategory()
        {
            _unitOfWork.Commit();
        }
    }
}
