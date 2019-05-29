using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwoCommon
{
    public interface ISupervisor
    {
        string name { get; set; }
        string phone { get; set; }
        string email { get; set; }
        Address address { get; set; }

        string Display();
    }
}
