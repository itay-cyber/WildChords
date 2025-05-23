using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;

namespace WildChords
{
    public enum ChordType
    {
        MINOR, MAJOR, AUGMENTED, DIMINISHED
    }
    public class Chord
    {
        private Note[] _chord;
        private string _name;
        private string _root;
        private ChordType _type;


        public Chord(string name)
        {
            _name = name;
            GetRoot();
            GetChordType();
            MakeChord();
        }

        public string GetRoot()
        {
            string accidental = _name.Substring(1, 1);
            if (accidental == "#" || accidental == "b")
            {
               _root = _name.Substring(0, 1);
            }
            else
            {
                _root = _name.Substring(0, 0);
            }
            return _root;
        }

        public ChordType GetChordType()
        {
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
        public void MakeChord()
        {
            
        }
    }
}
