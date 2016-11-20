using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment8
{
    public class Bill
    {
        const double tax = 0.09;
        private double tips;
        private double amount;       
        
        public Bill()
        {
            TipPercent = 0;
                Amount = 0;          
        }
     
        public double TipPercent { set; get; }
        public double Amount { set; get; }        
        

        public double GetTips(double TipPercent)
        {           
            return Amount * (TipPercent/100);         
        }

        public double GetTax()
        {
            return Amount * tax;
        }

        public double GetTotalAmount(double TipPercent)
       {          
            return Amount+GetTax() + GetTips(TipPercent);            
        }
    }
}
