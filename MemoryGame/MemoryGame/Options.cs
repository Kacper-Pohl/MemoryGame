using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Options : Form
    {
        public new static System.Drawing.Color DefaultBackColor { get; set; } = Color.LightSkyBlue;
        public Options()
        {
            InitializeComponent();
            this.BackColor = DefaultBackColor;
        }
        

        private void menuOptions_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void colorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color;
            color = (string) colorBox.SelectedItem;
            DefaultBackColor = Color.FromName(color);
            this.BackColor = DefaultBackColor;
        }
    }
}