using PuzzleShop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleShop.Repos
{
    public class BrandRepository
    {
        private readonly PuzzleShopContext ctx;
        public BrandRepository(PuzzleShopContext ctx)
        {
            this.ctx = ctx;
        }
        public Brand GetBrandById(int id)
        {
            return ctx.Brands.FirstOrDefault(x => x.Id == id);
        }
        public Brand GetBrandByName(string name)
        {
            return ctx.Brands.FirstOrDefault(x => x.Name == name);
        }
        public List<Brand> GetList()
        {
            return ctx.Brands.ToList();
        }
        public async Task<Brand> CreateBrandAsync(Brand brand)
        {
            ctx.Brands.Add(brand);
            await ctx.SaveChangesAsync();
            return GetBrandById(brand.Id);
        }
        public async Task<Brand> UpdateBrandAsync(Brand updatetBrand)
        {
            var brand = GetBrandById(updatetBrand.Id);
            if(brand.Name!=updatetBrand.Name)
                brand.Name = updatetBrand.Name;
            if(brand.Description!=updatetBrand.Description)
                brand.Description = updatetBrand.Description;
            await ctx.SaveChangesAsync();
            return GetBrandById(brand.Id);
        }
        public async Task DeleteBrandAsync(int id)
        {
            ctx.Remove(GetBrandById(id));
            await ctx.SaveChangesAsync();
        }
    }
}
