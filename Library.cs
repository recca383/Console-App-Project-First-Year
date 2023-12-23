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

            Terms.Add("DLSU, UP-D, ADMU, UST, At PUP");
            Definition.Add("Itinuturing na pinakamalakas at pinakamaaasahang balwarte ng Tanggol Wika.");

            Terms.Add("Batas Republika 7356");
            Definition.Add("Ang Batas na Lumilikha sa Pambansang Komisyon ng Kultura at Sining-National Commission for Culture and the Arts...");

            Terms.Add("Komunikasyon");
            Definition.Add("Ang proseso ng pagpapabatid ng mensahe mula sa tagapaghatid tungo sa tagatanggap nito.");

            Terms.Add("Communis");
            Definition.Add("Ang kahulugan sa Ingles ay \"ordinary\" at \"karaniwan\" naman kapag isinalin sa Filipino.");

            Terms.Add("Komunikasyong Di-Berbal");
            Definition.Add("Kinasasangkutan naman ng mga kilos o galaw ng katawan ang uri ng komunikasyong ito.");

            Terms.Add("Intrapersonal Na Komunikasyon");
            Definition.Add("Kinakausap ng tao ang kanyang sarili sa pagnanais na higit na maging produktong indibidwal.");

            Terms.Add("Interpersonal Na Komunikasyon");
            Definition.Add("Ang ugnayang komunikasyon ng isang tao sa iba pang tao.");

            Terms.Add("Komunikasyong Pampubliko");
            Definition.Add("Ugnayang komunikasyon sa pagitan ng isang tao at dalawa o higit pang katao.");

            Terms.Add("Primaryang Datos");
            Definition.Add("Mga datos na hinalaw o nagmula sa mga dokumentong isinulat sa panahon na isinasagawa ang aktwal na pananaliksik.");

            Terms.Add("Sekondaryang Datos");
            Definition.Add("Mga datos na nanggaling sa mga dokumentong isinulat matapos ang isang kaganapan.");

            Terms.Add("Tersyaryang Datos");
            Definition.Add("Tumutukoy sa mga datos na hinalaw sa mga dokumentong naglalarawan sa mga primarya at sekondaryong sanggunian.");

        }

        public static void LoadITEC101Preset()
        {
            Terms.Add("Platform");
            Definition.Add("It refers to a category of technologies which are used as a foundation for the development of other applications, software, systems, and processes.");

            Terms.Add("Smartphone");
            Definition.Add("It is a combination of a mobile phone and a handheld computer into a Single device (Beal, 2015).");

            Terms.Add("Web Platforms");
            Definition.Add("Platform that offers services that are useful for websites and web related applications, such as web servers, content delivery Networks and edge computing.");

            Terms.Add("Computing Platforms");
            Definition.Add("Designed on top of the operating system, the software offers computing capabilities in areas such as cloud computing and virtualization.");

            Terms.Add("Analytics");
            Definition.Add("Data capturing, processing, analyzing and visualizing services. ");

            Terms.Add("Game Platforms");
            Definition.Add("Environments that are designed for running gaming services such as mobile gaming backends or massively multiplayer online Gaming.");

            Terms.Add("Robotics");
            Definition.Add("Robot platforms may include a robot operating system and a framework for the development and deployment of a backend system and Robot services on a cloud infrastructure.");

            Terms.Add("Database Platforms");
            Definition.Add("Cloud platform for deploying and managing multiple types of databases, such as relational. No Sql databases and in-memory Databases.");

            Terms.Add("Mobile Platforms");
            Definition.Add("Includes a mobile operating system and mobile device building environments.");

            Terms.Add("Media Platforms");
            Definition.Add("Media publishing and analysis platform with technologies such as video transcoding, streaming and recognition.");     
        }
    }

}
