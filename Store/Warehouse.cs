using System.Collections.Generic;

public class Warehouse
{
    private List<StorageCell> _storageCells = new List<StorageCell>();

    public void Delive(Good newGood, int amount)
    {
        bool alreadyInStorage = false;

        foreach (StorageCell cell in _storageCells)
        {
            if (cell.Good.Name.ToLower() == newGood.Name.ToLower())
            {
                cell.AddAmount(amount); //TODO: а если место в ячейке закончилось?
                alreadyInStorage = true;
            }
        }

        if (alreadyInStorage == false)
            _storageCells.Add(new StorageCell(newGood, amount));
    }

    public void ShowAllCelsinfo()
    {
        foreach (StorageCell cell in _storageCells)
            cell.ShowInfo();
    }
}
