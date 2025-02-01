using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transacciones_en_ADO.NET
{
    public partial class rusuario : Form
    {
        public rusuario()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usuarioID = txtUsuarioID.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string password = txtPasswordNuevo.Text.Trim();

            if (string.IsNullOrEmpty(usuarioID) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CUsuario usuario = new CUsuario();
            bool resultado = usuario.RegistrarUsuario(usuarioID, nombre, password);

            if (resultado)
            {
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra el formulario después de registrar el usuario
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
