using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using CCm.Easy.Car.Credit.BLL;
using CCM.Easy.Car.Credit.DataModel;
using System.Data;

namespace CCM.Easy.Car.Credit.Api.Controllers
{
    public class Clickapplication2Controller : ApiController
    {
        ClickapplicationBll dal = new ClickapplicationBll();
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
    }
}
