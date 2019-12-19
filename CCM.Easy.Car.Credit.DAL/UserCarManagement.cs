using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CCM.Easy.Car.Credit.DataModel;
namespace CCM.Easy.Car.Credit.DAL
{
	/// <summary>
	/// 用户车辆管理 晋力 12.17
	/// </summary>
	public class UserCarManagement
	{
		SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
		/// <summary>
		/// 用户的车辆添加 晋力 12.17
		/// </summary>
		/// <param name="userCar"></param>
		/// <returns></returns>
		public  int UserCarAdd(UserCar userCar)
		{
			try
			{
				conn.Open();
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = $"insert into UserCar values('{userCar.UserId}','{userCar.CarId}','{userCar.CarJoinTime}','{userCar.UserCarState}')";//添加用户车辆
				int n = cmd.ExecuteNonQuery();
				return n;
			}
			catch (Exception ex)
			{

				throw ex ;
			}
			
		}
	}
}
