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
    public partial class Startwindow : Form
    {

        string enteredname;
        double enteredchips;
        

        public Startwindow()
        {
            InitializeComponent();
            if (!File.Exists("Gamedata.xml")) {

                load_button.Enabled = false;
                load_button.Text = "No game saved";
            }
            else
            {
                load_button.Enabled = true;
                load_button.Text = "Load game " + File.GetCreationTime("Gamedata.xml");
            }
        }


        private void start_button_Click(object sender, EventArgs e)
        {
            Gamecontroller gamecontroller = new Gamecontroller(true, enteredname, enteredchips);
            Statehandler.LoadGuiPlayerData();
            this.Hide();

        }

        private void Gamewindow_Load(object sender, EventArgs e)
        {

          

        }


        private void name_textbox_TextChanged(object sender, EventArgs e)
        {
            enteredname = name_textbox.Text;
         
            

        }

        private void chips_textbox_TextChanged(object sender, EventArgs e)
        {
            enteredchips = Double.Parse(chips_textbox.Text);

            start_button.Enabled = !string.IsNullOrWhiteSpace(name_textbox.Text +  chips_textbox.Text);
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            Gamecontroller gamecontroller = new Gamecontroller(false);
        }


    

      
    }
}
