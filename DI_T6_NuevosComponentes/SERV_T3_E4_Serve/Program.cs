using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV_T3_E4_Serve
{
    class Program
    {
        List<string> palabras = new List<string>();
        List<Record> records = new List<Record>();

        int maximoRecords = 10;
        static void Main(string[] args)
        {

        }
        public void llenarPalabras()
        {
            using(StreamReader sr = new StreamReader(Environment.GetEnvironmentVariable("appdata")+"/palabrasAhorcado"))
            {
                while (sr.Peek()>-1)
                {
                    palabras.Add(sr.ReadLine());
                }
            }
        }
        public void llenarRecords()
        {
            using (StreamReader sr = new StreamReader(Environment.GetEnvironmentVariable("appdata") + "/recordsAhorcado"))
            {
                while (sr.Peek() > -1 && records.Count< maximoRecords)
                {
                    try
                    {
                        records.Add(new Record(sr.Read(),sr.ReadLine()));
                    }
                    catch (IOException)
                    {

                    }
                }
            }
        }
        public string getword()
        {
            Random num = new Random(palabras.Count);
            return palabras.ElementAt(num.Next());
        }
        public void sendword(string word)
        {
            if (word.Trim().Length > 0)
            {
                palabras.Add(word);
            }
        }
        public List<Record> getrecords()
        {
            return records;
        }
        public void sendrecord(Record record)
        {
            records.Add(record);
        }
        public void closeserver(int clave)
        {
            saveData();
        }
        public void saveData()
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetEnvironmentVariable("appdata") + "/palabrasAhorcado"))
            {
                foreach (var palabra in palabras)
                {
                    sw.WriteLine(palabra);
                }
            }
            using (StreamWriter sw = new StreamWriter(Environment.GetEnvironmentVariable("appdata") + "/recordsAhorcado"))
            {
                foreach (var record in records)
                {
                    sw.WriteLine(record.getScore());
                    sw.WriteLine(record.getName());
                }
            }
        }
    }
}
