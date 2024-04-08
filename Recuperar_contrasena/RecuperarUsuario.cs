using Npgsql;
using System.CodeDom;
using System.Runtime.InteropServices;

namespace Recuperar_contrasena

{
    public partial class RecuperarUsuario : Form
    {
        public RecuperarUsuario()
        {
            InitializeComponent();
        }




        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string usuario = tbxUsuario.Text; // Nuevo TextBox para el usuario
            string nombreCompleto = tbxNombreCompleto.Text;
            string telefono = tbxTelefono.Text;
            string nuevacontrasena = tbxNuevaContrasena.Text;
            string repetirContrasena = tbxRepetirContrasena.Text;

            Classes.conexion objetoConexion = new Classes.conexion();
            objetoConexion.ActualizarContraseña(usuario, nombreCompleto, telefono, nuevacontrasena, repetirContrasena);
        }
    }
}
