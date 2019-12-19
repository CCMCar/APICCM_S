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
	/// 用户管理BLL 晋力 12.17
	/// </summary>
	public class UserCarManagementBLL
	{
		SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
		UserCarManagement dal=new UserCarManagement();//DAL用户车俩管理
		/// <summary>
		/// 用户的车辆添加 晋力 12.17
		/// </summary>
		/// <param name="userCar"></param>
		/// <returns></returns>
		public int UserCarAdd(UserCar userCar)
		{
			try
			{
				return dal.UserCarAdd(userCar);
			}
			catch (Exception ex)
			{

				throw ex;
			}
			
		}
	}
}
