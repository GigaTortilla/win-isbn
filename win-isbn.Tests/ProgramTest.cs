using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using win_isbn;

namespace win_isbn.Tests;

[TestClass]
[TestSubject(typeof(Program))]
public class ProgramTest
{
    private readonly string[] _validIsbn10List =
    [
        "3000735348",
        "0131103628",
        "1789343623"
    ];

    private readonly string[] _validIsbn13List =
    [
        "9783000735349",
        "9780131103627",
        "9781789343625"
    ];

    [TestMethod]
    public void TestChecks()
    {
        foreach (var isbn10 in _validIsbn10List) Assert.IsTrue(Program.CheckIsbn10(isbn10));
        foreach (var isbn13 in _validIsbn13List) Assert.IsTrue(Program.CheckIsbn13(isbn13));
    }

    [TestMethod]
    public void TestConversions()
    {
        for (var i = 0; i < _validIsbn10List.Length; i++)
        {
            Assert.AreEqual(_validIsbn13List[i], Program.ConvertToIsbn13(_validIsbn10List[i]));
            Assert.AreEqual(_validIsbn10List[i], Program.ConvertToIsbn10(_validIsbn13List[i]));
        }
    }
}