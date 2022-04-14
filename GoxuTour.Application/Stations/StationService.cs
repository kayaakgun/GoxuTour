using GoxuTour.Application.Repositories;
using GoxuTour.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoxuTour.Application.Stations
{
    public class StationService : IStationService
    {
        private readonly IStationRepository _stationRepository;

        public StationService(IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
        }

        public void Create(StationDTO stationDTO)
        {
            var station = new Station()
            {
                Id = stationDTO.Id,
                Name = stationDTO.Name,
                CityId = stationDTO.CityId
            };
            _stationRepository.Create(station);
        }

        public void Delete(StationDTO stationDTO)
        {
            var station = _stationRepository.GetById(stationDTO.Id);
            _stationRepository.Delete(station);
        }

        public IEnumerable<StationDTO> GetAll()
        {
            var stations = _stationRepository.GetAll();
            var stationsDTOs = new List<StationDTO>();
            foreach (var station in stations)
            {

                stationsDTOs.Add(new StationDTO()
                {
                    Id = station.Id,
                    Name = station.Name,
                    CityId = station.CityId
                });
              
            }
            return stationsDTOs;
        }


        public StationDTO GetById(int id)
        {
            var stations = _stationRepository.GetById(id);
            var stationDTO = new StationDTO()
            {
                Id = stations.Id,
                Name = stations.Name,
                CityId = stations.CityId
            };
            return stationDTO;
        }

        public void Update(StationDTO stationDTO)
        {
            var station = _stationRepository.GetById(stationDTO.Id);
            
            station.Name = stationDTO.Name;
            station.CityId = stationDTO.CityId;
            _stationRepository.Update(station);
            
        }
    }
}
