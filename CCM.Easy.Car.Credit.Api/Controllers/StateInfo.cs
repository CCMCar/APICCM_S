using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CCm.Easy.Car.Credit.BLL;
using System.Data;
using Newtonsoft.Json;
using CCM.Easy.Car.Credit.DataModel;
using Dapper;
using System.IO;
using System.Data.SqlClient;

namespace CCM.Easy.Car.Credit.Api.Controllers
{
    public class StateInfo : ApiController
    {

        StateInfoBLL bll = new StateInfoBLL();
        /// <summary>
        /// 王良昊 12月27日 信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        [HttpGet]

        public DataTable GetCollect(int id, int State)
        {
            return bll.Collect(id, State);
        }
    }
}
