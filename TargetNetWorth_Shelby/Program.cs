using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetNetWorth_Shelby
{
    public class Asset
    {
        public string AssetName { get; set; }   
        public decimal AssetValue { get; set; }  

        public Asset(string assetName, decimal assetValue)
        {
            AssetName = assetName;
            AssetValue = assetValue;
        }

        public override string ToString()
        {
            return $"{AssetName, -10:D} \t {AssetValue.ToString("c")}";
        }
    }

    public class Liability
    {
        public string LiabilityName { get; set; }
        public decimal LiabilityValue { get; set; }

        public Liability(string liabilityName, decimal liabilityValue)
        {
            LiabilityName = liabilityName;
            LiabilityValue = liabilityValue;
        }

        public override string ToString()
        {
            return $"{LiabilityName,-10:D} \t {LiabilityValue.ToString("c")}";
        }
    }


    class Program
    {
        static public void RunProgram()
        {
            int age = 22;
            decimal yearlySalary = 75000.00m;
            decimal targetNetWorth = (age * yearlySalary) * .10m;
            decimal netWorth = 0.0m, compare = 0.0m;
            char choice = '\0';

            List<Asset> objListAsset = new List<Asset>();
            List<Liability> objListLiability = new List<Liability>();
            PopulateLists(ref objListAsset, ref objListLiability);

            netWorth = CalcNetWorth(ref objListAsset, ref objListLiability);
            

            //descending
            objListAsset.Sort((x, y) => y.AssetValue.CompareTo(x.AssetValue));

            Console.WriteLine($"{"Asset", -10:D} {"Value($) DESC", 10:D}");
            foreach (Asset a in objListAsset)
            {
                Console.WriteLine(a);
            }
            //ascending
            //objListAsset.Sort((x, y) => x.AssetValue.CompareTo(y.AssetValue));
            //Console.WriteLine($"{"Asset",-10:D} {"Value($) ASC",10:D}");
            //foreach (Asset a in objListAsset)
            //{
            //    Console.WriteLine(a);
            //}

            //descending lia
            objListLiability.Sort((x, y) => y.LiabilityValue.CompareTo(x.LiabilityValue));
            Console.WriteLine($"{"Liability",-10:D} {"Value($) DESC",10:D}");
            foreach (Liability ab in objListLiability)
            {
                Console.WriteLine(ab);
            }

            ////ascending lia
            //objListLiability.Sort((x, y) => x.LiabilityValue.CompareTo(y.LiabilityValue));
            //Console.WriteLine($"{"Asset",-10:D} {"Value($) ASC",10:D}");
            //foreach (Asset a in objListAsset)
            //{
            //    Console.WriteLine(a);
            //}

            Console.WriteLine($"\n\nNet Worth is {netWorth.ToString("c")}");
            Console.WriteLine($"Target Net Worth is {targetNetWorth.ToString("c")}");

            Console.WriteLine("Would you like to change a value?");
            do
            {
                if (choice == 'y' || choice == 'Y')
                {

                }
               // else if (choice )

            }while(choice != 'n' && choice != 'N')
        }

        static void PopulateLists(ref List<Asset> objLA, ref List<Liability> objLL)
        {
            objLA.Add(new Asset("Home", 105000));
            objLA.Add(new Asset("Checking", 25000));
            objLA.Add(new Asset("Land", 200000));

            objLL.Add(new Liability("Mortgage", 25000));
            objLL.Add(new Liability("Student Loans", 15000));
            objLL.Add(new Liability("Car", 5000));
        }

        static decimal CalcNetWorth(ref List<Asset> objLA, ref List<Liability> objLL)
        {
            decimal netWorth= 0.0m, assetSum = 0.0m, liabilitySum = 0.0m;

            foreach (Asset a in objLA)
            {
                assetSum += a.AssetValue;
            }

            foreach (Liability ab in objLL)
            {
                liabilitySum += ab.LiabilityValue;
            }

            netWorth = assetSum - liabilitySum;

            return netWorth;
        }

        static void Main(string[] args)
        {
            RunProgram();
        }
    }
}
