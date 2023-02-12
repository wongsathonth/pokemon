using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBase
{
    public class PokemonBase
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int attatk { get; set; }
        public Bitmap image { get; set; }
        public void takeDamage(int damage)
        {
            this.hp = hp - damage;
        }

    }
}
