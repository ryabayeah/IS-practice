using System.Collections.Generic;
namespace IS_Lab_1
{
	[System.Serializable]
	public class Offer
	{
		public List<Office> officeList { get; set; }
		public List<House> houseList { get; set; }
		public List<Apartment> apartmentList { get; set; }
		public List<Stead> steadList { get; set; }
		public string name { get; set; }
	}

	[System.Serializable]
	public class Stead
	{
		public RealEstate GeneralCharacteristics { get; set; }
		public int AdjacentTerritory { get; set; }
		public string Ecology { get; set; }
		public string TransportAccessibility { get; set; }
	}

	[System.Serializable]
	public class Apartment
	{
		public RealEstate GeneralCharacteristics { get; set; }
		public string Infrastructure { get; set; }
		public int Floor { get; set; }
		public int MaxFloor { get; set; }
		public string TransportAccessibility { get; set; }
		public int CountOfRooms { get; set; }
		public int Years { get; set; }
		public string TypeOfBuilding { get; set; }
		public string NewOrOld { get; set; }
		public string Comfort { get; set; }
		public string Parking { get; set; }
		public string View { get; set; }
	}

	[System.Serializable]
	public class Office
	{
		public RealEstate GeneralCharacteristics { get; set; }
		public string Specifications { get; set; }
		public string Parking { get; set; }
		public int Years { get; set; }
		public int Floor { get; set; }
		public int CountOfWorkers { get; set; }
		public int CountOfRooms { get; set; }
	}
	[System.Serializable]
	public class House
	{
		public RealEstate GeneralCharacteristics { get; set; }
		public int Floors { get; set; }
		public string TransportAccessibility { get; set; }
		public string TypeOfHouse { get; set; }
		public string Comunication { get; set; }
		public string Comfort { get; set; }
		//нет размера населенного пункта
	}

	[System.Serializable]
	public class RealEstate
	{

		public int Price { get; set; }
		public string Adress { get; set; }
		public string Location { get; set; }
		public int Square { get; set; }
	}
	public enum HouseMaterials
	{
		BlockHouse,
		WoodenHouse,
		BrickHouse
	}

	public enum Comunication
	{
		good,
		normal,
		bad
	}
}
