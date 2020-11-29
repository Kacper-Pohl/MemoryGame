using System;
using System.IO;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.BackColor = Options.DefaultBackColor;
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            var gra = new Form1();
            gra.Show();
            this.Hide();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            Tabela tabela = new Tabela();
            tabela.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Popularna gra polegająca na odnajdowaniu par takich samych kart. Gracz odsłania 2 karty. Jeśli są to takie same karty, zostaną one zdjęte z planszy, jeśli nie, karty będą odwrócone z powrotem (po ok. 2 sekundach). Celem gracza jest zdjęcie wszystkich kart przy możliwie najmniejszej liczbie odsłon. W grze liczona jest ilość błędnych odsłon.", "MemoryGame - Info");
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
            this.Hide();
        }
    }
}