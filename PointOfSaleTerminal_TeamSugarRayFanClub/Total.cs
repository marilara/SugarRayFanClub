﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoSMidterm
{
    class Total
    {
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public double GrandTotal { get; set; }
        public Total()
        {

        }
        public void SetTotal(List<Product> x)
        {
            foreach (Product p in x)
            {
                SubTotal += (p.Price * p.Quantity);
            }
            Tax = SubTotal * .06;
            GrandTotal = Tax + SubTotal;
        }
        public void DisplayTotal(Total t)
        {
            Console.WriteLine("Subtotal: " + t.SubTotal);
            Console.WriteLine("Tax: " + t.Tax);
            Console.WriteLine("Grand Total: " + t.GrandTotal);
        }
    }
}
