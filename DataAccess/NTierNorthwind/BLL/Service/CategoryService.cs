using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Service
{
    
    public class CategoryService
    {
        NorthwindEntities db = new NorthwindEntities();
        public string AddCategory(Category category)
        {
            try
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return "Kategori Eklendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }            
        }

        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }


        public string UpdateCategory(Category category)
        {

            //Category updated = db.Categories.Find(category.CategoryID);
            //updated.CategoryName = category.CategoryName;
            //updated.Description = category.Description;
            //updated.Picture = category.Picture;

            db.Entry(category).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
            return "Kategori Güncellendi";

        }

        public string DeleteCategory(int? id)
        {

            if (id!=null)
            {
                try
                {
                    Category deleted = db.Categories.Find(id);
                    db.Categories.Remove(deleted);
                    db.SaveChanges();
                    return "Kategori silindi";

                }
                catch (Exception ex )
                {

                    return ex.Message;
                }
            }
            else
            {
                return "id boş olamaz";
            }
           
        }


    }

}
