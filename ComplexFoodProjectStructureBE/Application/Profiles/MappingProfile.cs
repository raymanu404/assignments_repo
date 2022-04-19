using Application.DtoModels.Admin;
using Application.DtoModels.Product;
using Application.DtoModels.OrderItem;
using Application.DtoModels.Buyer;
using Application.DtoModels.Coupon;
using Application.DtoModels.Order;
using Application.DtoModels.Cart;
using AutoMapper;
using Domain.Models.Roles;
using Domain.Models.Shopping;
using Domain.Models.Ordering;

namespace Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        //DTOs
        CreateMap<Admin, AdminDto>().ReverseMap();
        CreateMap<Buyer, BuyerDto>().ReverseMap();
        CreateMap<Buyer, BuyerDtoUpdate>().ReverseMap();
        CreateMap<Coupon, CouponDto>().ReverseMap();
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Admin, AdminDto>().ReverseMap();
        CreateMap<OrderItem, OrderItemDto>().ReverseMap();
        CreateMap<ShoppingCart, CartDto>().ReverseMap();
        CreateMap<Order, OrderDto>().ReverseMap();

    }
}