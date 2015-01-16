using System.Collections.Generic;
using Aytass.Model;

namespace Aytass.DAL.Interface
{
    public interface ICategory
    {
        IEnumerable<CategoryModel> GetAll();
        CategoryModel GetAllByID(int id);
        void Insert(CategoryModel category);
        void Delete(int id);
        void Update(CategoryModel category);
        int Save();
    }
}
