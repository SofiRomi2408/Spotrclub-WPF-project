using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sportclub.Model
{
    [DataContract]
    public class TrainingSession
    {

        [DataMember]
        public int SessionID { get; set; }

        [DataMember]
        public int ClientID { get; set; }

        [DataMember]
        public int CoachID { get; set; }

        [DataMember]
        public DateTime SessionDate { get; set; }

        [DataMember]
        public TimeSpan SessionTime { get; set; }

        [DataMember]
        public SessionStatus Status { get; set; }

        

    }

    [DataContract] 
    public enum SessionStatus
    {
        [EnumMember]
        Scheduled,

        [EnumMember]
        Running,

        [EnumMember]
        Completed,

        [EnumMember]
        Canceled
    }


}
