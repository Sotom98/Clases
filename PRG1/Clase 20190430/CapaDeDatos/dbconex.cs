using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Sql;

namespace CapaDeDatos
{
    public class dbconex
    {
        string cadenaConex = "Data Source=.;Initial Catalog=BaseDePruebas;Persist Security Info=True;User ID=Sotom98;Password=sql";

        public bool conex()
        {
            bool correcto = false;
            try {
                correcto = true;

                catch(Exception ex) {
                    correcto = false;
                }
            }            

            return correcto;
        }
    }
}
