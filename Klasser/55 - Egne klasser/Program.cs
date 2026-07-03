using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _55___Egne_klasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Clear();
                string w = "Vil du arbejde med: ";
                Write($"{w}" +
                    "\n\n1. Rektangler" +
                    "\n2. Trekanter" +
                    "\n3. Cirkler" +
                    "\n4. Cylinder" +
                    "\n5. Rumfanget af en kasse" +
                    "\n6. Afslut programmet");
                
                SetCursorPosition(w.Length, 0);
                string input = ReadLine();

                if (input == "6")
                    break;

                switch (input)
                {
                    case "1":
                        SwitchCases.Rektangler();
                        break;

                    case "2":
                        SwitchCases.Trekanter();
                        break;

                    case "3":
                        SwitchCases.Cirkler();
                        break;

                    default:
                        Clear();
                        Write($"Du har indtastet: {input}\n\nTryk enter for at gå tilbage.");
                        break;
                }
            }
        }
    }
    public class SwitchCases
    {
        static private double IndhentMål(string info)
        {
            double mål;
            while (true)
            {
                Clear();
                Write(info);
                string input = ReadLine();

                if (double.TryParse(input, out mål))
                    return mål;

                Clear();
                Write($"Du har indtastet: {input}\n\nTryk enter for at prøve igen.");
                ReadKey();
            }
        }
        static private string LængdeEnhed()
        {
            Write("\nHvilken længdeenhed vil du have resultatet udskrevet med? (f.eks. cm, m, km) ");
            string længdeEnhed = ReadLine();
            return længdeEnhed;
        }
        static public void Rektangler()
        {
            Clear();
            WriteLine("Her kan du indtaste to kendte sider på et rektangel, for at få udregnet dets omkreds og areal." +
                "\nDu skal bruge siderne b (bredden) og l (længden)");
            string længdeEnhed = LængdeEnhed();

            
            double l = IndhentMål("Indtast længden: ");
            double b = IndhentMål("Indtast bredden: ");

            Clear();
            Write($"Rektanglets omkreds er: {Matematik.RektangelOmkreds(l, b):0.##} {længdeEnhed}" +
                $"\n\nRektanglets areal er: {Matematik.RektangelAreal(l, b):0.##} {længdeEnhed}\u00B2" +
                $"\n\nTryk enter for at returnere til hovedmenuen.");
            ReadKey();
        }
        static public void Trekanter()
        {
            Clear();
            WriteLine("Her kan du indtaste grundlinjen og højden på en trekant, for at få udregnet arealet.");
            string længdeEnhed = LængdeEnhed();

            double g = IndhentMål("Indtast grundlinjen: ");
            double h = IndhentMål("Indtast højden: ");

            Clear();
            Write($"Trekantens areal er: {Matematik.TrekantAreal(g, h):0.##} {længdeEnhed}\u00B2" +
                $"\n\nTryk enter for at returnere til hovedmenuen.");
            ReadKey();
        }
        static public void Cirkler()
        {
            Clear();
            WriteLine("Her kan du indtaste en cirkels radius, for at få udregnet dens omkreds og areal.");
            string længdeEnhed = LængdeEnhed();

            double r = IndhentMål("Indtast radius: ");
            
            Clear();
            Write($"Cirklens omkreds er: {Matematik.CirkelOmkreds(r):0.##} {længdeEnhed}" +
                $"\n\nCirklens areal er: {Matematik.CirkelAreal(r):0.##} {længdeEnhed}\u00B2" +
                $"\n\nTryk enter for at returnere til hovedmenuen.");
            ReadKey();
        }
    }
    public class Matematik
    {
        static public double RektangelOmkreds(double l, double b)
        {
            double omkreds = l * 2 + b * 2;
            return omkreds;
        }
        static public double RektangelAreal(double l, double b)
        {
            double areal = l * b;
            return areal;
        }
        static public double TrekantAreal(double g, double h)
        {
            double areal = g * h * 0.5;
            return areal;
        }
        static public double CirkelOmkreds(double r)
        {
            double omkreds = Math.PI * 2 * r;
            return omkreds;
        }
        static public double CirkelAreal(double r)
        {
            double areal = Math.PI * Math.Pow(r, 2);
            return areal;
        }
    }
}
