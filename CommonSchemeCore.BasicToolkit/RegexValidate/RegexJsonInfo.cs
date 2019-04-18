using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.BasicToolkit.RegexValidate
{
    /// <summary>
    /// RegexInfo.json文件对应的模型
    /// </summary>
    public class RegexJsonInfo
    {
        /// <summary>
        /// 正则主键
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 正则表达式
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        /// 正则的用途与描述
        /// </summary>
        public string Explain { get; set; }
    }
}
