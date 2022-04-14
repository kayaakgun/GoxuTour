using GoxuTour.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoxuTour.Application.Repositories
{
    public interface ICityRepository
    {
        IEnumerable<City> GetAll();

        City GetById(int id);
        void Create(City city);
        void Update(City city);
        void Delete(City city);

    }
}
