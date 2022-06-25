namespace Mathy; 

public static class Smooth {

	public static double Lerp (double start, double end, double t) {
		return start + (end - start) * t;
	}

	public static double Mix (double a, double b, double bWeight) {
		return a + bWeight * (b - a);
	}

	#region Smooth

	#region Step

	public static double SmoothStep3 (double t) {
		return (1 - t) * SmoothStart2(t) + t * SmoothStop2(t);
	}

	#endregion

	#region Start
	
	public static double InverseSmoothStart2 (double start, double end, double t) {
		return Lerp(start, end, 1 - SmoothStart2(t));
	}
	
	public static double InverseSmoothStart3 (double start, double end, double t) {
		return Lerp(start, end, 1 - SmoothStart3(t));
	}
	
	public static double SmoothStart2 (double start, double end, double t) {
		return Lerp(start, end, SmoothStart2(t));
	}
	
	public static double SmoothStart3 (double start, double end, double t) {
		return Lerp(start, end, SmoothStart3(t));
	}

	public static double SmoothStart2 (double t) {
		return t * t;
	}
	
	public static double SmoothStart3 (double t) {
		return t * t * t;
	}

	#endregion

	#region Stop

	public static double InverseSmoothStop2 (double start, double end, double t) {
		return Lerp(start, end, 1 - SmoothStop2(t));
	}
	
	public static double InverseSmoothStop3 (double start, double end, double t) {
		return Lerp(start, end, 1 - SmoothStop3(t));
	}
	
	public static double SmoothStop2 (double start, double end, double t) {
		return Lerp(start, end, SmoothStop2(t));
	}
	
	public static double SmoothStop3 (double start, double end, double t) {
		return Lerp(start, end, SmoothStop3(t));
	}

	public static double SmoothStop2 (double t) {
		return 1 - (1 - t) * (1 - t);
	}
	
	public static double SmoothStop3 (double t) {
		return 1 - (1 - t) * (1 - t) * (1 - t);
	}

	#endregion

	#endregion

}