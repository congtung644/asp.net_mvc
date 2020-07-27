using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
   public interface IUserAccountDAL
    {
        /// <summary>
        /// Kiểm tra username và passwork có hợp lệ hay không
        /// Nếu hợp lệ thì trả về hệ thống của User
        /// Ngươc lại thì trả về giá trị  null
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        UserAccount Authorize(string username, string password);
    }
}
