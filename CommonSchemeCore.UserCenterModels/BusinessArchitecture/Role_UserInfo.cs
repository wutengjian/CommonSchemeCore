using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.UserCenterModels.BusinessArchitecture
{
    /// <summary>
    /// 用户-角色关联表
    /// </summary>
    public class Role_UserInfo
    {
        public int RoleID { get; set; }
        public int UserID { get; set; }
        /// <summary>
        /// 维护人
        /// </summary>
        public int GuardianID { get; set; }
        /// <summary>
        /// 维护时间
        /// </summary>
        public DateTime MaintenanceTime { get; set; }
        public int DataState { get; set; }
    }
}
