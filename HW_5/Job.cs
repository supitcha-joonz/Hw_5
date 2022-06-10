using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public interface Job
    {

        //method ไม่มี Body ไม่มี Return
        public string WhoAmI();
        public decimal GetTax();
    }
}
