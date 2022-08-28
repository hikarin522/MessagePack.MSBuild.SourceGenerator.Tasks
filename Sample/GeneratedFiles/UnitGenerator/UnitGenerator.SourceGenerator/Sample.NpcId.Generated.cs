﻿// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY UnitGenerator. DO NOT CHANGE IT.
// </auto-generated>
#pragma warning disable CS8669
using System;
 
using MessagePack;
using MessagePack.Formatters;

namespace Sample
{
 
    [MessagePackFormatter(typeof(NpcIdMessagePackFormatter))]
    [System.ComponentModel.TypeConverter(typeof(NpcIdTypeConverter))]
    readonly partial struct NpcId : IEquatable<NpcId> 
    {
        readonly System.Ulid value;

        public System.Ulid AsPrimitive() => value;

        public NpcId(System.Ulid value)
        {
            this.value = value;
        }


        public static explicit operator System.Ulid(NpcId value)
        {
            return value.value;
        }

        public static explicit operator NpcId(System.Ulid value)
        {
            return new NpcId(value);
        }

        public bool Equals(NpcId other)
        {
            return value.Equals(other.value);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj.GetType();
            if (t == typeof(NpcId))
            {
                return Equals((NpcId)obj);
            }
            if (t == typeof(System.Ulid))
            {
                return value.Equals((System.Ulid)obj);
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

        public static bool operator ==(in NpcId x, in NpcId y)
        {
            return x.value.Equals(y.value);
        }

        public static bool operator !=(in NpcId x, in NpcId y)
        {
            return !x.value.Equals(y.value);
        }


        public static readonly NpcId Empty = default(NpcId);
        
        public static NpcId New()
        {
            return new NpcId(Ulid.NewUlid());
        }

        public static NpcId NewNpcId()
        {
            return new NpcId(Ulid.NewUlid());
        }









 
        // UnitGenerateOptions.MessagePackFormatter
        private class NpcIdMessagePackFormatter : IMessagePackFormatter<NpcId>
        {
            public void Serialize(ref MessagePackWriter writer, NpcId value, MessagePackSerializerOptions options)
            {
                options.Resolver.GetFormatterWithVerify<System.Ulid>().Serialize(ref writer, value.value, options);
            }

            public NpcId Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
            {
                return new NpcId(options.Resolver.GetFormatterWithVerify<System.Ulid>().Deserialize(ref reader, options));
            }
        }



        // Default
        private class NpcIdTypeConverter : System.ComponentModel.TypeConverter
        {
            private static readonly Type WrapperType = typeof(NpcId);
            private static readonly Type ValueType = typeof(System.Ulid);

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
                    if (t == typeof(NpcId))
                    {
                        return (NpcId)value;
                    }
                    if (t == typeof(System.Ulid))
                    {
                        return new NpcId((System.Ulid)value);
                    }
                }

                return base.ConvertFrom(context, culture, value);
            }

            public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
            {
                if (value is NpcId wrappedValue)
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