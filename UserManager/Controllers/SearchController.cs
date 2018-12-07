﻿using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Http;
using WFKS.Check.Search.Models;

namespace WFKS.Check.Search.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchController : ApiController
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().ReflectedType);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetUsers")]
        [SwaggerOperation(operationId: "GetUsers")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<User>))]
        public List<User> GetUsers()
        {
            using (var context = new UserContext())
            {
                try
                {
                    var list = context.User.ToList();
                    return list;
                }
                catch (Exception ex)
                {
                    log.Error("获取列表出错", ex);
                    throw;
                }
            }
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
            using (var context = new UserContext())
            {
                try
                {
                    context.User.Add(user);
                    int count = context.SaveChanges();
                    return count;
                }
                catch (Exception ex)
                {
                    log.Error("AddUser出错", ex);
                    throw;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("EditUser")]
        [SwaggerOperation(operationId: "EditUser")]
        [SwaggerResponse(statusCode: 200, type: typeof(int))]
        public int EditUser([FromBody]User user)
        {

            try
            {
                using (var context = new UserContext())
                {
                    User updateuser = context.User.FirstOrDefault(u => u.Id == user.Id);
                    if (updateuser != null)
                    {
                        updateuser.realName = user.realName;
                        updateuser.userName = user.userName;
                        updateuser.hours = user.hours;
                        return context.SaveChanges();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("EditUser出错", ex);
                throw;
            }
        }
    }
}