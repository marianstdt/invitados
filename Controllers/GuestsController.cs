using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using invitados.Models;
using invitados.Services;
using Microsoft.AspNetCore.Mvc;

namespace invitados.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class GuestsController : ControllerBase
    {

        private readonly IGuestServices _services;

        public GuestsController(IGuestServices services)
        {
            _services = services;
        }
        //HTTP POST
        [HttpPost]
        [Route("AddGuestInvited")]
        public ActionResult<GuestsInvited> AddGuestInvited(GuestsInvited guest)
        {
            GuestsInvited newGuest = _services.AddGuestInvited(guest);

            if (newGuest == null)
            {
                return NotFound();
            }
            return newGuest;
        }

        //HTTP GET
        [HttpGet]
        [Route("GetGuestsInvited")]
        public ActionResult<Dictionary<string, GuestsInvited>> GetGuestsInvited()
        {
            Dictionary<string, GuestsInvited> guestsInvited = _services.GetGuestInvited();

            if (guestsInvited.Count == 0)
            {
                return NotFound();
            }
            //RETURNS THE DICTIONARY
            return guestsInvited;
        }
    }
}