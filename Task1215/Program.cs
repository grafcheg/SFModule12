﻿namespace Task1215;

class Program
{
    private static void Main(string[] args)
    {
        var users = new[]
        {
            new User() { Name = "Adam", IsPremium = true },
            new User() { Name = "Scott", IsPremium = true },
            new User() { Name = "John", IsPremium = false }
        };

        foreach (var user in users)
        {
            Console.WriteLine($"Hello {user.Name}");
            
            if (!user.IsPremium)
                ShowAds();
        }
    }

    private static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
}