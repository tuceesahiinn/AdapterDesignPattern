using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class VeriTabaniHata:IHata
    {
        private int _hataNumarasi;
        private string _aciklama;
        public int hataNumarasi
        {
            get { return _hataNumarasi; }
            set { _hataNumarasi = value; }
        }
        public string aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        public void MailGonder()
        {
            Console.WriteLine("\n{0} {1} ---> VERI TABANI HATASI", hataNumarasi.ToString(), aciklama);
        }
    }
}
