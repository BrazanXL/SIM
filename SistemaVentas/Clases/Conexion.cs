using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaVentas
{
    public class Conexion
    {
        private string db;
        private string servidor;
        private string usuario;
        private string contrasena;
        //private static Conexion conn = null;

        public Conexion()
        {
            this.db = "bxymyfyxvxkhdlsf4tpg";
            this.servidor = "bxymyfyxvxkhdlsf4tpg-mysql.services.clever-cloud.com";
            this.usuario = "uunvywmqw6xpltvy";
            this.contrasena = "eI54i3NKQkrF7bjSsJgV";
        }

        public MySqlConnection obtenerConexion()
        {
            MySqlConnection cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "Database=" + db + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + contrasena + ";";
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }

            return cadena;
        }
    }
}
