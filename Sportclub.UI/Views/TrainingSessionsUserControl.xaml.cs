using Sportclub.Model;
using Sportclub.UI.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Sportclub.UI.Views
{
    public partial class TrainingSessionsUserControl : UserControl
    {
        public TrainingSessionsUserControl()
        {
            InitializeComponent();
        }

        private void CompleteTrainingButton_Click(object sender, RoutedEventArgs e)
        {
            var trainingSessionViewModel = (TrainingSessionViewModel)dataGridTrainingSessions.SelectedItem;

            if (trainingSessionViewModel != null)
            {
                trainingSessionViewModel.Status = SessionStatus.Completed;
            }
            else
            {
                MessageBox.Show("Select training session to complete");
            }
        }

        private void RunningTrainingButton_Click(object sender, RoutedEventArgs e)
        {
            var trainingSessionViewModel = (TrainingSessionViewModel)dataGridTrainingSessions.SelectedItem;

            if (trainingSessionViewModel != null)
            {
                trainingSessionViewModel.Status = SessionStatus.Running;
            }
            else
            {
                MessageBox.Show("Select training session to complete");
            }
        }

        private void ScheduleTrainingButton_Click(object sender, RoutedEventArgs e)
        {
            var trainingSessionViewModel = (TrainingSessionViewModel)dataGridTrainingSessions.SelectedItem;

            if (trainingSessionViewModel != null)
            {
                trainingSessionViewModel.Status = SessionStatus.Scheduled;
            }
            else
            {
                MessageBox.Show("Select training session to complete");
            }
        }

        private void CancelTrainingButton_Click(object sender, RoutedEventArgs e)
        {
            var trainingSessionViewModel = (TrainingSessionViewModel)dataGridTrainingSessions.SelectedItem;

            if (trainingSessionViewModel != null)
            {
                trainingSessionViewModel.Status = SessionStatus.Canceled;
            }
            else
            {
                MessageBox.Show("Select training session to complete");
            }
        }

        private void dataGridTrainingSessions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Додаткові дії при зміні вибору
            var selectedSession = (TrainingSessionViewModel)dataGridTrainingSessions.SelectedItem;
            if (selectedSession != null)
            {
                // Використовуйте selectedSession для подальших дій.
            }
        }
    }
}
