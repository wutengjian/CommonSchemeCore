using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.UserCenterModels.BusinessArchitecture
{
    /// <summary>
    /// 组织架构(部门)
    /// </summary>
    public class DepartmentModel
    {
        public int DepartmentID { get; set; }
        /// <summary>
        /// 父级部门ID
        /// </summary>
        public int FatherLevelID { get; set; }
        
        public string DepartmentName { get; set; }
        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyID { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string DataDescribe { get; set; }
        public DateTime CreateTime { get; set; }
        public int DataState { get; set; }
    }
}
