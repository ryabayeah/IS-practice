using System;
using System.Windows.Forms;

namespace IS_Lab_1
{
    public partial class FindSteadForm : Form
    {
        public Stead modelOfClientSted = new Stead();
        public FindSteadForm()
        {
            InitializeComponent();
            modelOfClientSted.GeneralCharacteristics = new RealEstate();
            this.FormClosing += FindSteadForm_FormClosing;

            modelOfClientSted.GeneralCharacteristics.Price = 1000000;
            modelOfClientSted.GeneralCharacteristics.Square = 0;
            modelOfClientSted.GeneralCharacteristics.Location = "В области";
            modelOfClientSted.AdjacentTerritory = 2;
            modelOfClientSted.Ecology = "Средняя";
            modelOfClientSted.TransportAccessibility = "Неразвитая";

            PriceComboBox.SelectedItem = "< 1000000";
            SquareComboBox.SelectedItem = "< 1 га";
            LocationComboBox.SelectedItem = "В области";
            NearTeritotyComboBox.SelectedItem = "1-2";

        }

        private void FindSteadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm(modelOfClientSted);
            resultForm.Show();
        }

        private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PriceComboBox.SelectedItem.ToString() == "< 1000000")
            {
                modelOfClientSted.GeneralCharacteristics.Price = 1000000;
            }
            else if (PriceComboBox.SelectedItem.ToString() == "1000000 - 2000000")
            {
                modelOfClientSted.GeneralCharacteristics.Price = 2000000;
            }
            else if (PriceComboBox.SelectedItem.ToString() == "2000000 - 3000000")
            {
                modelOfClientSted.GeneralCharacteristics.Price = 3000000;
            }
            else
            {
                modelOfClientSted.GeneralCharacteristics.Price = 300000000;
            }
        }

        private void LocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelOfClientSted.GeneralCharacteristics.Location = LocationComboBox.SelectedItem.ToString();
        }

        private void SquareComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SquareComboBox.SelectedItem.ToString() == "< 1 га")
            {
                modelOfClientSted.GeneralCharacteristics.Square = 0;
            }
            else if (SquareComboBox.SelectedItem.ToString() == "1 -5 га")
            {
                modelOfClientSted.GeneralCharacteristics.Square = 1;
            }
            else if (SquareComboBox.SelectedItem.ToString() == "5 - 10 га")
            {
                modelOfClientSted.GeneralCharacteristics.Square = 5;
            }
            else
            {
                modelOfClientSted.GeneralCharacteristics.Square = 10;
            }
        }

        private void NearTeritotyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NearTeritotyComboBox.SelectedItem.ToString() == "1-2")
            {
                modelOfClientSted.AdjacentTerritory = 2;
            }
            else if (NearTeritotyComboBox.SelectedItem.ToString() == "3-5")
            {
                modelOfClientSted.AdjacentTerritory = 5;
            }
            else
            {
                modelOfClientSted.AdjacentTerritory = 1000;
            }
        }

        private void TransportCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TransportCheckBox.Checked)
            {
                modelOfClientSted.TransportAccessibility = "Развитая";
            }
            else
            {
                modelOfClientSted.TransportAccessibility = "Неразвитая";
            }
        }

        private void EcologyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EcologyCheckBox.Checked)
            {
                modelOfClientSted.Ecology = "Хорошая";
            }
            else
            {

                modelOfClientSted.Ecology = "Средняя";
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
