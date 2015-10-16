using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workshop_registration
{
    public partial class FormBitSecondRegMain : Form
    {
        private const int DAYSLODGING = 3;

        // initialize the form
        public FormBitSecondRegMain()
        {
            InitializeComponent();
        }

        // load the information on the form
        private void FormBitSecondRegMain_Load(object sender, EventArgs e)
        {
            // populate the location options
            listBoxLocations.Items.Add("Austin");
            listBoxLocations.Items.Add("Chicago");
            listBoxLocations.Items.Add("Dallas");
            listBoxLocations.Items.Add("Orlando");
            listBoxLocations.Items.Add("Phoenix");
            listBoxLocations.Items.Add("Raleigh");
        }

        // reset all the values
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            f_update_labels(0.00, 0.00);
            listBoxLocations.ClearSelected();
            radioButtonHandleStress.Checked = false;
            radioButtonSupSkills.Checked = false;
            radioButtonTimeMgmt.Checked = false;
        }

        // update the labels with the caluated values
        private void f_update_labels(double v_registration, double v_lodging)
        {
            double total = 0;
            double lodging_cost = 0;

            lodging_cost = DAYSLODGING * v_lodging;
            total = v_registration + lodging_cost;

            labelRegistration.Text = "Registration: $" + v_registration.ToString();
            labelLodging.Text = "Lodging: $" + lodging_cost.ToString();
            labelTotal.Text = "Total: $" + total.ToString();
        }

        /// <summary>
        /// Perform the calculation if the location and workshop have been selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if(listBoxLocations.SelectedIndex == -1)
            {
                MessageBox.Show("Select a location.");
            }
            else if (radioButtonHandleStress.Checked == false && 
                radioButtonSupSkills.Checked == false && 
                radioButtonTimeMgmt.Checked == false)
            {
                MessageBox.Show("Select a workshop.");
            }
            else
            {
                double lodging_fee = 0.00;
                double registration_fee = 0.00;

                // do work
                // switch(listBoxLocations.SelectedValue.ToString())
                switch(listBoxLocations.GetItemText(listBoxLocations.SelectedItem))
                {
                    case "Austin":
                        lodging_fee = 150.00;
                        break;
                    case "Chicago":
                        lodging_fee = 225.00;
                        break;
                    case "Dallas":
                        lodging_fee = 175.00;
                        break;
                    case "Orlando":
                        lodging_fee = 300.00;
                        break;
                    case "Phoenix":
                        lodging_fee = 175.00;
                        break;
                    case "Raleigh":
                        lodging_fee = 150.00;
                        break;

                    default:
                        MessageBox.Show("Error");
                        break;
                }

                if(radioButtonHandleStress.Checked == true)
                {
                    registration_fee = 1000.00;
                }
                else if(radioButtonSupSkills.Checked == true)
                {
                    registration_fee = 800.00;
                }
                else if(radioButtonTimeMgmt.Checked == true)
                {
                    registration_fee = 1500.00;
                }
                else
                {
                    MessageBox.Show("Error");
                }

                f_update_labels(registration_fee, lodging_fee);
            }
        }
    }
}
