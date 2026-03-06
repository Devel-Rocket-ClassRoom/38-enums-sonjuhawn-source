using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("'''");
{
    Priority priority = Priority.High;

    if(priority == Priority.High)
    {
        Console.WriteLine($"높은 우선순위");
    }

}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Animal animal = Animal.Tiger;
    Console.WriteLine(animal);
    if(animal == Animal.Tiger)
    {
        Console.WriteLine("호랑이");
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    int red = (int)Color.Red;
    int green = (int)Color.Green;
    int blue = (int)Color.Blue;
    Console.WriteLine($"Red:{red} Green:{green} Blue: {blue}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Console.WriteLine(sizeof(SmallEnum));
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Type type = typeof(ConsoleColor);
    string[] color = Enum.GetNames(type);

    Console.WriteLine("ConsoleColor 열거형의 색상들:");
    foreach(string c in color)
    {
        Console.WriteLine(c); 
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    string red = "Red";
    ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), red);
    Console.ForegroundColor = color;
    Console.WriteLine("빨간색 텍스트");
    Console.ResetColor();
    Console.WriteLine("기본 색상 텍스트");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    string input = "Up";
    if(Enum.TryParse(input, out Direction direction))
    {
        Console.WriteLine($"변환 성공: {direction}");
    }
    else
    {
        Console.WriteLine("변환 실패");
    }

    string invalid = "Foward";
    if(Enum.TryParse(invalid, out Direction dirction))
    {
        Console.WriteLine($"변환 성공: {dirction}");
    }
    else
    {
        Console.WriteLine($"'{invalid}'은(는) 유효하지 않은 값");
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    bool vaild1 = Enum.IsDefined(typeof(Animal), 1);
    bool vaild2 = Enum.IsDefined(typeof(Animal), 100);
    bool vaild3 = Enum.IsDefined(typeof(Animal), "Tiger");
    Console.WriteLine($"1은 유효한 Animal 값인가? {vaild1}");
    Console.WriteLine($"100은 유효한 Animal 값인가? {vaild2}");
    Console.WriteLine($"'Tiger'는 유효한 Animal 값인가? {vaild3}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Direction direction = Direction.Right;
    int right = (int)direction;
    int left = 2;
    Direction direction1 = (Direction)left;
    Console.WriteLine($"{direction} = {right}");
    Console.WriteLine($"{left} = {direction1}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Animal animal = (Animal)100;
    Console.WriteLine(animal);
}
Console.WriteLine("'''\n");


enum Priority
{
    High,
    Normal,
    Low
}

enum Animal
{
    Mouse,
    Cow, 
    Tiger
}

enum Color
{
    Red = 10, 
    Green, 
    Blue = 20
}
enum SmallEnum : byte
{
    Left, 
    Right, 
    Top, 
    Bottom
}
enum Direction
{
    Up, 
    Down,
    Left,
    Right
}