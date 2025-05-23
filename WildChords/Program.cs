using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WildChords
{
    internal class Program
    {
        const string FILENAME = "C:\\Users\\itayk\\source\\repos\\WildChords\\WildChords\\Frequencies.txt";

		static void Main(string[] args)
        {
            SineWavePlayer player = new SineWavePlayer();
            FrequencyReader reader = new FrequencyReader(FILENAME);
            Note csharp = new Note(reader.GetFrequency("C#4"), "C#");
            Note e = new Note(reader.GetFrequency("E4"), "E");
            Note gsharp = new Note(reader.GetFrequency("G#4"), "G#");
            Note b = new Note(reader.GetFrequency("B4"), "B");
            Note dsharp = new Note(reader.GetFrequency("D#4"), "D#");

            player.PlayNote(csharp, 1);
            player.PlayNote(e, 1);
            player.PlayNote(gsharp, 1);
            player.PlayNote(b, 1);
            player.PlayNote(dsharp, 1);
            Thread.Sleep(2000);
        }
    }
}

