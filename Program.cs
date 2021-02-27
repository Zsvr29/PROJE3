using System;

namespace PROJEM3
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim, soyisim, TC;
            int odasys;
            int ödenenpara = 0;
            int artanpara;
            int ögleyemegıfyt =50;
            int ymksys;
            Console.WriteLine("Hosgeldınız:");
            Console.WriteLine("Otelımızde sabah kahvaltı ve aksam yemeklerı ucretsızdır . Öğle yemegımızın standart fıyatı kısı bası  50 lıradır ");
            Console.WriteLine("Ismınızı gırınız:");
            isim = Console.ReadLine();
            Console.WriteLine("Soyısmınızı gırınız:");
            soyisim = Console.ReadLine();
            Console.WriteLine("TC nızı gırırınız:");
            TC = Console.ReadLine();
            Console.WriteLine("Kalmak ıstedıgınız oda sayısını gırınız:");
            odasys = Convert.ToInt32(Console.ReadLine());
            if (odasys==1)
            {

                Console.WriteLine(" 1 oda ıcın 100 lıra ucret odenmektedır.");
                Console.WriteLine("Odenen ucret:");
                ödenenpara = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Paranın artanı:");
                artanpara = ödenenpara - 100  ;
                Console.WriteLine(artanpara);
                Console.WriteLine("Kac defa ögle yemegı yedınız:");
                ymksys = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yemek parası:");
                ögleyemegıfyt = 50 * ymksys;
                Console.WriteLine(ögleyemegıfyt);
               

            }
           else  if (odasys==2)
            {
                Console.WriteLine("2 oda ıcın 200 lıra ucret odenmektedır.");
                Console.WriteLine("Odenen ucret:");
                ödenenpara = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Paranın artanı:");
                artanpara = ödenenpara - 200;
                Console.WriteLine(artanpara);
            }
           else   if (odasys==3)
            {
                Console.WriteLine(" e oda ıcın 350 lıra ücret odenmektedır.");
                Console.WriteLine("Odenen ucret:");
                ödenenpara = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Paranın artanı:");
                artanpara = ödenenpara - 350;
                Console.WriteLine(artanpara);

            }
           else   if (odasys==4)
            {
                Console.WriteLine(" 4 oda ıcın 500lıra ücret odenmektedır.");
                Console.WriteLine("Odenen ucret:");
                ödenenpara = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Paranın artanı:");
                artanpara = ödenenpara - 500;
                Console.WriteLine(artanpara);
            }
            Console.ReadLine();
        }
    }
}
