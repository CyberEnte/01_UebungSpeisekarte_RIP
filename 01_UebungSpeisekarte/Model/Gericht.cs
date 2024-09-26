using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_UebungSpeisekarte.Model
{
    public  class Gericht
    {

        public DateTime Datum { get; set; } = default;
        public String Essen { get; set; } = default;
        public double Preis { get; set; } = default;

        public Gericht(DateTime datum, string gericht, double preis)
        {
            this.Datum = datum;
            this.Essen = gericht;
            this.Preis = preis;
        }

        //public static List<Gericht> AlleLesen()
        //{
        //    return new List<Gericht>
        //    {
        //        new Gericht(new DateTime(2020,1,12), "Pommes", 2.5),
        //        new Gericht(new DateTime(2020,1,13), "Suppe", 5.51),
        //        new Gericht(new DateTime(2020,2,1), "Pizza Margherita", 8.99),
        //        new Gericht(new DateTime(2020,2,5), "Lasagne", 12.25),
        //        new Gericht(new DateTime(2020,3,3), "Spaghetti Carbonara", 10.30),
        //        new Gericht(new DateTime(2020,3,15), "Chicken Curry", 13.70),
        //        new Gericht(new DateTime(2020,4,10), "Sushi", 20.99),
        //        new Gericht(new DateTime(2020,4,12), "Tacos", 7.45),
        //        new Gericht(new DateTime(2020,4,15), "Enchiladas", 9.10),
        //        new Gericht(new DateTime(2020,5,1), "Burger", 11.25),
        //        new Gericht(new DateTime(2020,5,10), "Schnitzel", 15.50),
        //        new Gericht(new DateTime(2020,5,12), "Risotto", 9.99),
        //        new Gericht(new DateTime(2020,5,20), "Pho", 14.85),
        //        new Gericht(new DateTime(2020,6,2), "Ramen", 12.50),
        //        new Gericht(new DateTime(2020,6,7), "Pad Thai", 13.99),
        //        new Gericht(new DateTime(2020,6,15), "Bibimbap", 11.30),
        //        new Gericht(new DateTime(2020,7,1), "Paella", 16.80),
        //        new Gericht(new DateTime(2020,7,10), "Falafel", 6.75),
        //        new Gericht(new DateTime(2020,7,20), "Moussaka", 13.25),
        //        new Gericht(new DateTime(2020,7,25), "Chili con Carne", 10.50),
        //        new Gericht(new DateTime(2020,8,5), "Steak", 24.99),
        //        new Gericht(new DateTime(2020,8,12), "Fischfilet", 18.75),
        //        new Gericht(new DateTime(2020,8,22), "Pommes Frites", 3.99),
        //        new Gericht(new DateTime(2020,9,1), "Caesar Salad", 8.25),
        //        new Gericht(new DateTime(2020,9,10), "Tomatensuppe", 4.50),
        //        new Gericht(new DateTime(2020,9,15), "Gulasch", 12.75),
        //        new Gericht(new DateTime(2020,9,20), "Lammkoteletts", 19.50),
        //        new Gericht(new DateTime(2020,9,30), "Hähnchenbrust", 10.99),
        //        new Gericht(new DateTime(2020,10,5), "Gemüsecurry", 9.85),
        //        new Gericht(new DateTime(2020,10,12), "Rindfleisch Stroganoff", 17.30),
        //        new Gericht(new DateTime(2020,10,20), "Pulled Pork", 11.50),
        //        new Gericht(new DateTime(2020,10,25), "Bratwurst", 6.50),
        //        new Gericht(new DateTime(2020,11,1), "Gebratener Reis", 9.20)
        //    };
        //}

        public static List<Gericht> AlleLesen()
        {
            List<Gericht> lessen = new List<Gericht>();
            lessen.Add(new Gericht(DateTime.Today, "Kleiner Salat", 5.50));
            lessen.Add(new Gericht(DateTime.Today, "Rucollasalat", 10.90));
            lessen.Add(new Gericht(DateTime.Today, "Scheunensalat", 17.50));
            lessen.Add(new Gericht(new DateTime(2023, 9, 26), "Hotdog-Sandwich", 10.00));
            lessen.Add(new Gericht(new DateTime(2023, 9, 26), "Käse-Sandwich", 5.00));
            lessen.Add(new Gericht(new DateTime(2023, 9, 26), "Butter-Sandwich", 5.00));
            lessen.Add(new Gericht(new DateTime(2023, 9, 26), "Honig-Pfannkuchen", 7.00));
            lessen.Add(new Gericht(new DateTime(2023, 9, 25), "Eier mit Toast", 5.00));
            lessen.Add(new Gericht(new DateTime(2023, 9, 25), "Speck mit Toast", 2.00));
            lessen.Add(new Gericht(new DateTime(2023, 9, 25), "Käse-Omelette", 2.00));
            lessen.Add(new Gericht(new DateTime(2023, 9, 25), "Speck-Omelette", 5.00));
            return lessen;
        }

    }
}
