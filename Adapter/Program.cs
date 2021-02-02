using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fax fax = new Fax { faxHataKodu = 3003, hataAciklama = "---> CEVAP YOK" };
            Console.WriteLine("------->BAGLANTI BILGILENDIRME SISTEMI<---------");
            IHata[] hatalar =
            {
                      new VeriTabaniHata{hataNumarasi=101,aciklama="---> BAGLANTI YOK" },
                         new VeriTabaniHata{hataNumarasi=110,aciklama="---> SORGULAMA YAPILAMADI" },
                            new ServisHata{hataNumarasi=445,aciklama="---> YETKI BULUNAMADI" },
                               new FaxAdapter(fax)
            };
            foreach (IHata hata in hatalar)
                hata.MailGonder();
            Console.WriteLine("\nCikmak icin herhangi bir tusa basiniz.");
            Console.ReadKey();
        }
    }
}
