using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;

namespace WildChords
{
    
    public enum ChordType
    {
        MINOR, MAJOR, AUGMENTED, DIMINISHED, NONE
    }
    public class Chord
    {
        private Note[] _chord;
        private FrequencyReader _reader;

        private int _indexChord;

        private string _name;
        private string _root;
        private ChordType _type;


        public Chord(string name)
        {
            _name = name;
            _indexChord = 0;
            _chord = new Note[12];
            _type = ChordType.NONE;
            _root = "";
            _reader = new FrequencyReader(Program.FILENAME);

            GetRoot();
            GetChordType();
            MakeChord();
        }

        public string GetRoot()
        {
            string accidental = _name.Substring(1, 1);
            if (accidental == "#" || accidental == "b")
            {
                _root = _name.Substring(0, 2);
            }
            else
            {
                _root = _name.Substring(0, 1);
            }
            return _root;
        }

        public ChordType GetChordType()
        {
            // flawed logic
            if (_name.Contains("m"))
                _type = ChordType.MINOR;
            else if (_name.Contains("dim"))
                _type = ChordType.DIMINISHED;
            else if (_name.Contains("aug"))
                _type = ChordType.AUGMENTED;
            else
                _type = ChordType.MAJOR;
            return _type;
        }
        private void AddNote(string name, double frequency)
        {
            if (_indexChord > 11)
            {
                Console.WriteLine("Out of range: chord full");
                return;
            }
            _chord[_indexChord] = new Note(frequency, name);
            _indexChord++;
        }
        public void MakeChord()
        {
            AddNote(_root, _reader.GetFrequency(_root + "4"));
            switch (_type)
            {
                case ChordType.MINOR:
                    // minor third + major third
                    
                case ChordType.DIMINISHED:
                    break;
                case ChordType.AUGMENTED:
                    break;
                case ChordType.MAJOR:
                    break;
                default:
                    break;
            }
        }
    }
}
//B E A D G C F
// F C G D A E B


// Note[] scale = {Note(), Note(), Note()}
// 
