using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonSchemeCore.UserCenterModels.BusinessArchitecture
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserModel
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int DataState { get; set; }
    }
}
