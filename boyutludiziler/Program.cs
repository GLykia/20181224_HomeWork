using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boyutludiziler
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
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La düzgün girsene kaç kişiyseniz...");
                Console.ResetColor();
                goto Baslangic;
            }
            Console.ResetColor();
            string ogrenciAdi = "";
            string[,] ogrenciler = new string[ogrenciSayisi,3];
            double[,] MatematikNotlari = new double[ogrenciSayisi, 2];
            double[,] KimyaNotlari = new double[ogrenciSayisi, 2];
            

            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}. öğrencinin adını giriniz = ", i + 1);
                ogrenciAdi = Console.ReadLine().ToString().ToUpper();
                ogrenciler[i, 0] = ogrenciAdi;
                for (int j = 0; j < MatematikNotlari.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\"{0}\" adlı öğrencinin {1}. Matematik notunu giriniz = ", ogrenciler[i,0], j+1);
                    MatematikNotlari[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                for (int k = 0; k < KimyaNotlari.GetLength(1); k++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\"{0}\" adlı öğrencinin {1}. Kimya notunu giriniz = ", ogrenciler[i, 0], k+1);
                    KimyaNotlari[i, k] = Convert.ToDouble(Console.ReadLine());
                }
                ogrenciler[i, 1] = ((MatematikNotlari[i, 0] + MatematikNotlari[i, 1])/2).ToString();
                ogrenciler[i, 2] = ((KimyaNotlari[i, 0] + KimyaNotlari[i, 1]) / 2).ToString();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Öğrenciler Ve Ortalamaları Listesi");
            Console.WriteLine("*******************************************");

            Console.ResetColor();
            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} adlı öğrencinin Matematik 1.Notu: {1} 2.Notu : {2}", ogrenciler[i, 0], MatematikNotlari[i, 0], MatematikNotlari[i, 1]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} adlı öğrencinin Kimya 1. Notu: {1} 2. Notu : {2}", ogrenciler[i, 0], KimyaNotlari[i, 0], KimyaNotlari[i, 1]);
                Console.ResetColor();
                Console.WriteLine("{0} adlı öğrencinin Matematik Not Ort: {1} Kimya Not Ortalaması: {2} ",ogrenciler[i,0],ogrenciler[i,1],ogrenciler[i,2]);
                Console.WriteLine("*******************************************");
            }
            searchagain:
            Console.WriteLine("Aranan kişinin ismini giriniz");
            string aranankisi = Console.ReadLine();
            int tut = 0;
            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                if (aranankisi.ToUpper()==ogrenciler[i,0].ToUpper())
                {
                    Console.WriteLine("{0} adlı öğrencinin Matematik 1.Notu: {1} 2.Notu : {2}", ogrenciler[i, 0], MatematikNotlari[i, 0], MatematikNotlari[i, 1]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} adlı öğrencinin Kimya 1. Notu: {1} 2. Notu : {2}", ogrenciler[i, 0], KimyaNotlari[i, 0], KimyaNotlari[i, 1]);
                    Console.ResetColor();
                    Console.WriteLine("{0} adlı öğrencinin Matematik Not Ort: {1} Kimya Not Ortalaması: {2} ", ogrenciler[i, 0], ogrenciler[i, 1], ogrenciler[i, 2]);
                }
                else
                {
                    Console.WriteLine("Aradığın kişi bulunamadı");
                    tut++;
                }
            }
            if (tut==ogrenciler.GetLength(0))
            {
                goto searchagain;
            }
        }
    }
}
