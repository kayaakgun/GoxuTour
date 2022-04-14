using System;
using System.Collections.Generic;
using System.Text;

namespace GoxuTour.Application.Stations
{
    public interface IStationService
    {
        public IEnumerable<StationDTO> GetAll();

        StationDTO GetById(int id);

        void Create(StationDTO stationDTO);

        void Update(StationDTO stationDTO);

        void Delete(StationDTO stationDTO);
    }
}
