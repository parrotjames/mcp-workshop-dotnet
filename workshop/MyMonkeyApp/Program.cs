
// 모든 원숭이 목록을 테이블로 출력
var monkeys = MonkeyHelper.GetMonkeys();

Console.WriteLine("\n===== 원숭이 목록 =====\n");
Console.WriteLine($"{ "이름",-22} | { "서식지",-20} | { "개체수",-8} | ASCII 아트");
Console.WriteLine(new string('-', 70));
foreach (var m in monkeys)
{
	var artLines = m.AsciiArt.Split("\n");
	Console.Write($"{m.Name,-22} | {m.Location,-20} | {m.Population,8} | ");
	Console.WriteLine(artLines.Length > 0 ? artLines[0] : "");
	for (int i = 1; i < artLines.Length; i++)
	{
		Console.Write($"{"",-22}   {"",-20}   {"",8}   ");
		Console.WriteLine(artLines[i]);
	}
}
Console.WriteLine();
