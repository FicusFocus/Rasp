using System;

public class Weapon
{
    private int _damage;
    private int _bullets;

    public void Fire(Player player)
    {
        if (_bullets > 0)
        {
            player.TakeDamage(_damage);
            _bullets -= 1;
        }
    }
}

public class Player
{
    private int _health;

    public void TakeDamage(int damage)
    {
        if (damage > 0)
            _health -= damage;
    }
}

public class Bot
{
    private Weapon _Weapon;

    public void OnSeePlayer(Player player)
    {
        _Weapon.Fire(player);
    }
}
