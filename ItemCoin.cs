using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneta
{
    public class ItemCoin
    {
        //private int Id;                                 
        private string Metal;         
        private int WeightOz;                                               
        private int Price;                                                   

        public string GetMetal() { return Metal; }
        public int GetWeightOz() { return WeightOz; }
        public int GetPrice() { return Price; }

        public void SetMetal(string NewMetal) { Metal = NewMetal; }
        public void SetWeightOz(int NewWeightOz) { WeightOz = NewWeightOz; }
        public void SetPrice(int NewPrice) { Price = NewPrice; }


    }



}
