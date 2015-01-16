using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aytass.BLL;
using Aytass.Model;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            CategoryBLL categoryBll = new CategoryBLL();


            IEnumerable<CategoryModel> categoryModels =  categoryBll.GetAll();


            foreach (var categoryModel in categoryModels)
            {
                Console.WriteLine(categoryModel.Name);
            }

            Console.ReadLine();

        }
    }
}
