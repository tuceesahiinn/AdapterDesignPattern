using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FaxAdapter:IHata
    {
        private Fax _fax;
        public FaxAdapter(Fax fax)
        {
            _fax = fax;
        }
        public int hataNumarasi
        {
            get { return _fax.faxHataKodu; }
            set { _fax.faxHataKodu = value; }
        }
        public string aciklama
        {
            get { return _fax.hataAciklama; }
            set { _fax.hataAciklama = value; }
        }
        public void MailGonder()
        {
            Console.WriteLine("\n{0} {1} ---> FAX HATASİ ", hataNumarasi.ToString(), aciklama);
        }
    }
}
