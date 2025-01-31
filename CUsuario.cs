using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Transacciones_en_ADO.NET
{
    public class CUsuario
    {
        DataSet DS;
        String Tabla = "Usuarios";
        // constructor
        public CUsuario()
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.4.0; Data Source=BackupProgramado.mdb";
                cnn.Open();
                DS = new DataSet();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = Tabla;
                OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
                DA.Fill(DS, Tabla);
                DataColumn[] pk = new DataColumn[1];
                pk[0] = DS.Tables[Tabla].Columns["usuario"];
                DS.Tables[Tabla].PrimaryKey = pk;
                OleDbCommandBuilder cb = new OleDbCommandBuilder(DA);
                cnn.Close();
            }
            catch (Exception ex)
            {
                String MsgErr = "CUsuario: " + ex.Message;
                throw new Exception(MsgErr);
            }
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
        public void Dispose()
        {
            DS.Dispose();
        }
    }
}    
