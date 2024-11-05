﻿using GeometryLibrary;

namespace Tests;

public class ShapeTests
{
    [Fact]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        Assert.Equal(Math.PI * 25, circle.GetArea(), 10);
    }

    [Fact]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.GetArea(), 10);
    }

    [Fact]
    public void RightTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void NonRightTriangleTest()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.False(triangle.IsRightTriangle());
    }
}