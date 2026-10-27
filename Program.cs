Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");

Play silksong = new Play("silksong", 100);
Play Fnaf = new Play("Fnaf 4", 90);
Play brawl_stars = new Play("brawl_stars", 120);

silksong.rating = 75;
brawl_stars.Number_of_all_game = 4;
Console.WriteLine(">>> Игра 1 <<<");
Console.WriteLine($"название: {silksong.NameGame}");
Console.WriteLine($"рейтинг: {silksong.rating}");
Console.WriteLine($"Колво отзывов: {silksong.reviews}");
Console.WriteLine($"Игра по счету: {silksong.Number_of_all_game}");

Console.WriteLine();

Console.WriteLine(">>> Игра 2 <<<");
Console.WriteLine($"название: {Fnaf.NameGame}");
Console.WriteLine($"рейтинг: {Fnaf.rating}");
Console.WriteLine($"Колво отзывов: {Fnaf.reviews}");
Console.WriteLine($"Игра по счету: {Fnaf.Number_of_all_game}");

Console.WriteLine();

Console.WriteLine(">>> Игра 3 <<<");
Console.WriteLine($"название: {brawl_stars.NameGame}");
Console.WriteLine($"рейтинг: {brawl_stars.rating}");
Console.WriteLine($"Колво отзывов: {brawl_stars.reviews}");
Console.WriteLine($"Игра по счету: {brawl_stars.Number_of_all_game}");

