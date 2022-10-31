using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace JsonOppgave
{
    public class VerkstedControll
    {
        //public List<Verksted> verkstedList = new List<Verksted>();

        public List<Komuner> komuneList = new List<Komuner>()
        {
            new Komuner("Oslo", 1),
            new Komuner("Akershus", 2),
            new Komuner("Østfold", 3),
            new Komuner("Hedmark", 4),
            new Komuner("Oppland", 5),
            new Komuner("Buskerud", 6),
            new Komuner("Vestfold", 7),
            new Komuner("Telemark", 8),
            new Komuner("Rogaland", 9),
            new Komuner("Vest-Agder", 10),
            new Komuner("Aust-Agder", 11),
            new Komuner("Hordaland", 12),
            new Komuner("Sogn og Fjordane", 13),
            new Komuner("Møre og Romsdal", 14),
            new Komuner("Sør Trøndelag", 15),
            new Komuner("Nord Trøndelag", 16),
            new Komuner("Norland", 17),
            new Komuner("Troms", 18),
            new Komuner("Finnmark", 19),
        };

        public VerkstedControll()
        {
            var fileName = $"verkstedfil.json";
            var jsonString = File.ReadAllText(fileName);
            Komuner.verkstedList = JsonSerializer.Deserialize<List<Verksted>>(jsonString)!;
        }

        public void Test()
        {

            foreach (var komune in komuneList)
            {
                foreach (var verksted in Komuner.verkstedList)
                {
                    int postnummer = int.Parse(verksted.Postnummer);

                    if (komune.KomuneNr == 1)
                    {
                        verksted.PrintVerksted();
                    }
                }
            }
        }

        //public void Test()
        //{
        //    var userInput = Convert.ToInt32(Console.ReadLine());

        //    foreach (var verkste in verksted)
        //    {
        //        int postnummer = int.Parse(verkste.Postnummer);

        //        if (userInput == 1)//oslo
        //        {
        //            if(postnummer >= 0001 && postnummer <= 1299) verkste.PrintVerksted();
        //        }
        //        if (userInput == 2)//akershus
        //        {
        //            if (postnummer >= 1300 && postnummer <= 1500) verkste.PrintVerksted();
        //            if (postnummer >= 1900 && postnummer <= 2100) verkste.PrintVerksted();
        //        }
        //        if (userInput == 3)//østfold
        //        {
        //            if (postnummer >= 1501 && postnummer <= 1899) verkste.PrintVerksted();
        //        }
        //        if (userInput == 4)//hedmark
        //        {
        //            if (postnummer >= 2101 && postnummer <= 2600) verkste.PrintVerksted();
        //        }
        //        if (userInput == 5)//oppland
        //        {
        //            if (postnummer >= 2601 && postnummer <= 2900) verkste.PrintVerksted();
        //            if (postnummer >= 3500 && postnummer <= 3599) verkste.PrintVerksted();
        //        }
        //        if (userInput == 6)//buskerud
        //        {
        //            if (postnummer >= 3000 && postnummer <= 3050) verkste.PrintVerksted();
        //            if (postnummer >= 3300 && postnummer <= 3499) verkste.PrintVerksted();
        //        }
        //        if (userInput == 7)//vestfold
        //        {
        //            if (postnummer >= 3051 && postnummer <= 3299) verkste.PrintVerksted();
        //        }
        //        if (userInput == 8)//telemark
        //        {
        //            if (postnummer >= 3600 && postnummer <= 3999) verkste.PrintVerksted();
        //        }
        //        if (userInput == 9)//rogaland
        //        {
        //            if (postnummer >= 4000 && postnummer <= 4450) verkste.PrintVerksted();
        //            if (postnummer >= 5500 && postnummer <= 5599) verkste.PrintVerksted();
        //        }
        //        if (userInput == 10)//vest-agder
        //        {
        //            if (postnummer >= 4451 && postnummer <= 4750) verkste.PrintVerksted();
        //        }
        //        if (userInput == 11)//aust-agder
        //        {
        //            if (postnummer >= 4751 && postnummer <= 4999) verkste.PrintVerksted();
        //        }
        //        if (userInput == 12)//hordaland
        //        {
        //            if (postnummer >= 5000 && postnummer <= 5499) verkste.PrintVerksted();
        //            if (postnummer >= 5551 && postnummer <= 5750) verkste.PrintVerksted();
        //            if (postnummer >= 5800 && postnummer <= 5950) verkste.PrintVerksted();
        //        }
        //        if (userInput == 13)//sogn og fjordane
        //        {
        //            if (postnummer >= 5751 && postnummer <= 5799) verkste.PrintVerksted();
        //            if (postnummer >= 5951 && postnummer <= 5999) verkste.PrintVerksted();
        //            if (postnummer >= 6700 && postnummer <= 6999) verkste.PrintVerksted();
        //        }
        //        if (userInput == 14)//møre og romsdal
        //        {
        //            if (postnummer >= 6000 && postnummer <= 6699) verkste.PrintVerksted();
        //        }
        //        if (userInput == 15)//Sør trøndelag
        //        {
        //            if (postnummer >= 7000 && postnummer <= 7550) verkste.PrintVerksted();
        //            if (postnummer >= 7700 && postnummer <= 7750) verkste.PrintVerksted();
        //        }
        //        if (userInput == 16)//nord trøndelag
        //        {
        //            if (postnummer >= 7551 && postnummer <= 7699) verkste.PrintVerksted();
        //            if (postnummer >= 7751 && postnummer <= 7950) verkste.PrintVerksted();
        //        }
        //        if (userInput == 17)//nordland
        //        {
        //            if (postnummer >= 7951 && postnummer <= 8450) verkste.PrintVerksted();
        //            if (postnummer >= 8500 && postnummer <= 8999) verkste.PrintVerksted();
        //        }
        //        if (userInput == 18)//troms
        //        {
        //            if (postnummer >= 8451 && postnummer <= 8499) verkste.PrintVerksted();
        //            if (postnummer >= 9000 && postnummer <= 9150) verkste.PrintVerksted();
        //            if (postnummer >= 9200 && postnummer <= 9499) verkste.PrintVerksted();
        //        }
        //        if (userInput == 19)//finnmark
        //        {
        //            if (postnummer >= 9151 && postnummer <= 9199) verkste.PrintVerksted();
        //            if (postnummer >= 9500 && postnummer <= 9999) verkste.PrintVerksted();
        //        }
        //    }
        //}
    }
}
