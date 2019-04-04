using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleApp.Applicants
{
    public interface IApplicantModel
    {
        IAccounts AccountProcessor { get; set; }
    }
}
