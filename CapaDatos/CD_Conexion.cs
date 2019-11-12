using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
     public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Data Source = LAPTOP\\SQLEXPRESS; Initial Catalog = COAGRO2; User ID = sa; Password=master#$2016");


       // cn = new SqlConnection("Data Source=PELAZON;Initial Catalog=COAGRO2;Persist Security Info=False;Pwd=Houdelot777$;User ID=sa");
        // cn = new SqlConnection("Data Source=LAPTOP\\SQLEXPRESS;Initial Catalog=COAGRO2;User ID=sa;Password=master#$2016");
        //cn.Open();




        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
