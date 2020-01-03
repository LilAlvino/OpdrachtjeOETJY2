using Betabit.Spaces.App.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Betabit.Spaces.App.Clients
{
    public interface ISpacesClient
    {
        Task<Space> GetSpace(string code);
        Task<IReadOnlyCollection<Reservation>> GetSpaceReservations(string code);
        Task<IReadOnlyCollection<Space>> GetSpaces();
    }
}