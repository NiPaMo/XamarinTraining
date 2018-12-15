using System.Collections.Generic;
using System.Linq;

namespace TrainingRooms
{
    public class RoomRespository
    {
        private List<TrainingRooms> _rooms =
            new List<TrainingRooms>
            {
                new TrainingRooms
                {
                    Id = 1,
                    Name = "Copernicus",
                    Location = "bldg 1",
                    NumberComputers = 25
                },
                new TrainingRooms
                {
                    Id = 2,
                    Name = "Sagitarius",
                    Location = "bldg 1",
                    NumberComputers = 10
                },
                new TrainingRooms
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

        public List<TrainingRooms> GetRooms()
        {
            return _rooms;
        }

        public TrainingRooms GetRoom(int id)
        {
            return(from r in _rooms
                  where r.Id == id
                  select r).FirstOrDefault();
        }
    }
}
