using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS.Globals
{
    public static class StaticClasses
    {
        public static class CreateUnicId
        {
            public static string CreateCheckSum(string s)
            {
                var i = 0;
                Int64 r = 0;
                while ((i < s.Length))
                {
                    long c = Convert.ToChar(s.Substring(i, 1));
                    if (c >= 128)
                    {
                        c = 0xFFFFFF00 + c;
                    }
                    r = (r * 0x10 ^ r / 0x10000000 ^ c);
                    i++;
                }

                return r.ToString();
            }

            public static string AddChar(int length)
            {
                string RandomID;
                Int16 counter;
                double RandomNumber;
                Int16 RandomNumberInt;
                string CurrentCharacter;
                string ValidCharacters;
                ValidCharacters = "BCDFGHJKMNPQRSTVWXZ";
                int ValidCharactersLength;
                ValidCharactersLength = ValidCharacters.Length;
                RandomID = "";

                counter = 0;

                while (counter < (length + 1))
                {
                    RandomNumber = RandomProvider.Next();
                    RandomNumberInt = Convert.ToInt16(((ValidCharactersLength - 1) * RandomNumber + 1));
                    CurrentCharacter = ValidCharacters.Substring(RandomNumberInt, 1);
                    counter++;
                    RandomID = RandomID + CurrentCharacter;
                }
                return RandomID;
            }

            public static string CreateNewId(int idDoc)
            {
                string OrderID;
                OrderID = AddChar(9 - idDoc.ToString().Length) + Reverse(CreateCheckSum(idDoc.ToString()));
                return OrderID;
            }

            public static string Reverse(string str)
            {

                char[] charArray = str.ToCharArray();
                int len = str.Length - 1;

                for (int i = 0; i < len; i++, len--)
                {
                    charArray[i] ^= charArray[len];
                    charArray[len] ^= charArray[i];
                    charArray[i] ^= charArray[len];
                }
                return new string(charArray);
            }
        }


        public static class RandomProvider
        {
            private static Random m_RNG1;
            private static double m_StoredUniformDeviate;
            private static bool m_StoredUniformDeviateIsGood = false;

            #region -- Construction/Initialization --

            static RandomProvider()
            {
                Reset();
            }
            public static void Reset()
            {
                m_RNG1 = new Random(Environment.TickCount);
            }

            #endregion

            #region -- Uniform Deviates --

            /// <summary>
            /// Returns double in the range [0, 1)
            /// </summary>
            public static double Next()
            {
                return m_RNG1.NextDouble();
            }

            /// <summary>
            /// Returns true or false randomly.
            /// </summary>
            public static bool NextBoolean()
            {
                if (m_RNG1.Next(0, 2) == 0)
                    return false;
                else
                    return true;
            }
            public static bool NextBoolean(string iputString)
            {
                if (m_RNG1.Next(0, 2) == 0)
                    return false;
                else
                    return true;
            }
            /// <summary>
            /// Returns double in the range [0, 1)
            /// </summary>
            public static double NextDouble()
            {
                double rn = m_RNG1.NextDouble();
                return rn;
            }

            /// <summary>
            /// Returns Int16 in the range [min, max)
            /// </summary>
            public static Int16 Next(Int16 min, Int16 max)
            {
                if (max <= min)
                {
                    string message = "Max must be greater than min.";
                    throw new ArgumentException(message);
                }
                double rn = (max * 1.0 - min * 1.0) * m_RNG1.NextDouble() + min * 1.0;
                return Convert.ToInt16(rn);
            }

            /// <summary>
            /// Returns Int32 in the range [min, max)
            /// </summary>
            public static int Next(int min, int max)
            {
                return m_RNG1.Next(min, max);
            }

            /// <summary>
            /// Returns Int64 in the range [min, max)
            /// </summary>
            public static Int64 Next(Int64 min, Int64 max)
            {
                if (max <= min)
                {
                    string message = "Max must be greater than min.";
                    throw new ArgumentException(message);
                }

                double rn = (max * 1.0 - min * 1.0) * m_RNG1.NextDouble() + min * 1.0;
                return Convert.ToInt64(rn);
            }

            /// <summary>
            /// Returns float (Single) in the range [min, max)
            /// </summary>
            public static Single Next(Single min, Single max)
            {
                if (max <= min)
                {
                    string message = "Max must be greater than min.";
                    throw new ArgumentException(message);
                }

                double rn = (max * 1.0 - min * 1.0) * m_RNG1.NextDouble() + min * 1.0;
                return Convert.ToSingle(rn);
            }

            /// <summary>
            /// Returns double in the range [min, max)
            /// </summary>
            public static double Next(double min, double max)
            {
                if (max <= min)
                {
                    string message = "Max must be greater than min.";
                    throw new ArgumentException(message);
                }

                double rn = (max - min) * m_RNG1.NextDouble() + min;
                return rn;
            }

            /// <summary>
            /// Returns DateTime in the range [min, max)
            /// </summary>
            public static DateTime Next(DateTime min, DateTime max)
            {
                if (max <= min)
                {
                    string message = "Max must be greater than min.";
                    throw new ArgumentException(message);
                }
                long minTicks = min.Ticks;
                long maxTicks = max.Ticks;
                double rn = (Convert.ToDouble(maxTicks)
                   - Convert.ToDouble(minTicks)) * m_RNG1.NextDouble()
                   + Convert.ToDouble(minTicks);
                return new DateTime(Convert.ToInt64(rn));
            }

            /// <summary>
            /// Returns TimeSpan in the range [min, max)
            /// </summary>
            public static TimeSpan Next(TimeSpan min, TimeSpan max)
            {
                if (max <= min)
                {
                    string message = "Max must be greater than min.";
                    throw new ArgumentException(message);
                }

                long minTicks = min.Ticks;
                long maxTicks = max.Ticks;
                double rn = (Convert.ToDouble(maxTicks)
                   - Convert.ToDouble(minTicks)) * m_RNG1.NextDouble()
                   + Convert.ToDouble(minTicks);
                return new TimeSpan(Convert.ToInt64(rn));
            }

            /// <summary>
            /// Returns double in the range [min, max)
            /// </summary>
            public static double NextUniform()
            {
                return Next();
            }

            /// <summary>
            /// Returns a uniformly random integer representing one of the values 
            /// in the enum.
            /// </summary>
            public static int NextEnum(Type enumType)
            {
                int[] values = (int[])Enum.GetValues(enumType);
                int randomIndex = Next(0, values.Length);
                return values[randomIndex];
            }

            #endregion

            public static string NextString(int limit = 255)
            {
                // added spaces so there will be 
                // a higher chance of spacing words
                string legal = "        abcdefghijklmnopqrstuvwxyz" +
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789      ";
                StringBuilder s = new StringBuilder();
                //Random length for the string
                limit = new Random().Next(1, limit);
                for (int i = 0; i < limit; i++)
                    s.Append(legal[new Random().Next(legal.Length)]);
                return s.ToString();
            }


            #region -- Exponential Deviates --

            /// <summary>
            /// Returns an exponentially distributed, positive, random deviate 
            /// of unit mean.
            /// </summary>
            public static double NextExponential()
            {
                double dum = 0.0;
                while (dum == 0.0)
                    dum = NextUniform();
                return -1.0 * System.Math.Log(dum, System.Math.E);
            }

            #endregion

            #region -- Normal Deviates --

            /// <summary>
            /// Returns a normally distributed deviate with zero mean and unit 
            /// variance.
            /// </summary>
            public static double NextNormal()
            {
                // based on algorithm from Numerical Recipes
                if (m_StoredUniformDeviateIsGood)
                {
                    m_StoredUniformDeviateIsGood = false;
                    return m_StoredUniformDeviate;
                }
                else
                {
                    double rsq = 0.0;
                    double v1 = 0.0, v2 = 0.0, fac = 0.0;
                    while (rsq >= 1.0 || rsq == 0.0)
                    {
                        v1 = 2.0 * Next() - 1.0;
                        v2 = 2.0 * Next() - 1.0;
                        rsq = v1 * v1 + v2 * v2;
                    }
                    fac = System.Math.Sqrt(-2.0
                       * System.Math.Log(rsq, System.Math.E) / rsq);
                    m_StoredUniformDeviate = v1 * fac;
                    m_StoredUniformDeviateIsGood = true;
                    return v2 * fac;
                }
            }

            #endregion

        }
    }
}
