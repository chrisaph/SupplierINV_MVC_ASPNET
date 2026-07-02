using AutoMapper;
using Suppliers.DataModel;
using SuppliersINV.App.Controllers;
using SuppliersINV.App.Models;

namespace SuppliersINV.App.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Product, ProductVM>().ReverseMap();
        }
    }
}
