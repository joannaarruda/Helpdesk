using AutoMapper;
using HelpdeskNeoh.Domain.Entities;
using HelpdeskNeoh.MVC.ViewModels;

namespace HelpdeskNeoh.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName

        {

            get { return "DomainToViewModelMappings"; }

        }

        protected override void Configure()

        {

            Mapper.CreateMap<HospitalViewModel, Hospital >();
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
            Mapper.CreateMap<DesenvolvedorViewModel,Desenvolvedor>();
            Mapper.CreateMap<PedidoSuporteViewModel,PedidoSuporte>();
            Mapper.CreateMap<AtenderPedidoViewModel, AtenderPedido>();

        }



    }
}