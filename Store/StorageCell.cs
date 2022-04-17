using System;

public class StorageCell
{
    private int _maxGoodsAmount;

    public Good Good { get; private set; }
    public int CurrentGoodsAmount { get; private set; }

    public StorageCell(Good newGood, int goodsAmount)
    {
        Good = newGood;
        CurrentGoodsAmount = goodsAmount;
    }

    public void AddAmount(int value)
    {
        if (value + CurrentGoodsAmount > _maxGoodsAmount)
            Console.WriteLine("Места в данной ячейке больше нет.");
        else
            CurrentGoodsAmount += value;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Good.Name}, количество данной ячейке - {CurrentGoodsAmount}." +
                          $" Осталось свободного места - {_maxGoodsAmount}");
    }
}