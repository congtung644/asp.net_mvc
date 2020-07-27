using LiteCommerce.Admin.Models;
using LiteCommerce.BusinessLayers;
using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiteCommerce.Admin.Controllers
{
    public class CountryController : Controller
    {

        // GET: Category
        public ActionResult Index(int page = 1, string searchValue = "")
        {
            int pageSize = 3;
            int rowCount = 0;
            List<Country> ListOfCountry = CountryBLL.ListOfCountries(page, pageSize, searchValue, out rowCount);
            var model = new CountryPaginationResult()
            {
                Page = page,
                PageSize = pageSize,
                RowCount = rowCount,
                SearchValue = searchValue,
                Data = ListOfCountry
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult Input(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Title = "Create new Country";
                Country newCategory = new Country()
                {
                    CountryID = 0
                };
                return View(newCategory);
            }
            else
            {
                ViewBag.Title = "Edit a Country";
                Country editCountry = CountryBLL.GetCountry(Convert.ToInt32(id));
                if (editCountry == null)
                    return RedirectToAction("Index");
                return View(editCountry);
            }

        }
        [HttpPost]
        public ActionResult Input(Country model)
        {
            try
            {
                //TODO :Kiểm tra tính hợp lệ của dữ liệu nhập vào
                if (string.IsNullOrEmpty(model.CountryName))
                    ModelState.AddModelError("CountryName", "CountryName expected");
                if (string.IsNullOrEmpty(model.Abbreviation))
                    model.Abbreviation = "";
                //TODO :Lưu dữ liệu nhập vào
                if (model.CountryID == 0)
                {

                    CountryBLL.AddCountry(model);
                }
                else
                {
                    CountryBLL.UpdateCountry(model);
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message + ":" + ex.StackTrace);
                return View(model);
            }
        }
        /// <summary>
        /// Xóa danh sách category
        /// </summary>
        /// <param name="CategoriesID"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(int[] CountryID)
        {
            if (CountryID != null)
            {
                CountryBLL.DeleteCountry(CountryID);

            }
            return RedirectToAction("Index");

        }
    }

}
