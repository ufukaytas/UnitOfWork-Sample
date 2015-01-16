using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aytass.BLL;
using Aytass.Model;

public partial class _Default : System.Web.UI.Page
{
    CategoryBLL categoryBll = new CategoryBLL();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_OnClick(object sender, EventArgs e)
    {
        try
        {
           


            IEnumerable<CategoryModel> categoryModels = categoryBll.GetAll();


            foreach (CategoryModel categoryModel in categoryModels)
            {
                litMessage.Text += categoryModel.CategoryID + " - " +  categoryModel.Name;
            }

        }
        catch (Exception ex)
        {
            
        }
    }

    protected void btnInsert_OnClick(object sender, EventArgs e)
    {
        try
        {
          

            CategoryModel categoryModel = new CategoryModel();

            categoryModel.Name = txtName.Text;
            categoryModel.LongDescription = txtLongDesc.Text;

            categoryBll.Insert(categoryModel);

           litMessage.Text = "eklenen kayıt : " + categoryBll.Save();
             

        }
        catch (Exception ex)
        {
            litMessage.Text = ex.Message;
        }
    }
}