using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.pokemonList
{
    internal class Golduck:Pokemon
    {
        public Golduck()
        {
            Random random = new Random();
            this.name = "Golduck";
            this.hp = random.Next(1000, 2500);
            this.attack = random.Next(85, 167);
            this.image = Properties.Resources.golduck;
        }
    }
}
