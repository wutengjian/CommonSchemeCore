using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSchemeCore.BasicDataCenterModels.LearningExperts;
using CommonSchemeCore.DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;

namespace DomainCoreDBRepertory.BasicData.LearningExperts
{
    public class LanguageComparisonDal
    {
        private HookNetWorkDbContext dbContext;
        public LanguageComparisonDal(HookNetWorkDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }
        public IQueryable<LanguageComparisonModel> GetAll()
        {
            return dbContext.LanguageComparisons.AsQueryable<LanguageComparisonModel>();
        }
        public LanguageComparisonModel GetModel(string key)
        {
            return dbContext.LanguageComparisons.Where(x => x.OriginalText == key).FirstOrDefault();
        }
        /// <summary>
        /// 基本单词,随机排序
        /// </summary>
        /// <param name="WordLen">原文长度：不超过5</param>
        /// <param name="WordNum">出现次数：大于500</param>
        /// <returns></returns>
        public List<Models.KVInfo> BasicWords(int WordLen = 5, int WordNum = 500)
        {
            var query = dbContext.LanguageComparisons.Where(x => x.OriginalText.Length <= WordLen && x.WordNum > WordNum)
                .OrderBy(x => Guid.NewGuid()).Select(x => new Models.KVInfo() { Key = x.OriginalText, Value = x.Translation });
            return query.ToList<Models.KVInfo>();
        }
        /// <summary>
        /// 出现频繁的单词
        /// </summary>
        /// <param name="WordNum">单词出现次数:大于1000</param>
        /// <returns></returns>
        public async Task<IList<LanguageComparisonModel>> FrequentWords(int WordNum = 1000)
        {
            var query = from LC in dbContext.LanguageComparisons
                        where LC.WordNum > WordNum && LC.Translation.Length > 0
                        orderby LC.WordNum descending
                        select LC;
            return await query.ToListAsync();
        }
    }
}
