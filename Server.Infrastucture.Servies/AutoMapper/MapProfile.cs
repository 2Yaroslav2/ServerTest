using AutoMapper;
using Server.Domain.Application.Dto.CategoryDTO;
using Server.Domain.Application.Dto.CloseOrderDTO;
using Server.Domain.Application.Dto.GoodsDescriptionDTO;
using Server.Domain.Application.Dto.GoodsDTO;
using Server.Domain.Application.Dto.LanguageDTO;
using Server.Domain.Application.Dto.OrderDTO;
using Server.Domain.Application.Dto.OrderStatusDTO;
using Server.Domain.Application.Dto.UserDTO;
using Server.Domain.Core.Entities;

namespace Server.Infrastucture.Servies.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region Goods
            CreateMap<Goods, GoodsCreateDTO>().ReverseMap();
            CreateMap<Goods, GoodsUpdateDTO>().ReverseMap();
            CreateMap<Goods, GoodsViewDTO>().ReverseMap();
            #endregion

            #region Order
            CreateMap<Order, OrderCreateDTO>().ReverseMap();
            CreateMap<Order, OrderUpdateDTO>().ReverseMap();
            CreateMap<Order, OrderViewDTO>().ReverseMap();
            #endregion

            #region Closer Order
            CreateMap<CloseOrder, CloseOrderCreateDTO>().ReverseMap();
            CreateMap<CloseOrder, CloseOrderUpdateDTO>().ReverseMap();
            CreateMap<CloseOrder, CloseOrderViewDTO>().ReverseMap();
            #endregion

            #region User
            CreateMap<User, UserCreateDTO>().ReverseMap();
            CreateMap<User, UserViewDTO>().ReverseMap();
            #endregion

            #region Category
            CreateMap<Category, CategoryCreateDTO>().ReverseMap();
            CreateMap<Category, CategoryUpdateDTO>().ReverseMap();
            CreateMap<Category, CategoryViewDTO>().ReverseMap();
            #endregion

            #region Order Status
            CreateMap<OrderStatus, OrderStatusCreateDTO>().ReverseMap();
            CreateMap<OrderStatus, OrderStatusUpdateDTO>().ReverseMap();
            CreateMap<OrderStatus, OrderStatusViewDTO>().ReverseMap();
            #endregion

            #region Language
            CreateMap<Language, LanguageCreateDTO>().ReverseMap();
            CreateMap<Language, LanguageUpdateDTO>().ReverseMap();
            CreateMap<Language, LanguageViewDTO>().ReverseMap();
            #endregion

            #region Goods Description
            CreateMap<GoodsDescription, GoodsDescriptionCreateDTO>().ReverseMap();
            CreateMap<GoodsDescription, GoodsDescriptionUpdateDTO>().ReverseMap();
            CreateMap<GoodsDescription, GoodsDescriptionViewDTO>().ReverseMap();
            #endregion
        }
    }
}
