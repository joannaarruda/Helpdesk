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

            Mapper.CreateMap<Hospital, HospitalViewModel>();
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
            Mapper.CreateMap<Desenvolvedor, DesenvolvedorViewModel>();
            Mapper.CreateMap<PedidoSuporte, PedidoSuporteViewModel>();
            Mapper.CreateMap<AtenderPedido, AtenderPedidoViewModel>();

        }



    }
}