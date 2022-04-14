using GoxuTour.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoxuTour.Application.Repositories
{
    public interface IStationRepository
    {
        IEnumerable<Station> GetAll();

        Station GetById(int id);

        void Create(Station station);

        void Update(Station station);

        void Delete(Station station);
    }
}
