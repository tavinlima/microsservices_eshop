using AutoMapper;
using GeekShooping.ProductAPI.Data.DTO;
using GeekShooping.ProductAPI.Model;

namespace GeekShooping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, Product>();
                config.CreateMap<Product, ProductDTO>();
            });

            return mappingConfig;
        }
    }
}
