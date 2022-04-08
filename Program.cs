using System;
using System.Collections.Generic;

namespace week10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Fighter> fighters = new List<Fighter>();

            Enemy e = new Enemy();
            Player p = new Player();

            p.opponent = e;
            e.opponent = p;

            fighters.Add(p);
            fighters.Add(e);

            bool gameOver = false;

            while(!gameOver)
            {
                foreach (Fighter f in fighters)
                {
                    if (f.dead)
                        gameOver = true;

                    else
                        f.TakeAction();
                }
            }


            
        }
    }
}

public class Fighter
{
    public int hp = 25;
    public int potionAmount = 2;
    public int healAmount = 5;
    public bool dead = false;
    public Fighter opponent;
    public int playerAttack = 5;

    /*if(hp > 0)
      {
           Console.WriteLine("Enemy defeated! You won!");
      }
   else
   {
       Console.WriteLine("You have been defeated! You lose!");
   }*/

    public virtual void TakeAction()
    {
        {

            
            

        }
        
    }
}



/*
{

    Console.WriteLine("==Player Turn==");
    Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

    string choice = Console.ReadLine();

    if (choice == "a")
    {
        enemyHp -= playerAttack;
        Console.WriteLine("Player attacks enemy and deals" + playerAttack + "damage!");

    }
    else
    {
        hp += healAmount;
        Console.WriteLine("Layer restored" + healAmount + "HP!");
    }

}*/

public class Enemy : Fighter
{
    public override void TakeAction()
    {
        Console.WriteLine("==Enemy Turn==");

        if (hp < 0)
        {
            dead = true;
            Console.WriteLine("Enemy defeated! You won!");

        }

        // attack player
        Random random = new Random();
        opponent.hp -= random.Next(0, 3);
        Console.WriteLine("Enemy attacked!");

    }

    
        
}


public class Player : Fighter
{
    public override void TakeAction()
    {
        Console.WriteLine("==Player Turn==");



        Console.WriteLine("Enter '1' to attack or '2' to heal.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            hp -= playerAttack;
            Console.WriteLine("Player attacks enemy and deals " + playerAttack + " damage!");

        }
        if (choice == "2")
        {
            hp += healAmount;
            Console.WriteLine("Layer restored " + healAmount + " HP!");
        }
        if (potionAmount == 0)
        {
            Console.WriteLine("You are out of potions!");
        }

        if (hp < 0)
        {
            dead = true;
            Console.WriteLine("You have been defeated! You lose!");
            //int enemyChoice = Random.Next(0, 3);

            // int choice = Console.ReadLine

            // if choice == 1
            // attack enemy

            // if choice == 2
            // drink potion
        }

    }
}



