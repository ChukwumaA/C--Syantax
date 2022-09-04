//Chukwuma Akunyili Solution
/*
Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;


do{
    int attack = random.Next(1,10);

    heroHealth -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health");

    monsterHealth -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health");

    if (heroHealth <= 0 )
        Console.WriteLine("Hero Wins");
    if (monsterHealth <= 0 )
        Console.WriteLine("Monster Wins");
} while ((heroHealth <= 0) || (monsterHealth <= 0));

*/


//Microsoft Solution
int hero = 10;
int monster = 10;

Random dice = new Random();

do{
    int roll = dice.Next(1,11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0){
        continue;
    }
    
    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero Wins" : "Monster Wins!");