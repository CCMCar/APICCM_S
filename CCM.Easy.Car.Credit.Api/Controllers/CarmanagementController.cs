using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CCM.Easy.Car.Credit.DataModel;
using System.Data;
using CCm.Easy.Car.Credit.BLL;

namespace CCM.Easy.Car.Credit.Api.Controllers
{
    public class CarmanagementController : ApiController
    {
		CarmanagementBLL bll = new CarmanagementBLL();
		/// <summary>
		/// 晋力 API 车辆管理 12.19
		/// </summary>
		/// <param name="MinPrice"></param>
		/// <param name="MaxPrice"></param>
		/// <param name="BrandId"></param>
		/// <param name="CarName"></param>
		/// <returns></returns>
		public DataTable GetCarTable(string MinPrice = "", string MaxPrice = "", int BrandId = 0, string CarName = "")
		{
			return bll.CarTable(MinPrice,MaxPrice,BrandId,CarName);
		}

	}
}
