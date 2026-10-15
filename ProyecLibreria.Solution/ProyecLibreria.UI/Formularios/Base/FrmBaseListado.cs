using ProyecLibreria.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecLibreria.UI.Formularios.Base
{
    public partial class FrmBaseListado : Form
    {
        protected int paginaActual = 1;
        protected int TamPagina = 10;
        protected int TotalRegristros = 0;
        protected int TotalPaginas = 0;


        public FrmBaseListado()
        {
            InitializeComponent();
        }

        #region Metodos Virtuales

        protected virtual bool MostrarBotonPrincipal => true;

        protected virtual bool MostrarBotonSecundario => true;

        protected virtual bool MostrarBotonTerciario => true;

        protected virtual Task MostrarDatosAsync(int pagina, int TamPagina, string? buscar = null)
        {
            return Task.CompletedTask;
        }

        protected void ActualizarBotonesPaginacion()
        {
            // sin registros 
            if (TotalRegristros <= 0)
            {
                buttonPrimero.Enabled = false;
                buttonAnterior.Enabled = false;
                buttonSiguiente.Enabled = false;
                buttonUltimo.Enabled = false;

                return;

            }
            // sin registros
            buttonPrimero.Enabled = paginaActual > 1;
            buttonAnterior.Enabled = paginaActual > 1;

            // Ultima pagina
            buttonSiguiente.Enabled = paginaActual < TotalPaginas;
            buttonUltimo.Enabled = paginaActual < TotalPaginas;
        }

        protected void ActualizarPaginacion()
        {
            if (TotalRegristros == 0)
            {
                lblPagina.Text = "pagina 0 de 0";
                lblTotalRegistros.Text = "Total registros: 0";

                ActualizarBotonesPaginacion();
                return;
            }

            lblPagina.Text = $"pagina {paginaActual} de {TotalPaginas}";
            lblTotalRegistros.Text = $"Total registros: {TotalRegristros}";

            ActualizarBotonesPaginacion();
        }

        protected virtual Form? CrearFormularioAccionPrincipal()
        {
            return null;
        }

        protected virtual Form? CrearFormularioAccionSecundaria(int id)
        {
            return null;
        }

        protected virtual int? ObtenerIdSeleccionado()
        {
            return null;
        }

        protected virtual Task DesactivarAsync()
        {
            return Task.CompletedTask;
        }
        protected virtual void FormatearCelda(DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name != "Estado")
                return;

            GridColorHelper.FormatearActivoInactivo(e);
        }

        protected void AjustarColumnas(params string[] columnas)
        {
            foreach (string columna in columnas)
            {
                if (!dgvListado.Columns.Contains(columna))
                    continue;

                dgvListado.Columns[columna]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        #endregion

        #region personalizar el formulario

        protected void MostrarEstadoVacio(bool tieneDatos)
        {
            dgvListado.Visible = tieneDatos;
            pictureEmpty.Visible = !tieneDatos;
        }

        #endregion

        private async void FrmBaseListado_Load(object sender, EventArgs e)
        {
            buttonAgregar.Visible = MostrarBotonPrincipal;
            buttonEditar.Visible = MostrarBotonSecundario;
            butttonDesactivar.Visible = MostrarBotonTerciario;

            GridDashboardHelper.Personalizar(dgvListado);

            await MostrarDatosAsync(paginaActual, TamPagina, txtBuscar.Text);
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            paginaActual = 1;

            await MostrarDatosAsync(paginaActual, TamPagina, txtBuscar.Text);
        }

        private void dgvListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatearCelda(e);
        }

        private void FrmBaseListado_Shown(object sender, EventArgs e)
        {


            RedondearControlHelper.RedondearControl(panelContenido, 20);
            RedondearControlHelper.RedondearControl(panelPaginacion, 20);

            RedondearControlHelper.RedondearControl(dgvListado, 15);
            RedondearControlHelper.RedondearControl(pictureEmpty, 15);
            RedondearControlHelper.RedondearControl(PanelBuscar, 15);
        }

        private async void buttonPrimero_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            await MostrarDatosAsync(paginaActual, TamPagina, txtBuscar.Text);
        }

        private async void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual <= 1)
                return;

            paginaActual--;
            await MostrarDatosAsync(paginaActual, TamPagina, txtBuscar.Text);
        }
        private async void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (paginaActual >= TotalPaginas)
                return;

            paginaActual++;
            await MostrarDatosAsync(paginaActual, TamPagina, txtBuscar.Text);
        }

        private async void buttonUltimo_Click(object sender, EventArgs e)
        {
            paginaActual = TotalPaginas;
            await MostrarDatosAsync(paginaActual, TamPagina, txtBuscar.Text);
        }

    }
}