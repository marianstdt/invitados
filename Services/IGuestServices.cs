using invitados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invitados.Services
{
    public interface IGuestServices
    {
        GuestsInvited AddGuestInvited(GuestsInvited guest);
        Dictionary<string, GuestsInvited> GetGuestInvited();
    }
}
