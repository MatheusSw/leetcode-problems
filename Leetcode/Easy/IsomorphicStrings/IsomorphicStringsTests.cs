using Xunit;

namespace Leetcode.Easy.IsomorphicStrings;

public class IsomorphicStringsTests
{
    [Fact]
    public void Test()
    {
        //Arrange
        const string s = "egg";
        const string t = "add";
        const bool expected = true;
        
        //Act
        var result = IsomorphicStrings.IsIsomorphic(s, t);
        
        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test2()
    {
        //Arrange
        const string s = "foo";
        const string t = "bar";
        const bool expected = false;
        
        //Act
        var result = IsomorphicStrings.IsIsomorphic(s, t);
        
        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test3()
    {
        //Arrange
        const string s = "paper";
        const string t = "title";
        const bool expected = true;
        
        //Act
        var result = IsomorphicStrings.IsIsomorphic(s, t);
        
        //Assert
        Assert.Equal(expected, result);
    }
}