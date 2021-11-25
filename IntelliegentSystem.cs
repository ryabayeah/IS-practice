using System.Collections.Generic;
using System;

namespace IS_Lab_1
{
    class IntelliegentSystem
    {
		public static List<Office> FindOffice(Office clientOffice, List<Office> offices)
		{
			List<Office> result = new List<Office>();
			foreach (var variant in offices)
			{
				if (CheckGeneralCharacteristics(clientOffice.GeneralCharacteristics, variant.GeneralCharacteristics)
					&& CheckOfficeCharacteristics(clientOffice, variant))
				{
					result.Add(variant);
				}
			}
			return result;
		}
		public static List<House> FindHouse(House clientHouse, List<House> houses)
		{
			List<House> result = new List<House>();
			foreach (var variant in houses)
			{
				if (CheckGeneralCharacteristics(clientHouse.GeneralCharacteristics, variant.GeneralCharacteristics) &&
					CheckHouseCharacteristics(clientHouse, variant))
				{
					result.Add(variant);
				}
			}
			return result;
		}
		public static List<Apartment> FindApartment(Apartment clientApartment, List<Apartment> apartments)
		{
			List<Apartment> result = new List<Apartment>();
			foreach (var variant in apartments)
			{
				if (CheckGeneralCharacteristics(clientApartment.GeneralCharacteristics, variant.GeneralCharacteristics) &&
					CheckApartmentCharacteristics(clientApartment, variant))
				{
					result.Add(variant);
				}
			}
			return result;
		}
		public static List<Stead> FindStead(Stead clientStead, List<Stead> steads)
		{
			List<Stead> result = new List<Stead>();
			foreach (var variant in steads)
			{
				if (CheckGeneralCharacteristics(clientStead.GeneralCharacteristics, variant.GeneralCharacteristics) && CheckSteadCharacteristics(clientStead, variant))
				{
					result.Add(variant);
				}
			}
			return result;
		}
		private static bool CheckGeneralCharacteristics(RealEstate clientModel, RealEstate listModel)
		{
			if (clientModel.Location == listModel.Location)
			{
				if (clientModel.Price >= listModel.Price && clientModel.Square <= listModel.Square)
				{
					return true;
				}
			}
			return false;
		}
		private static bool CheckOfficeCharacteristics(Office clientModel, Office listModel)
		{
			if (clientModel.CountOfRooms <= listModel.CountOfRooms && clientModel.CountOfWorkers <= listModel.CountOfWorkers && clientModel.Parking == listModel.Parking && clientModel.Specifications == listModel.Specifications)
			{
				if (clientModel.Floor == 1 && clientModel.Floor == listModel.Floor && CheckOfficeRooms(clientModel, listModel))
				{
					return true;
				}
				if (clientModel.Floor == 2 && listModel.Floor >= 2 && CheckOfficeRooms(clientModel, listModel))
				{
					return true;
				}
				if (clientModel.Floor == 3 && listModel.Floor >= 3 && CheckOfficeRooms(clientModel, listModel))
				{
					return true;
				}
			}
			return false;
		}
		private static bool CheckOfficeRooms(Office clientModel, Office listModel)
		{
			if (clientModel.CountOfRooms <= listModel.CountOfRooms)
			{
				return true;
			}
			else return false;
		}

		private static bool CheckHouseCharacteristics(House clientModel, House listModel)
		{
			if (clientModel.TransportAccessibility == listModel.TransportAccessibility
				&& clientModel.Comfort == listModel.Comfort
				&& clientModel.Comunication == listModel.Comunication
				&& clientModel.TypeOfHouse == listModel.TypeOfHouse &&
				(clientModel.Floors == listModel.Floors || clientModel.Floors == 4 && listModel.Floors >= 4))
			{
				return true;
			}
			return false;
		}
		private static bool CheckApartmentCharacteristics(Apartment clientModel, Apartment listModel)
		{

			if (clientModel.TransportAccessibility == listModel.TransportAccessibility
				&& clientModel.Comfort == listModel.Comfort &&
				clientModel.Infrastructure == listModel.Infrastructure
				&& clientModel.TypeOfBuilding == listModel.TypeOfBuilding &&
				clientModel.Parking == listModel.Parking &&
				clientModel.View == listModel.View &&
				clientModel.Years >= listModel.Years &&
				clientModel.NewOrOld == listModel.NewOrOld &&
				(((clientModel.Floor == 1) && (listModel.Floor == 1)) || 
				((clientModel.Floor == 2) && ((listModel.Floor >= 2) && (listModel.Floor < listModel.MaxFloor))) || 
				((clientModel.Floor == 3) && (listModel.Floor == listModel.MaxFloor))))
			{
				Console.WriteLine(clientModel.Floor + " " + listModel.Floor + " " + listModel.MaxFloor);
				return true;
			}
			return false;
		}
		private static bool CheckSteadCharacteristics(Stead clientModel, Stead listModel)
		{
			if (clientModel.TransportAccessibility == listModel.TransportAccessibility
				&& clientModel.Ecology == listModel.Ecology &&
				CheckNearTeritotySteadDistance(clientModel, listModel))
			{
				return true;
			}
			return false;
		}
		private static bool CheckNearTeritotySteadDistance(Stead clientModel, Stead listModel)
		{
			if (clientModel.AdjacentTerritory <= 2 && listModel.AdjacentTerritory <= 2)
			{
				return true;
			}
			else if (clientModel.AdjacentTerritory >= 3 && clientModel.AdjacentTerritory <= 5 && listModel.AdjacentTerritory >= 3 && listModel.AdjacentTerritory <= 5)
			{
				return true;
			}
			else if (clientModel.AdjacentTerritory > 5 && listModel.AdjacentTerritory >= 5)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
