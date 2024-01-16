﻿using ReviewApp.Data;
using ReviewApp.Interfaces;
using ReviewApp.Models;

namespace ReviewApp.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DataContext _context;

        public OwnerRepository(DataContext context)
        {
            _context = context;
        }
        public Owner GetOwner(int ownerId)
        {
            return _context.Owners.Where(o => o.Id == ownerId).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnerOfPokemon(int pokeId)
        {
           return _context.PokemonOwners.Where(p => p.Pokemon.Id == pokeId).Select(o =>o.Owner).ToList();
        }

        public ICollection<Owner> GetOwners()
        {
           return _context.Owners.ToList();
        }

        public ICollection<Pokemon> GetPokemonByOwner(int ownerId)
        {
            return _context.PokemonOwners.Where(p => p.Owner.Id == ownerId).Select(p =>p.Pokemon).ToList();
        }

        public bool OwnerExist(int ownerId)
        {
           return _context.Owners.Any(O => O.Id == ownerId);
        }
    }
}
