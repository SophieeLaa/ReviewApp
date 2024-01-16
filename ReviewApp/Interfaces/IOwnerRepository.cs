using ReviewApp.Models;

namespace ReviewApp.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners ();
        Owner GetOwner (int ownerId);
        ICollection<Owner> GetOwnerOfPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOwner(int ownerTd);
        bool OwnerExists(int ownerId);
    }
}
