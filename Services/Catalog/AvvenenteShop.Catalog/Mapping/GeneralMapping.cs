
using AutoMapper;
using AvvenenteShop.Catalog.Dtos.CategoryDtos;
using AvvenenteShop.Catalog.Dtos.ProductDetailDtos;
using AvvenenteShop.Catalog.Dtos.ProductImageDtos;
using AvvenenteShop.Catalog.Entities;

namespace AvvenenteShop.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<Product, ResultCategoryDto>().ReverseMap();
            CreateMap<Product, CreateCategoryDto>().ReverseMap();
            CreateMap<Product, UpdateCategoryDto>().ReverseMap();
            CreateMap<Product, GetByIdCategoryDto>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();

            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();





        }
    }
}
