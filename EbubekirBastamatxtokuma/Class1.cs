using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EbubekirBastamatxtokuma
{
    public class Class1
    {
        //*İletişim ve Eğitim Adreslerimiz..*//
        //*---------------------------------*//
        //Contact : +90 5554128854;
        //Whatshapp Contact : +90 5554128854;
        //Email Contact : ebubekirbastama@elmalicesmekuruyemis.com
        //Website Contact : https://www.ebubekirbastama.com
        //Education https://www.youtube.com/user/yazilimegitim
        //Education https://www.youtube.com/channel/UC240A7DHqgAR8bEMakGdqWg/videos?view_as=subscriber

        public Encoding en { get; set; }

        private void txt_aktar(string DosyaYolu, ListBox lst, bool encode)
        {
            if (encode==false)
            {
                string[] vrr = File.ReadAllLines(DosyaYolu, Encoding.GetEncoding("iso-8859-9"));
                foreach (var item in vrr)
                {
                    lst.Items.Add(item);
                }
            }
            else
            {
                string[] vrr = File.ReadAllLines(DosyaYolu,en);
                foreach (var item in vrr)
                {
                    lst.Items.Add(item);
                }
            }

        }
        private string [] txt_aktar_dizi(string DosyaYolu, bool encode)
        {
            if (encode==false)
            {
                string[] dizi = File.ReadAllLines(DosyaYolu, Encoding.GetEncoding("iso-8859-9"));
                return dizi;
            }
            else
            {
                string[] dizi = File.ReadAllLines(DosyaYolu, en);
                return dizi;
            }

        }

        public void Txt_Aktar_Dizi(string DosyaYolu, ListBox lst,bool encode)
        {
            txt_aktar(DosyaYolu, lst, encode);
        }
        public void Txt_Aktar(string DosyaYolu, bool encode)
        {
            txt_aktar_dizi(DosyaYolu, encode);
        }
    }
}
