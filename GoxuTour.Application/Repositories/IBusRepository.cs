using GoxuTour.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoxuTour.Application.Repositories
{
    public interface IBusRepository
    {
        IEnumerable<Bus> GetAll();

        Bus GetById(int id);

        void Create(Bus bus);

        void Update(Bus bus);

        void Delete(Bus bus);
    }
}
