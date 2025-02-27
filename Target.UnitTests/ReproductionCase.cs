using Moq;
using NSubstitute;
using Xunit;

namespace Target.UnitTests;

public interface IExample
{
    bool Check();
}

public interface IExampleWithInternal
{
    internal bool Check();
}

public class ReproductionCase
{
    [Fact]
    public void NSubstitute_IExampleWithInternal()
    {
        var mock = Substitute.For<IExampleWithInternal>();
    }

    [Fact]
    public void Moq_IExampleWithInternal()
    {
        var mock = new Mock<IExampleWithInternal>().Object;
    }   
    
    [Fact]
    public void NSubstitute_IExample()
    {
        var mock = Substitute.For<IExample>();
    }

    [Fact]
    public void Moq_IExample()
    {
        var mock = new Mock<IExample>().Object;
    }
}