using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тортики.мяу
{
    internal class Tortik
    {
        public string form;
        public string size;
        public string taste;
        public string glaze;
        public string decor;
        public string all_options;
        public int FormPrice;
        public int SizePrice;
        public int TastePrice;
        public int GlazePrice;
        public int DecorPrice;
        public int AllPrice;

        public Tortik(int formPrice, int sizePrice, int tastePrice, int glazePrice, int decorPrice, int allPrice, string AllOptions)
        {
            FormPrice = formPrice;
            SizePrice = sizePrice;
            TastePrice = tastePrice;
            GlazePrice = glazePrice;
            DecorPrice = decorPrice;
            AllPrice = allPrice;
            all_options = AllOptions;
        }
    }
}
