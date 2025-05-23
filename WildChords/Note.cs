using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace WildChords
{
	public class Note
	{
		private double _frequency;
		private string _note;

		public Note(double frequency, string note)
		{
			_frequency = frequency;
			_note = note;
		}

		public double GetFrequency() { return _frequency; }
		public string GetNote() { return _note;}
	}
}
