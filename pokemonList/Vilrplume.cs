using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.pokemonList
{
    internal class Vilrplume:Pokemon
    {
        public Vilrplume()
        {
            Random random = new Random();
            this.name = "Vilrplume";
            this.hp = random.Next(430, 524);
            this.attack = random.Next(202, 350);
            this.image = Properties.Resources.vileplume;
        }
    }
}
