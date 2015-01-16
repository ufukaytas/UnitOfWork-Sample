using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aytass.DAL;
using Aytass.Model;

namespace Aytass.BLL
{
    public class CategoryBLL
    {
        UnitOfWork unitOfWork = new UnitOfWork();


        public IEnumerable<CategoryModel> GetAll()
        {
            return unitOfWork.CategoryRepository.GetAll();
        }

        public CategoryModel GetAllByID(int id)
        {
            return unitOfWork.CategoryRepository.GetAllByID(id);
        }

        public int Insert(CategoryModel categoryModel)
        { 
            unitOfWork.CategoryRepository.Insert(categoryModel);

            unitOfWork.Save();

            return categoryModel.CategoryID;
        }

        public int Update(CategoryModel categoryModel)
        {
            unitOfWork.CategoryRepository.Update(categoryModel);

            return unitOfWork.Save();
        }

        public int Delete(int id)
        {
            unitOfWork.CategoryRepository.Delete(id);
            return unitOfWork.Save();
        }
         
    }
}
