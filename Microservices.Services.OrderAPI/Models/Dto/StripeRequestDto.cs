﻿using Microservices.Services.OrderAPI.Models.Dto;

namespace MicroservicesApp.Services.OrderAPI.Models.Dto
{
    public class StripeRequestDto
    {
        public string? StripeSessionUrl { get; set; }
        public string? StripeSessionId { get; set; }
        public string ApproveUrl { get; set; }
        public string CancelUrl { get; set; }
        public OrderHeaderDto OrderHeader { get; set; }
    }
}
