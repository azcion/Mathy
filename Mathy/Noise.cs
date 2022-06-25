namespace Mathy; 

public class Noise {

	private const int Prime1 = 198491317;
	private const int Prime2 = 6542989;
	private const int Prime3 = 357239;
	private const double OneOverMaxUint = 1d / uint.MaxValue;
	private const double OneOverMaxInt = 1d / int.MaxValue;

	public static uint Get (int position, uint seed) {
		const uint bitNoise1 = 0xd2a80a3f; // 11010010101010000000101000111111
		const uint bitNoise2 = 0xa884f197; // 10101000100001001111000110010111
		const uint bitNoise3 = 0x6c736f4b; // 01101100011100110110111101001011
		const uint bitNoise4 = 0xb79f3abb; // 10110111100111110011101010111011
		const uint bitNoise5 = 0x1b56c4f5; // 00011011010101101100010011110101

		uint mangled = (uint)position;
		mangled *= bitNoise1;
		mangled += seed;
		mangled ^= mangled >> 9;
		mangled += bitNoise2;
		mangled ^= mangled >> 11;
		mangled *= bitNoise3;
		mangled ^= mangled >> 13;
		mangled += bitNoise4;
		mangled ^= mangled >> 15;
		mangled *= bitNoise5;
		mangled ^= mangled >> 17;

		return mangled;
	}

	public static uint Get1DUint (int x, uint seed = 0) {
		return Get(x, seed);
	}

	public static uint Get2DUint (int x, int y, uint seed = 0) {
		return Get(x + Prime1 * y, seed);
	}

	public static uint Get3DUint (int x, int y, int z, uint seed = 0) {
		return Get(x + Prime1 * y + Prime2 * z, seed);
	}

	public static uint Get4DUint (int x, int y, int z, int t, uint seed = 0) {
		return Get(x + Prime1 * y + Prime2 * z + Prime3 * t, seed);
	}

	public static double Get1D0To1 (int x, uint seed = 0) {
		return OneOverMaxUint * Get(x, seed);
	}

	public static double Get2D0To1 (int x, int y, uint seed = 0) {
		return OneOverMaxUint * Get2DUint(x, y, seed);
	}

	public static double Get3D0To1 (int x, int y, int z, uint seed = 0) {
		return OneOverMaxUint * Get3DUint(x, y, z, seed);
	}
	
	public static double Get4D0To1 (int x, int y, int z, int t, uint seed = 0) {
		return OneOverMaxUint * Get4DUint(x, y, z, t, seed);
	}

	public static double Get1DNeg1To1 (int x, uint seed = 0) {
		return OneOverMaxInt * Get(x, seed);
	}

	public static double Get2DNeg1To1 (int x, int y, uint seed = 0) {
		return OneOverMaxInt * Get2DUint(x, y, seed);
	}

	public static double Get3DNeg1To1 (int x, int y, int z, uint seed = 0) {
		return OneOverMaxInt * Get3DUint(x, y, z, seed);
	}

	public static double Get4DNeg1To1 (int x, int y, int z, int t, uint seed = 0) {
		return OneOverMaxInt * Get4DUint(x, y, z, t, seed);
	}

}