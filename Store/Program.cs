using System;

//У вас есть UseCase от проектировщика который показывает как ожидается работа с системой магазина.
//Вот он - https://gist.github.com/HolyMonkey/0ea27f88a1ce55d514588ab013c91076
//Paylink - просто какая - нибудь случайная строка.

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");

            shop.AddGoodsToWarehouse(iPhone12, 10);
            shop.AddGoodsToWarehouse(iPhone11, 1);

            shop.ShowAssortment();
            //Вывод всех товаров на складе с их остатком + 

            Cart cart = shop.Cart(); //ToDo: корзина отдельно? есть клас покупателя, или покупатель использует корзину от магазина
            cart.Add(iPhone12, 4);
            cart.Add(iPhone11, 3); //при такой ситуации возникает ошибка так, как нет нужного количества товара на складе

            //Вывод всех товаров в корзине

            Console.WriteLine(cart.Order().Paylink);

            cart.Add(iPhone12, 9); //Ошибка, после заказа со склада убираются заказанные товары
        }
    }
}
