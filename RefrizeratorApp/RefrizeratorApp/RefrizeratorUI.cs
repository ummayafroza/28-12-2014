using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RefrizeratorApp
{
    public partial class RefrizeratorUI : Form
    {
        private Refrizerator aRefrizerator;

        public RefrizeratorUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrizerator = new Refrizerator(Convert.ToInt32(maxWeightTextBox.Text));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int noOfItems = Convert.ToInt32(noOfItemsTextBox.Text);
            int weightPerUnit = Convert.ToInt32(weightPerUnitTextBox.Text);
            try
            {
                aRefrizerator.AddItems(noOfItems, weightPerUnit);
                currentWeightTextBox.Text = aRefrizerator.CurrentWeight.ToString();
                remainingWeightTextBox.Text = aRefrizerator.RemainingWeight.ToString();
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show("Overflow..");
            }


        }
    }
}
