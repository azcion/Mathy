namespace Mathy;

/// <summary>
/// A PRNG implementation using noise.
/// </summary>
public class Rand {

	private static class State {

		internal static uint NextSeed => _seed++;
		private static uint _seed = (uint)Guid.NewGuid().GetHashCode();

	}

	public uint Seed { get; }

	private static int NextPosition => _position++;
	private static int _position;

	public Rand () : this(0, State.NextSeed) { }

	public Rand (int startPosition, uint seed) {
		_position = startPosition;
		Seed = seed;
	}

	public int Next () {
		return (int)Noise.Get(NextPosition, Seed);
	}

	public int Next (int maxExcl) {
		return NextInt(0, maxExcl);
	}

	public int Next (int minIncl, int maxExcl) {
		return NextInt(minIncl, maxExcl);
	}

	public int NextInt (int minIncl, int maxExcl) {
		return (int)Smooth.Lerp(minIncl, maxExcl, NextDouble());
	}

	public double NextDouble () {
		return Noise.Get1D0To1(NextPosition, Seed);
	}

	public double NextDouble (double minIncl, double maxExcl) {
		return Smooth.Lerp(minIncl, maxExcl, NextDouble());
	}

}