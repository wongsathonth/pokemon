using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.pokemonList
{
    internal class Tentacruel :Pokemon
    {
        public Tentacruel()
        {
            Random random = new Random();
            this.name = "Tentacruel";
            this.hp = random.Next(180, 274);
            this.attack = random.Next(103, 229);
            this.image = Properties.Resources.tentacruel;
        }
    }
}
