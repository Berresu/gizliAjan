using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gizliAjan.Ajan;

namespace gizliAjan
{
    public class Ajan
    {
        public string ismi { get; set; }
        private string kodAdi;
        public int gorevSayisi { get; set; }

        public Ajan(string ajanIsmi, string ajanKodAdi, int ajanGorevSayisi)
        {
            this.ismi = ajanIsmi;
            this.kodAdi = ajanKodAdi;
            this.gorevSayisi = ajanGorevSayisi;
        }

        protected string getKodAdi()
        {
            return kodAdi;
        }

        public class SahteAjan : Ajan
        {
            public SahteAjan(string isim, string sahteKod, int goorevSayisi)
            : base(isim, sahteKod, goorevSayisi) { }

            public void KodAdiUret()
            {
                Console.WriteLine("Sahte Kod Adı Üretildi: SAH-007");
            }

            public void TaklitEt()
            {
                Console.WriteLine($"{ismi} Başka Bir Ajanı Taklit Ediyor...");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SahteAjan sahte = new SahteAjan("Yekta", "Şair", 7);
            sahte.KodAdiUret();
            sahte.TaklitEt();
        }
    }
}
