using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asli_Donmez
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Baslangic:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Kaç öğrenci istiyorsunuz ? ");
            int ogrenciSayisi = 0;
            if (int.TryParse(Console.ReadLine(), out ogrenciSayisi))
            {
                Console.WriteLine("Sayısal Değer Girdiniz");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Düzgün değer gir");
                Console.ResetColor();
                goto Baslangic;
            }

            string[,] ogrenciler = new string[ogrenciSayisi, 3];
            int[,] MatematikNotlari = new int[ogrenciSayisi, 2];
            int[,] KimyaNotlari = new int[ogrenciSayisi, 2];

            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                Console.WriteLine("{0} öğrencinin ismini giriniz", i + 1);
                ogrenciler[i, 0] = Console.ReadLine();
                for (int j = 0; j < KimyaNotlari.GetLength(1); j++)
                {
                    Console.WriteLine("{0} adlı öğrencinin {1} kimya notunu giriniz:", ogrenciler[i, 0], j+1);
                    KimyaNotlari[i, j] = int.Parse(Console.ReadLine());
                }
                for (int k = 0; k < MatematikNotlari.GetLength(1); k++)
                {
                    Console.WriteLine("{0} adlı öğrencinin {1} MAT notunu giriniz:", ogrenciler[i, 0],k+1);
                    MatematikNotlari[i, k] = int.Parse(Console.ReadLine());
                }
                ogrenciler[i, 1] = ((double)(KimyaNotlari[i, 0] + KimyaNotlari[i, 1]) / 2).ToString();
                ogrenciler[i, 2] = ((double)(MatematikNotlari[i, 0] + MatematikNotlari[i, 1]) / 2).ToString();
            }
            Console.Clear();
            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                Console.WriteLine("{0} adlı ogrencinin Kimya not ortalamsı: {1}, Matematik not ortalaması: {2}", ogrenciler[i, 0], ogrenciler[i, 1],ogrenciler[i,2]);
            }

            Console.Write("Aranacak öğrenci adı: ");
            string aranan = Console.ReadLine().ToLower();

            for (int m = 0; m < ogrenciler.GetLength(0);)
            {
                if ((ogrenciler.GetLength(0) != m) && (aranan != ogrenciler[m, 0]))
                {
                    m++;
                }
                else
                {
                    Console.WriteLine("Öğrenci adı: {0}\nMatematik Ort: {1}\nKimya Ort: {2}",
                        ogrenciler[m, 0], ogrenciler[m, 2], ogrenciler[m, 1]);
                    break;
                }
            }
        }
    }
}
