using Dapper;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
using WFKS.Check.Search.Common;
using WFKS.Check.Search.Models;

namespace WFKS.Check.Search.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchController : ApiController
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchRequest"></param>
        /// <returns></returns>
        [HttpGet, Route("Get")]
        [SwaggerOperation(operationId: "Get")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<SearchResponse>))]
        public List<SearchResponse> Get([FromUri]SearchRequest searchRequest)
        {
            List<SearchResponse> list = new List<SearchResponse>();
            List<Periodical> periodicalList = null;
            string zz_xm = "%宋鹏%", qk_name = "%计算机%";
            try
            {
                using (IDbConnection conn = new SQLBaseRepository().OpenConnection())
                {
                    periodicalList = conn.Query<Periodical>("select * from 期刊 where zz_xm like @zz_xm and qk_name like @qk_name and 有无版权 = '1' ", new { zz_xm, qk_name }).ToList();
                }

                if (periodicalList != null)
                {
                    foreach (var item in periodicalList)
                    {
                        list.Add(new SearchResponse()
                        {
                            Type = "qikan",
                            CheckinID = item.CheckinID,
                            Title = item.F_Title,
                            TitleE = item.qk_engname,
                            CreaterInfoZ = item.zz_xm,
                            CreaterInfoE = item.zze_xm,
                            Source = item.qk_name,
                            f_code = item.f_qcode,
                            YearIssueText = item.f_year + "年" + item.f_issue + "期"
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetUsers")]
        [SwaggerOperation(operationId: "GetUsers")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<User>))]
        public List<User> GetUsers()
        {
            SQLiteDbHelper dbHelper = new SQLiteDbHelper();
            var list = dbHelper.QueryMultiByWhere<User>("1=1");

            return list;
        }

    }
}
