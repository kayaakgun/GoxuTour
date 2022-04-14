using GoxuTour.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoxuTour.Application.Repositories
{
    public interface IBusModelRepository
    {
        IEnumerable<BusModel> GetAll();

        BusModel GetById(int id);

        void Create(BusModel busModel);

        void Update(BusModel busModel);

        void Delete(BusModel busModel);
    }
}
