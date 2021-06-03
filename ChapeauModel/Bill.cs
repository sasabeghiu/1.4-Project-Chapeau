using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Bill
    {
        //order overview
        public int OrderId { get; set; }// which order is linked
        public int BillId { get; set; }//the number of such bill
        public Order order { get;set;}
        public int TotalPrice { get; set; }//total price of the meal
        
        //for the payment method, message box
        public PaymentType Type { get; set; }//how gonna be pay
        public string Feedback { get; set; }//any comments to add
        public int Tip { get; set; }//tip for the host
        public int Vat { get; set; }
        
        public Bill(int orderId, int billId, Order host_name,int totalPrice,PaymentType type, string feedback, int tip, int vat)
        {
            this.OrderId = orderId;
            this.BillId = billId;
            this.Host_name = host_name;
            this.TotalPrice = totalPrice;
            this.Type = type;
            this.Feedback = feedback;
            this.Tip = tip;
            this.Vat = vat;
            
            
        }
       
    }
}
