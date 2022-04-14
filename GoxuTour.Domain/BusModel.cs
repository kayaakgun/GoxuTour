using System;
using System.Collections.Generic;
using System.Text;

namespace GoxuTour.Domain
{
	public class BusModel
	{

		public BusModel(int id,string name,int busManufacturerId,Bustype type,int seatCapacity,bool hasToilet) {

			Id = id;
			Name = name;	
			BusManufacturerId = busManufacturerId;
			Type = type;
			SeatCapacity = seatCapacity;
			HasToilet = hasToilet;
		}

		public int Id { get; set; }	

		public string Name { get; set; }

		public int BusManufacturerId { get; }

		public Bustype Type { get;  }

		public int SeatCapacity { get;  }

		public bool HasToilet { get; }

		public BusManufacturer BusManufacturer { get; }
	}
}
