using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserrControl
{
    class Program
    {
        static void Main(string[] args)
        {
            UserControl uye = new UserControl();
            uye.KullaniciAdi = "software";
            uye.Sifre = "12345";
            Console.WriteLine("Kullanıcı Adı: {0}"+"\n"+"Şifre:{1}",uye.KullaniciAdi,uye.Sifre);
            Console.ReadLine();
        }
    }
}
