using AutoMapper;
using CleanArchi.Core.DTO;
using CleanArchi.Core.Entities;
using CleanArchi.Core.Interfaces;
using CleanArchi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchi.Infrastructure.Repository
{
    public class CategoryService(AppDbContext _context, IMapper _mapper) : ICategoryService
    {

        public async Task<Category> Add(CategoryDto category)
        {
            try
            {
                var categ = _mapper.Map<Category>(category);

                await _context.Categories.AddAsync(categ);
                await _context.SaveChangesAsync();
                return categ;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Category> Delete(int id)
        {
            try
            {
                var categ = await _context.Categories.FindAsync(id);
                if (categ == null)
                    return null;


                _context.Categories.Remove(categ);
                await _context.SaveChangesAsync();

                return categ;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Category>> GetAll()
        {
            try
            {
                var categories = await _context.Categories.ToListAsync();
                return categories;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Category> GetById(int id)
        {
            try
            {
                var res = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Category> Update(int id, CategoryDto category)
        {
            try
            {
                var existingCateg = await _context.Categories.FindAsync(id);

                if (existingCateg == null)
                {
                    return null;
                }

                _mapper.Map(category, existingCateg);

                _context.Entry(existingCateg).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return existingCateg;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
