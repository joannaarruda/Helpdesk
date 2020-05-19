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

        protected void Configure()

        {
            var hospitalViewModel = new HospitalViewModel();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Hospital, HospitalViewModel>();
            });

            var usuarioViewModel = new UsuarioViewModel();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Usuario, UsuarioViewModel>();
            });


            var desenvolvedorViewModel = new DesenvolvedorViewModel();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Desenvolvedor, DesenvolvedorViewModel>();
            });


            var pedidoSuporteViewModel = new PedidoSuporteViewModel();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<PedidoSuporte, PedidoSuporteViewModel>();
            });


            var atenderPedidoViewModel = new AtenderPedidoViewModel();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AtenderPedido, AtenderPedidoViewModel>();
            });


        }



    }
}