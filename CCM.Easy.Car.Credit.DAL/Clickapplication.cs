using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Easy.Car.Credit.DataModel;
using System.Data;
using System.Data.SqlClient;
namespace CCM.Easy.Car.Credit.DAL
{
    /// <summary>
    /// 李高阳添加Clickapplication点击申请
    /// </summary>
   public class Clickapplication
    {
        /// <summary>
        /// 车辆的查询
        /// </summary>
        /// <param name="Id">车的编号</param>
        /// <returns></returns>
        public DataTable Cha(int Id)
        {

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=XProject;Integrated Security=True");
            conn.Open();
            string sql = "select * from UserCar join CarInfo on UserCar.CarId=CarInfo.CarId join BrandType on BrandType.BrandId=CarInfo.BrandId join ShopInfo on ShopInfo.ShopId=CarInfo.ShopId join City on City.CityId=ShopInfo.CityId where 1=1";
            if (Id != 0)
            {
                sql += $" and CarInfo.CarId={Id}";
            }
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable data = new DataTable("sf");
            sqlData.Fill(data);
            conn.Close();
            return data;
        }
        /// <summary>
        /// 查询包含这个车辆的公司
        /// </summary>
        /// <param name="Id">车辆的编号查询</param>
        /// <param name="name">车辆的名字查询</param>
        /// <returns></returns>
        public DataTable Chacha(int Id,string name)
        {

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=XProject;Integrated Security=True");
            conn.Open();
            string sql = "select * from CarInfo join ShopInfo on CarInfo.ShopId=ShopInfo.ShopId where 1=1";
            if (Id!=0)
            {
                sql += $" and CarInfo.CarId={Id} ";
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += $" and CarInfo.CarName like '%'{name}'%'";
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable data = new DataTable("sf");
            sqlData.Fill(data);
            conn.Close();
            return data;
        }
        /// <summary>
        /// 用户信息查找
        /// </summary>
        /// <param name="Email">用户邮箱</param>
        /// <param name="Pwd">用户密码</param>
        /// <returns></returns>
        public DataTable UserXin(string Email, string Pwd)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=XProject;Integrated Security=True");
            conn.Open();
            string sql = "select * from UserInfo  where 1=1";
            if (!string.IsNullOrEmpty(Email))
            {
                sql += $" and UserEmail={Email} ";
            }
            if (!string.IsNullOrEmpty(Pwd))
            {
                sql += $"  and Pwd={Pwd}";
            }
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable data = new DataTable("sf");
            sqlData.Fill(data);
            conn.Close();
            return data;
        }
        /// <summary>
        /// 用户信息修改，补全信息
        /// </summary>
        /// <param name="model">学历，工作信息，职位等</param>
        /// <returns></returns>
        public int Userdetailed(UserInfo model)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=XProject;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand($" update UserInfo set UserTrueName='{model.UserTrueName}',UserNumber={model.UserNumber},UserTelPhone={model.UserTelPhone},UserEducation='{model.UserEducation}',UserJobInfo='{model.UserJobInfo}',UserPosition='{model.UserPosition}',UserCredit='{model.UserCredit}', UserIncome='{model.UserIncome}',UserBandCard='{model.UserBandCard}' where UserId='{model.UserId}' ",conn);
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            return n;
        }
    }
}
