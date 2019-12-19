using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CCM.Easy.Car.Credit.DataModel;
using CCm.Easy.Car.Credit.BLL;

namespace CCM.Easy.Car.Credit.Api.Controllers
{
    /// <summary>
    /// 用户管理（登录和注册）
    /// </summary>
    public class UserManagerController : ApiController
    {
        UserManagermentBLL bll = new UserManagermentBLL();
        /// <summary>
        /// 陈彤彤和顾烯墰共同完成---用户注册 12.18
        /// </summary>
        /// <param name="userInfoModel"></param>
        /// <returns></returns>
        
        public int PostRegister(UserInfo userInfoModel)
        {
            return bll.Register(userInfoModel);
        }
        /// <summary>
        /// 陈彤彤和顾烯墰共同完成---用户登录 12.18
        /// </summary>
        /// <param name="UserEmail"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public int GetUserLogin(string json)
        {
            return bll.UserLogin(json);
        }
        /// <summary>
        /// 邮箱登录验证邮箱是否存在 陈彤彤
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int PutUserLoginRe(UserInfo model)
        {
            return bll.UserLoginRe(model);
        }
    }
}
