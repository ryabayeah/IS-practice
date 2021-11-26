using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace IS_Lab_1
{
    public partial class ResultForm : Form
    {
        private Offer offerList;
        private Office clientOffice;
        private House clientHouse;
        private Apartment clientApartment;
        private Stead clientStead;
        private List<Office> officeResult;
        private List<House> houseResult;
        private List<Apartment> apartmentResult;
        private List<Stead> steadResult;

        public ResultForm()
        {
            InitializeComponent();
        }

		public ResultForm(Office office)
		{
			clientOffice = office;
			InitializeComponent();
			TakeOffers();
			officeResult = IntelliegentSystem.FindOffice(clientOffice, offerList.officeList);
			if (officeResult.Count > 0)
			{
				foreach (var res in officeResult)
				{
					richTextBox1.Text += "Стоимость: " + res.GeneralCharacteristics.Price.ToString() + " руб." + "\n";
					richTextBox1.Text += "Расположение: " + res.GeneralCharacteristics.Location + "\n";
					richTextBox1.Text += "Адрес офиса: " + res.GeneralCharacteristics.Adress + "\n";
					richTextBox1.Text += "Площадь офиса: " + res.GeneralCharacteristics.Square + " кв. м." + "\n";
					richTextBox1.Text += "Возраст офиса: " + res.Years + " лет" + "\n";
					richTextBox1.Text += "Количество комнат: " + res.CountOfRooms.ToString() + "\n";
					richTextBox1.Text += "Этаж: " + res.Floor.ToString() + "\n";
					richTextBox1.Text += "Инфраструктура: " + res.Specifications + "\n";
					richTextBox1.Text += "Парковка: " + res.Parking;
					richTextBox1.Text += "\n...\n";
				}
			}
			else
			{
				richTextBox1.Text = "Ничего подходящего не найдено(";
			}
		}
		public ResultForm(House house)
		{
			clientHouse = house;
			InitializeComponent();
			TakeOffers();
			houseResult = IntelliegentSystem.FindHouse(clientHouse, offerList.houseList);
			if (houseResult.Count > 0)
			{
				foreach (var res in houseResult)
				{
					richTextBox1.Text += "Стоимость: " + res.GeneralCharacteristics.Price.ToString() + " руб." + "\n";
					richTextBox1.Text += "Локация: " + res.GeneralCharacteristics.Location + "\n";
					richTextBox1.Text += "Местоположение: " + res.GeneralCharacteristics.Adress + "\n";
					richTextBox1.Text += "Площадь: " + res.GeneralCharacteristics.Square + " кв. м." + "\n";
					richTextBox1.Text += "Количество этажей: " + res.Floors + "\n";
					richTextBox1.Text += "Удобства: " + res.Comfort + "\n";
					richTextBox1.Text += "Комуникация: " + res.Comunication  + "\n";
					richTextBox1.Text += "Транспортная доступность: " + res.TransportAccessibility + "\n";
					richTextBox1.Text += "Тип дома: " + res.TypeOfHouse + "\n";
					richTextBox1.Text += "...\n";
				}
			}
			else
			{
				richTextBox1.Text = "Ничего подходящего не найдено(";
			}

		}
		public ResultForm(Apartment apartment)
		{
			clientApartment = apartment;
			InitializeComponent();
			TakeOffers();
			apartmentResult = IntelliegentSystem.FindApartment(clientApartment, offerList.apartmentList);
			if (apartmentResult.Count > 0)
			{
				foreach (var res in apartmentResult)
				{
					richTextBox1.Text += "Стоимость: " + res.GeneralCharacteristics.Price.ToString() + " руб." + "\n";
					richTextBox1.Text += "Местоположение: " + res.GeneralCharacteristics.Location + "\n";
					richTextBox1.Text += "Адрес: " + res.GeneralCharacteristics.Adress + "\n";
					richTextBox1.Text += "Площадь: " + res.GeneralCharacteristics.Square + " кв. м." + "\n";
					richTextBox1.Text += "Состояние: " + res.NewOrOld + "\n";
					richTextBox1.Text += "Этаж: " + res.Floor+ "\n";
					richTextBox1.Text += "Всего этажей: " + res.MaxFloor + "\n";
					richTextBox1.Text += "Удобства: " + res.Comfort + "\n";
					richTextBox1.Text += "Количство комнат: " + res.CountOfRooms + "\n";
					richTextBox1.Text += "Транспортная доступность: " + res.TransportAccessibility + "\n";
					richTextBox1.Text += "Тип здания: " + res.TypeOfBuilding + "\n";
					richTextBox1.Text += "Красивый вид:" + res.View + "\n";
					richTextBox1.Text += "Парковка: " + res.Parking;
					richTextBox1.Text += "\n...\n";
				}
			}
			else
			{
				richTextBox1.Text = "Ничего подходящего не найдено(";
			}

		}
		public ResultForm(Stead stead)
		{
			clientStead = stead;
			InitializeComponent();
			TakeOffers();
			steadResult = IntelliegentSystem.FindStead(clientStead, offerList.steadList);
			if (steadResult.Count > 0)
			{
				foreach (var res in steadResult)
				{
					richTextBox1.Text += "Стоимость: " + res.GeneralCharacteristics.Price.ToString() + " руб." + "\n";
					richTextBox1.Text += "Локация: " + res.GeneralCharacteristics.Location + "\n";
					richTextBox1.Text += "Местоположение: " + res.GeneralCharacteristics.Adress + "\n";
					richTextBox1.Text += "Площадь: " + res.GeneralCharacteristics.Square + " га." + "\n";
					richTextBox1.Text += "Прилегающая территория " + res.AdjacentTerritory + " км." + "\n";
					richTextBox1.Text += "Экология: " + res.Ecology + "\n";
					richTextBox1.Text += "Транспортная доступность: " + res.TransportAccessibility + "\n";
					richTextBox1.Text += "...\n";

				}
			}
			else
			{
				richTextBox1.Text = "Ничего подходящего не найдено(";
			}
		}

		private void TakeOffers()
		{
			string path = Directory.GetCurrentDirectory() + @"\JsonOffersList.json";
			string jsonString = File.ReadAllText(path);
			offerList = JsonSerializer.Deserialize<Offer>(jsonString);
		}

        private void GoBackButton_Click(object sender, EventArgs e)
        {
			richTextBox1.Text = "";
			this.Hide();
		}
    }
}
