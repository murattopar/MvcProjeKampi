using DataAccessLayer.Abstract;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public class CategoryManager : ICategoryService
  {
    ICategoryDAL _categoryDal;
    public CategoryManager(ICategoryDAL categoryDal)
    {
      _categoryDal = categoryDal;
    }

    public List<Category> GetList()
    {
      return _categoryDal.List();
    }

    public void CategoryAdd(Category category)
    {
      _categoryDal.Insert(category);
    }
  }
}
