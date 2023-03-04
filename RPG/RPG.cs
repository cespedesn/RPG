using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class RPG : Form
    {
        private Player _player;

        //Constructor
        public RPG()
        {
            InitializeComponent();

            //Creating a new Location obj and saving it to the variable 
            //location. 
            Location location = new Location(1, "Home", "This is your house.");
            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house.";

            //Assign values to properties of _player obj
            _player = new Player(10, 10, 20, 0, 1);
            //_player.CurrentHitPoints = 10;
            //_player.MaximumHitPoints = 10;
            //_player.Gold = 20;
            //_player.ExperiencePoints = 0;
            //_player.Level = 1;
            
            //Assign values of properties from _player to text of labels
            //on screen
            //Have to convert to string since point system is in integers
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RPG_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}

