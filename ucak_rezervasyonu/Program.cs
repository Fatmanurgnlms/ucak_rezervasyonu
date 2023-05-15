using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucak_rezervasyonu
{
    internal class proje
    {
        public static string musteriAdSoyad;
        static void Main(string[] args)
        {
            DateTime TarihveSaat0 = new DateTime(2025, 08, 15, 22, 0, 0);
            DateTime TarihveSaat1 = new DateTime(2025, 08, 18, 22, 0, 0);
            DateTime TarihveSaat2 = new DateTime(2025, 08, 20, 22, 0, 0);
            DateTime TarihveSaat3 = new DateTime(2025, 08, 22, 22, 0, 0);

            ucak ucak0 = new ucak();
            ucak0.bakimTarihi = TarihveSaat0;
            ucak0.seriNo = 888;
            ucak0.kacKisilik = 100;
            musteri musteri0 = new musteri();
            Console.WriteLine("musteri adı soyadı?");
            musteri0.adSoyad = (Console.ReadLine());
            Console.WriteLine("musteri cinsiyeti?");
            musteri0.cinsiyet = (Console.ReadLine());
            Console.WriteLine("musteri yası?");
            musteri0.yas = Convert.ToInt32(Console.ReadLine());
            musteri0.yasli = "hayır";
            musteri0.genc = "evet";
            Console.WriteLine("engelli misiniz evet yada hayır?");
            musteri0.engelli = (Console.ReadLine());


            lokasyon lokasyon0 = new lokasyon();
            Console.WriteLine("ucak hangi ulke'ye gidiyor?");
            lokasyon0.Ulke = (Console.ReadLine());
            Console.WriteLine("ucak hangi şehir'e gidyor?");
            lokasyon0.Sehir = (Console.ReadLine());
            Console.WriteLine("hangi havaalanı?");
            lokasyon0.Havaalani = (Console.ReadLine());
            lokasyon0.kapali = 'k';


            rezervasyon rezervasyon0 = new rezervasyon();
            Console.WriteLine("koltuk numarası seçiniz\nKoltuk numaraları: 'f1-150,j1-150");
            Console.WriteLine("Koltuk no seçin: ");
            rezervasyon0.KoltukNo = Console.ReadLine();
            rezervasyon0.doluKoltuk = 150;
            rezervasyon0.Lokasyon = (lokasyon0.Ulke + " " + lokasyon0.Sehir);
            Console.WriteLine("Lokasyon:" + rezervasyon0.Lokasyon);
            rezervasyon0.Müsteri = musteri0.adSoyad;
            Console.WriteLine("AD SOYAD:" + rezervasyon0.Müsteri);
            rezervasyon0.TarihVeSaat = TarihveSaat1;
            Console.WriteLine("Tarih:" + rezervasyon0.TarihVeSaat);
            Console.WriteLine("seçilen koltuk no:" + rezervasyon0.KoltukNo);
            rezervasyon0.KoltukNo = (Console.ReadLine());
            rezervasyon0.Acik = 'A';
            rezervasyon0.Kapali = 'K';




        }
    }
}
