using Reloaded.ModHelper;
using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace NoMansSky.Api
{
    [StructLayout(LayoutKind.Explicit)]
    public struct GcInventoryIndex : IEquatable<GcInventoryIndex>, IEquatable<Vector2>, IComparable<GcInventoryIndex>
    {
        [FieldOffset(0x0)]
        public int x;

        [FieldOffset(0x4)]
        public int y;


        public override string ToString()
        {
            return $"({x}, {y})";
        }

        public bool Equals(Vector2 other)
        {
            return x == (int)other.X && y == (int)other.Y;
        }

        public bool Equals(GcInventoryIndex other)
        {
            return x == other.x && y == other.y;
        }

        public override bool Equals(object obj)
        {
            if (obj is GcInventoryIndex index)
                return Equals((GcInventoryIndex)obj);
            else if (obj is Vector2 vector2)
                return Equals((Vector2)obj);
            else
                return false;
        }

        public int CompareTo(GcInventoryIndex other)
        {
            if (this == other)
                return 0;
            else if (this < other)
                return -1;
            else
                return 1;
        }



        // These were added for convinience.
        #region Operators

        public static bool operator <=(GcInventoryIndex point1, GcInventoryIndex point2)
        {
            return point1 < point2 || point1 == point2;
        }

        public static bool operator >=(GcInventoryIndex point1, GcInventoryIndex point2)
        {
            return point1 > point2 || point1 == point2;
        }

        public static bool operator <(GcInventoryIndex point1, GcInventoryIndex point2)
        {
            if (point1 == point2)
                return false;

            if (point1.x > point2.x)
                return false;

            if ((point1.x == point2.x) && (point1.y > point2.y))
                return false;

            return true;
        }

        public static bool operator >(GcInventoryIndex point1, GcInventoryIndex point2)
        {
            if (point1 == point2)
                return false;

            if (point1.x < point2.x)
                return false;

            if ((point1.x == point2.x) && (point1.y < point2.y))
                return false;

            return true;
        }

        public static bool operator ==(GcInventoryIndex point1, GcInventoryIndex point2)
        {
            return point1.Equals(point2);
        }

        public static bool operator !=(GcInventoryIndex point1, GcInventoryIndex point2)
        {
            return !point1.Equals(point2);
        }


        public static bool operator ==(GcInventoryIndex point1, Vector2 point2)
        {
            return point1.Equals(point2);
        }

        public static bool operator !=(GcInventoryIndex point1, Vector2 point2)
        {
            return !point1.Equals(point2);
        }


        public static implicit operator Vector2(GcInventoryIndex index)
        {
            return new Vector2(index.x, index.y);
        }

        public static implicit operator GcInventoryIndex(Vector2 vector)
        {
            var index = new GcInventoryIndex();
            index.x = (int)vector.X;
            index.y = (int)vector.Y;
            return index;
        }

        #endregion
    }
}
