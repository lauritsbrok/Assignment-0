namespace LeapYear.Tests;
using System;

public class UnitTest1
{
    [Fact]
    public void is4aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = Program.IsLeapYear(4);

        // Assert
        Assert.True(leapYear);
    }

    [Fact]
    public void is1700aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = Program.IsLeapYear(1700);

        // Assert
        Assert.False(leapYear);
    }

    [Fact]  
    public void is1800aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = Program.IsLeapYear(1800);

        // Assert
        Assert.False(leapYear);
    }

    [Fact]
    public void is1600aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = Program.IsLeapYear(1600);

        // Assert
        Assert.True(leapYear);
    }

    [Fact]
    public void is2000aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = Program.IsLeapYear(2000);

        // Assert
        Assert.True(leapYear);
    }

    [Fact]
    public void is1964aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = Program.IsLeapYear(1964);

        // Assert
        Assert.True(leapYear);
    }

    [Fact]
    public void is2022aLeapYear()
    {
        // Arrange

        // Act
        var leapYear = Program.IsLeapYear(2024);

        // Assert
        Assert.True(leapYear);
    }

    [Fact]
    public void isStringaLeapYear()
    {
        // Assert
        Assert.Throws<FormatException>(() => Convert.ToInt32("sdsd"));
    }
}