using Microsoft.EntityFrameworkCore;
using PuzzleShop.Core;
using PuzzleShop.Repos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleShop.Repos
{
    public class PuzzleRepository
    {
        private readonly PuzzleShopContext ctx;
        private readonly BrandRepository _brandRepository;
        private readonly CountryRepository _countryRepository;

        public PuzzleRepository(PuzzleShopContext ctx)
        {
            this.ctx = ctx;
        }
        public Puzzle GetPuzzleById(int id)
        {
            return ctx.Puzzles.Include(x => x.Brand).Include(x => x.Country).FirstOrDefault(x => x.Id == id);
        }
        public Puzzle GetPuzzleByName(string name)
        {
            return ctx.Puzzles.Include(x => x.Brand).Include(x => x.Country).FirstOrDefault(x => x.Name == name);
        }
        public List<Puzzle> GetList()
        {
            return ctx.Puzzles.Include(x => x.Brand).Include(x => x.Country).ToList();
        }
        public async Task<Puzzle> CreatePuzzleAsync(Puzzle puzzle)
        {
            ctx.Puzzles.Add(puzzle);
            await ctx.SaveChangesAsync();
            return GetPuzzleByName(puzzle.Name);
        }
        public async Task<Puzzle> CreatePuzzleFromDto(PuzzleDto dto, string brand, string country)
        {
            var brandFromDb = _brandRepository.GetBrandByName(brand);
            var countryFromDb = _countryRepository.GetCountryByName(country);
            dto.Brand = "f";
            var puzzle = new Puzzle()
            {
                Name = dto.Name,
                Description = dto.Description,
                Articul = dto.Articul,
                Price = dto.Price,
                Count = dto.Count,
                VideoURL = dto.VideoURL,
                ImgPath = dto.ImgPath,
                Brand = brandFromDb,
                Country = countryFromDb
            };
            return await CreatePuzzleAsync(puzzle);
        }
        public async Task UpdatePuzzleAsync(PuzzleDto model, string brand, string country)
        {
            var puzzle = ctx.Puzzles.Include(x => x.Brand).Include(x => x.Country).FirstOrDefault(x => x.Id == model.Id);
            if (puzzle.Name != model.Name)
                puzzle.Name = model.Name;
            if (puzzle.Description != model.Description)
                puzzle.Description = model.Description; 
            if (puzzle.Articul != model.Articul)
                puzzle.Articul = model.Articul;
            if (puzzle.Price != model.Price) 
                puzzle.Price = model.Price;
            if (puzzle.Count != model.Count)
                puzzle.Count= model.Count;
            if (puzzle.VideoURL != model.VideoURL)
                puzzle.VideoURL = model.VideoURL;
            if (puzzle.ImgPath != model.ImgPath)
                puzzle.ImgPath = model.ImgPath;
            if (puzzle.Brand.Name != brand)
                puzzle.Brand = _brandRepository.GetBrandByName(brand);
            if (puzzle.Country.Name != country)
                puzzle.Country = _countryRepository.GetCountryByName(country);
            await ctx.SaveChangesAsync();
        }
        public async Task DeletePuzzleAsync(int id)
        {
            ctx.Remove(GetPuzzleById(id));
            await ctx.SaveChangesAsync();
        }
    }
}
