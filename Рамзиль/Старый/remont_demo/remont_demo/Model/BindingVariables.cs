using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Xml.Linq;

namespace remont_demo.Model
{
    partial class StaffsTable
    {
        public override string ToString() => $"{StaffName}";
    }
}
