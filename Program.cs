 class Program
    {
        public static string? GlobalChoixUser;
        public static bool ContinueALancer = true;
        public static Random random = new Random();
        public static List<string> ObjetTrouver = new List<string>();
        public static int NombreInitialDePointDeVie = 3;
        public static string? ReponseAUser;
        public static int QuestionCounter = 0;

        /* Tout les questions ici avec reponse et objet trouver */
         public static List<Question> Questions = new List<Question>()
         {
             new Question(
                 "Je suis quelque chose que vous cassez avant de pouvoir m’utiliser. Qui suis-je ?",
                 new List<string>() {
                        "Une noix",
                        "Un oeuf",
                        "Une boîte"
                 },
                 "Un oeuf",
                 "un cafe"),
                 new Question(
                 "J’ai des clés mais je n’ouvre aucune serrure. Qui suis-je ?",

                 new List<string>() {
                        "Un piano",
                        "Un clavier",
                        "Une porte"
                 },
                 "Un clavier",
                 "un telephone"),

                  new Question(
                 "Plus je suis grand, moins j’existe. Qui suis-je ?",
                  new List<string>() {
                        "Un trou.",
                        "Un chien",
                        "Un enfant"
                  },
                 "Un chien",
                 "une maison"),
                  new Question(
                 "Peu importe que tu t'inclines devant les gens ou pas... L'important c'est de veiller sur les autres",
                  new List<string>() {
                        "Naruto",
                        "Sangoku",
                        "Loffi"
                  },
                 "Naruto",
                 "une pomme de france"),
                  new Question(
                 "Même si je suis loin, mon coeur reste avec toi ?",
                  new List<string>() {
                        "Minato Namikaze",
                        "Kushina Uzumaki",
                        "Itach Uchiha"
                  },
                 "tach Uchiha",
                 "une tele"),
                  new Question(
                 "Être seul fait plus mal que la douleur?",
                  new List<string>() {
                        "Anzo",
                        "vegeta",
                        "Arthur Morgan"
                  },
                 "Anzo",
                 "une maison"),
                  new Question(
                 "Vivre n'est pas un crime ?",
                  new List<string>() {
                        "Sammy.",
                        "Togo Lando",
                        "Eve smartty"
                  },
                 "Sammy",
                 "une ecole"),
                  new Question(
                 "Le seul qui peut me battre, c'est moi ?",
                  new List<string>() {
                        "Uchiha Sasuke",
                        "Naruto",
                        "Sarada Uchiha"
                  },
                 "Uchiha Sarada",
                 "une maison"),
                  new Question(
                 "Mes ordres sont absolus ?",
                  new List<string>() {
                        "Akashi",
                        "Kuroko ",
                        "Kagami"
                  },
                 "Akashi",
                 "une maison"),
                                    new Question(
                 "Le roi des pirates, ce sera moi ?",
                  new List<string>() {
                        "Luffi",
                        "Un chien",
                        "Une enfant"
                  },
                 "Luffi",
                 "un laptop gamer zone"),
         };
         public static List<string> ObjetTrouvers = new List<string>();
        /* Tout les questions ici avec reponse et objet trouver */



        static void Main(string[] args)
        {

            do
            {
                ManuelUser();
                // RandomNumber();
                Console.WriteLine("Entrer L'option ici [ A, B, Q ] :".ToUpper());
                GlobalChoixUser = Console.ReadLine();

                switch (GlobalChoixUser)
                {
                    case "A":
                    case "a":
                        ResolutionEnigmes();
                        break;
                    case "B":
                    case "b":
                        TousLesObjetsTrouver(ObjetTrouver);
                        break;
                    case "Q":
                    case "q":
                        ContinueALancer = false;
                        break;
                    default:
                        Console.WriteLine($"Desoler mais le choix [{GlobalChoixUser}] n'existe pas..");
                        break;
                }


            } while (ContinueALancer != false);



        }



        /* Résolution d’énigmes : @SOH TAGNE ACHILLE IVES ET SIM FREDERICK*/

        public static void ResolutionEnigmes()
        {
            /* Ok travaillions avec les questions et les reponse ici */
            int Index = -1;
            // string? StateReponse = "";

            

            do
            {
                Index = Index + 1;
                var radomize = random.Next(0, Questions.Count());
                Console.WriteLine("MY NEW RANDOM IS " + radomize);
                //Console.WriteLine(Index);
                //Console.WriteLine(radomize);
                var question = Questions[radomize].QuestionName;
                Console.WriteLine(question);
                QuestionCounter = QuestionCounter + 1;
                /*  --- possibilities abswers ----  */
                var Reponses = Questions[radomize].Answers;

                for(int i = 0; i < Reponses.Count(); i ++)
                {
        
                    Console.WriteLine($"[* {Reponses[i]} *]");
                    // StateReponse = Reponses[i];
                }
                // Console.WriteLine("Numnber of questions " + Questions.Count());
                // Console.WriteLine("Current Question " + QuestionCounter);
                ReponseAUser =  Console.ReadLine();


                
                if (ReponseAUser?.ToLower() == Questions[radomize].CorrectAnswers.ToLower())
                {
                //    Console.WriteLine(" Voici ton Objet ici " +Questions[radomize].Objets);
                //    Je pense que ici est claire, j'ajoute lobjet trouver dans le pagner 
                   Console.WriteLine("Success | Bonne Reponse |");
                   ObjetTrouver.Add(Questions[radomize].Objets);
                }
                else
                {
                    NombreInitialDePointDeVie--;
                    Console.WriteLine("**Erreur | Mauvaise Reponse |");

                }

                if(NombreInitialDePointDeVie == 0)
                {
                    Console.WriteLine($"Il vous reste {NombreInitialDePointDeVie} poits de vie".ToUpper());
                    Console.WriteLine("Vous n'avez plus des points de vie:".ToUpper() + NombreInitialDePointDeVie);
                    Console.WriteLine("Game Over ".ToUpper());
                    NombreInitialDePointDeVie = 3;
                    // ContinueALancer = false;
                    return;
                    
                }

                if(QuestionCounter >= Questions.Count() )
                {
                    
                    Console.WriteLine(" ");
                    Console.WriteLine(" **JEUX TERMINER** "); 
                    Console.WriteLine($"Vous avez un score de ({QuestionCounter} / {Questions.Count()}) ");
                    NombreInitialDePointDeVie = 3;
                    Console.WriteLine(" ");
                    return;
                    
                }

                

            } while ( Index < Questions.Count() && NombreInitialDePointDeVie != 0);


        }

        // public static void RandomNumber()
        // {
        //     Random randoms = new Random();
        //     var ran = randoms.Next(0, 10);
        //     Console.WriteLine(ran);

        // }

        public static void ManuelUser()
        {
            Console.WriteLine("Welcome to [ **** ] application ".ToUpper());
            Console.WriteLine(" ");
            Console.WriteLine("[ A ] POUR RESOUDRE UNE EGNIME");
            Console.WriteLine("[ B ] POUR VOIR LES OBJETS TROUVERS");
            Console.WriteLine("[ Q ] POUR QUITTER LE PROGRAMME");
            Console.WriteLine(" ");
        }

    public static void TousLesObjetsTrouver(List<string> ObjetsTrouver)
    {
        Console.WriteLine(" ");
        if(ObjetsTrouver.Count != 0)
        {
            Console.WriteLine($" Voici vos objets: tota: |{ObjetsTrouver.Count()}|  ".ToUpper());
            for(int i = 0; i < ObjetsTrouver.Count(); i++)
            {
                Console.WriteLine($"[{i + 1}] || {ObjetsTrouver[i]}");
            }
        }else
        {
            Console.WriteLine("Objets trouver".ToUpper() + ObjetsTrouver.Count());
            Console.WriteLine("Vous navez pas d'objets trouver pour le moment".ToUpper());

        }

        Console.WriteLine(" ");
        
    }
    }





/*  j'ai cree cette class pour pourvoir bien gerer la creations des questions */
/* Developpeur Soh Tagne Achille Et Sim Frederick */
class Question
{
    public string QuestionName { get; private set; }
    public List<string> Answers { get; private set; }
    public string CorrectAnswers { get; private set; }
    public string Objets { get; private set; }

    

    public Question(string questionName,List<string> answers, string correctAnswer,
            string objet_)
    {
        QuestionName = questionName;
        Answers = answers;
        CorrectAnswers = correctAnswer;
        Objets = objet_;
    }
}