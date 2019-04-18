using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.UserCenterModels.BusinessArchitecture
{
    /// <summary>
    /// 资源-操作权限关联表
    /// </summary>
    public class Resources_OperationPermissionsInfo
    {
        public int ResourcesID { get; set; }
        public int OperationPermissionsID { get; set; }
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
