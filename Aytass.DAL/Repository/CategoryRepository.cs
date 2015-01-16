using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aytass.DAL.Interface;
using Aytass.Entity;
using Aytass.Model;

namespace Aytass.DAL.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly AytassCMSEntities _entities;

        public CategoryRepository(AytassCMSEntities entities)
        {
            _entities = entities;
        }

        public IEnumerable<CategoryModel> GetAll()
        {


            // return (_entities.Categories.Select(q => new CategoryModel()));


            List<Category> list = (from q in _entities.Categories select q).ToList();

            return list.Select(
                category => new CategoryModel  
                {
                    CategoryID = category.CategoryID,
                    Name = category.Name,
                    Title = category.Title,
                    MetaK = category.MetaK,
                    MetaD = category.MetaD,
                    LongDescription = category.LongDescription,
                    Picture = category.Picture
                }).ToList();
        }

        public CategoryModel GetAllByID(int id)
        {
            return (from q in _entities.Categories where (q.CategoryID == id) select new CategoryModel()).ToList()[0];
        }

        public void Insert(CategoryModel categoryModel)
        {
            Category category = new Category
            {
                Name = categoryModel.Name,
                Title = categoryModel.Title,
                MetaK = categoryModel.MetaK,
                MetaD = categoryModel.MetaD,
                LongDescription = categoryModel.LongDescription
            };

            _entities.Categories.Add(category);
        }

        public void Delete(int id)
        {
            Category category = new Category();
            category.CategoryID = id;

            _entities.Categories.Remove(category);
        }

        public void Update(CategoryModel categoryModel)
        {
            Category category = new Category
            {
                CategoryID = categoryModel.CategoryID,
                Name = categoryModel.Name,
                Title = categoryModel.Title,
                MetaK = categoryModel.MetaK,
                MetaD = categoryModel.MetaD,
                LongDescription = categoryModel.LongDescription
            };

            _entities.Categories.Add(category);
        }

        public int Save()
        {
            return _entities.SaveChanges();
        }
    }
}
