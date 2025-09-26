using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Anchors.Tests;

[Collection("Collection")]
public sealed class AnchorTests : FixturedUnitTest
{
    public AnchorTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Anchor is now a Razor component, so integration tests would be more appropriate
        // This test serves as a placeholder for future component testing
    }
}
