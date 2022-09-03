namespace LeapYear.Tests;
using System;

public class UnitTest1
{
    [Fact]
    public void is4aLeapYear()
    {
        // Arrange
        var program = new Program();

        // Act
        var leapYear = program.IsLeapYear(4);

        // Assert
        Assert.Equal(true, leapYear);
    }

    [Fact]
    public void is1700aLeapYear()
    {
        // Arrange
        var program = new Program();

        // Act
        var leapYear = program.IsLeapYear(1700);

        // Assert
        Assert.Equal(false, leapYear);
    }

    [Fact]  
    public void is1800aLeapYear()
    {
        // Arrange
        var program = new Program();

        // Act
        var leapYear = program.IsLeapYear(1800);

        // Assert
        Assert.Equal(false, leapYear);
    }

    [Fact]
    public void is1600aLeapYear()
    {
        // Arrange
        var program = new Program();

        // Act
        var leapYear = program.IsLeapYear(1600);

        // Assert
        Assert.Equal(true, leapYear);
    }

    [Fact]
    public void is2000aLeapYear()
    {
        // Arrange
        var program = new Program();

        // Act
        var leapYear = program.IsLeapYear(2000);

        // Assert
        Assert.Equal(true, leapYear);
    }

    [Fact]
    public void is1964aLeapYear()
    {
        // Arrange
        var program = new Program();

        // Act
        var leapYear = program.IsLeapYear(1964);

        // Assert
        Assert.Equal(true, leapYear);
    }

    [Fact]
    public void is2022aLeapYear()
    {
        // Arrange
        var program = new Program();

        // Act
        var leapYear = program.IsLeapYear(2022);

        // Assert
        Assert.Equal(false, leapYear);
    }
}