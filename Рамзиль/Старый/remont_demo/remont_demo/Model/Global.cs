using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remont_demo.Model
{
    class Global
    {
        public static ClientsTable clients = new ClientsTable();
        public static StaffsTable stuff=new StaffsTable();
        public static RequestsTable request=new RequestsTable();
    }
}
