namespace ProyecLibreria.Entities.Entidades
{
    public class UsuarioEntities
    {
        public int Id { get; private set; }
        public string Correo { get; private set; } = string.Empty;
        public byte[] Contraseña { get; private set; } = Array.Empty<byte>();
        public int RolId { get; private set; }
        public bool Estado { get; private set; } = true;
        public DateTime FechaRegistro { get; private set; }
        public string NombreRol { get; private set; } = string.Empty;

        public string EstadoTexto => Estado ? "Activo" : "Inactivo";

        public UsuarioEntities() { }

        public UsuarioEntities(string correo, byte[] contraseña, int rolId)
        {
            CambiarCorreo(correo);
            CambiarContraseña(contraseña);
            CambiarRolId(rolId);
            Estado = true;
            FechaRegistro = DateTime.Now;
        }

        public void AsignarId(int id)
        {
            Id = id;
        }

        public void CambiarCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                throw new ArgumentException("El correo no puede estar vacío.");
            Correo = correo.Trim();
        }

        public void CambiarContraseña(byte[] contraseña)
        {
            if (contraseña == null || contraseña.Length == 0)
                throw new ArgumentException("La contraseña no puede estar vacía.");
            Contraseña = contraseña;
        }

        public void CambiarRolId(int rolId)
        {
            if (rolId <= 0)
                throw new ArgumentException("El ID del rol debe ser un número positivo.");
            RolId = rolId;
        }

        public void CambiarNombreRol(string nombreRol)
        {
            NombreRol = nombreRol?.Trim() ?? string.Empty;
        }

        public void CambiarEstado(bool estado)
        {
            Estado = estado;
        }

        public void AsignarFechaRegistro(DateTime fecha)
        {
            FechaRegistro = fecha;
        }
    }
}