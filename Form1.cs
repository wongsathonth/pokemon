using pokemon.pokemonList;

namespace pokemon
{
    public partial class Form1 : Form
    {
        public List<Pokemon> Pokemons = new List<Pokemon>();
        Pokemon selectPokemon;
        Pokemon selectBoss;
        int selected;
        int heart = 4;
        int emheart = 1;
        public Form1()
        {
            InitializeComponent();
            Pokemons.Add(new Golduck());
            Pokemons.Add(new Nidoking());
            Pokemons.Add(new Reshiram());
            Pokemons.Add(new Tentacruel());
            selectBoss = new Vilrplume();
            this.pictureBox1.Image = selectBoss.getImage();
            this.label7.Text = "Pichai_dubai";
            this.label8.Text = selectBoss.getHp().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[0];
            this.pictureBox3.Image = selectPokemon.getImage();
            this.label5.Text = selectPokemon.getName();
            this.label6.Text = selectPokemon.getHp().ToString();
            this.selected = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[1];
            this.pictureBox3.Image = selectPokemon.getImage();
            this.label5.Text = selectPokemon.getName();
            this.label6.Text = selectPokemon.getHp().ToString();
            this.selected = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[2];
            this.pictureBox3.Image = selectPokemon.getImage();
            this.label5.Text = selectPokemon.getName();
            this.label6.Text = selectPokemon.getHp().ToString();
            this.selected = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[3];
            this.pictureBox3.Image = selectPokemon.getImage();
            this.label5.Text = selectPokemon.getName();
            this.label6.Text = selectPokemon.getHp().ToString();
            this.selected = 4;
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            selectBoss.takeDamage(selectPokemon.getAttack());
            this.label8.Text = selectBoss.getHp().ToString();
            await Task.Delay(500);
            selectPokemon.takeDamage(selectBoss.getAttack());
            if (selectPokemon.getHp() <= 0)
            {
                if (selected == 1)
                {
                    this.button1.Hide();
                }
                if (selected == 2)
                {
                    this.button3.Hide();
                }
                if (selected == 3)
                {
                    this.button2.Hide();
                }
                if (selected == 4)
                {
                    this.button4.Hide();
                }
                this.pictureBox3.Image = null;
                this.label5.Text = null;
                this.label6.Text = null;
                this.heart -= 1;
                if (heart == 0)
                {
                    MessageBox.Show("You Lose!\nGame Over");
                }
                return;
            }
            if (selectBoss.getHp() <= 0)
            {
                this.pictureBox1.Image = null;
                this.label7.Text = null;
                this.label8.Text = null;
                this.emheart -= 1;
                if (emheart == 0)
                {
                    MessageBox.Show("You Win!");
                }
            }
            this.label6.Text = selectPokemon.getHp().ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}