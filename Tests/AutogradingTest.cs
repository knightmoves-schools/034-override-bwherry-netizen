namespace Tests;

using System.Reflection;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Define_A_Cat_Class_That_Is_A_Child_Of_The_Animal_Class_And_Implements_The_Speak_Method(){
      Cat cat = new Cat();
      Assert.True(cat.Speak() != null);
    }
}