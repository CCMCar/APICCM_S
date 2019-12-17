using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CCM.Easy.Car.Credit.DAL
{
	/// <summary>
	/// 车辆管理 晋力 12.17
	/// </summary>
	public class Carmanagement
	{
		SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
		/// <summary>
		/// 车俩的查询及显示 晋力 12.17
		/// </summary>
		/// <returns></returns>
		public DataTable CarTable()
		{
			SqlCommand cmd = conn.CreateCommand();
			string sql = @"select * from CarInfo Car join BrandType Brand on Car.BrandId=Brand.BrandId  join ShopInfo Shop on Car.ShopId=Shop.ShopId 
join City Ct on Shop.CityId = Ct.CityId  where 1=1";//SQL语句

			cmd.CommandText = sql;
			SqlDataAdapter ap = new SqlDataAdapter(cmd);//适配器
			DataTable table = new DataTable("Mytable");//表格
			ap.Fill(table);
			return table;
		}
	}
}
