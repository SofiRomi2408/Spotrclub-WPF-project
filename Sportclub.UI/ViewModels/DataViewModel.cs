using Sportclub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Sportclub.UI.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
            ScheduleSessionCommand = new Command(ScheduleSession);
            CancelSessionCommand = new Command(CancelSession);
            RunSessionCommand = new Command(RunSession);
            CompleteSessionCommand = new Command(CompleteSession);
        }


        public ObservableCollection<Client> Clients { get; set; }
        public ObservableCollection<Coach> Coaches { get; set; }

        private string _visibleControl = "TrainingSessions";

        public string VisibleControl
        {
            get => _visibleControl;
            set
            {
                _visibleControl = value;
                OnPropertyChanged(nameof(VisibleControl));
            }
        }

        public ICommand SetControlVisibility { get; set; }

        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }



        public ICommand ScheduleSessionCommand { get; set; }
        public void ScheduleSession(object args)
        {

            SelectedTrainingSessions.Status = SessionStatus.Scheduled;
        }

        public ICommand CancelSessionCommand { get; set; }
        public void CancelSession(object args)
        {

            SelectedTrainingSessions.Status = SessionStatus.Canceled;
        }


        public ICommand RunSessionCommand { get; set; }
        public void RunSession(object args)
        {

            SelectedTrainingSessions.Status = SessionStatus.Running;
        }

        public ICommand CompleteSessionCommand { get; set; }
        public void CompleteSession(object args)
        {

            SelectedTrainingSessions.Status = SessionStatus.Completed;
        }


        private TrainingSessionViewModel _selectedTrainingSessions;

        public TrainingSessionViewModel SelectedTrainingSessions
        {
            get => _selectedTrainingSessions;
            set
            {
                _selectedTrainingSessions = value;
                OnPropertyChanged(nameof(SelectedTrainingSessions));
            }
        }




        private ObservableCollection<TrainingSessionViewModel> _trainingSessions;
        public ObservableCollection<TrainingSessionViewModel> TrainingSessions
        {
            get => _trainingSessions;
            set
            {
                _trainingSessions = value;
                OnPropertyChanged(nameof(TrainingSessions));
            }
        }

        /*
        public DataViewModel()
        {
            Clients = new ObservableCollection<Client>();
            Coaches = new ObservableCollection<Coach>();
            _trainingSessions = new ObservableCollection<TrainingSessionViewModel>();
        }
        */

    }
}
