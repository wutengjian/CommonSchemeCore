using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DomainCoreDBRepertory.BasicData.LearningExperts;
using DomainCoreDBRepertory.BasicData.Models;
using CommonSchemeCore.DataAccess.EFCore;
using Newtonsoft.Json;

namespace ProductCore.LearningExperts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageComparisonController : ControllerBase
    {
        private LanguageComparisonDal LCDal;

        public LanguageComparisonController(HookNetWorkDbContext dbContext)
        {
            LCDal = new LanguageComparisonDal(dbContext);
        }

        [HttpGet("{id}", Name = "GetBasicWords")]
        public string GetBasicWords()
        {
            var data = LCDal.BasicWords().ToList<KVInfo>();
            return JsonConvert.SerializeObject(data);
        }
    }
}
