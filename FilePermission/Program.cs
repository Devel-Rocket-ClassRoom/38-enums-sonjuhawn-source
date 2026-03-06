using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("=== 파일 권한 관리 ===");

FilePermission file = FilePermission.None;
Console.WriteLine($"현재 권한: {file}");
file |= FilePermission.Read;
Console.WriteLine($"+ Read 추가: {file}");
file |= FilePermission.Write;
Console.WriteLine($"+ Write 추가: {file}");
file |= FilePermission.Execute;
Console.WriteLine($"+ Execute 추가: {file}");

Console.WriteLine("[권한 확인]");
Console.WriteLine($"Read 권한: {HasFlag(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {HasFlag(FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {HasFlag(FilePermission.Execute)}");

file &= ~FilePermission.Write;
Console.WriteLine($"+ Write 제거: {file}");

Console.WriteLine("[제거 후 권한 확인]");
Console.WriteLine($"Read 권한: {HasFlag(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {HasFlag(FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {HasFlag(FilePermission.Execute)}");
bool HasFlag(FilePermission permission)
{
    if((file & permission) != 0)
    {
        return true; 
    }
    else
    {
        return false;
    }
}


[Flags]
enum FilePermission
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}