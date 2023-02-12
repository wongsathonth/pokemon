using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.pokemonList
{
    internal class Nidoking:Pokemon
    {
        public Nidoking()
        {
            Random random = new Random();
            this.name = " Nidoking";
            this.hp = random.Next(188, 282);
            this.attack = random.Next(98, 223);
            this.image = Properties.Resources.nidoking;
        }
    }
}
