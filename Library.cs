using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project_First_Year
{
    public class Library
    {
        public static List<string> Terms = new List<string>();
        public static List<string> Definition = new List<string>();

        public static void LoadKomfilPreset()
        {
            Terms.Add("Lope K. Santos");
            Definition.Add("Siya ay naging punong-tagapangasiwa ng SWP noong 1941 -1946. ");

            Terms.Add("Cecilio Lopez");
            Definition.Add("ang pinakaunang linggwistang Pilipino");

            Terms.Add("Ponciano B. Pineda");
            Definition.Add("Itinuturing na \"Ama ng Komisyon sa Wikang Filipino\". ");

            Terms.Add("Cmo 20, Serye Ng 2013");
            Definition.Add("Nilagdaan ni Komisyuner Patricia Licuanan");

            Terms.Add("Komunikasyong Berbal");
            Definition.Add("Ito ay ginagamitan ng wika na maaaring pasulat at maaari rin namang pasalita.");
        }
    }

}
