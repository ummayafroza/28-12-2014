using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryApp
{
    public partial class Form1 : Form
    {
        private Employee anEmployee;

        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            anEmployee = new Employee(idTextBox.Text, nameTextBox.Text, emailTextBox.Text);
            double basic = Convert.ToDouble(basicTextBox.Text);
            double medicalPercent = Convert.ToDouble(medicalPercentageTextBox.Text);
            double convPercent = Convert.ToDouble(conveyancePercentageTextBox.Text);
            Salary aSalary = new Salary(basic, medicalPercent, convPercent);
            anEmployee.EmployeeSalary = aSalary;
            MessageBox.Show("Saved");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            noOfIncrementsTextBox.Text = anEmployee.EmployeeSalary.NoOfIncrements.ToString();
            basicShowTextBox.Text = anEmployee.EmployeeSalary.Basic.ToString();
            conveyanceAmountTextBox.Text = anEmployee.EmployeeSalary.GetConvAmount().ToString();
            medicalAmountTextBox.Text = anEmployee.EmployeeSalary.GetMedicalAmount().ToString();
            totalTextBox.Text = anEmployee.EmployeeSalary.GetTotal().ToString();
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            double basicPercentToBeIncreased = Convert.ToDouble(incrementPercentageTextBox.Text);
            anEmployee.EmployeeSalary.Increase(basicPercentToBeIncreased);
            MessageBox.Show("Salary increased");
        }
    }
}
