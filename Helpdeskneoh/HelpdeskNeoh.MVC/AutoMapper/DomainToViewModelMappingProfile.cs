using AutoMapper;
using HelpdeskNeoh.Domain.Entities;
using HelpdeskNeoh.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpdeskNeoh.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile 
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected void Configure()

        {

            var hospitalViewModel = new HospitalViewModel();

            Mapper.Initialize(cfg => {
                cfg.CreateMap<Hospital, HospitalViewModel>();
            });

            


        }



}
}