using AutoMapper;
using CleanArchi.Core.DTO;
using CleanArchi.Core.Entities;
using CleanArchi.Core.Interfaces;
using CleanArchi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchi.Infrastructure.Repository
{
    internal class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;
        public ProductService(AppDbContext context, IMapper map)
        {
            _context = context;
            _mapper = map;
        }
        public async Task<Product> Add(ProductDto prod)
        {
            try
            {
                prod.DateAjout = DateTime.Now;
                prod.DateMAJ = DateTime.Now;
                var product = _mapper.Map<Product>(prod);

                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> Delete(int id)
        {
            try
            {
                var prod = await _context.Products.FindAsync(id);
                if (prod == null)
                    return null;


                _context.Products.Remove(prod);
                await _context.SaveChangesAsync();

                return prod;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Product>> GetAll()
        {
            try
            {
                var products = await _context.Products.ToListAsync();
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> GetById(int id)
        {
            try
            {
                var res = await _context.Products.FirstOrDefaultAsync(c => c.Id == id);
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<Product> Update(int id, ProductDto prod)
        {
            try
            {
                prod.DateMAJ = DateTime.Now;
                var existingProd = await _context.Products.FindAsync(id);

                if (existingProd == null)
                {
                    return null;
                }

                _mapper.Map(prod, existingProd);

                _context.Entry(existingProd).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return existingProd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Product>> Search(DateTime start, DateTime end)
        {
            try
            {

                var res = await _context.Products.Where(p => p.DateAjout >= start && p.DateAjout <= end).ToListAsync();
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
