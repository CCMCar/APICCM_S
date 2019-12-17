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
        /// <param name="CarName">车的品牌名称</param>
        /// <returns></returns>
        public DataTable Cha(int Id,string CarName)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=XProject;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand($" select CarInfo.*,BrandType.BrandName,ShopInfo.ShopName,ShopInfo.ShopAddress from CarInfo join BrandType on CarInfo.BrandId = BrandType.BrandIdjoin ShopInfo on CarInfo.ShopId = ShopInfo.ShopIdwhere  CarId ={Id } and BrandName={CarName}");
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
            SqlCommand cmd = new SqlCommand($" select * from UserInfo where UserEmail={Email} and UserPwd={Pwd}");
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
            SqlCommand cmd = new SqlCommand($" update UserInfo set UserTrueName={model.UserTrueName},UserEducation={model.UserEducation},UserJobInfo={model.UserJobInfo},UserPosition={model.UserPosition},UserCredit={model.UserCredit}, UserIncome={model.UserIncome},UserBandCard={model.UserBandCard} where UserId={model.UserId} ");
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            return n;
        }
    }
}
