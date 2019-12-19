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
		public DataTable CarTable( string MinPrice="",string MaxPrice="",int BrandId=0, string CarName="")
		{
			try
			{
				string sql = @"select * from CarInfo Car join BrandType Brand on Car.BrandId=Brand.BrandId  join ShopInfo Shop on Car.ShopId=Shop.ShopId 
join City Ct on Shop.CityId = Ct.CityId  where 1=1";//SQL语句
				if (!string.IsNullOrWhiteSpace(MinPrice))
				{
					sql += "   and  Car.CarPrice>=" + MinPrice + " ";
				}
				if (!string.IsNullOrWhiteSpace(MaxPrice))
				{
					sql += "   and  Car.CarPrice<=" + MaxPrice + " ";
				}
				if (BrandId != 0)
				{
					sql += "   and  Car.BrandId=" + BrandId + " ";
				}
				if (!string.IsNullOrWhiteSpace(CarName))
				{
					sql += "   and  Car.CarName like '%'" + CarName + "'%'";
				}
				return carmanagement.CarTable(sql);
			}
			catch (Exception ex)
			{
				
				throw ex;//抛出异常的代码
			}
			
		}
	}
}
