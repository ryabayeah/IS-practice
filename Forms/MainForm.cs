using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace IS_Lab_1
{
    public partial class MainForm : Form
    {
		Offer offer = new Offer();
		public MainForm()
		{
			InitializeComponent();
			this.FormClosing += MainForm_FormClosing;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void HouseButton_Click(object sender, EventArgs e)
		{
			FindHouseForm findHouseForm = new FindHouseForm();
			findHouseForm.Show();
			this.Hide();
		}

		private void ApartmentButton_Click(object sender, EventArgs e)
		{
			FindApartmentForm findApartmentForm = new FindApartmentForm();
			findApartmentForm.Show();
			this.Hide();
		}

		private void SteadButton_Click(object sender, EventArgs e)
		{
			FindSteadForm findSteadForm = new FindSteadForm();
			findSteadForm.Show();
			this.Hide();
		}

        private void officeButton_Click(object sender, EventArgs e)
        {
			FindOfficeForm findForm = new FindOfficeForm();
			findForm.Show();
			this.Hide();
		}
    }
}
