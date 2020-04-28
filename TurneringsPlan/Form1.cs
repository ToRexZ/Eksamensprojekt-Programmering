using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurneringsPlan
{
    public partial class formTeamCreator : Form
    {
        public formTeamCreator()
        {
            InitializeComponent();
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            if (ValidName()) 
            { 
                cmbPlayers.Items.Add(txtFirstName.Text + " " + txtLastName.Text);
            }

            else
            {
                MessageBox.Show("Please fill out the player's name.");
            }
            
        }

        private void btnAddToTeam_Click(object sender, EventArgs e)
        {
            lsbPlayerInTeam.Items.Add(cmbPlayers.SelectedItem);
        }

        public bool ValidName()
        {
            if (txtFirstName.Text == "")
                return false;
            if (txtLastName.Text == "")
                return false;
            return true;
        }
    }
}
