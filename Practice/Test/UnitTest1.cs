using NUnit.Framework;
using System.Reflection;
using System;
using System.Collections;
namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test, Category("Point")]
    public void testExistFilePoint()
    {


        Assert.That(@"../../../../Practice/Point.cs", Does.Exist, "Не забудьте создать файл для класса");
    }


    [Test, Category("Point")]
    public void testClassExist()
    {
        Assembly assembly = typeof(Program).Assembly;
        ArrayList classes = new ArrayList();
        foreach (Type type in assembly.GetTypes())
        {
            classes.Add(type.FullName);
        }
        Assert.True(classes.Contains("Point"), "Добавьте класс Point в файл");
    }

    [Test, Category("Point")]
    public void testConstructorLenght()
    {
        ConstructorInfo[] p = typeof(Point).GetConstructors();
        Assert.AreEqual(p.Length, 2, "Реализуйте все требуемые по заданию конструкторы");
    }



    [Test, Category("Point")]
    public void testConstructorEmptyWork()
    {
        Point p = new Point();
        Assert.AreEqual(p.X, 0, "Реализуйте метод в соответствии с заданием");
        Assert.AreEqual(p.Y, 0, "Реализуйте метод в соответствии с заданием");
    }


    [Test, Category("Point")]
    public void testConstructorWork()
    {
        int x = 42;
        int y = 24;
        Point p = new Point(x, y);
        Assert.AreEqual(p.X, x, "Реализуйте метод в соответствии с заданием");
        Assert.AreEqual(p.Y, y, "Реализуйте метод в соответствии с заданием");
    }

    [Test, Category("Point")]
    public void testAddNumberExist()
    {
        MethodInfo[] methods = typeof(Point).GetMethods();
        ArrayList met = new ArrayList();
        foreach (MethodInfo meth in methods)
        {
            met.Add(meth.Name);
        }
        Assert.True(met.Contains("AddNumber"));

    }


    [Test, Category("Point")]
    public void testAddNumber()
    {
        Point p = new Point();
        p.AddNumber(3);
        Assert.AreEqual(p.X, 3, "Реализуйте метод в соответствии с заданием");
        Assert.AreEqual(p.Y, 3, "Реализуйте метод в соответствии с заданием");
    }


    [Test, Category("Point")]
    public void testMinusNumberExist()
    {
        MethodInfo[] methods = typeof(Point).GetMethods();
        ArrayList met = new ArrayList();
        foreach (MethodInfo meth in methods)
        {
            met.Add(meth.Name);
        }
        Assert.True(met.Contains("MinusNumber"));

    }

    [Test, Category("Point")]
    public void testMinusNumber()
    {
        Point p = new Point(1, 1);
        p.MinusNumber(1);
        Assert.AreEqual(p.X, 0, "Реализуйте метод в соответствии с заданием");
        Assert.AreEqual(p.Y, 0, "Реализуйте метод в соответствии с заданием");
    }

    [Test, Category("Point")]
    public void testMinusPointExist()
    {
        MethodInfo[] methods = typeof(Point).GetMethods();
        ArrayList met = new ArrayList();
        foreach (MethodInfo meth in methods)
        {
            met.Add(meth.Name);
        }
        Assert.True(met.Contains("MinusPoint"));

    }


    [Test, Category("Point")]
    public void testMinusPoint()
    {
        Point p = new Point(2, 2);
        Point p2 = new Point(1, 1);
        p.MinusPoint(p2);
        Assert.That(p.X, Is.EqualTo(1));
        Assert.That(p.Y, Is.EqualTo(1));
    }



    [Test, Category("Point")]
    public void testAddPointExist()
    {
        MethodInfo[] methods = typeof(Point).GetMethods();
        ArrayList met = new ArrayList();
        foreach (MethodInfo meth in methods)
        {
            met.Add(meth.Name);
        }
        Assert.True(met.Contains("AddPoint"));

    }

    [Test, Category("Point")]
    public void testAddPoint()
    {
        Point p = new Point(2, 2);
        Point p2 = new Point(1, 1);
        p.AddPoint(p2);
        Assert.That(p.X, Is.EqualTo(3));
        Assert.That(p.Y, Is.EqualTo(3));
    }


}