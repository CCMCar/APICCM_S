using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Easy.Car.Credit.DAL;
using CCM.Easy.Car.Credit.DataModel;
using System.Data;
using System.Data.SqlClient;
namespace CCm.Easy.Car.Credit.BLL
{
	/// <summary>
	/// 车辆管理BLL 晋力 12.17
	/// </summary>
	public class CarmanagementBLL
	{
		SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
		Carmanagement carmanagement = new Carmanagement();//DAL车辆管理
		/// <summary>
		/// 车俩的查询及显示 晋力 12.17
		/// </summary>
		/// <returns></returns>
		public DataTable CarTable()
		{
			return carmanagement.CarTable();
		}
	}
}
