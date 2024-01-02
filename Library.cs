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

            Terms.Add("Kom. Licuanan");
            Definition.Add("Ipinaliwanag niya na hindi naman daw naging tahasan ang pagkawala ng Filipino sa kurikulum dahil may inilaan para rito sa ika-11 at 12 baitang ng pag-aaral sa Senior High School.");

            Terms.Add("PCSPE");
            Definition.Add("Ahensyang binuo sa pamamagitan ng E.O. 202 ni Pangulong Ferdinand E. Marcos upang magsagawa ng pag-aaral sa mabuting sistema ng edukasyon, na wika ng pagtuturo ang siyang nangangailangan ng agarang atensyon sa larangan ng edukasyon. ");

            Terms.Add("Komisyon Sa Wikang Filipino");
            Definition.Add("Ang ahensya ng gobyerno na binigyan ng kapangyarihan na makapagmungkahi ng mga hakbang, plano, patakaran, at gawain hinggil sa wika");

            Terms.Add("Batas Pambansa 232");
            Definition.Add("Ang Batas na Nilikha para sa Pagtatag at Pagpapanatili ng Sistemang Integratibo ng Edukasyon.");

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

        public static void LoadITEC102Preset()
        {
            Terms.Add("Computer Program");
            Definition.Add("A program is a set of instructions following the rules of the chosen language.");

            Terms.Add("Programming Language");
            Definition.Add("A system of signs used by a person to communicate a task/algorithm to a computer, causing the task to be performed (Albacea, 2006)");

            Terms.Add("Computer Programming");
            Definition.Add("Computer programming is the process of writing, testing, debugging/troubleshooting, and maintaining the source code of computer programs.");

            Terms.Add("Computer Programmer");
            Definition.Add("A programmer is someone who writes computer program.");

            Terms.Add("Machine Language");
            Definition.Add("Low-Level language is the only language which can be understood by the computer.");

            Terms.Add("Assembly Language");
            Definition.Add("Middle-level language is a computer language in which the instructions are created using symbols such as letters, digits and special characters.");

            Terms.Add("High Level Language");
            Definition.Add("High-level language is a computer language which can be understood by the users");

            Terms.Add("Critical Thinking");
            Definition.Add("Using logic and analysis to identify the strengths and weaknesses of different approaches.");

            Terms.Add("Written Comprehension ");
            Definition.Add("The ability to read and understand information and ideas presented in writing.");

            Terms.Add("Program Development");
            Definition.Add("Creating application programs is referred to as");

            Terms.Add("Flowcharts");
            Definition.Add("Illustrate step-by-step logic in a program.");

            Terms.Add("Wireframes");
            Definition.Add("Visual representation of application design.");

            Terms.Add("Pseudocode");
            Definition.Add("Expresses steps in English-like statements.");

            Terms.Add("Sequence Control Structure");
            Definition.Add("Series of statements that follow one another.");

            Terms.Add("Selection Control Structure");
            Definition.Add("The direction will depend on the results of a certain condition.");

            Terms.Add("Repetition Control Structure");
            Definition.Add("One or more statements are to be repeated in a loop until a particular condition is reached.");

            Terms.Add("Debugging");
            Definition.Add("The process of ensuring a program is free of errors, or bugs.");

            Terms.Add("Compiler");
            Definition.Add("A language translator that converts an entire program into machine language before executing it.");

            Terms.Add("Interpreter");
            Definition.Add("A language translator that converts program statements line-by-line into machine language, immediately executing each statement.");

            Terms.Add("Assembler");
            Definition.Add("It converts assembly language statements into machine language.");
        }

        public static void LoadPathfitPreset()
        {
            Terms.Add("Exercise");
            Definition.Add("Any physical activity that enhances or maintains physical fitness and overall health.");

            Terms.Add("MFIT");
            Definition.Add("Stands for Mode or type of exercise, frequency, and time or in some references it’s also called FITT or frequency, intensity, time, and type.");

            Terms.Add("Health-Related Component of Physical Fitness");
            Definition.Add("Refers to aspects of physical fitness that are associated with good health and reduced risk of chronic diseases.");

            Terms.Add("Body Composition");
            Definition.Add("Refers to the proportion of fat, muscle, bone, and other tissues that make up a person's body.");

            Terms.Add("Cardiorespiratory Endurance");
            Definition.Add("It is a crucial component of overall physical fitness and is essential for performing activities that require a continuous supply of oxygen, such as running, swimming, cycling, and other aerobic exercises.");

            Terms.Add("Flexibility");
            Definition.Add("The ability of a joint or a series of joints to move through a full range of motion.");

            Terms.Add("Muscular Endurance");
            Definition.Add("The ability of a muscle or group of muscles to repeatedly exert force over an extended period. Muscular endurance is essential for activities that involve sustained muscle contractions, such as cycling and long-distance running.");

            Terms.Add("Muscular Strength");
            Definition.Add("The amount of force a muscle or group of muscles can exert against a resistance in a single effort.");

            Terms.Add("Specifity");
            Definition.Add("This principle emphasizes the need for tailoring exercise programs to achieve specific goals or improvements in particular fitness components or skills.");

            Terms.Add("Overload");
            Definition.Add("Involves progressively increasing the intensity, duration, or frequency of exercise to challenge the body and stimulate further improvements in fitness.");

            Terms.Add("Progression");
            Definition.Add("This principle is closely linked to overload and suggests that exercise intensity, duration, or frequency should be gradually increased over time to prevent plateaus and promote continued improvement.");

            Terms.Add("Individualization");
            Definition.Add("Acknowledges that each person has unique fitness goals, physical abilities, and limitations.");

            Terms.Add("Rest and Recovery");
            Definition.Add("Vital for allowing the body to repair and strengthen itself following exercise.");

            Terms.Add("Cool Down");
            Definition.Add("A set of exercises or activities performed at the end of a workout session to gradually reduce the heart rate and return the body to its pre-exercise state.");

            Terms.Add("Warm up");
            Definition.Add("A set of exercises or activities performed at the beginning of a workout session to prepare the body for more intense physical activity.");

            Terms.Add("Skills-Related Component of Physical Fitness");
            Definition.Add("Aspects of physical fitness that contribute to successful performance in sports and other activities. These components include agility, balance, coordination, power, reaction time, and speed.");

            Terms.Add("Agility");
            Definition.Add("Refers to the ability to move quickly and easily.");

            Terms.Add("Balance");
            Definition.Add("Refers to the ability to maintain control of the body's position while performing various movements or activities.");

            Terms.Add("Coordination");
            Definition.Add("The ability to synchronize different parts of the body to perform tasks smoothly and efficiently.");

            Terms.Add("Power");
            Definition.Add("The ability to exert force quickly, combining both strength and speed.");
        }
    }

}
