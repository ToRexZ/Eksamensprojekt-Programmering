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
        /// <summary>
        /// Temporary storage for player name.
        /// </summary>
        public string tempName;
        public formTeamCreator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Represents button generate player clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            //stores the name of the player temporarily, and makes the first letter uppercase.
            tempName = FirstLetterToUpper(txtFirstName.Text) + " " + FirstLetterToUpper(txtLastName.Text); 

            //Checks if the name is valid. 
            if (ValidName()) 
            {
                //adds the name to the combobox, and resets the textboxes.
                cmbPlayers.Items.Add(tempName);
                txtFirstName.Text = "";
                txtLastName.Text = "";
            }

            //if not valid, show error messange
            else
            {
                MessageBox.Show("Please fill out the player's name.");
            }
            
        }

        /// <summary>
        /// Represents button Add to team clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToTeam_Click(object sender, EventArgs e)
        {
            //checks if the player is already in the team.
            if (ValidPlayer())
            {
                //adds the player to the team.
                lsbPlayerInTeam.Items.Add(cmbPlayers.SelectedItem);
            }
            //else show errormesagge.
            else
            {
                MessageBox.Show("The player is already in the team.");
            }
            
        }

        /// <summary>
        /// This checks if the player already exists in the team.
        /// </summary>
        /// <returns> a boolean </returns>
        private bool ValidPlayer()
        {
            if (lsbPlayerInTeam.Items.Contains(cmbPlayers.SelectedItem))
                return false;
            return true;
        }

        /// <summary>
        /// Checks if the typed name is valid. 
        /// </summary>
        /// <returns> a boolean </returns>
        private bool ValidName()
        {
            //if firstname is empty.
            if (txtFirstName.Text == "")
                return false;
            //if last name is empty.
            if (txtLastName.Text == "")
                return false;
            //if the list of players already contains the name. 
            if (cmbPlayers.Items.Contains(tempName))
                return false;
            //else return true.
            return true;
        }

        /// <summary>
        /// Converts the first character of a string to uppercase.
        /// </summary>
        /// <param name="input"> represents the string input. </param>
        /// <returns> string </returns>
        public string FirstLetterToUpper(string input)
        {
            //if the textbox is empty return null. 
            if (input == null)
                return null;

            //if the input contains any characters.
            if (input.Length > 1)
                //return the first char to upper.
                return char.ToUpper(input[0]) + input.Substring(1);
            //return the character to upper.
            return input.ToUpper();
        }

    }
}
