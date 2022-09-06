namespace LeapYear.Tests;
using MyApp;
using System;

public class UnitTest1
{
    [Fact]
    public void is4aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = LeapYear.IsLeapYear(4);

        // Assert
        Assert.True(leapYear);
    }

    [Fact]
    public void is1700aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = LeapYear.IsLeapYear(1700);

        // Assert
        Assert.False(leapYear);
    }

    [Fact]  
    public void is1800aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = LeapYear.IsLeapYear(1800);

        // Assert
        Assert.False(leapYear);
    }

    [Fact]
    public void is1600aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = LeapYear.IsLeapYear(1600);

        // Assert
        Assert.True(leapYear);
    }

    [Fact]
    public void is2000aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = LeapYear.IsLeapYear(2000);

        // Assert
        Assert.True(leapYear);
    }

    [Fact]
    public void is1964aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = LeapYear.IsLeapYear(1964);

        // Assert
        Assert.True(leapYear);
    }

    [Fact]
    public void is2022aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = LeapYear.IsLeapYear(2024);

        // Assert
        Assert.True(leapYear);
    }

    [Fact]
    public void isStringaLeapYearYay()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        LeapYear.PrintIsLeapYear("2004");

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("yay", output); 
    }

    [Fact]
    public void isStringaLeapYearNay()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        LeapYear.PrintIsLeapYear("2005");

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("nay", output); 
    }

    [Fact]
    public void isStringaLeapYearException()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        LeapYear.PrintIsLeapYear("hello");

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal("You must enter a valid number!", output); 
    }
}