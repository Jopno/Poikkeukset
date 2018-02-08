using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;    //tiedostojen käsittelyä varten.
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsApp
{
    class NamesToFile
    {
        static void Test()
        {
            try
            {
                string line;
                string myfile = @"D:\l7043\testi.txt";
                //luodaan tiedosto
                StreamWriter sw = new StreamWriter(myfile);
                //kysytään käyttäjältä nimet ja kirjoitetaan nimet tiedostoon
                do
                {
                    Console.WriteLine("Give a person name (space ends prog)");
                    line = Console.ReadLine();
                    if (line.Length > 0)
                        sw.WriteLine(line);

                } while (line.Length > 0);
                sw.Close();
                //avataan tiedosto lukua varten
                if (File.Exists(myfile))
                {
                //näytetään nimet
                    string txt = File.ReadAllText(myfile);
                    Console.WriteLine("In file {0} are names: {1} ",myfile,txt);
                }
                else
                {
                    Console.WriteLine("Could not found {0} file", myfile);
                }

            }
            catch (Exception)
            {

                throw;
            }

            //kysytään käyttäjältä nimet
            //luodaan tiedosto ja kirjoitetaan nimet tiedostoon
            //avataan tiedosto lukua varten
            //näytetään nimet
        }

        static void Main(string[] args)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
