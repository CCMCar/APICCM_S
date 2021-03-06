﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Easy.Car.Credit.DAL;
using CCM.Easy.Car.Credit.DataModel;
namespace CCm.Easy.Car.Credit.BLL
{
    /// <summary>
    /// 李高阳添加Clickapplication点击申请
    /// </summary>
    public class ClickapplicationBll
    {
        Clickapplication dal = new Clickapplication();
        /// <summary>
        /// 查询包含这个车辆的公司
        /// </summary>
        /// <param name="Id">车辆的编号查询</param>
        /// <param name="name">车辆的名字查询</param>
        /// <returns></returns>
        public DataTable Chacha(int Id, string name)
        {

            return dal.Chacha(Id, name);
        }
        /// <summary>
        /// 车辆的查询
        /// </summary>
        /// <param name="Id">车的编号</param>
        /// <returns></returns>
        public DataTable Cha(int Id)
        {
            return dal.Cha(Id);
        }
        /// <summary>
        /// 用户信息查找
        /// </summary>
        /// <param name="Email">用户邮箱</param>
        /// <param name="Pwd">用户密码</param>
        /// <returns></returns>
        public DataTable UserXin(string Email, string Pwd)
        {
            return dal.UserXin(Email, Pwd);
        }
        /// <summary>
        /// 用户信息修改，补全信息
        /// </summary>
        /// <param name="model">学历，工作信息，职位等</param>
        /// <returns></returns>
        public int Userdetailed(UserInfo model)
        {
            return dal.Userdetailed(model);
        }
    }
}
