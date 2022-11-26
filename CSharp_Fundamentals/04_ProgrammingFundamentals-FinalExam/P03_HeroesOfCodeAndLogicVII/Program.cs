using System;
using System.Collections.Generic;

namespace P03_HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, int> heroHP = new Dictionary<string, int>();
            Dictionary<string, int> heroMP = new Dictionary<string, int>();

            for (int i = 0; i < number; i++)
            {
                string[] heroArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = heroArgs[0];
                int healthPoints = int.Parse(heroArgs[1]);
                int manaPoints = int.Parse(heroArgs[2]);

                heroHP[name] = healthPoints;
                heroMP[name] = manaPoints;
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split(" - ");
                string cmdType = cmdArg[0];
                string heroName = cmdArg[1];

                if (cmdType == "CastSpell")    
                {
                    int manaNeeded = int.Parse(cmdArg[2]);
                    string spellName = cmdArg[3];

                    if (heroMP[heroName] >= manaNeeded)
                    {
                        heroMP[heroName] -= manaNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroMP[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmdType == "TakeDamage")
                {
                    int damage = int.Parse(cmdArg[2]);
                    string attacker = cmdArg[3];

                    heroHP[heroName] -= damage;
                    if (heroHP[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroHP[heroName]} HP left!");
                    }
                    else
                    {
                        heroHP.Remove(heroName);
                        heroMP.Remove(heroName);

                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (cmdType == "Recharge")
                {
                    int manaReplanished = int.Parse(cmdArg[2]);
                    if (heroMP[heroName] + manaReplanished > 200)
                    {
                        manaReplanished = 200 - heroMP[heroName];
                    }

                    heroMP[heroName] += manaReplanished;
                    Console.WriteLine($"{heroName} recharged for {manaReplanished} MP!");
                }
                else if (cmdType == "Heal")
                {
                    int healthReplanished = int.Parse(cmdArg[2]);
                    if (heroHP[heroName] + healthReplanished > 100)
                    {
                        healthReplanished = 100 - heroHP[heroName];
                    }

                    heroHP[heroName] += healthReplanished;
                    Console.WriteLine($"{heroName} healed for {healthReplanished} HP!");
                }

                command = Console.ReadLine();
            }

            foreach (var kvp in heroMP)
            {
                string heroName = kvp.Key;
                int manaPoints = kvp.Value;
                int healthPoints = heroHP[heroName];

                Console.WriteLine($"{heroName}");
                Console.WriteLine($"  HP: {healthPoints}");
                Console.WriteLine($"  MP: {manaPoints}");
            }
        }
    }
}
