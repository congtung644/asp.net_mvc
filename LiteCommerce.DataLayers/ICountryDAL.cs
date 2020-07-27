using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    public interface ICountryDAL
    {
        List<Country> GetAll();
        List<Country> List(int page, int pagesize, string searchValue);
        /// <summary>
        /// Đếm số lượng Category
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        int Count(string searchValue);
        /// <summary>
        /// Lấy Category
        /// </summary>
        /// <returns></returns>
        Country Get(int countryID);
        /// <summary>
        /// Thêm Category.Hàm trả về ID Category được bổ sung.
        /// Nếu lỗi ,hàm trả về giá trj nhỏ hơn hoặc bằng 0.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Add(Country data);
        /// <summary>
        /// Sữa đỗi 1 Category.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(Country data);
        /// <summary>
        /// Xóa nhiều Category.
        /// Trả về số lượng được xóa.
        /// </summary>
        /// <param name="categoryIDs"></param>
        /// <returns></returns>
        int Delete(int[] countryIDs);
        /// <summary>
        /// Lay tat ca categories
        /// </summary>
        /// <returns></returns>

    }
}
