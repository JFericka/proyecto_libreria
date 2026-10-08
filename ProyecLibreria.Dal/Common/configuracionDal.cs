using ProyecLibreria.Entities.Entidades;
using System;
using System.IO;
using System.Text.Json;

namespace ProyecLibreria.Dal.Common
{
    public class ConfiguracionDal
    {
        private readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "configuracion.json");

        public bool ExisteConfiguracion()
        {
            return File.Exists(rutaArchivo);
        }

        public bool Guardar(ConexionEntity config)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo)!);

                string json = JsonSerializer.Serialize(config,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                File.WriteAllText(rutaArchivo, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ConexionEntity? Obtener()
        {
            if (!File.Exists(rutaArchivo))
                return null;

            string json = File.ReadAllText(rutaArchivo);

            return JsonSerializer.Deserialize<ConexionEntity>(json);
        }
    }
}
