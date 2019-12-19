using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Easy.Car.Credit.DAL;
using CCM.Easy.Car.Credit.DataModel;

namespace CCm.Easy.Car.Credit.BLL
{
    public class UserManagermentBLL
    {
        UserManagerment dal = new UserManagerment();
        /// <summary>
        /// 陈彤彤和顾烯墰共同完成---用户注册 12.18
        /// </summary>
        /// <param name="userInfoModel"></param>
        /// <returns></returns>
        public int Register(UserInfo userInfoModel)
        {
            return dal.Register(userInfoModel);
        }
        /// <summary>
        /// 陈彤彤和顾烯墰共同完成---用户登录 12.18
        /// </summary>
        /// <param name="UserEmail"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public int UserLogin(string json)
        {
            return dal.UserLogin(json);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public int UserLoginRe(UserInfo model)
        {
            return dal.UserLoginRe(model);
        }
    }
}
