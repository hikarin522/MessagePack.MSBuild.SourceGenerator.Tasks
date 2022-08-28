using System;
using System.ValueVariant;

using MessagePack;

using UnitGenerator;

namespace Sample;

[UnitOf(typeof(Ulid), UnitGenerateOptions.MessagePackFormatter)]
public partial struct PlayerId { }

[UnitOf(typeof(Ulid), UnitGenerateOptions.MessagePackFormatter)]
public partial struct NpcId { }

[ValueVariant(ValueVariantGenerateOptions.MessagePackFormatter)]
public partial struct CharacterId: IValueVariant<CharacterId, PlayerId, NpcId> { }

[UnitOf(typeof(int), UnitGenerateOptions.ArithmeticOperator | UnitGenerateOptions.ValueArithmeticOperator | UnitGenerateOptions.Comparable | UnitGenerateOptions.MinMaxMethod | UnitGenerateOptions.MessagePackFormatter)]
public partial struct Hp { }

[MessagePackObject]
public class DamagePacket
{
    [Key(0)]
    public CharacterId Target { get; set; }

    [Key(1)]
    public CharacterId Attacker { get; set; }

    [Key(2)]
    public Hp Damage { get; set; }
}
