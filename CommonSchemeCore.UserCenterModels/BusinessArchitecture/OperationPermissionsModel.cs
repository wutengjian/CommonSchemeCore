using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.UserCenterModels.BusinessArchitecture
{
    /// <summary>
    /// 操作权限（对页面的曽删改查等操作）
    /// </summary>
    public class OperationPermissionsModel
    {
        public int OperationPermissionsID { get; set; }
        public string OperationPermissionsName { get; set; }
        public string DataDescribe { get; set; }
        public DateTime CreateTime { get; set; }
        public int DataState { get; set; }
    }
}
