using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.UserCenterModels.BusinessArchitecture
{
    /// <summary>
    /// 资源信息表(页面/API/Action)
    /// </summary>
    public class ResourcesModel
    {
        public int ResourcesID { get; set; }
        public string ResourcesName { get; set; }
        public string DataDescribe { get; set; }
        public DateTime CreateTime { get; set; }
        public int DataState { get; set; }
    }
}
