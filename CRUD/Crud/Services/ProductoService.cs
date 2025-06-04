using Crud.Models;
using Crud.Repositories;

namespace Crud.Services
{
    public class ProductoService
    {
        private readonly ProductoRepository _repo;

        public ProductoService(ProductoRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Producto>> ObtenerTodos() => await _repo.ObtenerTodos();
        public async Task<Producto?> ObtenerPorId(int id) => await _repo.ObtenerPorId(id);
        public async Task Agregar(Producto producto) => await _repo.Agregar(producto);
        public async Task Actualizar(Producto producto) => await _repo.Actualizar(producto);
        public async Task Eliminar(int id) => await _repo.Eliminar(id);
    }
}
