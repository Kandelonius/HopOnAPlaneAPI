using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCTestProject
{
    public class RetailStore
    {
        private long receiptNumber;
        private DateTime dateOfPurchase;
        private long customerNumber;
        private string customerName;
        private string customerAddress;
        private string customerPhone;
        private long itemNumber;
        private string itemDescription;
        private decimal unitPrice;
        private int quantity;

        public RetailStore()
        {
        }
        public RetailStore(long receiptNumber, DateTime dateOfPurchase, long customerNumber, string customerName, string customerAddress, string customerPhone, long itemNumber, string itemDescription, decimal unitPrice, int quantity)
        {
            ReceiptNumber = receiptNumber;
            DateOfPurchase = dateOfPurchase;
            CustomerNumber = customerNumber;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerPhone = customerPhone;
            ItemNumber = itemNumber;
            ItemDescription = itemDescription;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public long ReceiptNumber
        {
            get { return receiptNumber; }
            set
            {
                if (value > 0)
                {
                    receiptNumber = value;
                }
            }
        }
        public DateTime DateOfPurchase { get => dateOfPurchase; set => dateOfPurchase = value; }
        public long CustomerNumber 
        {
            get { return customerNumber; }
            set
            {
                if (value > 0)
                {
                    customerNumber = value;
                }
            }
        }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }
        public string CustomerPhone { get => customerPhone; set => customerPhone = value; }
        public long ItemNumber
        {
            get { return itemNumber; }
            set
            {
                if (value > 0 && value < 9999)
                {
                    itemNumber = value;
                }
            }
        }
        public string ItemDescription { get => itemDescription; set => itemDescription = value; }
        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (value > 0 && value < 9999m)
                {
                    unitPrice = value;
                }
            }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
            }
        }

        public decimal TotalCost()
        {
            return (decimal)Quantity * UnitPrice;
        }

        public override string ToString()
        {
            return $"Customer: {CustomerName}\n" +
                $"Phone: {CustomerPhone}\n" +
                $"Total Purchases ${TotalCost()}";
        }
    }
}
