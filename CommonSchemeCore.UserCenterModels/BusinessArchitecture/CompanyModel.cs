using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.UserCenterModels.BusinessArchitecture
{
    /// <summary>
    /// 公司信息
    /// </summary>
    public class CompanyModel
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public int DataState { get; set; }
    }
}
