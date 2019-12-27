using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Easy.Car.Credit.DAL;
using System.Data;

namespace CCm.Easy.Car.Credit.BLL
{
    public class StateInfoBLL
    {
        StateInfoDAL dal = new StateInfoDAL();
        public DataTable Collect(int id,int State)
        {
            return dal.Collect(id,State);
        }
    }
}
