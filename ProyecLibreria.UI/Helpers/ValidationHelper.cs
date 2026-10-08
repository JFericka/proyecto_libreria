using Guna.UI2.WinForms;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyecLibreria.UI.Helpers
{
    public static class ValidationHelper
    {
        public static bool Requerido(TextBox textBox, ErrorProvider errorProvider, string mensaje)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }

            errorProvider.SetError(textBox, mensaje);
            textBox.Focus();
            return false;
        }

        public static bool Requerido(ComboBox comboBox, ErrorProvider errorProvider, string mensaje)
        {
            if (comboBox.SelectedIndex >= 0)
            {
                errorProvider.SetError(comboBox, "");
                return true;
            }

            errorProvider.SetError(comboBox, mensaje);
            comboBox.Focus();
            return false;
        }

        public static bool Requerido(Guna2TextBox textBox, ErrorProvider errorProvider, string mensaje)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }

            errorProvider.SetError(textBox, mensaje);
            textBox.Focus();
            return false;
        }

        public static bool EmailValido(TextBox textBox, ErrorProvider errorProvider)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(textBox.Text, patron))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }

            errorProvider.SetError(textBox, "Ingrese un correo válido.");
            textBox.Focus();
            return false;
        }
    }
}
