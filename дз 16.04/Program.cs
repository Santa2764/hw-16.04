using System;

delegate void MenuItemDelegate();

class Program
{
    static void Main(string[] args)
    {
        // Создание делегатов для каждого пункта меню
        MenuItemDelegate[] menuItems = new MenuItemDelegate[]
        {
            NewGame,
            LoadGame,
            Rules,
            About,
            Exit
        };

        int choice = -1;
        do
        {
            // Отображение меню и получение выбора пользователя
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - новая игра");
            Console.WriteLine("2 - загрузить игру");
            Console.WriteLine("3 - правила игры");
            Console.WriteLine("4 - о авторе");
            Console.WriteLine("0 - выход");
            Console.Write("Введите номер пункта меню: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Ошибка ввода! Попробуйте снова.");
                continue;
            }

            // Вызов соответствующего метода в зависимости от выбора пользователя
            if (choice < 0 || choice >= menuItems.Length)
            {
                Console.WriteLine("Некорректный номер пункта меню! Попробуйте снова.");
            }
            else if (choice == 0)
            {
                menuItems[4]();
            }
            else
            {
                menuItems[choice - 1]();
            }
        } while (choice != 0);
    }

    static void NewGame()
    {
        Console.WriteLine("Метод для начала новой игры.\n");
    }

    static void LoadGame()
    {
        Console.WriteLine("Метод для загрузки сохраненной игры.\n");
    }

    static void Rules()
    {
        Console.WriteLine("Метод для отображения правил игры.\n");
    }

    static void About()
    {
        Console.WriteLine("Метод для отображения информации об авторе.\n");
    }

    static void Exit()
    {
        Console.WriteLine("Метод для выхода из программы.\n");
    }
}
