using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DomainModels
{
    /// <summary>
    /// luu thong tin lien quan den tai khoan dang nhap he thong
    /// </summary>
    public class UserAccount
    {
        /// <summary>
        /// Id của tài khoan dăng nhap he thong
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// Ten đầy đủ của User
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// tên file ảnh của User 
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }
        public string Roles { get; set; }
    }
}
