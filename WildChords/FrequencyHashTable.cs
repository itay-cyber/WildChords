using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildChords
{
	internal class FrequencyHashTable
	{
		Node<Note>[] NoteHash = new Node<Note>[24];

        public FrequencyHashTable()
        {
            
        }
        /*private string _fileName;
        private StreamReader _sr;

        public Node<Note>[]  hash() { return NoteHash; }

        public FrequencyHashTable(string _fileName)
		{
            _sr = new StreamReader(_fileName);
            String line = _sr.ReadLine();
            int index = 0;
            double freq = -1;
            string name = "";
            Node<Note> P = new Node<Note>(null, null);
            NoteHash[0] = P;
            while (line != null)
            {
                line = _sr.ReadLine();
                
                if (line.Contains("=")) {
                    int i;
                    for (i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '=')
                            break;
                    }
                    i++;
                    name = line.Substring(0, i);
                    freq = Convert.ToDouble(line.Substring(i));
                    Note N = new Note(freq, name);
                    Node<Note> note = new Node<Note>(N, null);
                    P = note;
                    P = P.GetNext();
                }
                else 
                {
                    index++;
                    if (index > 23) { break; }
                    NoteHash[index] = P;
                }
            }
		}*/
    }
}
