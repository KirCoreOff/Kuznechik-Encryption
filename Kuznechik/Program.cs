using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Kuz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст для зашифрования: ");
            string textToEncrypt = Console.ReadLine();
            string masterKey = "01234567890123456789012345678901234567890";  //Пароль должен быть 256 бит (32 символа)
            byte[] encryptedBytes = Kuznechik.Encript(Encoding.Default.GetBytes(textToEncrypt), Encoding.Default.GetBytes(masterKey)); //Получение массива байт зашифрованного файла
            string encryptedText = Encoding.Default.GetString(encryptedBytes);
            Console.WriteLine("Зашифрованный текст: " + encryptedText);
            byte[] decryptedBytes = Kuznechik.Decrypt(encryptedBytes, Encoding.Default.GetBytes(masterKey)); //Получение массива байт расшифрованного файла
            string decryptedText = Encoding.Default.GetString(decryptedBytes);
            Console.WriteLine("Расшифрованный текст: " + decryptedText);
        }
    }
}
