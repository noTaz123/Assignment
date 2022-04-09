using System;

namespace Assignment10a
{
    class Program
    {
        class Fighter
        {
            public int CurrHealth;
            public int MaxHealth=12;
            public bool IsDead;
            public int HitTaken;
            public string Name;
            public int potion = 3;

            public Fighter(int currHealth, bool isDead, int hitTaken, string name)
            {
                CurrHealth = currHealth;
                IsDead = isDead;
                HitTaken = hitTaken;
                Name = name;
            }

            public void SomeOneDead(string n, int health)
            {
                if(health <= 0)
                {
                    IsDead = true;
                    Console.WriteLine(Name + " is dead!");
                    Console.WriteLine(n + " Congratulations! You won.");
                }
            }

            public void Potion()
            {
                //potion--;
                if (potion > 0)
                {
                    //Console.WriteLine("You have " + potion + " left");
                    CurrHealth += 2;
                    potion--;
                    Console.WriteLine("Player, you just added to your life. (" + potion + " left)");
                    Console.WriteLine("Player, your current health is " + CurrHealth);
                    Console.WriteLine();
                    
                }
                else
                {
                    Console.WriteLine("You have no more potion.");
                    Console.WriteLine("Miss a turn.");
                    Console.WriteLine();
                }
                
            }

            public void EnemyHit(string n)
                    {
                        Random rnd = new Random();
                        int num = rnd.Next(0, 3);
                

                        switch (num)
                        {
                            case 1:
                                HitTaken = 2;
                                CurrHealth -= 2;
                                break;
                            case 2:
                                HitTaken = 5;
                                CurrHealth -= 5;
                                break;
                            case 0:
                                HitTaken = 1;
                                CurrHealth -= 1;
                                break;
                            default:
                                HitTaken = 0;
                                Console.WriteLine("Missed");
                                break;
                        }
                        SomeOneDead(n, CurrHealth);
                        Console.WriteLine(Name+"'s current health is "+ CurrHealth);
                        Console.WriteLine();
                    }
            
            

            public virtual int TakeAction(string n)
            {
                return 0;
            }
   
        }

        class Player : Fighter
        {
            public Player(int cHealth, bool Dead, int hit, string pname) : base(cHealth, Dead, hit, pname)
            {
                CurrHealth = cHealth;
                IsDead = Dead;
                HitTaken = hit;
                Name = pname;
            }

            public override int TakeAction(string n)
            {
                int a;
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter '1' for Attack");
                Console.WriteLine("Enter '2' for Take Potion");
                string action = Console.ReadLine();
                Console.WriteLine();
                if(action == "1")
                {
                    a =  1;                    
                }
                else { a = 2; }
                return a;
            }
        }

        class Enemy : Fighter
        {
            public Enemy(int cHealth, bool Dead, int hit, string pname) : base(cHealth, Dead, hit, pname)
            {
                CurrHealth = cHealth;
                IsDead = Dead;
                HitTaken = hit;
                Name = pname;
            }
            public override int TakeAction(string n)
            {
                EnemyHit(n);
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int turn = 0;
            Player player1 = new Player(10, false, 0, "Player");
            Enemy enemy = new Enemy(10, false, 0, "Computer");
            while (player1.IsDead == false && enemy.IsDead == false)
            {
                turn += 1;
                if((turn % 2) != 0)
                {
                    Console.WriteLine("It is Player's turn");

                    int tk = player1.TakeAction(enemy.Name);
                    if (tk == 1)
                    {
                        enemy.EnemyHit(player1.Name);
                    }
                    else
                    {
                        player1.Potion();
                    }
                }

                else
                {
                    Console.WriteLine("It is Enemy's turn");

                    player1.EnemyHit(enemy.Name);
                }

            }
           
        }
    }
}
