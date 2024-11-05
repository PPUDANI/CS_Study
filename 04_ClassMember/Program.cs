// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Player MyPlayer = new Player();

        MyPlayer.SetAttackForce(0);
        MyPlayer.Attack();
    }
}

class Player
{
    private int AttackForce = 100;
    private int Hp = 1000;

    public void SetAttackForce(int _Force)
    {
        AttackForce = _Force;               
    }

    public void Attack()
    {
        Console.WriteLine("%d", AttackForce);
    }

    public int GetHp()
    {
        return Hp;
    }
}