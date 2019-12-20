using CCm.Easy.Car.Credit.BLL;
using CCM.Easy.Car.Credit.DataModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CCM.Easy.Car.Credit.Api.Controllers
{
    public class Clickapplication1Controller : ApiController
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
    }
}
