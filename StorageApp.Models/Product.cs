using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public void Show()
        {
            Console.WriteLine("Данные продукта\n" +
                "Название: {0}\n" +
                "Производитель: {1}\n" +
                "Цена: {2}\n" +
                "Количество: {3}",
                Name, Manufacturer, Price, Quantity);
        }
    }
}
