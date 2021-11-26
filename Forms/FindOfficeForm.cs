using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Lab_1
{
    public partial class FindOfficeForm : Form
    {
		public Office modelOfClientOffice = new Office();
		public FindOfficeForm()
        {
            InitializeComponent();
            modelOfClientOffice.GeneralCharacteristics = new RealEstate();
			this.FormClosing += FindOfficeForm_FormClosing;


			modelOfClientOffice.GeneralCharacteristics.Price = 3000000;
			modelOfClientOffice.GeneralCharacteristics.Square = 0;
			modelOfClientOffice.Years = 0;
			modelOfClientOffice.Specifications = "Развитая";
			modelOfClientOffice.CountOfRooms = 1;
			modelOfClientOffice.Floor = 1;
			modelOfClientOffice.CountOfWorkers = 5;
			modelOfClientOffice.Parking = "Нет";



			PriceComboBox.SelectedItem = "1000000 - 3000000";
			SquareComboBox.SelectedItem = "< 50";
			YearsComboBox.SelectedItem = "Еще строится";
			InfastuctureComboBox.SelectedItem = "Развитая";
			CountOfRoomsComboBox.SelectedItem = "1 - 2";
			FloorComboBox.SelectedItem = "1";
			CountOfWorkersComboBox.SelectedItem = "до 10";
			LocationComboBox.SelectedItem = "Не в центре";
		}

		private void FindOfficeForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (PriceComboBox.SelectedItem.ToString() == "< 1000000")
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 1000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "1000000 - 3000000")
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 3000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "3000000 - 6000000")
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 6000000;
			}
			else
			{
				modelOfClientOffice.GeneralCharacteristics.Price = 1000000000;
			}
		}

		private void SquareComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SquareComboBox.SelectedItem.ToString() == "< 50")
			{
				modelOfClientOffice.GeneralCharacteristics.Square = 0;
			}
			else if (SquareComboBox.SelectedItem.ToString() == "50 - 200")
			{
				modelOfClientOffice.GeneralCharacteristics.Square = 50;
			}
			else
			{
				modelOfClientOffice.GeneralCharacteristics.Square = 200;
			}
		}

		private void YearsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (YearsComboBox.SelectedItem.ToString() == "Еще строится")
			{
				modelOfClientOffice.Years = 0;
			}
			else if (YearsComboBox.SelectedItem.ToString() == "меньше 10 лет")
			{
				modelOfClientOffice.Years = 10;
			}
			else if (YearsComboBox.SelectedItem.ToString() == "10-15 лет")
			{
				modelOfClientOffice.Years = 15;
			}
			else if (YearsComboBox.SelectedItem.ToString() == "15-30 лет")
			{
				modelOfClientOffice.Years = 30;
			}
			else
			{
				modelOfClientOffice.Years = 31;
			}
		}

		private void InfastuctureComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (InfastuctureComboBox.SelectedItem.ToString() == "Развитая")
			{
				modelOfClientOffice.Specifications = "Развитая";
			}
			else
			{
				modelOfClientOffice.Specifications = "Неразвитая";
			}
		}

		private void CountOfRoomsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CountOfRoomsComboBox.SelectedItem.ToString() == "1 - 2")
			{
				modelOfClientOffice.CountOfRooms = 1;
			}
			else if (CountOfRoomsComboBox.SelectedItem.ToString() == "2 - 5")
			{
				modelOfClientOffice.CountOfRooms = 2;
			}
			else if (CountOfRoomsComboBox.SelectedItem.ToString() == "5 - 10")
			{
				modelOfClientOffice.CountOfRooms = 5;
			}
			else
			{
				modelOfClientOffice.CountOfRooms = 10;
			}
		}

		private void FloorComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (FloorComboBox.SelectedItem.ToString() == "1")
			{
				modelOfClientOffice.Floor = 1;
			}
			else
			{
				modelOfClientOffice.Floor = 2;
			}
		}

		private void ParkingCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (ParkingCheckBox.Checked)
			{
				modelOfClientOffice.Parking = "Есть";
			}
			else
			{
				modelOfClientOffice.Parking = "Нет";
			}
		}

		private void CountOfWorkersComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CountOfWorkersComboBox.SelectedItem.ToString() == "до 10")
			{
				modelOfClientOffice.CountOfWorkers = 0;
			}
			else if (CountOfWorkersComboBox.SelectedItem.ToString() == "10 - 20")
			{
				modelOfClientOffice.CountOfWorkers = 10;
			}
			else if (CountOfWorkersComboBox.SelectedItem.ToString() == "20 - 50")
			{
				modelOfClientOffice.CountOfWorkers = 20;
			}
			else
			{
				modelOfClientOffice.CountOfWorkers = 50;
			}
		}


        private void LocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			modelOfClientOffice.GeneralCharacteristics.Location = LocationComboBox.SelectedItem.ToString();
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			ResultForm resultForm = new ResultForm(modelOfClientOffice);
			resultForm.Show();
		}

		private void GoBackButton_Click(object sender, EventArgs e)
        {
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();
		}
    }
}
