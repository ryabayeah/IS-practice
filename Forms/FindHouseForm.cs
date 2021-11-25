using System;
using System.Windows.Forms;

namespace IS_Lab_1
{
    public partial class FindHouseForm : Form
    {
		public House modelOfClientHouse = new House();
		public FindHouseForm()
		{
			InitializeComponent();
			modelOfClientHouse.GeneralCharacteristics = new RealEstate();
			this.FormClosing += FindHouseForm_FormClosing;

			modelOfClientHouse.GeneralCharacteristics.Price = 1000000;
			modelOfClientHouse.GeneralCharacteristics.Square = 0;
			modelOfClientHouse.Comunication = "Средняя";
			modelOfClientHouse.Comfort = "Нет";
			modelOfClientHouse.Floors = 1;
			modelOfClientHouse.TransportAccessibility = "Неразвитая";
			modelOfClientHouse.TypeOfHouse = "Деревянный";
			modelOfClientHouse.GeneralCharacteristics.Location = "За городом";

			PriceComboBox.SelectedItem = "< 1000000";
			LocationComboBox.SelectedItem = "За городом";
			TransportComboBox.SelectedItem = "Неразвитая";
			TypeOfHouseComboBox.SelectedItem = "Деревянный";
			SquareComboBox.SelectedItem = "< 80";
			FloorComboBox.SelectedItem = "1";

		}

		private void FindHouseForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (PriceComboBox.SelectedItem.ToString() == "< 1000000")
			{
				modelOfClientHouse.GeneralCharacteristics.Price = 1000000;
			}
			else if (PriceComboBox.SelectedItem.ToString() == "1000000 - 3000000")
			{
				modelOfClientHouse.GeneralCharacteristics.Price = 3000000;
			}
			else if (PriceComboBox.SelectedItem.ToString().Equals("3000000 - 6000000"))
			{
				modelOfClientHouse.GeneralCharacteristics.Price = 6000000;
			}
			else
			{
				modelOfClientHouse.GeneralCharacteristics.Price = 1000000000;
			}
		}

		private void LocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (LocationComboBox.SelectedItem.ToString() == "В городе")
			{
				modelOfClientHouse.GeneralCharacteristics.Location = "В городе";
			}
			else
			{
				modelOfClientHouse.GeneralCharacteristics.Location = "За городом";
			}
		}

		private void TransportComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TransportComboBox.SelectedItem.ToString() == "Развитая")
			{
				modelOfClientHouse.TransportAccessibility = "Развитая";
			}
			else
			{
				modelOfClientHouse.TransportAccessibility = "Неразвитая";
			}
		}

		private void TypeOfHouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TypeOfHouseComboBox.SelectedItem.ToString() == "Деревянный")
			{
				modelOfClientHouse.TypeOfHouse = "Деревянный";
			}
			else if (TypeOfHouseComboBox.SelectedItem.ToString() == "Кирпичный")
			{
				modelOfClientHouse.TypeOfHouse = "Кирпичный";
			}
			else
			{
				modelOfClientHouse.TypeOfHouse = "Бревенчатый";
			}
		}

		private void SquareComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SquareComboBox.SelectedItem.ToString() == "< 80")
			{
				modelOfClientHouse.GeneralCharacteristics.Square = 0;
			}
			else if (SquareComboBox.SelectedItem.ToString() == "80 - 150")
			{
				modelOfClientHouse.GeneralCharacteristics.Square = 80;
			}
			else
			{
				modelOfClientHouse.GeneralCharacteristics.Square = 150;
			}
		}

		private void FloorComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (FloorComboBox.SelectedItem.ToString() == "1")
			{
				modelOfClientHouse.Floors = 1;
			}
			else if (FloorComboBox.SelectedItem.ToString() == "2")
			{
				modelOfClientHouse.Floors = 2;
			}
			else if (FloorComboBox.SelectedItem.ToString() == "3")
			{
				modelOfClientHouse.Floors = 3;
			}
			else
			{
				modelOfClientHouse.Floors = 4;
			}
		}


		private void ComfortCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (ComfortCheckBox.Checked)
			{
				modelOfClientHouse.Comfort = "Есть";
			}
			else
			{
				modelOfClientHouse.Comfort = "Нет";
			}
		}

		private void ComunicationCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (ComunicationCheckBox.Checked)
			{
				modelOfClientHouse.Comunication = "Хорошая";
			}
			else
			{
				modelOfClientHouse.Comunication = "Средняя";
			}
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			ResultForm resultForm = new ResultForm(modelOfClientHouse);
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
