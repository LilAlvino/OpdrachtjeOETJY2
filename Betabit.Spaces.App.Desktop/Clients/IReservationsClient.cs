using Betabit.Spaces.App.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Betabit.Spaces.App.Clients
{
    public interface IReservationsClient
    {
        Task<IReadOnlyCollection<Reservation>> GetReservations();
        Task PostReservation(Reservation reservation);
    }
}