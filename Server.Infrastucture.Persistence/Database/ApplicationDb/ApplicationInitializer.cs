using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.Database.ApplicationDb
{
    public class ApplicationInitializer
    {
        public static async Task InitializeAsync(IServiceManagerAsync serviceManagerAsync)
        {
            #region Language

            await serviceManagerAsync.LanguageServiceAsync.CreateAsync(new Domain.Application.Dto.LanguageDTO.LanguageCreateDTO
            {
                Name = "ENG"
            });

            await serviceManagerAsync.LanguageServiceAsync.CreateAsync(new Domain.Application.Dto.LanguageDTO.LanguageCreateDTO
            {
                Name = "RU"
            });

            await serviceManagerAsync.LanguageServiceAsync.CreateAsync(new Domain.Application.Dto.LanguageDTO.LanguageCreateDTO
            {
                Name = "UA"
            });

            #endregion

            #region Category


            #region ENG
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Audio",
                LanguageId = 1,
                CategoryId = 1
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Book",
                LanguageId = 1,
                CategoryId = 2
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Video",
                LanguageId = 1,
                CategoryId = 3
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Dictionary",
                LanguageId = 1,
                CategoryId = 4
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Course",
                LanguageId = 1,
                CategoryId = 5
            });
            #endregion

            #region RU
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Аудио",
                LanguageId = 2,
                CategoryId = 1
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Книга",
                LanguageId = 2,
                CategoryId = 2
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Видео",
                LanguageId = 2,
                CategoryId = 3
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Словарь",
                LanguageId = 2,
                CategoryId = 4
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Курс",
                LanguageId = 2,
                CategoryId = 5
            });
            #endregion

            #region UA
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Аудіо",
                LanguageId = 3,
                CategoryId = 1
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Книга",
                LanguageId = 3,
                CategoryId = 2
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Відео",
                LanguageId = 3,
                CategoryId = 3
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Cловник",
                LanguageId = 3,
                CategoryId = 4
            });
            await serviceManagerAsync.CategoryServiceAsync.CreateAsync(new Domain.Application.Dto.CategoryDTO.CategoryCreateDTO
            {
                Name = "Курс",
                LanguageId = 3,
                CategoryId = 5
            });
            #endregion


            #endregion

            #region OrderStatus

            //#region ENG

            //this.serviceManagerAsync.OrderStatusServiceAsync.CreateAsync(new Domain.Application.Dto.OrderStatusDTO.OrderStatusCreateDTO
            //{
            //    Name = "Completed",
            //    LanguageId = 1
            //});
            //this.serviceManagerAsync.OrderStatusServiceAsync.CreateAsync(new Domain.Application.Dto.OrderStatusDTO.OrderStatusCreateDTO
            //{
            //    Name = "Canceled",
            //    LanguageId = 1
            //});
            //this.serviceManagerAsync.OrderStatusServiceAsync.CreateAsync(new Domain.Application.Dto.OrderStatusDTO.OrderStatusCreateDTO
            //{
            //    Name = "Expected",
            //    LanguageId = 1
            //});
            //#endregion

            //#region RU

            //this.serviceManagerAsync.OrderStatusServiceAsync.CreateAsync(new Domain.Application.Dto.OrderStatusDTO.OrderStatusCreateDTO
            //{
            //    Name = "Завершено",
            //    LanguageId = 2
            //});
            //this.serviceManagerAsync.OrderStatusServiceAsync.CreateAsync(new Domain.Application.Dto.OrderStatusDTO.OrderStatusCreateDTO
            //{
            //    Name = "Отменено",
            //    LanguageId = 2
            //});
            //this.serviceManagerAsync.OrderStatusServiceAsync.CreateAsync(new Domain.Application.Dto.OrderStatusDTO.OrderStatusCreateDTO
            //{
            //    Name = "Ожидается",
            //    LanguageId = 2
            //});
            //#endregion

            //#region UA

            //this.serviceManagerAsync.OrderStatusServiceAsync.CreateAsync(new Domain.Application.Dto.OrderStatusDTO.OrderStatusCreateDTO
            //{
            //    Name = "Завершено",
            //    LanguageId = 3
            //});
            //this.serviceManagerAsync.OrderStatusServiceAsync.CreateAsync(new Domain.Application.Dto.OrderStatusDTO.OrderStatusCreateDTO
            //{
            //    Name = "Скасовано",
            //    LanguageId = 3
            //});
            //this.serviceManagerAsync.OrderStatusServiceAsync.CreateAsync(new Domain.Application.Dto.OrderStatusDTO.OrderStatusCreateDTO
            //{
            //    Name = "Очікуваний",
            //    LanguageId = 3
            //});
            //#endregion



            #endregion

            #region Goods

            //await serviceManagerAsync.GoodsServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDTO.GoodsCreateDTO
            //{
            //    Name = "Goods 1",
            //    Discount = 0,
            //    NumberOfDays = 0,
            //    Price = 50,
            //    CategoryId = 1,
            //    QuantityInStock = 10,
            //    CountPurchased = 0,
            //    Image = "/assets/home-assets/spoken-english-language-course.jpg"
            //});

            //await serviceManagerAsync.GoodsServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDTO.GoodsCreateDTO
            //{
            //    Name = "Goods 2",
            //    Discount = 0,
            //    NumberOfDays = 0,
            //    Price = 150,
            //    CategoryId = 2,
            //    QuantityInStock = 10,
            //    CountPurchased = 0,
            //    Image = "/assets/basket-assets/goods1.png"
            //});

            //await serviceManagerAsync.GoodsServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDTO.GoodsCreateDTO
            //{
            //    Name = "Goods 3",
            //    Discount = 0,
            //    NumberOfDays = 0,
            //    Price = 250,
            //    CategoryId = 3,
            //    QuantityInStock = 10,
            //    CountPurchased = 0,
            //    Image = "/assets/home-assets/spoken-english-language-course.jpg"
            //});

            //await serviceManagerAsync.GoodsServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDTO.GoodsCreateDTO
            //{
            //    Name = "Goods 4",
            //    Discount = 0,
            //    NumberOfDays = 0,
            //    Price = 250,
            //    CategoryId = 4,
            //    QuantityInStock = 10,
            //    CountPurchased = 0,
            //    Image = "/assets/basket-assets/goods1.png"
            //});

            //await serviceManagerAsync.GoodsServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDTO.GoodsCreateDTO
            //{
            //    Name = "Goods 5",
            //    Discount = 0,
            //    NumberOfDays = 0,
            //    Price = 250,
            //    CategoryId = 5,
            //    QuantityInStock = 10,
            //    CountPurchased = 0,
            //    Image = "/assets/home-assets/spoken-english-language-course.jpg"
            //});


            #endregion

            #region Goods Description

            //#region ENG
            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Description 1",
            //    GoodsId = 1,
            //    LanguageId = 1

            //});

            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Description 2",
            //    GoodsId = 2,
            //    LanguageId = 1

            //});

            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Description 3",
            //    GoodsId = 3,
            //    LanguageId = 1

            //});

            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Description 4",
            //    GoodsId = 4,
            //    LanguageId = 1

            //});


            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Description 5",
            //    GoodsId = 5,
            //    LanguageId = 1

            //});

            //#endregion

            //#region RU
            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Описание 1",
            //    GoodsId = 1,
            //    LanguageId = 2

            //});

            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Описание 2",
            //    GoodsId = 2,
            //    LanguageId = 2

            //});

            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Описание 3",
            //    GoodsId = 3,
            //    LanguageId = 2

            //});

            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Описание 4",
            //    GoodsId = 4,
            //    LanguageId = 1

            //});


            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Описание 5",
            //    GoodsId = 5,
            //    LanguageId = 1

            //});
            //#endregion

            //#region UA

            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Опис 1",
            //    GoodsId = 1,
            //    LanguageId = 3

            //});

            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Опис 2",
            //    GoodsId = 2,
            //    LanguageId = 3

            //});

            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Опис 3",
            //    GoodsId = 3,
            //    LanguageId = 3

            //});

            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Опис 4",
            //    GoodsId = 4,
            //    LanguageId = 1

            //});


            //await serviceManagerAsync.GoodsDescriptionServiceAsync.CreateAsync(new Domain.Application.Dto.GoodsDescriptionDTO.GoodsDescriptionCreateDTO
            //{
            //    Description = "Опис 5",
            //    GoodsId = 5,
            //    LanguageId = 1

            //});
            //#endregion

            #endregion
        }
    }
}
