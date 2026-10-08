using ProyecLibreria.Dal.Common;
using ProyecLibreria.Entities.Entidades;
using ProyecLibreria.UI.Helpers;
using ProyectLibreria.Bll.Common;
using System;
using System.Windows.Forms;

namespace ProyecLibreria.UI.Formularios.Seguridad
{
    public partial class FrmConfiguracionConexion : Form
    {
        public FrmConfiguracionConexion()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            errorIcon.Clear();

            bool valido = true;

            if (!ValidationHelper.Requerido(txtServidor, errorIcon, "Debe ingresar el servidor."))
                valido = false;

            if (!ValidationHelper.Requerido(txtBaseDatos, errorIcon, "Debe ingresar la base de datos."))
                valido = false;

            if (!ValidationHelper.Requerido(txtUsuario, errorIcon, "Debe ingresar su Usuario."))
                valido = false;

            if (!ValidationHelper.Requerido(txtcontraseña, errorIcon, "Debe ingresar la contraseña."))
                valido = false;

            return valido;
        }

        private void cancelar()
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private async void btnProbar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            ConexionBll conexionBll = new();

            bool ok = await conexionBll.ProbarConexion(
                txtServidor.Text.Trim(),
                txtBaseDatos.Text.Trim(),
                txtUsuario.Text.Trim(),
                txtcontraseña.Text);

            if (ok)
            {
                MessageBox.Show("Conexión exitosa", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = true;

                // Una vez probada, no se puedan editar
                txtServidor.Enabled = false;
                txtBaseDatos.Enabled = false;
                txtUsuario.Enabled = false;
                txtcontraseña.Enabled = false;
            }
            else
            {
                MessageBox.Show("No fue posible conectar", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGuardar.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConexionEntity config = new()
            {
                Servidor = txtServidor.Text.Trim(),
                BaseDatos = txtBaseDatos.Text.Trim(),
                UsuarioSql = txtUsuario.Text.Trim(),
                Password = txtcontraseña.Text.Trim(),
            };

            ConfiguracionDal dal = new();

            bool resultado = dal.Guardar(config);

            if (!resultado)
            {
                MessageBox.Show("No fue posible guardar la configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Configuración guardada", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureCerrar_Click(object sender, EventArgs e)
        {
            cancelar();
        }
    }
}
