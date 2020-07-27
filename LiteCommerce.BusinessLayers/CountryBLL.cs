using LiteCommerce.DataLayers;
using LiteCommerce.DataLayers.SqlServer;
using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.BusinessLayers
{
    public static class CountryBLL
    {
        private static ICountryDAL CountryDB;

        public static void Initialize(string connectionString)
        {
            CountryDB = new CountryDAL(connectionString);
        }
        public static List<Country> GetList()
        {
            return CountryDB.GetAll();
        }
        public static Country GetCountry(int countryID)
        {
            return CountryDB.Get(countryID);
        }
        /// <returns></returns>
        public static List<Country> ListOfCountries(int page, int pageSize, string searchValue, out int rowCount)
        {
            if (page < 1)
                page = 1;
            if (pageSize < 0)
                pageSize = 20;
            rowCount = CountryDB.Count(searchValue);
            return CountryDB.List(page, pageSize, searchValue);
        }

        public static List<Country> GetAllCountries()
        {
            return CountryDB.GetAll();

        }
        public static int AddCountry(Country data)
        {
            return CountryDB.Add(data);
        }
        /// <summary>
        /// xóa 1 danh sách suppliers
        /// </summary>
        /// <param name="supplierIDs"></param>
        /// <returns></returns>
        public static int DeleteCountry(int[] CountryIDs)
        {
            return CountryDB.Delete(CountryIDs);
        }
        public static bool UpdateCountry(Country data)
        {
            return CountryDB.Update(data);
        }
    }
}
