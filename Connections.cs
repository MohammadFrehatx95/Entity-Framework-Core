using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test
{
    internal class Connections
    {
        public const string sqlConStr = """
        Server=DESKTOP-I3VPEEA\SQLEXPRESS;
        Database=EF_TestDB;
        User Id=sa;
        Password = 123;
        TrustServerCertificate=True;
        Persist Security Info=True;
        """;
    }
}
