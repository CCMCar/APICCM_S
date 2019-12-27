using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Easy.Car.Credit.DataModel;
using Newtonsoft.Json;

namespace CCM.Easy.Car.Credit.DAL
{
    /// <summary>
    /// 用户管理系统
    /// </summary>
    public class UserManagerment
    {
        SqlConnection conn = new SqlConnection("Data Source=192.168.0.183;Initial Catalog=Project;User ID=sa;Pwd=123456");
        /// <summary>
        /// 陈彤彤和顾烯墰共同完成---用户注册 12.18
        /// </summary>
        /// <param name="userInfoModel"></param>
        /// <returns></returns>
        public int Register(UserInfo userInfoModel)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"insert into UserInfo(UserEmail,UserPwd) values('{userInfoModel.UserEmail}','{userInfoModel.UserPwd}')";
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            return n;
        }
        /// <summary>
        /// 陈彤彤和顾烯墰共同完成---用户登录 12.18
        /// </summary>
        /// <param name="UserEmail"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public int UserLogin(string json)
        {
            UserInfo model = JsonConvert.DeserializeObject<UserInfo>(json);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"select count(1) from UserInfo where UserEmail='{model.UserEmail}' and UserPwd='{model.UserPwd}'";
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            return n;
        }
        /// <summary>
        /// 邮箱登录
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public int UserLoginRe(UserInfo model)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"select count(1) from UserInfo where UserEmail='{model.UserEmail}'";
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            return n;
        }
    }
}
