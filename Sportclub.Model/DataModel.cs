using Sportclub.Model.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sportclub.Model
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Client> Clients { get; set; }

        [DataMember]
        public IEnumerable<Coach> Coaches { get; set; }

        [DataMember]
        public IEnumerable<TrainingSession> TrainingSessions { get; set; }

        public DataModel() { 
        Clients = new List<Client>() {
        new Client
        {
        ClientID = 1,
        FirstName = "John",
        LastName = "Doe",
        DateOfBirth = new DateTime(1990, 5, 24),
        PhoneNumber = "123-456-7890",
        Email = "john.doe@example.com"
        }
        };

        Coaches = new List<Coach>()
        {
         new Coach
        {
        CoachID = 1,
        FirstName = "John",
        LastName = "Smith",
        Specialization = "Fitness",
        DateOfBirth = new DateTime(1985, 6, 15),
        PhoneNumber = "123-456-7890"
        },

        new Coach
        {
        CoachID = 2,
        FirstName = "Emily",
        LastName = "Johnson",
        Specialization = "Yoga",
        DateOfBirth = new DateTime(1990, 9, 12),
        PhoneNumber = "987-654-3210"
        }
};
        

        TrainingSessions = new List<TrainingSession>()
        {
        new TrainingSession
        {
        SessionID = 1,
        ClientID = 1,
        CoachID = 1,
        SessionDate = new DateTime(2024, 10, 20),
        SessionTime = new TimeSpan(10, 0, 0),
        Status = SessionStatus.Scheduled
        },

        new TrainingSession
        {
        SessionID = 2,
        ClientID = 1,
        CoachID = 2,
        SessionDate = new DateTime(2024, 10, 21),
        SessionTime = new TimeSpan(14, 0, 0),
        Status = SessionStatus.Running
        }
        };
        }

        public static string DataPath = "sportclub.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);

            }
            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }
    }
}
