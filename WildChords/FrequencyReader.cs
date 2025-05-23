using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildChords
{
	public class FrequencyReader
	{
		private string _fileName;
		private StreamReader _sr;

		public FrequencyReader(string fileName)
		{
			_fileName = fileName;
			_sr = new StreamReader(_fileName);
		}

		// -1 means it didn't find the note
		public double GetFrequency(string name)
		{
			String line = _sr.ReadLine();
			string freq = "";
			double dFreq = -1;
			while (line != null)
			{
				if (line.StartsWith(name))
				{
					int i;
					for (i = 0; i < line.Length; i++)
					{
						if (line[i] == '=')
							break;
					}
					i++;
					freq = line.Substring(i);
					Console.WriteLine("#" + freq + "#");
					dFreq = Convert.ToDouble(freq);
					break;
                }
				line = _sr.ReadLine();
			}
			return dFreq;
		}
	}
}
