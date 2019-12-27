using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Easy.Car.Credit.DataModel;
using System.Data.SqlClient;
using System.Data;

namespace CCM.Easy.Car.Credit.DAL
{
    public class StateInfoDAL
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

        public DataTable Collect(int Id, int State)
        {
            if (State == 4)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"select GETDATE(),CarInfo.CarId,CarInfo.CarImg,CarInfo.CarName,CarInfo.CarPrice,City.CityName from CarInfo join BrandType on BrandType.BrandId = CarInfo.BrandId join ShopInfo on CarInfo.ShopId = ShopInfo.ShopId join City on City.CityId = ShopInfo.CityId where CarId={Id} and CarState={State}", conn);
                SqlDataAdapter Sqldata = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("lh");
                Sqldata.Fill(dt);
                conn.Close();
                return dt;
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"select GETDATE(),CarInfo.CarId,CarInfo.CarImg,CarInfo.CarName,CarInfo.CarPrice,City.CityName from CarInfo join BrandType on BrandType.BrandId = CarInfo.BrandId join ShopInfo on CarInfo.ShopId = ShopInfo.ShopId join City on City.CityId = ShopInfo.CityId where CarId={Id}  and CarState={State}", conn);
                SqlDataAdapter Sqldata = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("lh");
                Sqldata.Fill(dt);
                conn.Close();
                return dt;
            }
        }
    }
}
