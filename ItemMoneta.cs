using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneta
{
    public class ItemMoneta
    {
        private int Id;           // id addet automat                       // { get; set; }
        private string Metal;         //s - silver, g - gold     moneta      // { get; set; }
        private int WeightOz;                                                //{ get; set; }
        private int Price;                                                   //{ get; set}

        public string GetMetal() { return Metal; }
        public int GetWeightOz() { return WeightOz; }
        public int GetPrice() { return Price; }

        public void SetMetal(string NewMetal) { Metal = NewMetal; }
        public void SetWeightOz(int NewWeightOz) { WeightOz = NewWeightOz; }
        public void SetPrice(int NewPrice) { Price = NewPrice; }


    }



}
