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
    public partial class FindApartmentForm : Form
    {
        public Apartment modelOfClientApartment = new Apartment();
        public FindApartmentForm()
        {
            InitializeComponent();
            modelOfClientApartment.GeneralCharacteristics = new RealEstate();
            this.FormClosing += FindApartmentForm_FormClosing;

            modelOfClientApartment.GeneralCharacteristics.Price = 300000000;
            modelOfClientApartment.GeneralCharacteristics.Square = 50;
            modelOfClientApartment.Years = 100;
            modelOfClientApartment.Infrastructure = "Развитая";
            modelOfClientApartment.TypeOfBuilding = "Монолитный";
            modelOfClientApartment.CountOfRooms = 3;
            modelOfClientApartment.Floor = 2;
            modelOfClientApartment.GeneralCharacteristics.Location = "В городе";


            modelOfClientApartment.NewOrOld = "Вторичка";
            modelOfClientApartment.Parking = "Есть";
            modelOfClientApartment.Comfort = "Есть";
            modelOfClientApartment.View = "Есть";
            modelOfClientApartment.TransportAccessibility = "Развитая";

            modelOfClientApartment.MaxFloor = 100;




            PriceComboBox.SelectedItem = "> 3000000";
            SquareComboBox.SelectedItem = "50 - 100";
            YearsComboBox.SelectedItem = "больше 30 лет";
            InfastuctureComboBox.SelectedItem = "Развитая";
            MaterialsComboBox.SelectedItem = "Монолитный";
            CountOfRoomsComboBox.SelectedItem = "3";
            FloorComboBox.SelectedItem = "От второго до предпоследнего";
            LocationComboBox.SelectedItem = "В городе";

            ParkingCheckBox.Checked = true;
            ComfortCheckBox.Checked = true;
            ViewCheckBox.Checked = true;
            TransportСheckBox.Checked = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm(modelOfClientApartment);
            resultForm.Show();
        }

        private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PriceComboBox.SelectedItem.ToString() == "< 1000000")
            {
                modelOfClientApartment.GeneralCharacteristics.Price = 1000000;
            }
            else if (PriceComboBox.SelectedItem.ToString() == "1000000 - 2000000")
            {
                modelOfClientApartment.GeneralCharacteristics.Price = 2000000;
            }
            else if (PriceComboBox.SelectedItem.ToString() == "2000000 - 3000000")
            {
                modelOfClientApartment.GeneralCharacteristics.Price = 3000000;
            }
            else
            {
                modelOfClientApartment.GeneralCharacteristics.Price = 300000000;
            }
        }

        private void SquareComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SquareComboBox.SelectedItem.ToString() == "< 50")
            {
                modelOfClientApartment.GeneralCharacteristics.Square = 0;
            }
            else if (SquareComboBox.SelectedItem.ToString() == "50 - 100")
            {
                modelOfClientApartment.GeneralCharacteristics.Square = 50;
            }
            else
            {
                modelOfClientApartment.GeneralCharacteristics.Square = 100;
            }
        }

        private void YearsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearsComboBox.SelectedItem.ToString() == "Еще строится")
            {
                modelOfClientApartment.Years = 0;
            }
            else if (YearsComboBox.SelectedItem.ToString() == "меньше 10 лет")
            {
                modelOfClientApartment.Years = 10;
            }
            else if (YearsComboBox.SelectedItem.ToString() == "10-15 лет")
            {
                modelOfClientApartment.Years = 15;
            }
            else if (YearsComboBox.SelectedItem.ToString() == "15-30 лет")
            {
                modelOfClientApartment.Years = 30;
            }
            else
            {
                modelOfClientApartment.Years = 100;
            }
        }

        private void InfastuctureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InfastuctureComboBox.SelectedItem.ToString() == "Развитая")
            {
                modelOfClientApartment.Infrastructure = "Развитая";
            }
            else
            {
                modelOfClientApartment.Infrastructure = "Неразвитая";
            }
        }

        private void MaterialsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaterialsComboBox.SelectedItem.ToString() == "Панельный")
            {
                modelOfClientApartment.TypeOfBuilding = "Панельный";
            }
            else if (MaterialsComboBox.SelectedItem.ToString() == "Кирпичный")
            {
                modelOfClientApartment.TypeOfBuilding = "Кирпичный";
            }
            else
            {
                modelOfClientApartment.TypeOfBuilding = "Монолитный";
            }
        }

        private void CountOfRoomsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CountOfRoomsComboBox.SelectedItem.ToString() == "1")
            {
                modelOfClientApartment.CountOfRooms = 1;
            }
            else if (CountOfRoomsComboBox.SelectedItem.ToString() == "2")
            {
                modelOfClientApartment.CountOfRooms = 2;
            }
            else if (CountOfRoomsComboBox.SelectedItem.ToString() == "3")
            {
                modelOfClientApartment.CountOfRooms = 3;
            }
            else if (CountOfRoomsComboBox.SelectedItem.ToString() == "4")
            {
                modelOfClientApartment.CountOfRooms = 4;
            }
            else
            {
                modelOfClientApartment.CountOfRooms = 5;
            }
        }

        private void FloorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FloorComboBox.SelectedItem.ToString() == "Первый этаж")
            {
                modelOfClientApartment.Floor = 1;
            }
            else if (FloorComboBox.SelectedItem.ToString() == "От второго до предпоследнего")
            {
                modelOfClientApartment.Floor = 2;
            }
            else
            {
                modelOfClientApartment.Floor = 3;
            }
        }

        private void LocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LocationComboBox.SelectedItem.ToString() == "В городе")
            {
                modelOfClientApartment.GeneralCharacteristics.Location = "В городе";
            }
            else
            {
                modelOfClientApartment.GeneralCharacteristics.Location = "За городом";
            }
        }

        private void NewOrOldcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NewOrOldcheckBox.Checked)
            {
                modelOfClientApartment.NewOrOld = "Новостройка";
            }
            else
            {
                modelOfClientApartment.NewOrOld = "Вторичка";
            }
        }

        private void ParkingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ParkingCheckBox.Checked)
            {
                modelOfClientApartment.Parking = "Есть";
            }
            else
            {
                modelOfClientApartment.Parking = "Нет";
            }
        }

        private void ComfortCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ComfortCheckBox.Checked)
            {
                modelOfClientApartment.Comfort = "Есть";
            }
            else
            {
                modelOfClientApartment.Comfort = "Нет";
            }
        }

        private void ViewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewCheckBox.Checked)
            {
                modelOfClientApartment.View = "Есть";
            }
            else
            {
                modelOfClientApartment.View = "Нет";
            }
        }

        private void TransportСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TransportСheckBox.Checked)
            {
                modelOfClientApartment.TransportAccessibility = "Развитая";
            }
            else
            {
                modelOfClientApartment.TransportAccessibility = "Неразвитая";
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void FindApartmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
