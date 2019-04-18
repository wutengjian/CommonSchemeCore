using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.UserCenterModels.BusinessArchitecture
{
    /// <summary>
    /// 角色-资源关联表
    /// </summary>
    public class Resources_RoleInfo
    {
        public int ResourcesID { get; set; }
        public int RoleID { get; set; }
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
