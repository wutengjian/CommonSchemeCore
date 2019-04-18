using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonSchemeCore.BasicDataCenterModels.LearningExperts
{
    public class LanguageComparisonModel
    {
        /// <summary>
        /// 数据类型：单词、语句等
        /// </summary>
        public string DataType { get; set; }
        /// <summary>
        /// 原文
        /// </summary>
        [Key]
        public string OriginalText { get; set; }
        /// <summary>
        /// 译文
        /// </summary>
        public string Translation { get; set; }
        /// <summary>
        /// 原文语言
        /// </summary>
        public string OriginalLang { get; set; }
        /// <summary>
        /// 译文语言
        /// </summary>
        public string TranslationLang { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public int DataState { get; set; }
        /// <summary>
        /// 出现总次数
        /// </summary>
        public int WordNum { get; set; }
    }
}
