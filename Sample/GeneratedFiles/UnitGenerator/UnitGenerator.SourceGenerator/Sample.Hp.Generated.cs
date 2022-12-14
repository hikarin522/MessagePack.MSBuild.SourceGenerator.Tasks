// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY UnitGenerator. DO NOT CHANGE IT.
// </auto-generated>
#pragma warning disable CS8669
using System;
 
using MessagePack;
using MessagePack.Formatters;

namespace Sample
{
 
    [MessagePackFormatter(typeof(HpMessagePackFormatter))]
    [System.ComponentModel.TypeConverter(typeof(HpTypeConverter))]
    readonly partial struct Hp : IEquatable<Hp> , IComparable<Hp>
    {
        readonly int value;

        public int AsPrimitive() => value;

        public Hp(int value)
        {
            this.value = value;
        }


        public static explicit operator int(Hp value)
        {
            return value.value;
        }

        public static explicit operator Hp(int value)
        {
            return new Hp(value);
        }

        public bool Equals(Hp other)
        {
            return value.Equals(other.value);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj.GetType();
            if (t == typeof(Hp))
            {
                return Equals((Hp)obj);
            }
            if (t == typeof(int))
            {
                return value.Equals((int)obj);
            }

            return value.Equals(obj);
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public static bool operator ==(in Hp x, in Hp y)
        {
            return x.value.Equals(y.value);
        }

        public static bool operator !=(in Hp x, in Hp y)
        {
            return !x.value.Equals(y.value);
        }




 
        // UnitGenerateOptions.MinMaxMethod

        public static Hp Min(Hp x, Hp y)
        {
            return new Hp(Math.Min(x.value, y.value));
        }

        public static Hp Max(Hp x, Hp y)
        {
            return new Hp(Math.Max(x.value, y.value));
        }



 
        // UnitGenerateOptions.ArithmeticOperator

        public static Hp operator +(in Hp x, in Hp y)
        {
            checked
            {
                return new Hp((int)(x.value + y.value));
            }
        }

        public static Hp operator -(in Hp x, in Hp y)
        {
            checked
            {
                return new Hp((int)(x.value - y.value));
            }
        }

        public static Hp operator *(in Hp x, in Hp y)
        {
            checked
            {
                return new Hp((int)(x.value * y.value));
            }
        }

        public static Hp operator /(in Hp x, in Hp y)
        {
            checked
            {
                return new Hp((int)(x.value / y.value));
            }
        }


 
        // UnitGenerateOptions.ValueArithmeticOperator

        public static Hp operator ++(in Hp x)
        {
            checked
            {
                return new Hp((int)(x.value + 1));
            }
        }

        public static Hp operator --(in Hp x)
        {
            checked
            {
                return new Hp((int)(x.value - 1));
            }
        }

        public static Hp operator +(in Hp x, in int y)
        {
            checked
            {
                return new Hp((int)(x.value + y));
            }
        }

        public static Hp operator -(in Hp x, in int y)
        {
            checked
            {
                return new Hp((int)(x.value - y));
            }
        }

        public static Hp operator *(in Hp x, in int y)
        {
            checked
            {
                return new Hp((int)(x.value * y));
            }
        }

        public static Hp operator /(in Hp x, in int y)
        {
            checked
            {
                return new Hp((int)(x.value / y));
            }
        }


 
        // UnitGenerateOptions.Comparable

        public int CompareTo(Hp other)
        {
            return value.CompareTo(other.value);
        }

         
        
        public static bool operator >(in Hp x, in Hp y)
        {
            return x.value > y.value;
        }

        public static bool operator <(in Hp x, in Hp y)
        {
            return x.value < y.value;
        }

        public static bool operator >=(in Hp x, in Hp y)
        {
            return x.value >= y.value;
        }

        public static bool operator <=(in Hp x, in Hp y)
        {
            return x.value <= y.value;
        }



 
        // UnitGenerateOptions.MessagePackFormatter
        private class HpMessagePackFormatter : IMessagePackFormatter<Hp>
        {
            public void Serialize(ref MessagePackWriter writer, Hp value, MessagePackSerializerOptions options)
            {
                options.Resolver.GetFormatterWithVerify<int>().Serialize(ref writer, value.value, options);
            }

            public Hp Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
            {
                return new Hp(options.Resolver.GetFormatterWithVerify<int>().Deserialize(ref reader, options));
            }
        }



        // Default
        private class HpTypeConverter : System.ComponentModel.TypeConverter
        {
            private static readonly Type WrapperType = typeof(Hp);
            private static readonly Type ValueType = typeof(int);

            public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, Type sourceType)
            {
                if (sourceType == WrapperType || sourceType == ValueType)
                {
                    return true;
                }

                return base.CanConvertFrom(context, sourceType);
            }

            public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == WrapperType || destinationType == ValueType)
                {
                    return true;
                }

                return base.CanConvertTo(context, destinationType);
            }

            public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
            {
                if (value != null)
                {
                    var t = value.GetType();
                    if (t == typeof(Hp))
                    {
                        return (Hp)value;
                    }
                    if (t == typeof(int))
                    {
                        return new Hp((int)value);
                    }
                }

                return base.ConvertFrom(context, culture, value);
            }

            public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
            {
                if (value is Hp wrappedValue)
                {
                    if (destinationType == WrapperType)
                    {
                        return wrappedValue;
                    }

                    if (destinationType == ValueType)
                    {
                        return wrappedValue.AsPrimitive();
                    }
                }

                return base.ConvertTo(context, culture, value, destinationType);
            }
        }
    }
}
