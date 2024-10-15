using Sportclub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sportclub.UI.ViewModels
{
    public class TrainingSessionViewModel : ViewModelBase
    {
        private int _sessionID;
        public int SessionID {
            get { 
            return _sessionID;
            }
            set {
                _sessionID = value;
                OnPropertyChanged(nameof(SessionID));
            } 
        }


        private int _clientID;

        public int ClientID { get { 
                return _clientID;
            } 
            set { 
                _clientID = value;
                OnPropertyChanged(nameof(ClientID));
            } 
        }

        private int _coachID;
        public int CoachID
        {
            get
            {
            return _coachID;        
            }
            set
            {
                _coachID = value;
                OnPropertyChanged(nameof(CoachID));
            }
        }


        private DateTime _sessionDate;
        public DateTime SessionDate
        {
            get
            {
                return _sessionDate;
            }
            set
            {
                _sessionDate = value;
                OnPropertyChanged(nameof(SessionDate));
            }
        }

        private TimeSpan _sessionTime;
        public TimeSpan SessionTime
        {
            get
            {
                return _sessionTime;
            }
            set
            {
                _sessionTime = value;
                OnPropertyChanged(nameof(SessionTime));
            }
        }

        private SessionStatus _status;
        public SessionStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

    }
}
