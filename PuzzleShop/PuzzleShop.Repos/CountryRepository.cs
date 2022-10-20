using PuzzleShop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleShop.Repos
{
    public class CountryRepository
    {
        private readonly PuzzleShopContext ctx;
        public CountryRepository(PuzzleShopContext ctx)
        {
            this.ctx = ctx;
        }
        public Country GetCountryById(int id)
        {
            return ctx.Countries.FirstOrDefault(x => x.Id == id);
        }
        public Country GetCountryByName(string name)
        {
            return ctx.Countries.FirstOrDefault(x => x.Name == name);
        }
        public List<Country> GetList()
        {
            return ctx.Countries.ToList();
        }
        public async Task<Country> CreateCountryAsync(Country country)
        {
            ctx.Countries.Add(country);
            await ctx.SaveChangesAsync();
            return ctx.Countries.FirstOrDefault(x=>x.Name==country.Name);
        }
        public async Task<Country> UpdateCountryAsync(Country updatedCountry)
        {
            var country = GetCountryById(updatedCountry.Id);
            if(country.Name != updatedCountry.Name)
                country.Name = updatedCountry.Name;
            await ctx.SaveChangesAsync();
            return GetCountryById(country.Id);
        }
        public async Task DeleteCountryAsync(int id)
        {
            ctx.Countries.Remove(GetCountryById(id));
            await ctx.SaveChangesAsync();
        }
    }
}
