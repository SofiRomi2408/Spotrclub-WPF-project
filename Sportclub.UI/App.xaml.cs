using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AutoMapper;
using Sportclub.Model;
using Sportclub.UI.Base;
using Sportclub.UI.ViewModels;

namespace Sportclub.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel _model;
        private DataViewModel _viewModel;
        private readonly Mapping _mapping; 

        public App()
        {
            _mapping = new Mapping(); 
            _model = DataModel.Load();
            _viewModel = _mapping.MapToViewModel(_model); 
            var window = new MainWindow() { DataContext = _viewModel };
            try
            {
                window.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                _model = _mapping.MapToModel(_viewModel); 
                _model.Save();
            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }

    }
}
