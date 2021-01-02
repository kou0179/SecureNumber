

using SecureNumber.Encryption;
using System;

namespace SecureNumber.Types
{
    public struct Int16_s : ISecureNumber<Int16, Int16_s>
    {
        private byte[] _value;

        private Int16_s(byte[] value)
        {
            _value = value;
        }

        #region operators

        public static implicit operator Int16_s(Int16 value) => new Int16_s(NumberEncryption.Encryption(value));

        public static Int16_s operator +(Int16_s value) => (Int16)(+NumberEncryption.DecryptionAsInt16(value._value));

                public static Int16_s operator -(Int16_s value) => (Int16)(-NumberEncryption.DecryptionAsInt16(value._value));
        
        public static Int16_s operator ++(Int16_s value) => (Int16)(NumberEncryption.DecryptionAsInt16(value._value) + 1);

        public static Int16_s operator --(Int16_s value) => (Int16)(NumberEncryption.DecryptionAsInt16(value._value) - 1);

        public static Int16_s operator +(Int16_s left, Int16_s right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) + NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator -(Int16_s left, Int16_s right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) - NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator *(Int16_s left, Int16_s right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) * NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator /(Int16_s left, Int16_s right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) / NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator %(Int16_s left, Int16_s right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) % NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator +(Int16_s left, Int16 right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) + right);

        public static Int16_s operator -(Int16_s left, Int16 right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) - right);

        public static Int16_s operator *(Int16_s left, Int16 right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) * right);

        public static Int16_s operator /(Int16_s left, Int16 right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) / right);

        public static Int16_s operator %(Int16_s left, Int16 right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) % right);

        public static Int16_s operator +(Int16 left, Int16_s right) => (Int16)(left + NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator -(Int16 left, Int16_s right) => (Int16)(left - NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator *(Int16 left, Int16_s right) => (Int16)(left * NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator /(Int16 left, Int16_s right) => (Int16)(left / NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator %(Int16 left, Int16_s right) => (Int16)(left % NumberEncryption.DecryptionAsInt16(right._value));

        public static bool operator ==(Int16_s left, Int16_s right) => NumberEncryption.DecryptionAsInt16(left._value) == NumberEncryption.DecryptionAsInt16(right._value);

        public static bool operator !=(Int16_s left, Int16_s right) => NumberEncryption.DecryptionAsInt16(left._value) != NumberEncryption.DecryptionAsInt16(right._value);

        public static bool operator <(Int16_s left, Int16_s right) => NumberEncryption.DecryptionAsInt16(left._value) < NumberEncryption.DecryptionAsInt16(right._value);

        public static bool operator >(Int16_s left, Int16_s right) => NumberEncryption.DecryptionAsInt16(left._value) > NumberEncryption.DecryptionAsInt16(right._value);

        public static bool operator <=(Int16_s left, Int16_s right) => NumberEncryption.DecryptionAsInt16(left._value) <= NumberEncryption.DecryptionAsInt16(right._value);

        public static bool operator >=(Int16_s left, Int16_s right) => NumberEncryption.DecryptionAsInt16(left._value) >= NumberEncryption.DecryptionAsInt16(right._value);

        public static bool operator ==(Int16_s left, Int16 right) => NumberEncryption.DecryptionAsInt16(left._value) == right;

        public static bool operator !=(Int16_s left, Int16 right) => NumberEncryption.DecryptionAsInt16(left._value) != right;

        public static bool operator <(Int16_s left, Int16 right) => NumberEncryption.DecryptionAsInt16(left._value) < right;

        public static bool operator >(Int16_s left, Int16 right) => NumberEncryption.DecryptionAsInt16(left._value) > right;

        public static bool operator <=(Int16_s left, Int16 right) => NumberEncryption.DecryptionAsInt16(left._value) <= right;

        public static bool operator >=(Int16_s left, Int16 right) => NumberEncryption.DecryptionAsInt16(left._value) >= right;

        public static bool operator ==(Int16 left, Int16_s right) => left == NumberEncryption.DecryptionAsInt16(right._value);

        public static bool operator !=(Int16 left, Int16_s right) => left != NumberEncryption.DecryptionAsInt16(right._value);

        public static bool operator <(Int16 left, Int16_s right) => left < NumberEncryption.DecryptionAsInt16(right._value);

        public static bool operator >(Int16 left, Int16_s right) => left > NumberEncryption.DecryptionAsInt16(right._value);

        public static bool operator <=(Int16 left, Int16_s right) => left <= NumberEncryption.DecryptionAsInt16(right._value);

        public static bool operator >=(Int16 left, Int16_s right) => left >= NumberEncryption.DecryptionAsInt16(right._value);

        
        public static Int16_s operator |(Int16_s left, Int16_s right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) | NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator ^(Int16_s left, Int16_s right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) ^ NumberEncryption.DecryptionAsInt16(right._value));
        
        public static Int16_s operator |(Int16_s left, Int16 right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) | right);

        public static Int16_s operator ^(Int16_s left, Int16 right) => (Int16)(NumberEncryption.DecryptionAsInt16(left._value) ^ right);
        
        public static Int16_s operator |(Int16 left, Int16_s right) => (Int16)(left | NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator ^(Int16 left, Int16_s right) => (Int16)(left ^ NumberEncryption.DecryptionAsInt16(right._value));

        public static Int16_s operator <<(Int16_s value, int count) => (Int16)(NumberEncryption.DecryptionAsInt16(value._value) << count);

        public static Int16_s operator >>(Int16_s value, int count) => (Int16)(NumberEncryption.DecryptionAsInt16(value._value) >> count);

                

        #endregion operators

        public Int16 ToPrimitive() => NumberEncryption.DecryptionAsInt16(_value);

        public int CompareTo(object obj)
        {
            if (obj is Int16)
            {
                Int16 thisValue = ToPrimitive();
                if ((Int16)obj < thisValue)
                {
                    return 1;
                }
                else if ((Int16)obj > thisValue)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (obj is Int16_s)
            {
                return CompareTo((Int16_s)obj);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int CompareTo(Int16_s other)
        {
            Int16 thisValue = ToPrimitive();
            Int16 otherValue = NumberEncryption.DecryptionAsInt16(other._value);
            if (otherValue < thisValue)
            {
                return 1;
            }
            else if (otherValue > thisValue)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool Equals(Int16_s other) => this == other;

        public string ToString(string format, IFormatProvider formatProvider) => ToPrimitive().ToString(format, formatProvider);

        public override string ToString() => ToPrimitive().ToString();
    }

    public struct Int32_s : ISecureNumber<Int32, Int32_s>
    {
        private byte[] _value;

        private Int32_s(byte[] value)
        {
            _value = value;
        }

        #region operators

        public static implicit operator Int32_s(Int32 value) => new Int32_s(NumberEncryption.Encryption(value));

        public static Int32_s operator +(Int32_s value) => (Int32)(+NumberEncryption.DecryptionAsInt32(value._value));

                public static Int32_s operator -(Int32_s value) => (Int32)(-NumberEncryption.DecryptionAsInt32(value._value));
        
        public static Int32_s operator ++(Int32_s value) => (Int32)(NumberEncryption.DecryptionAsInt32(value._value) + 1);

        public static Int32_s operator --(Int32_s value) => (Int32)(NumberEncryption.DecryptionAsInt32(value._value) - 1);

        public static Int32_s operator +(Int32_s left, Int32_s right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) + NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator -(Int32_s left, Int32_s right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) - NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator *(Int32_s left, Int32_s right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) * NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator /(Int32_s left, Int32_s right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) / NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator %(Int32_s left, Int32_s right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) % NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator +(Int32_s left, Int32 right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) + right);

        public static Int32_s operator -(Int32_s left, Int32 right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) - right);

        public static Int32_s operator *(Int32_s left, Int32 right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) * right);

        public static Int32_s operator /(Int32_s left, Int32 right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) / right);

        public static Int32_s operator %(Int32_s left, Int32 right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) % right);

        public static Int32_s operator +(Int32 left, Int32_s right) => (Int32)(left + NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator -(Int32 left, Int32_s right) => (Int32)(left - NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator *(Int32 left, Int32_s right) => (Int32)(left * NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator /(Int32 left, Int32_s right) => (Int32)(left / NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator %(Int32 left, Int32_s right) => (Int32)(left % NumberEncryption.DecryptionAsInt32(right._value));

        public static bool operator ==(Int32_s left, Int32_s right) => NumberEncryption.DecryptionAsInt32(left._value) == NumberEncryption.DecryptionAsInt32(right._value);

        public static bool operator !=(Int32_s left, Int32_s right) => NumberEncryption.DecryptionAsInt32(left._value) != NumberEncryption.DecryptionAsInt32(right._value);

        public static bool operator <(Int32_s left, Int32_s right) => NumberEncryption.DecryptionAsInt32(left._value) < NumberEncryption.DecryptionAsInt32(right._value);

        public static bool operator >(Int32_s left, Int32_s right) => NumberEncryption.DecryptionAsInt32(left._value) > NumberEncryption.DecryptionAsInt32(right._value);

        public static bool operator <=(Int32_s left, Int32_s right) => NumberEncryption.DecryptionAsInt32(left._value) <= NumberEncryption.DecryptionAsInt32(right._value);

        public static bool operator >=(Int32_s left, Int32_s right) => NumberEncryption.DecryptionAsInt32(left._value) >= NumberEncryption.DecryptionAsInt32(right._value);

        public static bool operator ==(Int32_s left, Int32 right) => NumberEncryption.DecryptionAsInt32(left._value) == right;

        public static bool operator !=(Int32_s left, Int32 right) => NumberEncryption.DecryptionAsInt32(left._value) != right;

        public static bool operator <(Int32_s left, Int32 right) => NumberEncryption.DecryptionAsInt32(left._value) < right;

        public static bool operator >(Int32_s left, Int32 right) => NumberEncryption.DecryptionAsInt32(left._value) > right;

        public static bool operator <=(Int32_s left, Int32 right) => NumberEncryption.DecryptionAsInt32(left._value) <= right;

        public static bool operator >=(Int32_s left, Int32 right) => NumberEncryption.DecryptionAsInt32(left._value) >= right;

        public static bool operator ==(Int32 left, Int32_s right) => left == NumberEncryption.DecryptionAsInt32(right._value);

        public static bool operator !=(Int32 left, Int32_s right) => left != NumberEncryption.DecryptionAsInt32(right._value);

        public static bool operator <(Int32 left, Int32_s right) => left < NumberEncryption.DecryptionAsInt32(right._value);

        public static bool operator >(Int32 left, Int32_s right) => left > NumberEncryption.DecryptionAsInt32(right._value);

        public static bool operator <=(Int32 left, Int32_s right) => left <= NumberEncryption.DecryptionAsInt32(right._value);

        public static bool operator >=(Int32 left, Int32_s right) => left >= NumberEncryption.DecryptionAsInt32(right._value);

        
        public static Int32_s operator |(Int32_s left, Int32_s right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) | NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator ^(Int32_s left, Int32_s right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) ^ NumberEncryption.DecryptionAsInt32(right._value));
        
        public static Int32_s operator |(Int32_s left, Int32 right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) | right);

        public static Int32_s operator ^(Int32_s left, Int32 right) => (Int32)(NumberEncryption.DecryptionAsInt32(left._value) ^ right);
        
        public static Int32_s operator |(Int32 left, Int32_s right) => (Int32)(left | NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator ^(Int32 left, Int32_s right) => (Int32)(left ^ NumberEncryption.DecryptionAsInt32(right._value));

        public static Int32_s operator <<(Int32_s value, int count) => (Int32)(NumberEncryption.DecryptionAsInt32(value._value) << count);

        public static Int32_s operator >>(Int32_s value, int count) => (Int32)(NumberEncryption.DecryptionAsInt32(value._value) >> count);

                

        #endregion operators

        public Int32 ToPrimitive() => NumberEncryption.DecryptionAsInt32(_value);

        public int CompareTo(object obj)
        {
            if (obj is Int32)
            {
                Int32 thisValue = ToPrimitive();
                if ((Int32)obj < thisValue)
                {
                    return 1;
                }
                else if ((Int32)obj > thisValue)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (obj is Int32_s)
            {
                return CompareTo((Int32_s)obj);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int CompareTo(Int32_s other)
        {
            Int32 thisValue = ToPrimitive();
            Int32 otherValue = NumberEncryption.DecryptionAsInt32(other._value);
            if (otherValue < thisValue)
            {
                return 1;
            }
            else if (otherValue > thisValue)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool Equals(Int32_s other) => this == other;

        public string ToString(string format, IFormatProvider formatProvider) => ToPrimitive().ToString(format, formatProvider);

        public override string ToString() => ToPrimitive().ToString();
    }

    public struct Int64_s : ISecureNumber<Int64, Int64_s>
    {
        private byte[] _value;

        private Int64_s(byte[] value)
        {
            _value = value;
        }

        #region operators

        public static implicit operator Int64_s(Int64 value) => new Int64_s(NumberEncryption.Encryption(value));

        public static Int64_s operator +(Int64_s value) => (Int64)(+NumberEncryption.DecryptionAsInt64(value._value));

                public static Int64_s operator -(Int64_s value) => (Int64)(-NumberEncryption.DecryptionAsInt64(value._value));
        
        public static Int64_s operator ++(Int64_s value) => (Int64)(NumberEncryption.DecryptionAsInt64(value._value) + 1);

        public static Int64_s operator --(Int64_s value) => (Int64)(NumberEncryption.DecryptionAsInt64(value._value) - 1);

        public static Int64_s operator +(Int64_s left, Int64_s right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) + NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator -(Int64_s left, Int64_s right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) - NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator *(Int64_s left, Int64_s right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) * NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator /(Int64_s left, Int64_s right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) / NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator %(Int64_s left, Int64_s right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) % NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator +(Int64_s left, Int64 right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) + right);

        public static Int64_s operator -(Int64_s left, Int64 right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) - right);

        public static Int64_s operator *(Int64_s left, Int64 right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) * right);

        public static Int64_s operator /(Int64_s left, Int64 right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) / right);

        public static Int64_s operator %(Int64_s left, Int64 right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) % right);

        public static Int64_s operator +(Int64 left, Int64_s right) => (Int64)(left + NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator -(Int64 left, Int64_s right) => (Int64)(left - NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator *(Int64 left, Int64_s right) => (Int64)(left * NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator /(Int64 left, Int64_s right) => (Int64)(left / NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator %(Int64 left, Int64_s right) => (Int64)(left % NumberEncryption.DecryptionAsInt64(right._value));

        public static bool operator ==(Int64_s left, Int64_s right) => NumberEncryption.DecryptionAsInt64(left._value) == NumberEncryption.DecryptionAsInt64(right._value);

        public static bool operator !=(Int64_s left, Int64_s right) => NumberEncryption.DecryptionAsInt64(left._value) != NumberEncryption.DecryptionAsInt64(right._value);

        public static bool operator <(Int64_s left, Int64_s right) => NumberEncryption.DecryptionAsInt64(left._value) < NumberEncryption.DecryptionAsInt64(right._value);

        public static bool operator >(Int64_s left, Int64_s right) => NumberEncryption.DecryptionAsInt64(left._value) > NumberEncryption.DecryptionAsInt64(right._value);

        public static bool operator <=(Int64_s left, Int64_s right) => NumberEncryption.DecryptionAsInt64(left._value) <= NumberEncryption.DecryptionAsInt64(right._value);

        public static bool operator >=(Int64_s left, Int64_s right) => NumberEncryption.DecryptionAsInt64(left._value) >= NumberEncryption.DecryptionAsInt64(right._value);

        public static bool operator ==(Int64_s left, Int64 right) => NumberEncryption.DecryptionAsInt64(left._value) == right;

        public static bool operator !=(Int64_s left, Int64 right) => NumberEncryption.DecryptionAsInt64(left._value) != right;

        public static bool operator <(Int64_s left, Int64 right) => NumberEncryption.DecryptionAsInt64(left._value) < right;

        public static bool operator >(Int64_s left, Int64 right) => NumberEncryption.DecryptionAsInt64(left._value) > right;

        public static bool operator <=(Int64_s left, Int64 right) => NumberEncryption.DecryptionAsInt64(left._value) <= right;

        public static bool operator >=(Int64_s left, Int64 right) => NumberEncryption.DecryptionAsInt64(left._value) >= right;

        public static bool operator ==(Int64 left, Int64_s right) => left == NumberEncryption.DecryptionAsInt64(right._value);

        public static bool operator !=(Int64 left, Int64_s right) => left != NumberEncryption.DecryptionAsInt64(right._value);

        public static bool operator <(Int64 left, Int64_s right) => left < NumberEncryption.DecryptionAsInt64(right._value);

        public static bool operator >(Int64 left, Int64_s right) => left > NumberEncryption.DecryptionAsInt64(right._value);

        public static bool operator <=(Int64 left, Int64_s right) => left <= NumberEncryption.DecryptionAsInt64(right._value);

        public static bool operator >=(Int64 left, Int64_s right) => left >= NumberEncryption.DecryptionAsInt64(right._value);

        
        public static Int64_s operator |(Int64_s left, Int64_s right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) | NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator ^(Int64_s left, Int64_s right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) ^ NumberEncryption.DecryptionAsInt64(right._value));
        
        public static Int64_s operator |(Int64_s left, Int64 right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) | right);

        public static Int64_s operator ^(Int64_s left, Int64 right) => (Int64)(NumberEncryption.DecryptionAsInt64(left._value) ^ right);
        
        public static Int64_s operator |(Int64 left, Int64_s right) => (Int64)(left | NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator ^(Int64 left, Int64_s right) => (Int64)(left ^ NumberEncryption.DecryptionAsInt64(right._value));

        public static Int64_s operator <<(Int64_s value, int count) => (Int64)(NumberEncryption.DecryptionAsInt64(value._value) << count);

        public static Int64_s operator >>(Int64_s value, int count) => (Int64)(NumberEncryption.DecryptionAsInt64(value._value) >> count);

                

        #endregion operators

        public Int64 ToPrimitive() => NumberEncryption.DecryptionAsInt64(_value);

        public int CompareTo(object obj)
        {
            if (obj is Int64)
            {
                Int64 thisValue = ToPrimitive();
                if ((Int64)obj < thisValue)
                {
                    return 1;
                }
                else if ((Int64)obj > thisValue)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (obj is Int64_s)
            {
                return CompareTo((Int64_s)obj);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int CompareTo(Int64_s other)
        {
            Int64 thisValue = ToPrimitive();
            Int64 otherValue = NumberEncryption.DecryptionAsInt64(other._value);
            if (otherValue < thisValue)
            {
                return 1;
            }
            else if (otherValue > thisValue)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool Equals(Int64_s other) => this == other;

        public string ToString(string format, IFormatProvider formatProvider) => ToPrimitive().ToString(format, formatProvider);

        public override string ToString() => ToPrimitive().ToString();
    }

    public struct Single_s : ISecureNumber<Single, Single_s>
    {
        private byte[] _value;

        private Single_s(byte[] value)
        {
            _value = value;
        }

        #region operators

        public static implicit operator Single_s(Single value) => new Single_s(NumberEncryption.Encryption(value));

        public static Single_s operator +(Single_s value) => (Single)(+NumberEncryption.DecryptionAsSingle(value._value));

                public static Single_s operator -(Single_s value) => (Single)(-NumberEncryption.DecryptionAsSingle(value._value));
        
        public static Single_s operator ++(Single_s value) => (Single)(NumberEncryption.DecryptionAsSingle(value._value) + 1);

        public static Single_s operator --(Single_s value) => (Single)(NumberEncryption.DecryptionAsSingle(value._value) - 1);

        public static Single_s operator +(Single_s left, Single_s right) => (Single)(NumberEncryption.DecryptionAsSingle(left._value) + NumberEncryption.DecryptionAsSingle(right._value));

        public static Single_s operator -(Single_s left, Single_s right) => (Single)(NumberEncryption.DecryptionAsSingle(left._value) - NumberEncryption.DecryptionAsSingle(right._value));

        public static Single_s operator *(Single_s left, Single_s right) => (Single)(NumberEncryption.DecryptionAsSingle(left._value) * NumberEncryption.DecryptionAsSingle(right._value));

        public static Single_s operator /(Single_s left, Single_s right) => (Single)(NumberEncryption.DecryptionAsSingle(left._value) / NumberEncryption.DecryptionAsSingle(right._value));

        public static Single_s operator %(Single_s left, Single_s right) => (Single)(NumberEncryption.DecryptionAsSingle(left._value) % NumberEncryption.DecryptionAsSingle(right._value));

        public static Single_s operator +(Single_s left, Single right) => (Single)(NumberEncryption.DecryptionAsSingle(left._value) + right);

        public static Single_s operator -(Single_s left, Single right) => (Single)(NumberEncryption.DecryptionAsSingle(left._value) - right);

        public static Single_s operator *(Single_s left, Single right) => (Single)(NumberEncryption.DecryptionAsSingle(left._value) * right);

        public static Single_s operator /(Single_s left, Single right) => (Single)(NumberEncryption.DecryptionAsSingle(left._value) / right);

        public static Single_s operator %(Single_s left, Single right) => (Single)(NumberEncryption.DecryptionAsSingle(left._value) % right);

        public static Single_s operator +(Single left, Single_s right) => (Single)(left + NumberEncryption.DecryptionAsSingle(right._value));

        public static Single_s operator -(Single left, Single_s right) => (Single)(left - NumberEncryption.DecryptionAsSingle(right._value));

        public static Single_s operator *(Single left, Single_s right) => (Single)(left * NumberEncryption.DecryptionAsSingle(right._value));

        public static Single_s operator /(Single left, Single_s right) => (Single)(left / NumberEncryption.DecryptionAsSingle(right._value));

        public static Single_s operator %(Single left, Single_s right) => (Single)(left % NumberEncryption.DecryptionAsSingle(right._value));

        public static bool operator ==(Single_s left, Single_s right) => NumberEncryption.DecryptionAsSingle(left._value) == NumberEncryption.DecryptionAsSingle(right._value);

        public static bool operator !=(Single_s left, Single_s right) => NumberEncryption.DecryptionAsSingle(left._value) != NumberEncryption.DecryptionAsSingle(right._value);

        public static bool operator <(Single_s left, Single_s right) => NumberEncryption.DecryptionAsSingle(left._value) < NumberEncryption.DecryptionAsSingle(right._value);

        public static bool operator >(Single_s left, Single_s right) => NumberEncryption.DecryptionAsSingle(left._value) > NumberEncryption.DecryptionAsSingle(right._value);

        public static bool operator <=(Single_s left, Single_s right) => NumberEncryption.DecryptionAsSingle(left._value) <= NumberEncryption.DecryptionAsSingle(right._value);

        public static bool operator >=(Single_s left, Single_s right) => NumberEncryption.DecryptionAsSingle(left._value) >= NumberEncryption.DecryptionAsSingle(right._value);

        public static bool operator ==(Single_s left, Single right) => NumberEncryption.DecryptionAsSingle(left._value) == right;

        public static bool operator !=(Single_s left, Single right) => NumberEncryption.DecryptionAsSingle(left._value) != right;

        public static bool operator <(Single_s left, Single right) => NumberEncryption.DecryptionAsSingle(left._value) < right;

        public static bool operator >(Single_s left, Single right) => NumberEncryption.DecryptionAsSingle(left._value) > right;

        public static bool operator <=(Single_s left, Single right) => NumberEncryption.DecryptionAsSingle(left._value) <= right;

        public static bool operator >=(Single_s left, Single right) => NumberEncryption.DecryptionAsSingle(left._value) >= right;

        public static bool operator ==(Single left, Single_s right) => left == NumberEncryption.DecryptionAsSingle(right._value);

        public static bool operator !=(Single left, Single_s right) => left != NumberEncryption.DecryptionAsSingle(right._value);

        public static bool operator <(Single left, Single_s right) => left < NumberEncryption.DecryptionAsSingle(right._value);

        public static bool operator >(Single left, Single_s right) => left > NumberEncryption.DecryptionAsSingle(right._value);

        public static bool operator <=(Single left, Single_s right) => left <= NumberEncryption.DecryptionAsSingle(right._value);

        public static bool operator >=(Single left, Single_s right) => left >= NumberEncryption.DecryptionAsSingle(right._value);

                

        #endregion operators

        public Single ToPrimitive() => NumberEncryption.DecryptionAsSingle(_value);

        public int CompareTo(object obj)
        {
            if (obj is Single)
            {
                Single thisValue = ToPrimitive();
                if ((Single)obj < thisValue)
                {
                    return 1;
                }
                else if ((Single)obj > thisValue)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (obj is Single_s)
            {
                return CompareTo((Single_s)obj);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int CompareTo(Single_s other)
        {
            Single thisValue = ToPrimitive();
            Single otherValue = NumberEncryption.DecryptionAsSingle(other._value);
            if (otherValue < thisValue)
            {
                return 1;
            }
            else if (otherValue > thisValue)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool Equals(Single_s other) => this == other;

        public string ToString(string format, IFormatProvider formatProvider) => ToPrimitive().ToString(format, formatProvider);

        public override string ToString() => ToPrimitive().ToString();
    }

    public struct Double_s : ISecureNumber<Double, Double_s>
    {
        private byte[] _value;

        private Double_s(byte[] value)
        {
            _value = value;
        }

        #region operators

        public static implicit operator Double_s(Double value) => new Double_s(NumberEncryption.Encryption(value));

        public static Double_s operator +(Double_s value) => (Double)(+NumberEncryption.DecryptionAsDouble(value._value));

                public static Double_s operator -(Double_s value) => (Double)(-NumberEncryption.DecryptionAsDouble(value._value));
        
        public static Double_s operator ++(Double_s value) => (Double)(NumberEncryption.DecryptionAsDouble(value._value) + 1);

        public static Double_s operator --(Double_s value) => (Double)(NumberEncryption.DecryptionAsDouble(value._value) - 1);

        public static Double_s operator +(Double_s left, Double_s right) => (Double)(NumberEncryption.DecryptionAsDouble(left._value) + NumberEncryption.DecryptionAsDouble(right._value));

        public static Double_s operator -(Double_s left, Double_s right) => (Double)(NumberEncryption.DecryptionAsDouble(left._value) - NumberEncryption.DecryptionAsDouble(right._value));

        public static Double_s operator *(Double_s left, Double_s right) => (Double)(NumberEncryption.DecryptionAsDouble(left._value) * NumberEncryption.DecryptionAsDouble(right._value));

        public static Double_s operator /(Double_s left, Double_s right) => (Double)(NumberEncryption.DecryptionAsDouble(left._value) / NumberEncryption.DecryptionAsDouble(right._value));

        public static Double_s operator %(Double_s left, Double_s right) => (Double)(NumberEncryption.DecryptionAsDouble(left._value) % NumberEncryption.DecryptionAsDouble(right._value));

        public static Double_s operator +(Double_s left, Double right) => (Double)(NumberEncryption.DecryptionAsDouble(left._value) + right);

        public static Double_s operator -(Double_s left, Double right) => (Double)(NumberEncryption.DecryptionAsDouble(left._value) - right);

        public static Double_s operator *(Double_s left, Double right) => (Double)(NumberEncryption.DecryptionAsDouble(left._value) * right);

        public static Double_s operator /(Double_s left, Double right) => (Double)(NumberEncryption.DecryptionAsDouble(left._value) / right);

        public static Double_s operator %(Double_s left, Double right) => (Double)(NumberEncryption.DecryptionAsDouble(left._value) % right);

        public static Double_s operator +(Double left, Double_s right) => (Double)(left + NumberEncryption.DecryptionAsDouble(right._value));

        public static Double_s operator -(Double left, Double_s right) => (Double)(left - NumberEncryption.DecryptionAsDouble(right._value));

        public static Double_s operator *(Double left, Double_s right) => (Double)(left * NumberEncryption.DecryptionAsDouble(right._value));

        public static Double_s operator /(Double left, Double_s right) => (Double)(left / NumberEncryption.DecryptionAsDouble(right._value));

        public static Double_s operator %(Double left, Double_s right) => (Double)(left % NumberEncryption.DecryptionAsDouble(right._value));

        public static bool operator ==(Double_s left, Double_s right) => NumberEncryption.DecryptionAsDouble(left._value) == NumberEncryption.DecryptionAsDouble(right._value);

        public static bool operator !=(Double_s left, Double_s right) => NumberEncryption.DecryptionAsDouble(left._value) != NumberEncryption.DecryptionAsDouble(right._value);

        public static bool operator <(Double_s left, Double_s right) => NumberEncryption.DecryptionAsDouble(left._value) < NumberEncryption.DecryptionAsDouble(right._value);

        public static bool operator >(Double_s left, Double_s right) => NumberEncryption.DecryptionAsDouble(left._value) > NumberEncryption.DecryptionAsDouble(right._value);

        public static bool operator <=(Double_s left, Double_s right) => NumberEncryption.DecryptionAsDouble(left._value) <= NumberEncryption.DecryptionAsDouble(right._value);

        public static bool operator >=(Double_s left, Double_s right) => NumberEncryption.DecryptionAsDouble(left._value) >= NumberEncryption.DecryptionAsDouble(right._value);

        public static bool operator ==(Double_s left, Double right) => NumberEncryption.DecryptionAsDouble(left._value) == right;

        public static bool operator !=(Double_s left, Double right) => NumberEncryption.DecryptionAsDouble(left._value) != right;

        public static bool operator <(Double_s left, Double right) => NumberEncryption.DecryptionAsDouble(left._value) < right;

        public static bool operator >(Double_s left, Double right) => NumberEncryption.DecryptionAsDouble(left._value) > right;

        public static bool operator <=(Double_s left, Double right) => NumberEncryption.DecryptionAsDouble(left._value) <= right;

        public static bool operator >=(Double_s left, Double right) => NumberEncryption.DecryptionAsDouble(left._value) >= right;

        public static bool operator ==(Double left, Double_s right) => left == NumberEncryption.DecryptionAsDouble(right._value);

        public static bool operator !=(Double left, Double_s right) => left != NumberEncryption.DecryptionAsDouble(right._value);

        public static bool operator <(Double left, Double_s right) => left < NumberEncryption.DecryptionAsDouble(right._value);

        public static bool operator >(Double left, Double_s right) => left > NumberEncryption.DecryptionAsDouble(right._value);

        public static bool operator <=(Double left, Double_s right) => left <= NumberEncryption.DecryptionAsDouble(right._value);

        public static bool operator >=(Double left, Double_s right) => left >= NumberEncryption.DecryptionAsDouble(right._value);

                

        #endregion operators

        public Double ToPrimitive() => NumberEncryption.DecryptionAsDouble(_value);

        public int CompareTo(object obj)
        {
            if (obj is Double)
            {
                Double thisValue = ToPrimitive();
                if ((Double)obj < thisValue)
                {
                    return 1;
                }
                else if ((Double)obj > thisValue)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (obj is Double_s)
            {
                return CompareTo((Double_s)obj);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int CompareTo(Double_s other)
        {
            Double thisValue = ToPrimitive();
            Double otherValue = NumberEncryption.DecryptionAsDouble(other._value);
            if (otherValue < thisValue)
            {
                return 1;
            }
            else if (otherValue > thisValue)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool Equals(Double_s other) => this == other;

        public string ToString(string format, IFormatProvider formatProvider) => ToPrimitive().ToString(format, formatProvider);

        public override string ToString() => ToPrimitive().ToString();
    }

    public struct UInt16_s : ISecureNumber<UInt16, UInt16_s>
    {
        private byte[] _value;

        private UInt16_s(byte[] value)
        {
            _value = value;
        }

        #region operators

        public static implicit operator UInt16_s(UInt16 value) => new UInt16_s(NumberEncryption.Encryption(value));

        public static UInt16_s operator +(UInt16_s value) => (UInt16)(+NumberEncryption.DecryptionAsUInt16(value._value));

                public static UInt16_s operator -(UInt16_s value) => (UInt16)(-NumberEncryption.DecryptionAsUInt16(value._value));
        
        public static UInt16_s operator ++(UInt16_s value) => (UInt16)(NumberEncryption.DecryptionAsUInt16(value._value) + 1);

        public static UInt16_s operator --(UInt16_s value) => (UInt16)(NumberEncryption.DecryptionAsUInt16(value._value) - 1);

        public static UInt16_s operator +(UInt16_s left, UInt16_s right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) + NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator -(UInt16_s left, UInt16_s right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) - NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator *(UInt16_s left, UInt16_s right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) * NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator /(UInt16_s left, UInt16_s right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) / NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator %(UInt16_s left, UInt16_s right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) % NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator +(UInt16_s left, UInt16 right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) + right);

        public static UInt16_s operator -(UInt16_s left, UInt16 right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) - right);

        public static UInt16_s operator *(UInt16_s left, UInt16 right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) * right);

        public static UInt16_s operator /(UInt16_s left, UInt16 right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) / right);

        public static UInt16_s operator %(UInt16_s left, UInt16 right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) % right);

        public static UInt16_s operator +(UInt16 left, UInt16_s right) => (UInt16)(left + NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator -(UInt16 left, UInt16_s right) => (UInt16)(left - NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator *(UInt16 left, UInt16_s right) => (UInt16)(left * NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator /(UInt16 left, UInt16_s right) => (UInt16)(left / NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator %(UInt16 left, UInt16_s right) => (UInt16)(left % NumberEncryption.DecryptionAsUInt16(right._value));

        public static bool operator ==(UInt16_s left, UInt16_s right) => NumberEncryption.DecryptionAsUInt16(left._value) == NumberEncryption.DecryptionAsUInt16(right._value);

        public static bool operator !=(UInt16_s left, UInt16_s right) => NumberEncryption.DecryptionAsUInt16(left._value) != NumberEncryption.DecryptionAsUInt16(right._value);

        public static bool operator <(UInt16_s left, UInt16_s right) => NumberEncryption.DecryptionAsUInt16(left._value) < NumberEncryption.DecryptionAsUInt16(right._value);

        public static bool operator >(UInt16_s left, UInt16_s right) => NumberEncryption.DecryptionAsUInt16(left._value) > NumberEncryption.DecryptionAsUInt16(right._value);

        public static bool operator <=(UInt16_s left, UInt16_s right) => NumberEncryption.DecryptionAsUInt16(left._value) <= NumberEncryption.DecryptionAsUInt16(right._value);

        public static bool operator >=(UInt16_s left, UInt16_s right) => NumberEncryption.DecryptionAsUInt16(left._value) >= NumberEncryption.DecryptionAsUInt16(right._value);

        public static bool operator ==(UInt16_s left, UInt16 right) => NumberEncryption.DecryptionAsUInt16(left._value) == right;

        public static bool operator !=(UInt16_s left, UInt16 right) => NumberEncryption.DecryptionAsUInt16(left._value) != right;

        public static bool operator <(UInt16_s left, UInt16 right) => NumberEncryption.DecryptionAsUInt16(left._value) < right;

        public static bool operator >(UInt16_s left, UInt16 right) => NumberEncryption.DecryptionAsUInt16(left._value) > right;

        public static bool operator <=(UInt16_s left, UInt16 right) => NumberEncryption.DecryptionAsUInt16(left._value) <= right;

        public static bool operator >=(UInt16_s left, UInt16 right) => NumberEncryption.DecryptionAsUInt16(left._value) >= right;

        public static bool operator ==(UInt16 left, UInt16_s right) => left == NumberEncryption.DecryptionAsUInt16(right._value);

        public static bool operator !=(UInt16 left, UInt16_s right) => left != NumberEncryption.DecryptionAsUInt16(right._value);

        public static bool operator <(UInt16 left, UInt16_s right) => left < NumberEncryption.DecryptionAsUInt16(right._value);

        public static bool operator >(UInt16 left, UInt16_s right) => left > NumberEncryption.DecryptionAsUInt16(right._value);

        public static bool operator <=(UInt16 left, UInt16_s right) => left <= NumberEncryption.DecryptionAsUInt16(right._value);

        public static bool operator >=(UInt16 left, UInt16_s right) => left >= NumberEncryption.DecryptionAsUInt16(right._value);

        
        public static UInt16_s operator |(UInt16_s left, UInt16_s right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) | NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator ^(UInt16_s left, UInt16_s right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) ^ NumberEncryption.DecryptionAsUInt16(right._value));
        
        public static UInt16_s operator |(UInt16_s left, UInt16 right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) | right);

        public static UInt16_s operator ^(UInt16_s left, UInt16 right) => (UInt16)(NumberEncryption.DecryptionAsUInt16(left._value) ^ right);
        
        public static UInt16_s operator |(UInt16 left, UInt16_s right) => (UInt16)(left | NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator ^(UInt16 left, UInt16_s right) => (UInt16)(left ^ NumberEncryption.DecryptionAsUInt16(right._value));

        public static UInt16_s operator <<(UInt16_s value, int count) => (UInt16)(NumberEncryption.DecryptionAsUInt16(value._value) << count);

        public static UInt16_s operator >>(UInt16_s value, int count) => (UInt16)(NumberEncryption.DecryptionAsUInt16(value._value) >> count);

                

        #endregion operators

        public UInt16 ToPrimitive() => NumberEncryption.DecryptionAsUInt16(_value);

        public int CompareTo(object obj)
        {
            if (obj is UInt16)
            {
                UInt16 thisValue = ToPrimitive();
                if ((UInt16)obj < thisValue)
                {
                    return 1;
                }
                else if ((UInt16)obj > thisValue)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (obj is UInt16_s)
            {
                return CompareTo((UInt16_s)obj);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int CompareTo(UInt16_s other)
        {
            UInt16 thisValue = ToPrimitive();
            UInt16 otherValue = NumberEncryption.DecryptionAsUInt16(other._value);
            if (otherValue < thisValue)
            {
                return 1;
            }
            else if (otherValue > thisValue)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool Equals(UInt16_s other) => this == other;

        public string ToString(string format, IFormatProvider formatProvider) => ToPrimitive().ToString(format, formatProvider);

        public override string ToString() => ToPrimitive().ToString();
    }

    public struct UInt32_s : ISecureNumber<UInt32, UInt32_s>
    {
        private byte[] _value;

        private UInt32_s(byte[] value)
        {
            _value = value;
        }

        #region operators

        public static implicit operator UInt32_s(UInt32 value) => new UInt32_s(NumberEncryption.Encryption(value));

        public static UInt32_s operator +(UInt32_s value) => (UInt32)(+NumberEncryption.DecryptionAsUInt32(value._value));

                public static UInt32_s operator -(UInt32_s value) => (UInt32)(-NumberEncryption.DecryptionAsUInt32(value._value));
        
        public static UInt32_s operator ++(UInt32_s value) => (UInt32)(NumberEncryption.DecryptionAsUInt32(value._value) + 1);

        public static UInt32_s operator --(UInt32_s value) => (UInt32)(NumberEncryption.DecryptionAsUInt32(value._value) - 1);

        public static UInt32_s operator +(UInt32_s left, UInt32_s right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) + NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator -(UInt32_s left, UInt32_s right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) - NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator *(UInt32_s left, UInt32_s right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) * NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator /(UInt32_s left, UInt32_s right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) / NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator %(UInt32_s left, UInt32_s right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) % NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator +(UInt32_s left, UInt32 right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) + right);

        public static UInt32_s operator -(UInt32_s left, UInt32 right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) - right);

        public static UInt32_s operator *(UInt32_s left, UInt32 right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) * right);

        public static UInt32_s operator /(UInt32_s left, UInt32 right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) / right);

        public static UInt32_s operator %(UInt32_s left, UInt32 right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) % right);

        public static UInt32_s operator +(UInt32 left, UInt32_s right) => (UInt32)(left + NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator -(UInt32 left, UInt32_s right) => (UInt32)(left - NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator *(UInt32 left, UInt32_s right) => (UInt32)(left * NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator /(UInt32 left, UInt32_s right) => (UInt32)(left / NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator %(UInt32 left, UInt32_s right) => (UInt32)(left % NumberEncryption.DecryptionAsUInt32(right._value));

        public static bool operator ==(UInt32_s left, UInt32_s right) => NumberEncryption.DecryptionAsUInt32(left._value) == NumberEncryption.DecryptionAsUInt32(right._value);

        public static bool operator !=(UInt32_s left, UInt32_s right) => NumberEncryption.DecryptionAsUInt32(left._value) != NumberEncryption.DecryptionAsUInt32(right._value);

        public static bool operator <(UInt32_s left, UInt32_s right) => NumberEncryption.DecryptionAsUInt32(left._value) < NumberEncryption.DecryptionAsUInt32(right._value);

        public static bool operator >(UInt32_s left, UInt32_s right) => NumberEncryption.DecryptionAsUInt32(left._value) > NumberEncryption.DecryptionAsUInt32(right._value);

        public static bool operator <=(UInt32_s left, UInt32_s right) => NumberEncryption.DecryptionAsUInt32(left._value) <= NumberEncryption.DecryptionAsUInt32(right._value);

        public static bool operator >=(UInt32_s left, UInt32_s right) => NumberEncryption.DecryptionAsUInt32(left._value) >= NumberEncryption.DecryptionAsUInt32(right._value);

        public static bool operator ==(UInt32_s left, UInt32 right) => NumberEncryption.DecryptionAsUInt32(left._value) == right;

        public static bool operator !=(UInt32_s left, UInt32 right) => NumberEncryption.DecryptionAsUInt32(left._value) != right;

        public static bool operator <(UInt32_s left, UInt32 right) => NumberEncryption.DecryptionAsUInt32(left._value) < right;

        public static bool operator >(UInt32_s left, UInt32 right) => NumberEncryption.DecryptionAsUInt32(left._value) > right;

        public static bool operator <=(UInt32_s left, UInt32 right) => NumberEncryption.DecryptionAsUInt32(left._value) <= right;

        public static bool operator >=(UInt32_s left, UInt32 right) => NumberEncryption.DecryptionAsUInt32(left._value) >= right;

        public static bool operator ==(UInt32 left, UInt32_s right) => left == NumberEncryption.DecryptionAsUInt32(right._value);

        public static bool operator !=(UInt32 left, UInt32_s right) => left != NumberEncryption.DecryptionAsUInt32(right._value);

        public static bool operator <(UInt32 left, UInt32_s right) => left < NumberEncryption.DecryptionAsUInt32(right._value);

        public static bool operator >(UInt32 left, UInt32_s right) => left > NumberEncryption.DecryptionAsUInt32(right._value);

        public static bool operator <=(UInt32 left, UInt32_s right) => left <= NumberEncryption.DecryptionAsUInt32(right._value);

        public static bool operator >=(UInt32 left, UInt32_s right) => left >= NumberEncryption.DecryptionAsUInt32(right._value);

        
        public static UInt32_s operator |(UInt32_s left, UInt32_s right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) | NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator ^(UInt32_s left, UInt32_s right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) ^ NumberEncryption.DecryptionAsUInt32(right._value));
        
        public static UInt32_s operator |(UInt32_s left, UInt32 right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) | right);

        public static UInt32_s operator ^(UInt32_s left, UInt32 right) => (UInt32)(NumberEncryption.DecryptionAsUInt32(left._value) ^ right);
        
        public static UInt32_s operator |(UInt32 left, UInt32_s right) => (UInt32)(left | NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator ^(UInt32 left, UInt32_s right) => (UInt32)(left ^ NumberEncryption.DecryptionAsUInt32(right._value));

        public static UInt32_s operator <<(UInt32_s value, int count) => (UInt32)(NumberEncryption.DecryptionAsUInt32(value._value) << count);

        public static UInt32_s operator >>(UInt32_s value, int count) => (UInt32)(NumberEncryption.DecryptionAsUInt32(value._value) >> count);

                

        #endregion operators

        public UInt32 ToPrimitive() => NumberEncryption.DecryptionAsUInt32(_value);

        public int CompareTo(object obj)
        {
            if (obj is UInt32)
            {
                UInt32 thisValue = ToPrimitive();
                if ((UInt32)obj < thisValue)
                {
                    return 1;
                }
                else if ((UInt32)obj > thisValue)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (obj is UInt32_s)
            {
                return CompareTo((UInt32_s)obj);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int CompareTo(UInt32_s other)
        {
            UInt32 thisValue = ToPrimitive();
            UInt32 otherValue = NumberEncryption.DecryptionAsUInt32(other._value);
            if (otherValue < thisValue)
            {
                return 1;
            }
            else if (otherValue > thisValue)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool Equals(UInt32_s other) => this == other;

        public string ToString(string format, IFormatProvider formatProvider) => ToPrimitive().ToString(format, formatProvider);

        public override string ToString() => ToPrimitive().ToString();
    }

    public struct UInt64_s : ISecureNumber<UInt64, UInt64_s>
    {
        private byte[] _value;

        private UInt64_s(byte[] value)
        {
            _value = value;
        }

        #region operators

        public static implicit operator UInt64_s(UInt64 value) => new UInt64_s(NumberEncryption.Encryption(value));

        public static UInt64_s operator +(UInt64_s value) => (UInt64)(+NumberEncryption.DecryptionAsUInt64(value._value));

        
        public static UInt64_s operator ++(UInt64_s value) => (UInt64)(NumberEncryption.DecryptionAsUInt64(value._value) + 1);

        public static UInt64_s operator --(UInt64_s value) => (UInt64)(NumberEncryption.DecryptionAsUInt64(value._value) - 1);

        public static UInt64_s operator +(UInt64_s left, UInt64_s right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) + NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator -(UInt64_s left, UInt64_s right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) - NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator *(UInt64_s left, UInt64_s right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) * NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator /(UInt64_s left, UInt64_s right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) / NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator %(UInt64_s left, UInt64_s right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) % NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator +(UInt64_s left, UInt64 right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) + right);

        public static UInt64_s operator -(UInt64_s left, UInt64 right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) - right);

        public static UInt64_s operator *(UInt64_s left, UInt64 right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) * right);

        public static UInt64_s operator /(UInt64_s left, UInt64 right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) / right);

        public static UInt64_s operator %(UInt64_s left, UInt64 right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) % right);

        public static UInt64_s operator +(UInt64 left, UInt64_s right) => (UInt64)(left + NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator -(UInt64 left, UInt64_s right) => (UInt64)(left - NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator *(UInt64 left, UInt64_s right) => (UInt64)(left * NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator /(UInt64 left, UInt64_s right) => (UInt64)(left / NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator %(UInt64 left, UInt64_s right) => (UInt64)(left % NumberEncryption.DecryptionAsUInt64(right._value));

        public static bool operator ==(UInt64_s left, UInt64_s right) => NumberEncryption.DecryptionAsUInt64(left._value) == NumberEncryption.DecryptionAsUInt64(right._value);

        public static bool operator !=(UInt64_s left, UInt64_s right) => NumberEncryption.DecryptionAsUInt64(left._value) != NumberEncryption.DecryptionAsUInt64(right._value);

        public static bool operator <(UInt64_s left, UInt64_s right) => NumberEncryption.DecryptionAsUInt64(left._value) < NumberEncryption.DecryptionAsUInt64(right._value);

        public static bool operator >(UInt64_s left, UInt64_s right) => NumberEncryption.DecryptionAsUInt64(left._value) > NumberEncryption.DecryptionAsUInt64(right._value);

        public static bool operator <=(UInt64_s left, UInt64_s right) => NumberEncryption.DecryptionAsUInt64(left._value) <= NumberEncryption.DecryptionAsUInt64(right._value);

        public static bool operator >=(UInt64_s left, UInt64_s right) => NumberEncryption.DecryptionAsUInt64(left._value) >= NumberEncryption.DecryptionAsUInt64(right._value);

        public static bool operator ==(UInt64_s left, UInt64 right) => NumberEncryption.DecryptionAsUInt64(left._value) == right;

        public static bool operator !=(UInt64_s left, UInt64 right) => NumberEncryption.DecryptionAsUInt64(left._value) != right;

        public static bool operator <(UInt64_s left, UInt64 right) => NumberEncryption.DecryptionAsUInt64(left._value) < right;

        public static bool operator >(UInt64_s left, UInt64 right) => NumberEncryption.DecryptionAsUInt64(left._value) > right;

        public static bool operator <=(UInt64_s left, UInt64 right) => NumberEncryption.DecryptionAsUInt64(left._value) <= right;

        public static bool operator >=(UInt64_s left, UInt64 right) => NumberEncryption.DecryptionAsUInt64(left._value) >= right;

        public static bool operator ==(UInt64 left, UInt64_s right) => left == NumberEncryption.DecryptionAsUInt64(right._value);

        public static bool operator !=(UInt64 left, UInt64_s right) => left != NumberEncryption.DecryptionAsUInt64(right._value);

        public static bool operator <(UInt64 left, UInt64_s right) => left < NumberEncryption.DecryptionAsUInt64(right._value);

        public static bool operator >(UInt64 left, UInt64_s right) => left > NumberEncryption.DecryptionAsUInt64(right._value);

        public static bool operator <=(UInt64 left, UInt64_s right) => left <= NumberEncryption.DecryptionAsUInt64(right._value);

        public static bool operator >=(UInt64 left, UInt64_s right) => left >= NumberEncryption.DecryptionAsUInt64(right._value);

        
        public static UInt64_s operator |(UInt64_s left, UInt64_s right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) | NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator ^(UInt64_s left, UInt64_s right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) ^ NumberEncryption.DecryptionAsUInt64(right._value));
        
        public static UInt64_s operator |(UInt64_s left, UInt64 right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) | right);

        public static UInt64_s operator ^(UInt64_s left, UInt64 right) => (UInt64)(NumberEncryption.DecryptionAsUInt64(left._value) ^ right);
        
        public static UInt64_s operator |(UInt64 left, UInt64_s right) => (UInt64)(left | NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator ^(UInt64 left, UInt64_s right) => (UInt64)(left ^ NumberEncryption.DecryptionAsUInt64(right._value));

        public static UInt64_s operator <<(UInt64_s value, int count) => (UInt64)(NumberEncryption.DecryptionAsUInt64(value._value) << count);

        public static UInt64_s operator >>(UInt64_s value, int count) => (UInt64)(NumberEncryption.DecryptionAsUInt64(value._value) >> count);

                

        #endregion operators

        public UInt64 ToPrimitive() => NumberEncryption.DecryptionAsUInt64(_value);

        public int CompareTo(object obj)
        {
            if (obj is UInt64)
            {
                UInt64 thisValue = ToPrimitive();
                if ((UInt64)obj < thisValue)
                {
                    return 1;
                }
                else if ((UInt64)obj > thisValue)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (obj is UInt64_s)
            {
                return CompareTo((UInt64_s)obj);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int CompareTo(UInt64_s other)
        {
            UInt64 thisValue = ToPrimitive();
            UInt64 otherValue = NumberEncryption.DecryptionAsUInt64(other._value);
            if (otherValue < thisValue)
            {
                return 1;
            }
            else if (otherValue > thisValue)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool Equals(UInt64_s other) => this == other;

        public string ToString(string format, IFormatProvider formatProvider) => ToPrimitive().ToString(format, formatProvider);

        public override string ToString() => ToPrimitive().ToString();
    }

}