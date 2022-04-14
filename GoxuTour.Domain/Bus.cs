using System;
using System.Collections.Generic;
using System.Text;

namespace GoxuTour.Domain
{
    public class Bus
    {


        public Bus(int id, int busModelId, string registrationPlate, short year, SeatingType seatMapping, int distanceTraveled)
        {

            Id = id;
            BusModelId = busModelId;
            RegistrationPlate = registrationPlate;
            Year = year;
            SeatMapping = seatMapping;
            DistanceTraveled = distanceTraveled;

        }


        public int Id { get; set; }

        public int BusModelId { get; }

        public string RegistrationPlate { get; }

        public short Year { get; }

        public SeatingType SeatMapping { get; set; }

        public int SeatCount
        {
            get
            {
                if (SeatMapping == SeatingType.Standard)
                {
                    return BusModel.SeatCapacity;
                }
                else if (SeatMapping == SeatingType.Deluxe)
                {
                    int koltukSırası = (BusModel.SeatCapacity / 4) + 1;
                    int koltukSayısı = 2 * 2;
                    koltukSayısı += (koltukSayısı - 2) * 3;
                    return koltukSayısı;
                }
                else
                {
                    int koltukSırası = (BusModel.SeatCapacity / 4) + 1;
                    int koltukSayısı = 2 * 2;
                    koltukSayısı += (koltukSayısı - 2) * 2;
                    return koltukSayısı;
                }
            }
        }

        public int DistanceTraveled { get; set; }

        public BusModel BusModel { get; set; }
    }
}
