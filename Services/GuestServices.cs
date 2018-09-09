using invitados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invitados.Services
{
    public class GuestServices : IGuestServices //IMPLEMENTS THE IGUESTSERVICES INTERFACE
    {
        //DECIDED TO USE A DICTIONARY TO SIMPLIFY THE CASE OF USE AS THE PORPOUSE OF THESE EXAMPLE IS TO HAVE A FIRST INSIGHT. BUT A DATABASE COULD BE USED AND DOCKERIZED.
        private readonly Dictionary<string, GuestsInvited> _guestsInvited;

        //CONSTRUCTOR OF THE DICTIONARY
        public GuestServices()
        {
            _guestsInvited = new Dictionary<string, GuestsInvited>();
        }

        public GuestsInvited AddGuestInvited(GuestsInvited guest)
        {
            //ADDS THE GUEST PASSED GUEST TO THE DICTIONARY USING THE GUEST NAME AS THE KEY
            _guestsInvited.Add(guest.GuestName, guest);
            //RETURNS THE SAME GUEST FOR TESTING WITH POSTMAN WHEN PUBLISHED
            return guest;
        }

        public Dictionary<string, GuestsInvited> GetGuestInvited()
        {
            return _guestsInvited;
        }
    }
}