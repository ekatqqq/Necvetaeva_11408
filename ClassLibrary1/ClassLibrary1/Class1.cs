namespace Geometry;

public class Vector
{
    public double X;
    public double Y;

    public double GetLength()
    {
        return Geometry.GetLength(this);
    }

    public Vector Add(Vector vector)
    {
        return Geometry.Add(this, vector);
    }

    public bool Belongs(Segment segment)
    {
        return Geometry.IsVectorInSegment(this, segment);
    }
}

public class Segment
{
    public Vector Begin;
    public Vector End;

    public double GetLength()
    {
        return Geometry.GetLength(this);
    }

    public bool Contains(Vector vector)
    {
        return Geometry.IsVectorInSegment(vector, this);
    }
}

public static class Geometry
{
    public static double GetLength(Vector vector)
    {
        return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
    }

    public static double GetLength(Segment segment)
    {
        var dx = segment.End.X - segment.Begin.X;
        var dy = segment.End.Y - segment.Begin.Y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    public static bool IsVectorInSegment(Vector vector, Segment segment)
    {
        bool result = false;
        var AB = GetLength(segment);
        var AC = Math.Sqrt((vector.X - segment.Begin.X) * (vector.X - segment.Begin.X)
                        + (vector.Y - segment.Begin.Y) * (vector.Y - segment.Begin.Y));
        var CB = Math.Sqrt((segment.End.X - vector.X) * (segment.End.X - vector.X)
                        + (segment.End.Y - vector.Y) * (segment.End.Y - vector.Y));

        if (AC + CB == AB)
            result = true;

        return result;
    }

    public static Vector Add(Vector vector1, Vector vector2)
    {
        var sum = new Vector();
        sum.X = vector1.X + vector2.X;
        sum.Y = vector1.Y + vector2.Y;
        return sum;
    }
}