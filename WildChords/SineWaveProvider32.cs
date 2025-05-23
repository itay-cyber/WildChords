using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WildChords
{
	// A simple sine wave generator using NAudio
	public class SineWaveProvider32 : WaveProvider32
	{
		public double Frequency { get; set; }
		public float Amplitude { get; set; }

		private double phaseAngle;

		public override int Read(float[] buffer, int offset, int sampleCount)
		{
			int sampleRate = WaveFormat.SampleRate;

			for (int i = 0; i < sampleCount; i++)
			{
				buffer[offset + i] = Amplitude * (float)Math.Sin(phaseAngle);
				phaseAngle += (2 * Math.PI * Frequency) / sampleRate;
				if (phaseAngle > 2 * Math.PI)
					phaseAngle -= 2 * Math.PI;
			}

			return sampleCount;
		}
	}
	public class SineWavePlayer
	{
		// play a specific note
		public void PlayNote(Note n, float durationS)
		{
			PlayTone(n.GetFrequency(), durationS);
		}
		// play a specific frequency
		private void PlayTone(double frequency, float durationSeconds)
		{
			var waveOut = new WaveOutEvent();
			var waveProvider = new SineWaveProvider32()
			{
				Frequency = frequency,
				Amplitude = 0.25f // between 0.0 and 1.0
			};

			waveOut.Init(waveProvider);
			waveOut.Play();

			// Stop playback after the duration
			new Timer(_ =>
			{
				waveOut.Stop();
				waveOut.Dispose();
			}, null, TimeSpan.FromSeconds(durationSeconds), Timeout.InfiniteTimeSpan);
		}
	}
}
