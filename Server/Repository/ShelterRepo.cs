using Client;
using Client.Models;
using Shelter.Shared;
using System;
using static Server.Repository.ShelterRepo;

namespace Server.Repository
{





    public class ShelterRepo
    {
        public class ShelterRepository : IShelterRepo
        {
            private List<ShelterItem> mItems;

            public ShelterRepository()
            {
            }

            public ShelterItem[] getAll()
            {
                return mItems.ToArray();
            }

            public void Add(ShelterItem item)
            {
                mItems.Add(item);
            }
            public void Remove(int id)
            {
                Console.WriteLine($"Delete {id}");

                // Find the index of the item with the given id and remove it from the list
                int index = mItems.FindIndex(p => p.Id == id);
                if (index != -1)
                {
                    mItems.RemoveAt(index);
                }
            }


            public void Update(ShelterItem item)
            {
                Console.WriteLine($"Put {item.Id}");

                foreach (var p in mItems)
                {
                    if (p.Id == item.Id)
                    {
                        p.booked = !p.booked;
                        break;
                    }
                }
            }
        }
    }
    }
