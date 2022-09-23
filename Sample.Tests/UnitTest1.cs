using System;

using Cysharp.Serialization.MessagePack;

using MessagePack;
using MessagePack.Resolvers;

using Xunit;

namespace Sample.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var resolver = CompositeResolver.Create(
            GeneratedResolver.Instance,
            UlidMessagePackResolver.Instance,
            StandardResolver.Instance
        );
        var options = MessagePackSerializerOptions.Standard.WithResolver(resolver);

        var data = new DamagePacket {
            Target = new PlayerId(Ulid.NewUlid()),
            Attacker = new NpcId(Ulid.NewUlid()),
            Damage = new Hp(100),
        };

        var serializedData = MessagePackSerializer.Serialize(data, options);

        var deserializedData = MessagePackSerializer.Deserialize<DamagePacket>(serializedData, options);

        Assert.NotNull(deserializedData);
        Assert.Equal(data.Target, deserializedData.Target);
        Assert.Equal(data.Attacker, deserializedData.Attacker);
        Assert.Equal(data.Damage, deserializedData.Damage);
    }
}
