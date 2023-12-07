namespace TvShop;

class Program
{
    public class Agent //Osztály az ügynökök létrehozásához
    {
        const int BASE = 30001; //Alap és közép minősítést meghatározó határértékek
        const int MID = 40001;

        public string name;
        public int classification_number;
        public string classification;

        public Agent(string c_name, int c_classification_number) //Konstruktor, hogy értéket adhassunk inicializálásnál
        {
            name = c_name;
            classification_number = c_classification_number;

            if (classification_number < BASE) //Logikai behatárolás (Így legalább ténylegesen lesz címkéje)
            {
                classification = "Alap";
            }
            else if (classification_number < MID)
            {
                classification = "Közép";
            }
            else if (classification_number > MID)
            {
                classification = "Emelt";
            }
            else
            {
                classification = "NaN";
            }
        }
    }

    const int START = 20000; //Minimum és maximum random generált szám tartományi határérték
    const int END = 50000;

    static void Main(string[] args)
    {
        Random rnd = new Random();
        List<Agent> agents = new List<Agent>();

        int number_of_agents;
        while (true)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine("| Adja meg a minősítendő eladók számát: --- |");
            Console.WriteLine("+-------------------------------------------+");
            Console.SetCursorPosition(40, 1);
            try
            {
                number_of_agents = Convert.ToInt32(Console.ReadLine());
                if (number_of_agents <= 0)
                {
                    Console.SetCursorPosition(0, 4);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nullánál nagyobb értéket adjon meg!\nPróbálja újra!");
                    Console.ResetColor();
                    continue;
                }
                break;
            }
            catch (Exception)
            {
                Console.SetCursorPosition(0, 4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hiba lépett fel az ügynökök számának megadásában!\nPróbálja újra!");
                Console.ResetColor();
                continue;
            }
        }

        string? agent_name; //A kérdőjel '?' arra van, hogy ne lehessen nullable az agent_name (kell oda, ne vedd ki)
        for (int i = 0; i < number_of_agents; i++)
        {
            while (true) //Ha ilyet, vagy hasonlót látsz, arra van hogy ellenőrizze az inputot
            {
                Console.SetCursorPosition(0, 0);

                if (i < 9)
                {
                    Console.WriteLine("+--------------------------------------------------------------------+");
                    Console.WriteLine($"| Adja meg a(z) {i + 1}. minősítendő eladók nevét: _______________________ |");
                    Console.WriteLine("+--------------------------------------------------------------------+");
                    Console.SetCursorPosition(45, 1);
                }
                else
                {
                    Console.WriteLine("+---------------------------------------------------------------------+");
                    Console.WriteLine($"| Adja meg a(z) {i + 1}. minősítendő eladók nevét: _______________________ |");
                    Console.WriteLine("+---------------------------------------------------------------------+");
                    Console.SetCursorPosition(46, 1);
                }

                try
                {
                    agent_name = Console.ReadLine();

                    if (agent_name == null || agent_name == "")
                    {
                        Console.SetCursorPosition(0, 4);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\rA név megadása kötelező!");
                        Console.ResetColor();
                        continue;
                    }
                    else
                    {
                        agents.Add(new Agent(agent_name, rnd.Next(START, END))); //Értékadás
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.SetCursorPosition(0, 4);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hiba lépett fel a név megadásában!\nPróbálja újra!");
                    Console.ResetColor();
                    continue;
                }
            }
        }

        Console.Clear();

        int switch_on;
        while (true)    //Zöme itt kezdődnek a kiiratások
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|     Kiiratási menü     |");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("| 1: Alap                |");
            Console.WriteLine("| 2: Közép               |");
            Console.WriteLine("| 3: Emelt               |");
            Console.WriteLine("| 4: Összes              |");
            Console.WriteLine("| 5: Kilép               |");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("| Választott menüpont: - |");
            Console.WriteLine("+------------------------+");
            Console.SetCursorPosition(23, 9);

            try
            {
                switch_on = Convert.ToInt32(Console.ReadLine());
                if (switch_on < 0 || switch_on > 5)
                {
                    Console.SetCursorPosition(0, 12);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Kérem a menüpontok sorszámai közül válasszon!");
                    Console.ResetColor();
                    continue;
                }
            }
            catch (Exception)
            {
                Console.SetCursorPosition(0, 12);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hiba lépett fel a menüpont kiválasztása során!\nPróbálja újra!");
                Console.ResetColor();
                continue;
            }

            if (switch_on != 5)
            {
                switch (switch_on) //User menü
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("+----------------------------------------------------------+");
                        Console.WriteLine("| Alap minősítésű ügynökök név és betelefonálószám szerint |");
                        Console.WriteLine("+----------------------------------------------------------+\n");
                        foreach (var item in agents)
                        {
                            if (item.classification == "Alap")
                            {
                                Console.WriteLine("+----------------------------------------+");
                                Console.WriteLine("|Név: {0}", item.name);
                                Console.WriteLine("|Betelefonálószám: {0}", item.classification_number);
                                Console.WriteLine("+----------------------------------------+");
                            }
                        }
                        Console.WriteLine("\n\nNyomjon egy Enter-t a visszalépéshez...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("+-----------------------------------------------------------+");
                        Console.WriteLine("| Közép minősítésű ügynökök név és betelefonálószám szerint |");
                        Console.WriteLine("+-----------------------------------------------------------+\n");
                        foreach (var item in agents)
                        {
                            if (item.classification == "Közép")
                            {
                                Console.WriteLine("+----------------------------------------+");
                                Console.WriteLine("|Név: {0}", item.name);
                                Console.WriteLine("|Betelefonálószám: {0}", item.classification_number);
                                Console.WriteLine("+----------------------------------------+");
                            }
                        }
                        Console.WriteLine("\n\nNyomjon egy Enter-t a visszalépéshez...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("+-----------------------------------------------------------+");
                        Console.WriteLine("| Emelt minősítésű ügynökök név és betelefonálószám szerint |");
                        Console.WriteLine("+-----------------------------------------------------------+\n");
                        foreach (var item in agents)
                        {
                            if (item.classification == "Emelt")
                            {
                                Console.WriteLine("+----------------------------------------+");
                                Console.WriteLine("|Név: {0}", item.name);
                                Console.WriteLine("|Betelefonálószám: {0}", item.classification_number);
                                Console.WriteLine("+----------------------------------------+");
                            }
                        }
                        Console.WriteLine("\n\nNyomjon egy Enter-t a visszalépéshez...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("+------------------------------------------------------------+");
                        Console.WriteLine("|Az összes ügynök minősítés, név és betelefonálószám szerint |");
                        Console.WriteLine("+------------------------------------------------------------+\n");
                        foreach (var item in agents)
                        {
                            Console.WriteLine("+----------------------------------------+");
                            Console.WriteLine("|Minősítés: {0}", item.classification);
                            Console.WriteLine("|Név: {0}", item.name);
                            Console.WriteLine("|Betelefonálószám: {0}", item.classification_number);
                            Console.WriteLine("+----------------------------------------+");
                        }
                        Console.WriteLine("\n\nNyomjon egy Enter-t a visszalépéshez...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            else if (switch_on == 5)
            {
                break;
            }
        }
    }
}

