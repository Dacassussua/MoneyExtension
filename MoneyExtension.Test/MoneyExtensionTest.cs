namespace MoneyExtension.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void ShowldConvertDecimalToInt()
    {
        decimal valor= 279.98M;

        var cents = valor.ToCents();

        Assert.AreEqual(27998,cents);
    }
}