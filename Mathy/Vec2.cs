namespace Mathy;

public readonly struct Vec2 {

	public Vec2 (int x, int y) {
		X = x;
		Y = y;
	}

	public int X { get; init; }
	public int Y { get; init; }

	public static Vec2 Zero { get; } = new(0, 0);
	public static Vec2 One { get; } = new(1, 1);

	public static Vec2 operator + (Vec2 a, int b) {
		return new Vec2(a.X + b, a.Y + b);
	}

	public static Vec2 operator - (Vec2 a, int b) {
		return new Vec2(a.X - b, a.Y - b);
	}

	public static Vec2 operator * (Vec2 a, int b) {
		return new Vec2(a.X * b, a.Y * b);
	}

	public static Vec2 operator + (Vec2 a, Vec2 b) {
		return new Vec2(a.X + b.X, a.Y + b.Y);
	}

	public static Vec2 operator - (Vec2 a, Vec2 b) {
		return new Vec2(a.X - b.X, a.Y - b.Y);
	}

	public static Vec2 operator * (Vec2 a, Vec2 b) {
		return new Vec2(a.X * b.X, a.Y * b.Y);
	}

}