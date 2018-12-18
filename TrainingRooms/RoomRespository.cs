using System.Collections.Generic;
using System.Linq;

namespace TrainingRooms
{
    public class RoomRespository
    {
        private readonly List<TrainingRoom> _rooms =
            new List<TrainingRoom>
            {
                new TrainingRoom
                {
                    Id = 1,
                    Name = "Copernicus",
                    Location = "bldg 1",
                    NumberComputers = 25
                },
                new TrainingRoom
                {
                    Id = 2,
                    Name = "Sagitarius",
                    Location = "bldg 1",
                    NumberComputers = 10
                },
                new TrainingRoom
                {
                    Id = 3,
                    Name = "Luna",
                    Location = "bldg 3",
                    NumberComputers = 50
                },

            };
        public RoomRespository()
        {
        }

        public List<TrainingRoom> GetRooms()
        {
            return _rooms;
        }

        public TrainingRoom GetRoom(int id)
        {
            return(from r in _rooms
                  where r.Id == id
                  select r).FirstOrDefault();
        }
    }
}
