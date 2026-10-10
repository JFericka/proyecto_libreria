using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecLibreria.Entities.Entidades
{
    public class LogErrorEntities
    {
        public int Id { get; private set; }
        public string MensajeError { get; private set; } = string.Empty;
        public int? NumeroError { get; private set; }
        public string? Procedimiento { get; private set; }
        public int? LineaError { get; private set; }
        public string UsuarioApp { get; private set; } = string.Empty;
        public DateTime FechaError { get; private set; }

        public LogErrorEntities() { }

        public LogErrorEntities(string mensajeError, string usuarioApp, int? numeroError = null, string? procedimiento = null, int? lineaError = null)
        {
            CambiarMensajeError(mensajeError);
            CambiarUsuarioApp(usuarioApp);
            NumeroError = numeroError;
            Procedimiento = procedimiento;
            LineaError = lineaError;
            FechaError = DateTime.Now;
        }

        public void AsignarId(int id) => Id = id;

        public void CambiarMensajeError(string mensaje)
        {
            if (string.IsNullOrWhiteSpace(mensaje))
                throw new ArgumentException("El mensaje de error no puede estar vacío.");
            MensajeError = mensaje.Trim();
        }

        public void CambiarUsuarioApp(string usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                throw new ArgumentException("El usuario de la aplicación no puede estar vacío.");
            UsuarioApp = usuario.Trim();
        }

        public void AsignarFechaError(DateTime fecha)
        {
            FechaError = fecha;
        }
    }
}
