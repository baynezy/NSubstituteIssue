using Moq;
using NSubstitute;
using Xunit;

namespace Target.UnitTests;

public class ReproductionCase
{
    [Fact]
    public void NSubstituteExample()
    {
        var mock = Substitute.For<IExample<object>>();
    }

    [Fact]
    public void MoqExample()
    {
        var mock = new Mock<IExample<object>>().Object;
    }
}