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

        public Chord(string name)
        {
            // initialize chord array 
            // C#m
            // _root = C#
            // typeStr = m
            // type = ChordType.MINOR


         
        }

    }
}
//B E A D G C F
// F C G D A E B


// Note[] scale = {Note(), Note(), Note()}
// 
