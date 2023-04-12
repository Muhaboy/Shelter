using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shelter.Shared;
using Client;
using Server.Repository;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/Shelter")]
    public class ShelterController : ControllerBase
    {

        private static List<ShelterItem> mProducts = new List<ShelterItem>() {
                  new ShelterItem { navn = "Shelterplads i Stavtrup", Id = 1, cvr_navn = "Aarhus Kommune", facil_ty = "Shelter", booked = true  }
                  

        };
        
        private IShelterRepo mShelters;

        public ShelterController(IShelterRepo repo)
        {
            mShelters = repo;
        }

         [HttpGet]
         public IEnumerable<ShelterItem> Get()
         {
             Console.WriteLine("get ");
             return mShelters.getAll();
         }

         [HttpPost]
         public void AddItem(ShelterItem product)
         {
             Console.WriteLine("post " + product.navn);
             mProducts.Add(product);
         }

         [HttpDelete("{id}")]
        public void Remove(int id)
        {
            Console.WriteLine($"delete {id}");
            
            mShelters.Remove(id);
        }

        [HttpPut]
         public void Update(ShelterItem item)
         {
             Console.WriteLine($"Put {item.Id}");
             Update(item);

         }
        
    }

}