using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteCommerce.DomainModels;

namespace LiteCommerce.DataLayers.SqlServer
{
    public class CustomerUserAccountDAL : IUserAccountDAL
    {
        private string connectionString;
        public CustomerUserAccountDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="passwork"></param>
        /// <returns></returns>
        public UserAccount Authorize(string UserName, string passwork)
        {
            //TODO: Kiểm tra thông tin đăng nhập dựa vào bảng Customers
            return new UserAccount()
            {
                UserID = UserName,
                FullName = "Trần Thị Quỳnh Như",
                Photo = "anhtn4.png"
            };
        }
    }
}
