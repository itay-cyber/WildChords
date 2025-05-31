using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildChords
{
	public class Intervals
	{
		private const int MINOR_SECOND = 1; //1 note
		private const int MAJOR_SECOND = 2; // 1 note
		private const int MINOR_THIRD = 3; // 2 notes
		private const int MAJOR_THIRD = 4; //2 notes
		private const int PERFECT_FOURTH = 5; //3 notes
		private const int TRITONE = 6; //3 notes
		private const int PERFECT_FIFTH = 7; // 4 notes
		private const int MINOR_SIXTH = 8; // 5
		private const int MAJOR_SIXTH = 9;// 5 notes
		private const int MINOR_SEVENTH = 10;//6 notes
		private const int MAJOR_SEVENTH = 11;// 6 notes
		private const int OCTAVE = 12; // 7 notes

		public Note JumpInterval(int semitones, int indexInDic)
		{
			Node<Note> note = FrequencyDict.FindNote(indexInDic);
			char tmpC = note.GetValue().GetNote()[0];
			tmpC++;
			indexInDic += semitones;
			Node<Note> ret = FrequencyDict.FindNote(indexInDic);




		
		}
		
		/*public static double MinorSecond(double baseFreq) => baseFreq * Math.Pow(2, 1.0 / 12);
		public static double MajorSecond(double baseFreq) => baseFreq * Math.Pow(2, 2.0 / 12);
		public static double MinorThird(double baseFreq) => baseFreq * Math.Pow(2, 3.0 / 12);
		public static double MajorThird(double baseFreq) => baseFreq * Math.Pow(2, 4.0 / 12);
		public static double PerfectFourth(double baseFreq) => baseFreq * Math.Pow(2, 5.0 / 12);
		public static double Tritone(double baseFreq) => baseFreq * Math.Pow(2, 6.0 / 12);
		public static double PerfectFifth(double baseFreq) => baseFreq * Math.Pow(2, 7.0 / 12);
		public static double MinorSixth(double baseFreq) => baseFreq * Math.Pow(2, 8.0 / 12);
		public static double MajorSixth(double baseFreq) => baseFreq * Math.Pow(2, 9.0 / 12);
		public static double MinorSeventh(double baseFreq) => baseFreq * Math.Pow(2, 10.0 / 12);
		public static double MajorSeventh(double baseFreq) => baseFreq * Math.Pow(2, 11.0 / 12);
		public static double Octave(double baseFreq) => baseFreq * Math.Pow(2, 12.0 / 12);*/

	}
}
