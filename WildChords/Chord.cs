using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        private string _typeStr;
        private ChordType _type;


        public Chord(string name)
        {
            // initialize chord array 
            
            _name = name;
            _indexChord = 0;
            _chord = new Note[12];
            _type = ChordType.NONE;
            _root = "";
            _typeStr = "";
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
            if (_root == "")
                return ChordType.NONE;
            _typeStr = _name.Replace(_root, "");
            // flawed logic
            _type = ChordType.MAJOR;
            switch (_typeStr)
            {
                case "m":
                    _type = ChordType.MINOR;
                    break;
                case "dim":
                    _type = ChordType.DIMINISHED;
                    break;
                case "aug":
                    _type = ChordType.AUGMENTED;
                    break;
                default:
                    _type = ChordType.MAJOR;
                    break;
            }
            
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
                    AddNote("minorThird", Intervals.MinorThird(_chord[0].GetFrequency())); //temporary
                    AddNote("majorThird", Intervals.MajorThird(_chord[1].GetFrequency()));
                    break;
                    
                case ChordType.DIMINISHED:
                    // minor third + minor third
                    AddNote("minorThird", Intervals.MinorThird(_chord[0].GetFrequency()));
                    AddNote("minorThird1", Intervals.MinorThird(_chord[1].GetFrequency()));
                    break;
                case ChordType.AUGMENTED:
					// major third + major third
					AddNote("majorThird", Intervals.MajorThird(_chord[0].GetFrequency()));
					AddNote("majorThird1", Intervals.MajorThird(_chord[1].GetFrequency()));
					break;

                default:
					// major third  + minor third
					AddNote("majorThird", Intervals.MajorThird(_chord[0].GetFrequency()));
					AddNote("minorThird", Intervals.MinorThird(_chord[1].GetFrequency()));
					break;
            }
        }
        public void PlayChord(SineWavePlayer sineWave, float durationS)
        {
            for (int i = 0; i < _indexChord; i++)
            {
                sineWave.PlayNote(_chord[i], 1);
            }
        }
    }
}
//B E A D G C F
// F C G D A E B


// Note[] scale = {Note(), Note(), Note()}
// 
