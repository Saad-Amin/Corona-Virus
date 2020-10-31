using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corona_virus
{
    class Program
    {
        public static void corona_test(int age, string fever, double temprature, string cough, string tired, string breathing)
        {
            if(age>50 && fever=="yes" && temprature>98 && cough=="yes" && tired=="yes" && breathing=="yes")
            {
                Console.WriteLine("\n\n\n\t\t******************    You are in danger kindly isolate yourself you have higlt chance of corona virus and consult your doctor    ******************");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            }
            else if(age < 50 && fever == "yes" && temprature > 98 && cough == "yes" && tired == "yes" && breathing == "yes")
            {
                Console.WriteLine("\n\n\n\t\t***************************     Kindly isolate yourself you have higtly chance of corona virus and consult your doctor     ***************************");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            }
            else if(fever == "yes" && temprature < 98 && cough == "no" && tired == "no" && breathing == "no")
            {
                Console.WriteLine("\n\n\n\t\t\t******************************************************    You are tired     ************************************************");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            }
            else if(fever == "yes" && temprature < 98 && cough == "yes" && tired == "no" && breathing == "no")
            {
                Console.WriteLine("\n\n\n\t\t\t*****************************************************    You have normal flu    ****************************************************");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            }
            else
            {
                Console.WriteLine("\n\n\n\t\t\t***************************************************    Chill our you have some another desease    ************************************************");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n\t\t****************************************************************       WELCOME       **************************************************************");
            Console.WriteLine("\n\n\n\t\t***********************    ANSWER FOLLOWING QUESTIONS TO CHECK WHETHER YOU HAVE CORONA VIRUS OR NOT ON THE BASIS OF SYMPTOMS     ******************");
            Console.WriteLine("\n\n\n\t\t*************************************************       PLEASE ANSWER THE FOLLOWING SYMPTOMS       ************************************************");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            Console.Write("What is your age?  ");
            int age = Int32.Parse(Console.ReadLine());

            Console.Write("nHave you felling fever?  ");
            string fever = Console.ReadLine();

            Console.Write("What is your current body temprature in farenhyte?  ");
            double temp = Double.Parse(Console.ReadLine());

            Console.Write("DO you have dry cough?  ");
            string cough = Console.ReadLine();

            Console.Write("Are you felling tired  ");
            string tired = Console.ReadLine();

            Console.Write("Are you felling difficulty in breathing  ");
            string breath = Console.ReadLine();

            corona_test(age, fever, temp, cough, tired, breath);
            Console.ReadKey();
        }
    }
}
