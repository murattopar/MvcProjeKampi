using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public class CategoryManager
  {
    GenericRepository<Category> repos = new GenericRepository<Category>();

    public List<Category> GetAll()
    {
      return repos.List();
    }
    public void AddCategory(Category p)
    {
      if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length > 50)
      {
        // hata mesajı
      }
      else
      {
        repos.Insert(p);
      }
    }

  }
}
