using GoxuTour.Application.Repositories;
using GoxuTour.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoxuTour.Application.Cities
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public void Create(CityDTO cityDTO)
        {
            var city = new City()
            {
                Id = cityDTO.Id,
                Name = cityDTO.Name
            };
            _cityRepository.Create(city);
        }

        public void Delete(CityDTO cityDTO)
        {
            if(cityDTO != null)
            {
                var city = new City()
                {
                    Id = cityDTO.Id,
                    Name = cityDTO.Name
                };

                _cityRepository.Delete(city);
            }
        }

        public IEnumerable<CityDTO> GetAll()
        {
           var cityEnties = _cityRepository.GetAll();
           var cityDTOs = new List<CityDTO>();
            foreach (var entity in cityEnties)
            {
                cityDTOs.Add(new CityDTO()
                {
                    Id = entity.Id,
                    Name = entity.Name
                });
            }
            return cityDTOs;
        }

        public CityDTO GetById(int id)
        {
            var city = _cityRepository.GetById(id);
            if(city != null)
            {
                var cityDTO = new CityDTO()
                {
                    Id = city.Id,
                    Name = city.Name
                };
                return cityDTO;
            }
            else
            {
                return null;
            }
        }

        public void Update(CityDTO cityDTO)
        {
            var cityDTOs= _cityRepository.GetById(cityDTO.Id);
            var city = new City()
            {
                Id=cityDTOs.Id,
                Name=cityDTOs.Name
            };

            _cityRepository.Update(city);

        }
    }
}
