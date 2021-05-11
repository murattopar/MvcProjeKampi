using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace MvcProjeKampi.Controllers
{
  public class CategoryController : Controller
  {
    // GET: Category

    CategoryManager cm = new CategoryManager(new EFCategoryDAL());
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult GetCategoryList()
    {
      var categoryValues = cm.GetList();
      return View(categoryValues);
    }

    [HttpGet]
    public ActionResult AddCategory()
    {
      return View();
    }

    [HttpPost]
    public ActionResult AddCategory(Category p)
    {
      CategoryValidator categoryValidator = new CategoryValidator();
      ValidationResult results = categoryValidator.Validate(p);
      if (results.IsValid)
      {
        cm.CategoryAdd(p);
        return RedirectToAction("GetCategoryList");
      }
      else
      {
        foreach (var item in results.Errors)
        {
          ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        }
      }
      return View();
    }
  }
}