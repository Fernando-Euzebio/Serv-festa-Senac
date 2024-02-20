using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseNamespace
{
    public class Database
    {
        public static string getConnectionString()
        {
            return "Data Source=locahost\\SQLEXPRESS;Initial Catalog=ChamadoTecnico54;Integrated Security=True";
        }

    }
    
}
