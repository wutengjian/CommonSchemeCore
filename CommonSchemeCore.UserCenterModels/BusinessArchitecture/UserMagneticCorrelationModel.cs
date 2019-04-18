using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.UserCenterModels.BusinessArchitecture
{
    /// <summary>
    /// 用户磁性关联：将别的信息绑定到用户上
    /// </summary>
    public class UserMagneticCorrelationModel
    {
        public int UserID { get; set; }
        /// <summary>
        /// 数据表名(模块标识)
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// 数据列(key的名字)
        /// </summary>
        public string ColumnName { get; set; }
        /// <summary>
        /// 对应信息的标识(key的值)
        /// </summary>
        public string CorrelationID { get; set; }
        public int DataState { get; set; }
    }
}
