using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace Lab6
{
    sealed class Sweets : Candy
    {
        public Sweets(string Type, int callories, int Cost, string Yummy, int Size) : base(Type, callories, Cost, Yummy, Size)
        {
            
            try
            {
                callories = 1000/callories;
               
            } 
            catch(DivideByZeroException)
            {
                throw;
                
            }
        }
        public override string ToString()
        {
            return "Sweets";
        }
        public override void GetCandyInf()
        {
            base.GetCandyInf();
        }
    }
}
