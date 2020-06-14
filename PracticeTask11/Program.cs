using System;

namespace PracticeTask11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в приложение по работе с криптографией!");

            string message;          // Нерасшифрованное сообщение
            string encryptedMessage; // Зашифрованное сообщение 
            string decryptedMessage; // Дешифрованное сообщение

            // Шифрование сообщения
            Console.WriteLine("\nШифрование сообщения");

            // Ввод сообщения
            Console.WriteLine("Введите сообщение:");
            message = Input();

            // Получение зашифрованного сообщения
            encryptedMessage = GetEncryptedMessage(message);

            // Вывод информации
            Console.WriteLine("Начальное сообщение:");
            Console.WriteLine(message);
            Console.WriteLine("Зашифрованное сообщение:");
            Console.WriteLine(encryptedMessage);

            Console.WriteLine("\nШифрование сообщения завершено");

            // Дешифрование сообщения
            Console.WriteLine("\nДешифрование сообщения");

            // Ввод зашифрованного сообщения
            Console.WriteLine("Введите зашифрованное сообщение:");
            message = Input();

            // Получение дешифрованного сообщения
            decryptedMessage = GetDecryptedMessage(message);

            // Вывод информации
            Console.WriteLine("Зашифрованное сообщение:");
            Console.WriteLine(message);
            Console.WriteLine("Расшифрованное сообщение:");
            Console.WriteLine(decryptedMessage);

            Console.WriteLine("\nРасшифрование сообщения завершено");

            Console.WriteLine("\nЗавершение работы в приложении по работе с криптографией");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }

        // Получение зашифрованного сообщения
        public static string GetEncryptedMessage(string message)
        {
            string encryptedMessage = message[0].ToString();
            for (int i = 1; i < message.Length; i++)
            {
                if (message[i].Equals(message[i - 1]))
                    encryptedMessage += "1";
                else
                    encryptedMessage += "0";
            }
            return encryptedMessage;
        }

        // Получение дешифрованного сообщения
        public static string GetDecryptedMessage(string message)
        {
            string decryptedMessage = message[0].ToString();
            for (int i = 1; i < message.Length; i++)
            {
                if (message[i].Equals(decryptedMessage[i - 1]))
                    decryptedMessage += "1";
                else
                    decryptedMessage += "0";
            }
            return decryptedMessage;
        }

        // Проверка корректности сообщения
        public static bool CheckInputMessage(string message)
        {
            if (message.Length > 100 || message.Length < 2) return false;
            foreach (char s in message)
            {
                if (s != '0' && s != '1')
                {
                    return false;
                }
            }
            return true;
        }

        // Ввод строки с ограничениями
        private static string Input()
        {
            string input;
            bool inputCheck;
            do
            {
                Console.Write("Ввод: ");
                input = Console.ReadLine();
                inputCheck = CheckInputMessage(input) && input.Length >= 2 && input.Length <= 100;
                if (!inputCheck) Console.WriteLine($"Ошибка! Введите сообщение, состоящее из 0 и 1, а также с длиной в пределах от {2} до {100}");
            } while (!inputCheck);
            return input;
        }
    }
}
