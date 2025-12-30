using Utilities.Strings;
using Xunit; 

public class StringTransformTests {
    [Fact]
    public void Reverse_ReturnsReverseString() {
        var result = StringTransform.Reverse("abc");
        Assert.Equal("cba", result);
    }
}