using CCm.Easy.Car.Credit.BLL;
using CCM.Easy.Car.Credit.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CCM.Easy.Car.Credit.Api.Controllers
{
    /// <summary>
    /// 李高阳添加Clickapplication点击申请
    /// </summary>
    public class ClickapplicationController : ApiController
    {
        ClickapplicationBll dal = new ClickapplicationBll();
        /// <summary>
        /// 车辆的查询
        /// </summary>
        /// <param name="Id">车的编号</param>
        /// <param name="CarName">车的品牌名称</param>
        /// <returns></returns>
        [HttpGet]
        public DataTable GetCha(int Id, string CarName)
        {
            return dal.Cha(Id, CarName);
        }
        /// <summary>
        /// 用户信息查找
        /// </summary>
        /// <param name="Email">用户邮箱</param>
        /// <param name="Pwd">用户密码</param>
        /// <returns></returns>
        [HttpGet]
        public  DataTable  GetUserXin(string Email, string Pwd)
        {
            return dal.UserXin(Email, Pwd);
        }
        /// <summary>
        /// 用户信息修改，补全信息
        /// </summary>
        /// <param name="model">学历，工作信息，职位等</param>
        /// <returns></returns>
        [HttpPost]
        public int PostUserdetailed(UserInfo model)
        {
            return dal.Userdetailed(model);
        }
    }
}
