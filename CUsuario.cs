using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Transacciones_en_ADO.NET
{
    public class CUsuario
    {
        DataSet DS;
        String Tabla = "Usuarios";
        private string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseDatos\\transaccionesenadonetdatabase.accdb;Persist Security Info=False;";

        // constructor
        public CUsuario()
        {
            CargarUsuarios();
        }

        // Método para cargar los usuarios en el DataSet
        private void CargarUsuarios()
        {
            try
            {
                using (OleDbConnection cnn = new OleDbConnection(cadenaConexion))
                {
                    cnn.Open();
                    DS = new DataSet();
                    OleDbCommand cmd = new OleDbCommand($"SELECT * FROM {Tabla}", cnn);
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
                    DA.Fill(DS, Tabla);
                    DS.Tables[Tabla].PrimaryKey = new DataColumn[] { DS.Tables[Tabla].Columns["usuario"] };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar usuarios: " + ex.Message);
            }
        }
        // Método para actualizar los datos después de registrar un usuario
        public void ActualizarDataSet()
        {
            CargarUsuarios();
        }
        public DataTable GetUsuarios()
        {
            if (DS.Tables.Count == 1)
            {
                return DS.Tables[Tabla];
            }
            else
            {
                throw new Exception("La tabla no existe");
            }
        }
        public String GetUsuario(int usuario)
        {
            String nombre = "";
            DataRow drU = DS.Tables[Tabla].Rows.Find(usuario);
            if (drU != null)
            {
                nombre = drU["Nombre"].ToString();
            }
            return nombre;
        }
        public String GetPasswordUsuario(int usuario)
        {
            DataRow drU = DS.Tables[Tabla].Rows.Find(usuario);
            if (drU != null)
            {
                return drU["palabra"].ToString();
            }
            else
            {
                throw new Exception("El usuario no existe");
            }
        }
        public bool RegistrarUsuario(string usuarioID, string nombre, string password)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(cadenaConexion))
                {
                    conn.Open();
                    string query = "INSERT INTO Usuarios (usuario, Nombre, palabra) VALUES (@usuario, @Nombre, @palabra)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuarioID);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@palabra", password);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            ActualizarDataSet(); // Recargar datos después de registrar
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void Dispose()
        {
            DS.Dispose();
        }
    }
}    
