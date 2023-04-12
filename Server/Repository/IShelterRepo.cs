using Shelter.Shared;
using System;

namespace Server.Repository
{
   
        public interface IShelterRepo
    {
        
            ShelterItem[] getAll();
            void Add(ShelterItem item);
            void Update(ShelterItem item);
            public void Remove(int id);


    }


}
