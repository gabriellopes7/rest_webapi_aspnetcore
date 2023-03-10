using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Business.Models;

namespace DevIO.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<ProdutoViewModel, Produto>();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<ProdutoImagemViewModel, Produto>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(destinationMember => destinationMember.NomeFornecedor, options => options.MapFrom(src => src.Fornecedor.Nome));
        }
    }
}
