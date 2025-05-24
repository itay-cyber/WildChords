using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildChords
{
	public class Intervals
	{
		public static double MinorSecond(double baseFreq) => baseFreq * Math.Pow(2, 1.0 / 12);
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
		public static double Octave(double baseFreq) => baseFreq * Math.Pow(2, 12.0 / 12);

	}
}
