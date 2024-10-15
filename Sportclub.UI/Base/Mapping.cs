using AutoMapper;
using Sportclub.Model;
using Sportclub.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportclub.UI.Base
{
    public class Mapping
    {
        private readonly IMapper _mapper;

        public Mapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataModel, DataViewModel>();
                cfg.CreateMap<DataViewModel, DataModel>();

                cfg.CreateMap<TrainingSession, TrainingSessionViewModel>();
                cfg.CreateMap<TrainingSessionViewModel, TrainingSession>();
            });

            _mapper = config.CreateMapper();
        }

        public DataViewModel MapToViewModel(DataModel dataModel)
        {
            return _mapper.Map<DataViewModel>(dataModel);
        }

        public DataModel MapToModel(DataViewModel dataViewModel)
        {
            return _mapper.Map<DataModel>(dataViewModel); 
        }

        public TrainingSessionViewModel MapToViewModel(TrainingSession trainingSession)
        {
            return _mapper.Map<TrainingSessionViewModel>(trainingSession);
        }

        public TrainingSession MapToModel(TrainingSessionViewModel trainingSessionViewModel)
        {
            return _mapper.Map<TrainingSession>(trainingSessionViewModel); 
        }
    }
}
