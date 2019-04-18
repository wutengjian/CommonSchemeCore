using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.UserCenterModels.BusinessArchitecture
{
    /// <summary>
    /// 用户详情信息
    /// </summary>
    public class UserDetailsModel
    {
        public int UserID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string UserImage { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreateTime { get; set; }
        public int DataState { get; set; }
    }
}
