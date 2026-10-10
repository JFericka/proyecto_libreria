using System;
using System.Collections.Generic;
using System.Text;

namespace ProyecLibreria.UI.Helpers
{
    public static class NavegacionHelper
    {
        private static Control? _botonActivo;

        // Colores
        private static readonly Color ColorNormal = Color.FromArgb(31, 42, 68);
        private static readonly Color ColorActivo = Color.FromArgb(37, 99, 235);

        private static void Pintar(Control boton, Color color)
        {
            // Guna2Button usa FillColor; un Button normal usa BackColor
            if (boton is Guna.UI2.WinForms.Guna2Button guna)
                guna.FillColor = color;
            else
                boton.BackColor = color;

            boton.ForeColor = Color.White;
        }

        /// <summary>
        /// Cambia el estilo del botón activo.
        /// </summary>
        public static void ActivarBoton(Control boton)
        {
            if (_botonActivo != null)
                Pintar(_botonActivo, ColorNormal);

            _botonActivo = boton;
            Pintar(boton, ColorActivo);
        }

        public static void AbrirFormulario(Form formularioHijo, Panel panelContenedor, ref Form? formularioActivo, Control boton, bool esHijoDelPanelContenedor = true)
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
