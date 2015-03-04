using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConsoleApplication1
{
    public partial class Gamewindow : Form
    {

        Gamecontroller controller;

        public Gamewindow(Gamecontroller control)
        {
            InitializeComponent();

            //Setting parent for labels
            player1_label.Parent = playerinfo_panel;
            player1chips_label.Parent = playerinfo_panel;
            desc_chips1_label.Parent = playerinfo_panel;
            desc_pot.Parent = pokerTable_box;
            currentpot.Parent = pokerTable_box;
            eventtext_label.Parent = pokerTable_box;
            player_bet_amount.Parent = pokerTable_box;
            aiplayer_bet_amount.Parent = pokerTable_box;
            controller = control;
        }


        private void Gamewindow_Load(object sender, EventArgs e)
        {
            controller.gameStarted();
            
            
        }

        public void showMessage(string text)
        {
            MessageBox.Show(text);
        }

        public void showEvent(string text)
        {

            eventtext_label.Text = text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void changePictureBox(PictureBox box, string filepath)
        {
            box.Image.Dispose();
            Image img = Image.FromFile(filepath);
            box.Image = img;
            

        }

        public void changeLabel(Label label, string text)
        {

            label.Text = text;
        }

        private void bet_button_Click(object sender, EventArgs e)
        {
            controller.attemptBet();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void call_button_ai_Click(object sender, EventArgs e)
        {
            
        }

        private void fold_button_Click(object sender, EventArgs e)
        {

            controller.attemptFold();
        }

        private void fold_button_ai_Click(object sender, EventArgs e)
        {
           
        }

        private void bet_button_ai_Click(object sender, EventArgs e)
        {
           
        }

        private void call_button_Click(object sender, EventArgs e)
        {
            controller.attemptCall();
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            controller.attemptCheck();
        }

        private void check_button_ai_Click(object sender, EventArgs e)
        {
          
        }

        public void disposeWindow()
        {
            this.Hide();
            this.Close();
            Startwindow sw = new Startwindow();
            sw.ShowDialog();
            
        }

        private void determine_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
