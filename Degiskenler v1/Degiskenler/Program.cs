using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;

            string a = null;// büyük küçük harf duyarlıdır değişken atamaları rakamlarla başlayamaz string 3A=null; olamaz
            string A = null;// sabit terimlerde kullanılamaz Boşluk yerine ("_") kullanabilirsin

            //DEGISKENLER

            


            byte b = 5;//1 byte yer kaplarlar 0-255 arası değer 
            sbyte c = 5;//-128 - 127 arası deger


            short d = 5;//2 byte yer kaplar -32768 - +32768 arası
            ushort f = 5;//0-65365 2 byte


            Int16 e =5;// 2 byte tam sayilar (belirli bir aralığı var)
            int g = 5;// 4 byte
            Int32 h = 5;// 4 byte 
            Int64 ab = 5;// 8 byte
            uint ac = 5;// 4 byte


            long ad = 5;// 8 byte tam sayilar (aralık daha fazla)
            ulong af = 5;//8 byte

            //reel sayılar
            float ba = 5.2f;// 4 byte 
            double bac = 5;// 8 byte
            decimal bacd = 5;// 16 byte


            char bacdf = 'A';// 2 byte 
            string metin = " ";// string degisken yer kaplar sınırsızdır 


            //dogru yanlış degerleri
            bool tru = true;
            bool fals = false;


            //Tarih ve saati tutuyor
            DateTime trh = DateTime.Now;
            Console.WriteLine(trh);


            //bir obje tutuyoruz her türlü veri olabilir üst tür bir değişken gibidir
            object gameobjct = "ayberk";


            //STRİNGLER

            string str1 = string.Empty;// Boş string

            str1 = "Ayberk";// Atama

            string isim,soyisim;
            isim = "Ayberk";
            soyisim = "Yasar";

            string kimlik = isim + "  " + soyisim;//String birleştirme



            // INTEGER

            int a1=5;
            int a2 = 3;
            int a3 = a1 * a2;

            // BOOLEAN


            bool b1 = 10 < 2;//false döndürcek


            // DEGiSKEN DONUSUMLERi

            string str20 = "54";
            int int54 = 54;

            string yenideger = str20 + int54.ToString();
            Console.WriteLine(yenideger);//5454


            int int20 = int54 + Convert.ToInt32(str20);
            Console.WriteLine(int20);//108


            int int55 = int20 + int.Parse(str20);//stringten donusum icin kullanılır


            //DATETiME


            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //Saat
            string hour = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(hour);
            Console.ReadLine();
        }
    }
}
