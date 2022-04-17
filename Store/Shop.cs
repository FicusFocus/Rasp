public class Shop
{
    private Warehouse _warehouse = new Warehouse();
    private Cart cart = new Cart();

    public void AddGoodsToWarehouse(Good newGood, int amount)
    {
        _warehouse.Delive(newGood, amount);
    }

    public void ShowAssortment()
    {
        _warehouse.ShowAllCelsinfo();
    }


}