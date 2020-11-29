using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Tabela : Form
    {
        public Tabela()
        {
            InitializeComponent();
            scoreBox.Items.AddRange(Gracz.ListRooms.ToArray());
            this.BackColor = Options.DefaultBackColor;
        }
        
        private void del_Click(object sender, EventArgs e)
        {
            if (scoreBox.Items.Count > 0 && scoreBox.SelectedIndex > -1)
            {
                scoreBox.Items.RemoveAt(scoreBox.SelectedIndex);
                
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("SavedList.txt");
                foreach (var item in scoreBox.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }

                SaveFile.Close();
            }
        }
        

        private void menuTab_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}