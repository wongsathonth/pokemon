using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.pokemonList
{
    internal class Reshiram:Pokemon
    {
        public Reshiram()
        {
            Random random = new Random();
            this.name = "Reshiram";
            this.hp = random.Next(370, 464);
            this.attack = random.Next(157, 295);
            this.image = Properties.Resources.reshiram;
        }
    }
}
