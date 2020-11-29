using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;
       
        SoundPlayer match = new SoundPlayer("match.wav");
        
        Random random = new Random();
        public int Liczba;
             
        List<string> icons = new List<string>() 
             { 
                 "!", "!", "N", "N", ",", ",", "k", "k", 
                 "h", "h", "e", "e", "w", "w", "%", "%", 
                 "o", "o", "j", "j", "$", "$", "Y", "Y",
                 "b", "b", "v", "v", "i", "i", "~", "~", "p", "p", "l", "l"
             };
        private void AssignIconsToSquares()
        {

            foreach (Control control in tablePanel.Controls) 
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        } 
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
            this.BackColor = Options.DefaultBackColor;
        }

        private void label_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
                return;
            
            Label clickedLabel = sender as Label;
            
            
            if  (secondClicked !=  null)
                return;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                
                CheckForWinner();
                
                if (firstClicked.Text == secondClicked.Text)
                {
                    
                    firstClicked = null;
                    secondClicked = null;
                    match.Play();
                    return;
                }

                if (firstClicked.Text != secondClicked.Text)
                {
                    Liczba++;
                    wynikShow.Text = Liczba.ToString();
                }
                
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            
            firstClicked = null;
            secondClicked = null;
        }

        private void Reset()
        {
            icons.AddRange(new String[]{
                "!", "!", "N", "N", ",", ",", "k", "k", 
                "h", "h", "e", "e", "w", "w", "%", "%", 
                "o", "o", "j", "j", "$", "$", "Y", "Y",
                "b", "b", "v", "v", "i", "i", "~", "~", 
                "p", "p", "l", "l"});
        }

        private void CheckForWinner()
        {
            
            foreach (Control control in tablePanel.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null) 
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            Gracz.Wynik = Liczba;
            match.SoundLocation = (@"win.wav");
            var formPopup = new Popup();
            formPopup.Show(this);
        }

        
        
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
            AssignIconsToSquares();
            Liczba = 0;
            wynikShow.Text = Liczba.ToString();
        }

        private void menuGame_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}