﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShare.Models.GetOrdersByUserId
{
    public class GetOrdersByUserIdResponse
    {
        public GetOrdersByUserIdResponse()
        {
            this.Data = new List<OrderData>();
        }
        public int Code { get; set; }
        public string Message { get; set; }
        public List<OrderData> Data { get; set; }
    }
    public class OrderData
    {
        public OrderData()
        {
            this.rate = new RateData();
        }
        public int id { get; set; }
        public int userId { get; set; }
        public int itemId { get; set; }
        public int SellerId { get; set; }
        public int qty { get; set; }
        public string orderNumber { get; set; }
        public string unitPrice { get; set; }
        public string foodName { get; set; }
        public string itemImage { get; set; }
        public string orderStatus { get; set; }
        public bool isOrderAccepted { get; set; }
        public bool isInvoiceGenerated { get; set; }
        public string acceptedDate { get; set; }
        public string deliverOn { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
        public bool isRated { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public RateData rate { get; set; }
        //additional Props
        public string orderPrice { get; set; }
        public bool isRateBtnVisible { get; set; }
    }

    public class RateData
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int itemId { get; set; }
        public int orderId { get; set; }
        public string comment { get; set; }
        public int starRating { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
    }
}
