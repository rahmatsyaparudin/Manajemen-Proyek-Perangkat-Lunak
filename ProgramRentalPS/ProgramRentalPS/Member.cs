using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramRentalPS
{
    class Member
    {
        public string jenis_kelamin { get; set; }

        public string GetSummary()
        {
            return jenis_kelamin;
        }
    }
}
