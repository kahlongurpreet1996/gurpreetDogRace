using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gurpreetDogRace
{
    public partial class Form1 : Form
    {
        //array that have the amount of value of the player
        int[] price = { 150, 170, 140 };

        //object of the clas that is sued to inherit the abstract class and help in running the dog
        dgMove obj = new dgMove();
        //count  the player who is participating in the game 
        int racePlayer = 0;
        public Form1()
        {
            InitializeComponent();
            //disable the button of the running 
            run.Enabled = false;
        }

        private void set_Click(object sender, EventArgs e)
        {
            //set the player to partcipate in the game and display the bet amount with the relevent dog in the label to show the bet details 
            if (lbPlayer.SelectedIndex == 0 && nmAmount.Value <= price[0] && nmDog.Value <= 4)
            {
                dog1.Text = nmDog.Value.ToString();
                amount1.Text = nmAmount.Value.ToString();
                racePlayer++;
                run.Enabled = true;
            }
            else if (lbPlayer.SelectedIndex == 1 && nmAmount.Value <= price[1] && nmDog.Value <= 4)
            {
                dog2.Text = nmDog.Value.ToString();
                amount2.Text = nmAmount.Value.ToString();
                racePlayer++;
                run.Enabled = true;
            }
            else if (lbPlayer.SelectedIndex == 2 && nmAmount.Value <= price[2] && nmDog.Value <= 4)
            {
                dog3.Text = nmDog.Value.ToString();
                amount3.Text = nmAmount.Value.ToString();
                racePlayer++;
                run.Enabled = true;
            }
            else {
                MessageBox.Show("You have to select any player for the race");
            }


        }
        public void result(int id) {

            MessageBox.Show("dog " + id + " is the winner");

            

            if (dog1.Text.ToString().Length == 1 && dog1.Text.Equals(id.ToString())) {

                price[0] = price[0] + Convert.ToInt32(amount1.Text.ToString());
                lbPlayer.Items.RemoveAt(0);
                lbPlayer.Items.Insert(0, "Gurpreet has $ " + price[0]);
                
            }

            if (dog1.Text.ToString().Length == 1 && !dog1.Text.Equals(id.ToString()))
            {
                price[0] = price[0] - Convert.ToInt32(amount1.Text.ToString());
                lbPlayer.Items.RemoveAt(0);
                lbPlayer.Items.Insert(0, "Gurpreet has $ " + price[0]);
                
            }


            if (dog2.Text.ToString().Length == 1 && dog2.Text.Equals(id.ToString()))
            {

                price[1] = price[1] + Convert.ToInt32(amount2.Text.ToString());
                lbPlayer.Items.RemoveAt(1);
                lbPlayer.Items.Insert(1, "Love  has $ " + price[1]);

            }

            if (dog2.Text.ToString().Length == 1 && !dog2.Text.Equals(id.ToString()))
            {
                price[1] = price[1] - Convert.ToInt32(amount2.Text.ToString());
                lbPlayer.Items.RemoveAt(1);
                lbPlayer.Items.Insert(1, "Love has $ " + price[1]);

            }

            if (dog3.Text.ToString().Length == 1 && dog3.Text.Equals(id.ToString()))
            {

                price[2] = price[2] + Convert.ToInt32(amount3.Text.ToString());
                lbPlayer.Items.RemoveAt(2);
                lbPlayer.Items.Insert(2, "Sukh  has $ " + price[2]);

            }

            if (dog3.Text.ToString().Length == 1 && !dog3.Text.Equals(id.ToString()))
            {
                price[2] = price[2] - Convert.ToInt32(amount3.Text.ToString());
                lbPlayer.Items.RemoveAt(2);
                lbPlayer.Items.Insert(2, "Sukh has $ " + price[2]);

            }

            resetGame();




        }

        // resett the game after playing the game 
        public void resetGame() {

            MessageBox.Show("Game is finished Now you have to setup again for playing again");
            racePlayer = 0;
            dog1.Text = "Selected Dog";
            dog2.Text = "Selected Dog";
            dog3.Text = "Selected Dog";
            amount1.Text = "Bet Amount";
            amount2.Text = "Bet Amount";
            amount3.Text = "Bet Amount";

            run.Enabled = false;

            dg1.Left = 0;
            dg2.Left = 0;
            dg3.Left = 0;
            dg4.Left = 0;
            nmDog.Value = 1;
            nmAmount.Value = 1;

        }
        //timer is used to call he method of the class and move the running dog
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dg1.Left < 710)
            {
                dg1.Left = dg1.Left + obj.dgMove1();
            }
            else {
                timer1.Stop();   
                result(1);
            }

            if (dg2.Left < 710)
            {
                dg2.Left = dg2.Left + obj.dgMove2();
            }
            else
            {                
                timer1.Stop();
                result(2);
            }


            if (dg3.Left < 710)
            {
                dg3.Left = dg3.Left + obj.dgMove3();
            }
            else
            {
                timer1.Stop();
                result(3);
            }

            if (dg4.Left < 710)
            {
                dg4.Left = dg4.Left + obj.dgMove4();
            }
            else
            {   
                timer1.Stop();
                result(4);
            }


        }


        private void run_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
