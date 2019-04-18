using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.UserCenterModels.BusinessArchitecture
{
    /// <summary>
    /// 角色/职位
    /// </summary>
    public class RoleModel
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int CompanyID { get; set; }
        public int DepartmentID { get; set; }
        public string DataDescribe { get; set; }
        public DateTime CreateTime { get; set; }
        public int DataState { get; set; }
    }
}
