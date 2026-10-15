using ProyecLibreria.Dal.Tablas;
using ProyecLibreria.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProyectLibreria.Bll
{
    public class RolBll
    {
        private readonly RolDal _rolDal;

        public RolBll(RolDal rolDal)
        {
            _rolDal = rolDal;
        }

        public async Task<PaginacionEntity<RolEntities>> MostrarAsync(int pagina, int tamPagina, string? buscar = null)
        {
            return await _rolDal.MostrarAsync(pagina, tamPagina, buscar);
        }

        public async Task<List<RolEntities>> MostrarRolesActivosAsync()
        {
            return await _rolDal.MostrarRolesActivosAsync();
        }

        public async Task<RolEntities?> ObtenerPorIdAsync(int id)
        {
            return await _rolDal.ObtenerPorIdAsync(id);
        }

        public async Task AgregarAsync(RolEntities rol, string usuarioApp)
        {
            await _rolDal.AgregrarAsync(rol, usuarioApp);
        }

        public async Task ActualizarAsync(RolEntities rol, string usuarioApp)
        {
            await _rolDal.ActualizarAsync(rol, usuarioApp);

        }

        public async Task CambairEstadoAsync(int id, bool activo, string usuarioApp)
        {
            await _rolDal.CambiarEstadoAsync(id, activo, usuarioApp);
        }
    }
}
