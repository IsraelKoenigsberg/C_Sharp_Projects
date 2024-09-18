// Yisrael Koenigsberg Touro ID: Too443606
using System;
using System.Windows.Forms;

namespace PresidentEligibilityGUIVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This method handles the button click event to check eligibility
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get user inputs from the form
            bool isNaturalBornCitizen = chkNaturalBornCitizen.Checked; // Get checkbox value
            int age = 0;
            int yearsLived = 0;
            int termsServed = 0;

            // Try parsing the age and years lived from the textboxes
            bool isAgeValid = int.TryParse(txtAge.Text, out age);
            bool isYearsLivedValid = int.TryParse(txtYearsLived.Text, out yearsLived);
            bool istermsServedValid = int.TryParse(txtTermsServed.Text, out termsServed);
            // Check if all inputs are valid
            if (isAgeValid && isYearsLivedValid && istermsServedValid)
            {
                // Check eligibility: age must be at least 35 and years lived must be at least 14
                if (isNaturalBornCitizen && age >= 35 && yearsLived >= 14 && termsServed < 2)
                {
                    lblResult.Text = "You are eligible to be a U.S. president.";
                }
                else
                {
                    lblResult.Text = "You are not eligible to be a U.S. president.";
                }
            }
            else
            {
                lblResult.Text = "Please enter valid information for age and years lived in the U.S. Age and years lived in the U.S. must be an exact number";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
