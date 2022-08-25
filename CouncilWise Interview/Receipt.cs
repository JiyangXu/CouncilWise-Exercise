using System;
using System.Collections.Generic;
using System.Text;

namespace CouncilWise
{
    internal class Receipt
    {
        public ICollection<ReceiptItem> Items { get; set; }
        public decimal Total { get; set; }
        public decimal TaxTotal { get; set; }

        public override string ToString()
        {
            string receiptHeader = "Receipt: \n";
            string outCome = "";

            foreach (var item in Items)
            {
                outCome +="\tItems:\n\t"+ item.Name + "\n\t\tQuantity\tUnitPrice\tTaxAmount" + "\n\t\t" + item.Quantity+" \t \t" + item.UnitPrice+" \t \t" + item.TaxAmount +"\n";

            }
            string receiptTotal = "Total:" + Total+"\n";
            string receiptGst = "GST:" + Helper.CurrencyRound(TaxTotal);
            return receiptHeader + outCome + receiptTotal + receiptGst;
        }
    }
}
