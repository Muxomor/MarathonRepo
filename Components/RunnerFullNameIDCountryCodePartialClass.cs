using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Components.DB;

namespace WpfApp1.Components.DB
{
    using System;
    using System.Collections.Generic;

    public partial class Runner
    {
        public string FullName
        {
            get
            {
                return $"{User.FirstName} {User.LastName} {RunnerId} ({CountryCode})";
            }
        }
    }
}
