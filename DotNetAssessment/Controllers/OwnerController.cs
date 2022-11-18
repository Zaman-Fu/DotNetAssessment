using DotNetAssessment.Models;
using DotNetAssessment.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAssessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OwnerController : ControllerBase
    {

        private readonly IOwnerService ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            this.ownerService = ownerService;
        }

        [HttpPost(Name = "addOwner")]
        public Owner AddOwner(Owner owner) 
        { 
            return ownerService.AddOwner(owner); 
        }

        [HttpGet(Name = "getOwners")]
        public IEnumerable<Owner> GetOwners() 
        { return ownerService.GetOwners(); 
        }

        [HttpPut(Name = "updateOwner")]
        public Owner UpdateOwner(Owner owner) 
        { 
            return ownerService.UpdateOwner(owner); 
        }

        [HttpDelete(Name = "deleteOwner")]
        public void DeleteUser(int id)
        {
            ownerService.DeleteOwner(id);
        }

    }
}
