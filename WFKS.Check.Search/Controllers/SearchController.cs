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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("AddUser")]
        [SwaggerOperation(operationId: "AddUser")]
        [SwaggerResponse(statusCode: 200, type: typeof(int))]
        public int AddUser([FromBody]User user)
        {
            try
            {
                SQLiteDbHelper dbHelper = new SQLiteDbHelper();
                return dbHelper.Add(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
