using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Library
{
    public class Vector2
    {
        private float m_X;
        private float m_Y;

        public Vector2(float x, float y)
        {
            m_X = x;
            m_Y = y;
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.m_X + rhs.m_X, lhs.m_Y + rhs.m_Y);
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.m_X - rhs.m_X, lhs.m_Y - rhs.m_Y);
        }

        public static Vector2 operator *(Vector2 vector, int scale)
        {
            return new Vector2(vector.m_X * scale, vector.m_Y * scale);
        }

        public static float Dot(Vector2 lhs, Vector2 rhs)
        {
            return (lhs.m_X * rhs.m_X) + (lhs.m_Y * rhs.m_Y);
        }

        public static bool operator==(Vector2 lhs, Vector2 rhs)
        {
            return (lhs.m_X == rhs.m_X && lhs.m_X == rhs.m_Y);
        }

        public static bool operator!=(Vector2 lhs, Vector2 rhs)
        {
            return (lhs.m_X != rhs.m_X && lhs.m_X != rhs.m_Y);
        }

        public float Magnitude()
        {
            float sum = (m_X * m_X) + (m_Y * m_Y);
            float mag = (float)Math.Sqrt(sum);
            return mag;
        }

        public Vector2 Normalize()
        {
            return new Vector2(m_X / Magnitude(), m_Y / Magnitude());
        }
    }
}
