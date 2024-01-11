using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Library
{
    public class CompanyService
    {
        public List<Company> GetCompanies()
        {
            return new List<Company>()
            {
                 new Company{ Name="Acme",  PaymentPerHour=150},
                 new Company{ Name="ABC",  PaymentPerHour=125},

            };
        }
    }
}
