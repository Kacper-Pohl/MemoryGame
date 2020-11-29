using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
            this.BackColor = Options.DefaultBackColor;
            SoundPlayer win = new SoundPlayer("win.wav");
            win.Play();
        }

        private void okTable(object sender, EventArgs e)
        {
            if (nameBox.Text.Length > 10 && nameBox.Text.Length < 3)
            {
                MessageBox.Show("Za dużo lub za mało znaków!", "Błąd!");
            }
            else
            {
                Gracz.Imie = nameBox.Text;
                Gracz.ListRooms.Add($"{Gracz.Imie}  -  {Gracz.Wynik}");
                                           
                using(TextWriter tw = new StreamWriter("SavedList.txt"))
                {
                    foreach (String s in Gracz.ListRooms)
                        tw.WriteLine(s);
                }
                
                this.Close();
            }
            
            
        }
    }
}