using System;
using System.Collections.Generic;

/// <summary>
/// 원숭이 데이터 관리 및 조회를 위한 헬퍼 클래스
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys = new()
    {
        new Monkey { Name = "Capuchin", Location = "Central/South America", Population = 50000, AsciiArt = @"  (o.o)\n  /|_|\n   | |" },
        new Monkey { Name = "Mandrill", Location = "Africa", Population = 20000, AsciiArt = @"  ('.')\n  /|_|\n   | |" },
        new Monkey { Name = "Japanese Macaque", Location = "Japan", Population = 100000, AsciiArt = @"  (^_^)\n  /|_|\n   | |" },
        new Monkey { Name = "Golden Lion Tamarin", Location = "Brazil", Population = 3500, AsciiArt = @"  (o_O)\n  /|_|\n   | |" }
    };

    /// <summary>
    /// 모든 원숭이 목록 반환
    /// </summary>
    public static List<Monkey> GetMonkeys() => monkeys;
}