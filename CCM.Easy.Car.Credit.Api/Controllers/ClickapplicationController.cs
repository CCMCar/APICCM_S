using CCm.Easy.Car.Credit.BLL;
using CCM.Easy.Car.Credit.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
namespace CCM.Easy.Car.Credit.Api.Controllers
{
    /// <summary>
    /// 李高阳添加Clickapplication点击申请
    /// </summary>
    public class ClickapplicationController : ApiController
    {
        ClickapplicationBll dal = new ClickapplicationBll();
        /// <summary>
        /// 查询包含这个车辆的公司
        /// </summary>
        /// <param name="Id">车辆的编号查询</param>
        /// <param name="name">车辆的名字查询</param>
        /// <returns></returns>
        [HttpGet]
        public DataTable Chacha(string join)
        {
            CarInfo car = new CarInfo();
            car = JsonConvert.DeserializeObject<CarInfo>(join);
            return dal.Chacha(car.CarId, car.CarName);
        }
        /// <summary>
        /// 车辆的查询
        /// </summary>
        /// <param name="join">车的编号</param>
        /// <returns></returns>
        [HttpGet]
        public DataTable GetCha(string join)
        {
            CarInfo car = new CarInfo();
            car = JsonConvert.DeserializeObject<CarInfo>(join);
            return dal.Cha(car.CarId);
        }
        /// <summary>
        /// 用户信息查找
        /// </summary>
        /// <param name="Email">用户邮箱</param>
        /// <param name="Pwd">用户密码</param>
        /// <returns></returns>
        [HttpGet]
        public  DataTable  GetUserXin(string join)
        {
            UserInfo model = new UserInfo();
            model = JsonConvert.DeserializeObject<UserInfo>(join);
            return dal.UserXin(model.UserEmail, model.UserPwd);
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
