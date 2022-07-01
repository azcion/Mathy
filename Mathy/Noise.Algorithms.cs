namespace Mathy;

public static partial class Noise {

	public static double FractalNeg1To1 (int octaves, Vec2 vec, uint seed, double persistence, double scale) {
		return FractalNeg1To1(octaves, vec.X, vec.Y, seed, persistence, scale);
	}

	public static double FractalNeg1To1 (int octaves, int x, int y, uint seed, double persistence, double scale) {
		double maxAmplitude = 0;
		double amplitude = 1;
		double frequency = scale;
		double noise = 0;

		for (int i = 0; i < octaves; i++) {
			noise += OpenSimplex2.Noise2(seed, x * frequency, y * frequency) * amplitude;
			maxAmplitude += amplitude;
			amplitude *= persistence;
			frequency *= 2;
		}

		return noise / maxAmplitude;
	}

}