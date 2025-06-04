using System;
using Crud.Data;
using Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud.Repositories
{
    public class ProductoRepository
    {
        private readonly AppDbContext _context;

        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Producto>> ObtenerTodos() => await _context.Productos.ToListAsync();
        public async Task<Producto?> ObtenerPorId(int id) => await _context.Productos.FindAsync(id);
        public async Task Agregar(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
        }

        public async Task Actualizar(Producto producto)
        {
            _context.Productos.Update(producto);
            await _context.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }
        }
    }
}
