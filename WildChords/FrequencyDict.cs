using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildChords
{
	internal class FrequencyDict
	{
        private static string _filename = "C:\\\\Users\\\\itayk\\\\source\\\\repos\\\\WildChords\\\\WildChords\\\\Frequencies.txt";

		private static Dictionary<int, Node<Note>> freqDict;
        private static StreamReader read;

        static FrequencyDict()
        {
            freqDict = new Dictionary<int, Node<Note>>();
            read = new StreamReader(_filename);
            string line = read.ReadLine();
            int i = 0;
            while (line != null)
            {
                if (line == "")
                {
                    line = read.ReadLine();
                    continue;
                }
                Node<Note> head = FindNote(line);
                line = read.ReadLine();
                if(line != null && line != "")
                {
                    Node<Note> ND1 = FindNote(line);
                    head.SetNext(ND1);
                }
                freqDict.Add(i, head);
                i++;
                line = read.ReadLine();
            }
        }
        private static Node<Note> FindNote(string line)
        {
            if(line == "") return null;

            string freqS = "";
            string name = "";
            int i = 0;
            for(; i < line.Length && line[i] != '=' ; i++)
            {
                name += line[i];
            }
            i++;
            for (; i < line.Length; i++)
            {
                freqS += line[i];
            }
            Node<Note> NodeNote = new Node<Note>(new Note(Convert.ToDouble(freqS), name), null);
            return NodeNote;

        }
        
        public static void printdic()
        {
            for(int i = 0; i < freqDict.Count; i++)
            {
                Node<Note> NN = freqDict[i];
                while(NN != null)
                {
                    Console.Write("->" + NN.GetValue().GetNote());
                    NN = NN.GetNext();
                }
                Console.WriteLine();
            }
        }
        public static Node<Note> FindNote(int index)
        {
            return freqDict[index]
        }
    }
 
}
