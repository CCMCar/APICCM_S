using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CCM.Easy.Car.Credit.DataModel;
using Dapper;
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
		public DataTable CarTable(string sql)
		{
			try
			{
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = sql;
				SqlDataAdapter ap = new SqlDataAdapter(cmd);//适配器
				DataTable table = new DataTable("Mytable");//表格
				ap.Fill(table);
				return table;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			
		}
		/// <summary>
		/// 车辆品牌二级联动 顾烯墰 12.19
		/// </summary>
		/// <param name="pid"></param>
		/// <returns></returns>
		public List<BrandType> BrandType(int pid=0)
		{
			using (IDbConnection conn=new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True"))
			{
				string sql = "select * from BrandType where PId=" + pid;
				return conn.Query<BrandType>(sql).ToList();
			}
		}
	}
}
