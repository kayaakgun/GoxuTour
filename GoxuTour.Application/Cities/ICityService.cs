using System;
using System.Collections.Generic;
using System.Text;

namespace GoxuTour.Application.Cities
{
    public interface ICityService
    {
        IEnumerable<CityDTO> GetAll();

        CityDTO GetById(int id);

        void Create(CityDTO cityDTO);

        void Update(CityDTO cityDTO);

        void Delete(CityDTO cityDTO);
    }
}
