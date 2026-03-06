using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("'''");
{
    Console.WriteLine($"{(int)Animal.Horse}");
    Console.WriteLine($"{(int)Animal.Sheep}");
    Console.WriteLine($"{(int)Animal.Monkey}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    CharacterStatus character = CharacterStatus.Poison | CharacterStatus.Confused;
    if((character & CharacterStatus.Poison) != 0)
    {
        Console.WriteLine("캐릭터가 독에 걸렸습니다!");
    }
    else
    {
        Console.WriteLine("독 상태가 아닙니다");
    }
    if((character & CharacterStatus.Paralyzed) != 0)
    {
        Console.WriteLine("캐릭터가 마비상태입니다!");
    }
    else
    {
        Console.WriteLine("마비 상태가 아닙니다.");
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    CharacterStatus status = CharacterStatus.Poison;
    Console.WriteLine($"초기 상태 : {status}");
    status |= CharacterStatus.Confused;
    Console.WriteLine($"혼란 추가 : {status}");
    status &= ~CharacterStatus.Poison;
    Console.WriteLine($"독 제거 : {status}");
    status ^= CharacterStatus.Invisible;
    Console.WriteLine($"투명 토글 : {status}");
}
Console.WriteLine("'''\n");
Console.WriteLine("'''");
{
    BuffStatus buff = BuffStatus.None;
}
Console.WriteLine("'''\n");


enum Animal
{
    Horse,
    Sheep = 5,
    Monkey
}
[Flags]
enum CharacterStatus
{
    None = 0,
    Poison = 1,
    Paralyzed = 1 << 1,
    Confused = 1 << 2,
    Invisible = 1 << 3
}
[Flags]
enum BuffStatus
{
    None = 0, 
    AttackUp = 1,
    DefenseUp = 1 << 1,
    SpeedUp = 1 << 2, 
    All = AttackUp | DefenseUp | SpeedUp
}