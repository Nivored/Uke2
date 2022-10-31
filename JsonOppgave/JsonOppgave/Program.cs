namespace JsonOppgave
{
    internal class Program
    {
        private static VerkstedControll verkstedControll = new VerkstedControll();
        static void Main(string[] args)
        {
            MainMenu();
            //while (true)
            //{
            //    MainMenu();
            //}
            
        }

        static void MainMenu()
        {
            //Console.WriteLine("1: Oslo");
            //Console.WriteLine("2: Akershus");
            //Console.WriteLine("3: Østfold");
            //Console.WriteLine("4: Hedmark");
            //Console.WriteLine("5: Oppland");
            //Console.WriteLine("6: Buskerud");
            //Console.WriteLine("7: Vestfold");
            //Console.WriteLine("8: Telemark");
            //Console.WriteLine("9: Rogaland");
            //Console.WriteLine("10: Vest-Agder");
            //Console.WriteLine("11: Øst-Agder");
            //Console.WriteLine("12: Hordaland");
            //Console.WriteLine("13: Sogn og Fjordane");
            //Console.WriteLine("14: Møre og Romsdal");
            //Console.WriteLine("15: Sør Trøndelag");
            //Console.WriteLine("16: Nord Trøndelag");
            //Console.WriteLine("17: Nordland");
            //Console.WriteLine("18: Troms");
            //Console.WriteLine("19: Finnmark");
            verkstedControll.Test();
        }
    }
}