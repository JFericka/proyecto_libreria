using System;
using System.Collections.Generic;
using System.Text;

namespace ProyecLibreria.UI.Helpers
{
    public static class NavegacionHelper
    {
        private static Button? _botonActivo;

        // Colores
        private static readonly Color ColorNormal = Color.FromArgb(31, 42, 68);
        private static readonly Color ColorActivo = Color.FromArgb(37, 99, 235);

        /// <summary>
        /// Cambia el estilo del botón activo.
        /// </summary>
        public static void ActivarBoton(Button boton)
        {
            if (_botonActivo != null)
            {
                _botonActivo.BackColor = ColorNormal;
                _botonActivo.ForeColor = Color.White;
            }

            _botonActivo = boton;

            _botonActivo.BackColor = ColorActivo;
            _botonActivo.ForeColor = Color.White;
        }

        public static void AbrirFormulario(Form formularioHijo, Panel panelContenedor, ref Form? formularioActivo, Button boton, bool esHijoDelPanelContenedor = true)
        {
            try
            {
                ActivarBoton(boton);

                if (esHijoDelPanelContenedor)
                {
                    if (formularioActivo != null)
                    {
                        formularioActivo.Close();
                        formularioActivo.Dispose();
                    }

                    formularioActivo = formularioHijo;

                    formularioHijo.TopLevel = false;
                    formularioHijo.FormBorderStyle = FormBorderStyle.None;
                    formularioHijo.Dock = DockStyle.Fill;

                    panelContenedor.Controls.Clear();
                    panelContenedor.Controls.Add(formularioHijo);
                    panelContenedor.Tag = formularioHijo;

                    formularioHijo.Show();
                    formularioHijo.BringToFront();
                }
                else
                {
                    formularioHijo.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
