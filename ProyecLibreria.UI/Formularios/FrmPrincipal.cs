using ProyecLibreria.UI.Helpers;
using System;
using System.Windows.Forms;

namespace ProyecLibreria.UI.Formularios
{
    public partial class FrmPrincipal : Form
    {
        private Form? formularioActivo;
        private bool cerrandoSesion = false;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Sidebar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            SesionHelper.CerrarSesion(this);
        }
        #endregion


        #region Metodos

        public void CerrarSesion()
        {
            cerrandoSesion = true;
            DialogResult = DialogResult.Retry;
            Close();
        }

        #endregion

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrandoSesion)
                return;

            DialogResult respuesta = MessageBox.Show("Seguro que desea sair del sistema?", "Confirmacion", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
               e.Cancel = true;
        }
    }
}
