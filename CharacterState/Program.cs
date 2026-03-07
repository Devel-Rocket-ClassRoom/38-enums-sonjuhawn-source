using System;
using System.Data.SqlTypes;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== 캐릭터 상태 관리 ===");

Mode mode = Mode.Idle;
bool turn = true;
int read = 0;

while (turn)
{
    PrintCurrenttMode();
    Console.WriteLine("1. 상태 변경\r\n2. 상태 목록 보기\r\n3. 현재 행동 보기\r\n4. 종료\n");
    Console.Write("선택: ");
    read = Convert.ToInt32(Console.ReadLine());
    switch (read)
    {
        case 1:
            ChooseMode();
            break;
        case 2:
            ShowMode();
            break;
        case 3:
            ActivateMode();
            break;
        case 4:
            turn = false;
            Console.WriteLine("프로그램을 종료합니다.");
            break;
    }
}


void PrintCurrenttMode()
{
    Console.WriteLine($"현재 상태: {mode}");
}
void ChooseMode()
{
    Console.WriteLine($"변경할 상태 번호 입력 (0-5):");
    int readmode = Convert.ToInt32(Console.ReadLine());
    mode = (Mode)readmode;
    Console.WriteLine($"상태가 {mode}(으)로 변경되었습니다.");
}
void ShowMode()
{
    Console.WriteLine("=== 상태 목록 ===");
    Array modesint = Enum.GetValues(typeof(Mode));
    foreach(Mode i in modesint)
    {
        Console.WriteLine($"{i} = {(int)i}"); 
    }
    Console.WriteLine();
}
void ActivateMode()
{
    switch (mode)
    {
        case Mode.Idle:;
            Console.WriteLine("[행동] 가만히 있습니다");
            break;
        case Mode.Walking:
            Console.WriteLine("[행동] 걷기 시작합니다");
            break;
        case Mode.Running:
            Console.WriteLine("[행동] 달리기 시작합니다");
            break;
        case Mode.Jumping:
            Console.WriteLine("[행동] 점프하기 시작합니다!");
            break;
        case Mode.Attacking:
            Console.WriteLine("[행동] 적을 공격합니다!");
            break;
        case Mode.Dead:
            Console.WriteLine("[행동] 사망 상태입니다. 행동할 수 없습니다.");
            break;
    }
}
enum Mode 
{
    Idle = 0,
    Walking = 1,
    Running = 2,
    Jumping = 3,
    Attacking = 4,
    Dead = 5
}
