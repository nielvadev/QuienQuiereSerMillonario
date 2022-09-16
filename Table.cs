using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQSM
{
    public class Table
    {

        static public bool instancia;
        public static DataTable dtUsers = new DataTable();

        public static void Create()
        {
            if (instancia == false)
            {

                dtUsers.Columns.Add("user", typeof(string));
                dtUsers.Columns.Add("passw", typeof(string));
                dtUsers.Columns.Add("email", typeof(string));
                dtUsers.Columns.Add("name", typeof(string));
                dtUsers.Rows.Add("admin", "admin", "admin@qqsm.com", "Root");
                instancia = true;
            }
        }


    }
}
