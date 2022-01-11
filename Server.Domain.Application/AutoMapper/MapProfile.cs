using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Server.Domain.Application.CQRS.Commands.CategoryCommands.CreateCategory;
using Server.Domain.Application.CQRS.Commands.CategoryCommands.UpdateCategory;
using Server.Domain.Application.CQRS.Commands.CloseOrderCommands.CreateCloseOrder;
using Server.Domain.Application.CQRS.Commands.CloseOrderCommands.UpdateCloseOrder;
using Server.Domain.Application.CQRS.Commands.GoodsCommands.CreateGoods;
using Server.Domain.Application.CQRS.Commands.GoodsCommands.UpdateGoods;
using Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.CreateGoodsDescription;
using Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.UpdateGoodsDescription;
using Server.Domain.Application.CQRS.Commands.LanguageCommands.CreateLanguage;
using Server.Domain.Application.CQRS.Commands.LanguageCommands.UpdateLanguage;
using Server.Domain.Application.CQRS.Commands.OrderCommands.CreateOrder;
using Server.Domain.Application.CQRS.Commands.OrderCommands.UpdateOrder;
using Server.Domain.Application.CQRS.Commands.OrderStatusCommands.CreateOrderStatus;
using Server.Domain.Application.CQRS.Commands.OrderStatusCommands.UpdateOrderStatus;
using Server.Domain.Application.CQRS.Commands.UserCommands.CreateUser;
using Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdateContacts;
using Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdateLogin;
using Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePassword;
using Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePersonalData;
using Server.Domain.Application.CQRS.Queries.CategoryQueries.GetAllCategoryQueries;
using Server.Domain.Application.CQRS.Queries.CategoryQueries.GetByIdCategoryQueries;
using Server.Domain.Application.CQRS.Queries.CategoryQueries.GetWhereCategoryQueries;
using Server.Domain.Application.CQRS.Queries.CloseOrderQueries.GetAllCloseOrder;
using Server.Domain.Application.CQRS.Queries.CloseOrderQueries.GetByIdCloseOrder;
using Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetAllGoodsDescription;
using Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetByIdGoodsDescription;
using Server.Domain.Application.CQRS.Queries.GoodsDescriptionQueries.GetWhereGoodsDescription;
using Server.Domain.Application.CQRS.Queries.GoodsQueries.GetAllGoods;
using Server.Domain.Application.CQRS.Queries.GoodsQueries.GetByIdGoods;
using Server.Domain.Application.CQRS.Queries.GoodsQueries.GetWhereGoods;
using Server.Domain.Application.CQRS.Queries.LanguageQueries.GetAllLanguage;
using Server.Domain.Application.CQRS.Queries.LanguageQueries.GetByIdLanguage;
using Server.Domain.Application.CQRS.Queries.OrderQueries.GetAllOrder;
using Server.Domain.Application.CQRS.Queries.OrderQueries.GetByIdOrder;
using Server.Domain.Application.CQRS.Queries.OrderStatusQueries.GetAllOrderStatusQueries;
using Server.Domain.Application.CQRS.Queries.OrderStatusQueries.GetByIdOrderStatusQueries;
using Server.Domain.Application.CQRS.Queries.UserQueries.SignIn;
using Server.Domain.Application.Dto.CategoryDTO;
using Server.Domain.Application.Dto.CloseOrderDTO;
using Server.Domain.Application.Dto.GoodsDescriptionDTO;
using Server.Domain.Application.Dto.GoodsDTO;
using Server.Domain.Application.Dto.LanguageDTO;
using Server.Domain.Application.Dto.OrderDTO;
using Server.Domain.Application.Dto.OrderStatusDTO;
using Server.Domain.Application.Dto.UserDTO;
using Server.Domain.Core.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Server.Domain.Application.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region Goods Commands
            CreateMap<GoodsCreateDTO, CreateGoodsCommandRequest>().ReverseMap();
            CreateMap<GoodsUpdateDTO, UpdateGoodsCommandRequest>().ReverseMap();
            CreateMap<CreateGoodsCommandResponse, GoodsViewDTO>().ReverseMap();
            CreateMap<UpdateGoodsCommandResponse, GoodsViewDTO>().ReverseMap();
            #endregion

            #region Goods Queries
            CreateMap<GetAllGoodsQueryResponse, GoodsViewDTO>().ReverseMap();
            CreateMap<GetByIdGoodsQueryResponse, GoodsViewDTO>().ReverseMap();
            CreateMap<GetWhereGoodsQueryResponse, GoodsViewDTO>().ReverseMap();
            #endregion

            #region Order Commands
            CreateMap<OrderCreateDTO, CreateOrderCommandRequest>().ReverseMap();
            CreateMap<CreateOrderCommandResponse, OrderViewDTO>().ReverseMap();
            CreateMap<OrderUpdateDTO, UpdateOrderCommandRequest>().ReverseMap();
            CreateMap<UpdateOrderCommandResponse, OrderViewDTO>().ReverseMap();
            #endregion

            #region Order Queries
            CreateMap<GetAllOrderQueryResponse, OrderViewDTO>().ReverseMap();
            CreateMap<GetByIdOrderQueryResponse, OrderViewDTO>().ReverseMap();
            #endregion

            #region Close Order Commands
            CreateMap<CloseOrderCreateDTO, CreateCloseOrderCommandRequest>().ReverseMap();
            CreateMap<CreateCloseOrderCommandResponse, CloseOrderViewDTO>().ReverseMap();
            CreateMap<CloseOrderUpdateDTO, UpdateCloseOrderCommandRequest>().ReverseMap();
            CreateMap<UpdateCloseOrderCommandResponse, CloseOrderViewDTO>().ReverseMap();
            #endregion

            #region Closer Order Queries
            CreateMap<GetAllCloseOrderQueryResponse, CloseOrderViewDTO>().ReverseMap();
            CreateMap<GetByIdCloseOrderQueryResponse, CloseOrderViewDTO>().ReverseMap();
            #endregion

            #region User Commands
            CreateMap<UserCreateDTO, CreateUserCommandRequest>().ReverseMap();
            CreateMap<CreateUserCommandResponse, IdentityResult>().ReverseMap();

            CreateMap<UserUpdateContactsDTO, UpdateContactsCommandRequest>().ReverseMap();
            //CreateMap<UpdateContactsCommandResponse, UserViewDTO>().ReverseMap();
          

            CreateMap<UserUpdateLoginDTO, UpdateLoginCommandRequest>().ReverseMap();
            CreateMap<UpdateLoginCommandResponse, UserViewDTO>().ReverseMap();

            CreateMap<UserUpdatePersonalDataDTO, UpdatePersonalDataCommandRequest>().ReverseMap();
            CreateMap<UpdatePersonalDataCommandResponse, UserViewDTO>().ReverseMap();

            CreateMap<UserUpdatePasswordDTO, UpdatePasswordCommandRequest>().ReverseMap();

            #endregion

            #region User Queries
            CreateMap<UserSignInDTO, SignInQueryRequest>().ReverseMap();
            CreateMap<SignInQueryResponse, UserViewDTO>().ReverseMap();
            #endregion

            #region Category Commands
            CreateMap<CategoryCreateDTO, CreateCategoryCommandRequest>().ReverseMap();
            CreateMap<CategoryUpdateDTO, UpdateCategoryCommandRequest>().ReverseMap();
            CreateMap<CreateCategoryCommandResponse, CategoryViewDTO>().ReverseMap();
            CreateMap<UpdateCategoryCommandResponse, CategoryViewDTO>().ReverseMap();
            #endregion

            #region Category Queries
            CreateMap<GetAllCategoryQueryResponse, CategoryViewDTO>().ReverseMap();
            CreateMap<GetByIdCategoryQueryResponse, CategoryViewDTO>().ReverseMap();
            CreateMap<GetWhereCategoryQueryResponse, CategoryViewDTO>().ReverseMap();
            #endregion

            #region Order Status Commands
            CreateMap<OrderStatusCreateDTO, CreateOrderStatusCommandRequest>().ReverseMap();
            CreateMap<OrderStatusUpdateDTO, UpdateOrderStatusCommandRequest>().ReverseMap();
            CreateMap<CreateOrderStatusCommandResponse, OrderStatusViewDTO>().ReverseMap();
            CreateMap<UpdateOrderStatusCommandResponse, OrderStatusViewDTO>().ReverseMap();
            #endregion

            #region Order Status Queries
            CreateMap<GetAllOrderStatusQueryResponse, OrderStatusViewDTO>().ReverseMap();
            CreateMap<GetByIdOrderStatusQueryResponse, OrderStatusViewDTO>().ReverseMap();
            #endregion

            #region Goods Description Commands
            CreateMap<GoodsDescriptionCreateDTO, CreateGoodsDescriptionCommandRequest >().ReverseMap();
            CreateMap<GoodsDescriptionUpdateDTO, UpdateGoodsDescriptionCommandRequest >().ReverseMap();
            CreateMap<CreateGoodsDescriptionCommandResponse, GoodsDescriptionViewDTO>().ReverseMap();
            CreateMap<UpdateGoodsDescriptionCommandResponse, GoodsDescriptionViewDTO>().ReverseMap();
            #endregion

            #region Goods Description Queries
            CreateMap<GetAllGoodsDescriptionQueryResponse, GoodsDescriptionViewDTO>().ReverseMap();
            CreateMap<GetByIdGoodsDescriptionQueryResponse, GoodsDescriptionViewDTO>().ReverseMap();
            CreateMap<GetWhereGoodsDescriptionQueryResponse, GoodsDescriptionViewDTO>().ReverseMap();
            #endregion

            #region Language Commands
            CreateMap<LanguageCreateDTO, CreateLanguageCommandRequest>().ReverseMap();
            CreateMap<LanguageUpdateDTO, UpdateLanguageCommandRequest>().ReverseMap();
            CreateMap<CreateLanguageCommandResponse, LanguageViewDTO>().ReverseMap();
            CreateMap<UpdateLanguageCommandResponse, LanguageViewDTO>().ReverseMap();
            #endregion

            #region Language Queries
            CreateMap<GetAllLanguageQueryResponse, LanguageViewDTO>().ReverseMap();
            CreateMap<GetByIdLanguageQueryResponse, LanguageViewDTO>().ReverseMap();
            #endregion
        }
    }
}
