using CCM.Easy.Car.Credit.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CCm.Easy.Car.Credit.BLL;
namespace CCM.Easy.Car.Credit.Api.Controllers
{
    public class UserCarManagementController : ApiController
    {
		UserCarManagementBLL bll = new UserCarManagementBLL();
		/// <summary>
		/// 晋力 添加用户车辆 API 12.19
		/// </summary>
		/// <param name="userCar"></param>
		/// <returns></returns>
		public int PostUserCarAdd(UserCar userCar)
		{
			return bll.UserCarAdd(userCar);
		}
	}
}
