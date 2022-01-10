using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserrControl
{
    class UserControl
    {
        private string _kullaniciadi;
        private string _sifre;

        public string KullaniciAdi
        {
            get
            {
                return _kullaniciadi;
            }

            set
            {
                bool isOK = true;
                for (int i = 0; i < value.Length; i++)
                {
                     if(!char.IsLetter(value[i])) 
                    {
                        isOK = false;
                        break;
                    }

                }

                if (isOK)
                {
                    _kullaniciadi = value;
                }
                else
                {
                    Console.WriteLine("Kullanıcı Adı Harf Dışında Karakter İçeremez. Lütfen Düzeltin..");
                }


            }
        }
        public string Sifre
        {
            get
            {
                return _sifre;
            }

            set
            {
                _sifre = value;
            }
        }
    }
}
