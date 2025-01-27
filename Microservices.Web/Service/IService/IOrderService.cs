﻿using MicroservicesApp.Web.Models;

namespace Microservices.Web.Service.IService
{
    public interface IOrderService
    {
        Task<ResponseDto?> CreateOrder(CartDto cartDto);
    }
}
