using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("'''");
{
    Animal animal = Animal.Dog;

    switch (animal)
    {
        case Animal.Chicken:
            Console.WriteLine("닭");
            break;
        case Animal.Dog:
            Console.WriteLine("개");
            break;
        case Animal.Pig:
            Console.WriteLine("돼지");
            break;
        default:
            Console.WriteLine("알 수 없는 동물");
            break;
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    CharacterState state = CharacterState.Idle;

    state = CharacterState.Attacking;

    Update(state);

    void Update(CharacterState state)
    {
        switch (state)
        {
            case CharacterState.Idle:
                Console.WriteLine("대기 애니메이션 재생");
                break;
            case CharacterState.Walking:
                Console.WriteLine("걷기 애니메이션 재생");
                break;
            case CharacterState.Running:
                Console.WriteLine("달리기 애니메이션 재생");
                break;
            case CharacterState.Jumping:
                Console.WriteLine("점프 애니메이션 재생");
                break;
            case CharacterState.Attacking:
                Console.WriteLine("공격 애니메이션 재생");
                break;
            case CharacterState.Dead:
                Console.WriteLine("사망 애니메이션 재생");
                break;
        }
    }
    
}
Console.WriteLine("'''\n");

enum Animal
{
    Chicken,
    Dog, 
    Pig
}
enum CharacterState
{
    Idle,
    Walking, 
    Running,
    Jumping,
    Attacking,
    Dead
}
enum ItemRarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}
enum Direction
{
    Up, 
    Down,
    Left,
    Right
}