using CsCalcApp;

namespace UnitTests
{
    public class UnitTests
    {
        // Test all basic digit inputs
        [Fact]
        public void TestInputChar1()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('1');
            Form1.InputChar('2');
            Form1.InputChar('3');
            Form1.InputChar('4');
            Form1.InputChar('5');
            Form1.InputChar('6');
            Form1.InputChar('7');
            Form1.InputChar('8');
            Form1.InputChar('9');
            Form1.InputChar('0');
            Assert.Equal("1234567890", Form1.DisplayStr);
        }
        // Test that zero input does not change display
        [Fact]
        public void TestInputChar2()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('0');
            Form1.InputChar('0');
            Form1.InputChar('0');
            Assert.Equal("0", Form1.DisplayStr);
        }
        // Test decimal
        [Fact]
        public void TestInputChar3()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('.');
            Form1.InputChar('0');
            Form1.InputChar('0');
            Form1.InputChar('7');
            Assert.Equal("0.007", Form1.DisplayStr);
        }
        // Test max char limit
        [Fact]
        public void TestInputChar4()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            for (int i = 0; i < 50; i++)
            {
                Form1.InputChar('3');
            }
            Assert.Equal(20, Form1.DisplayStr.Length);
            Assert.Equal("33333333333333333333", Form1.DisplayStr);
        }
        // Text max char limit for decimals
        [Fact]
        public void TestInputChar5()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('.');
            Form1.InputChar('.');
            for (int i = 0; i < 50; i++)
            {
                Form1.InputChar('6');
            }
            Assert.Equal(20, Form1.DisplayStr.Length);
            Assert.Equal("0.666666666666666666", Form1.DisplayStr);
        }
        // Test clear buttons
        [Fact]
        public void TestClearButton1()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('3');
            Form1.Operation('+');
            Form1.InputChar('3');
            Form1.Clear();
            Form1.InputChar('4');
            Form1.Equate();
            Assert.Equal("7", Form1.DisplayStr);
        }
        [Fact]
        public void TestAllClearButton1()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('3');
            Form1.Operation('+');
            Form1.InputChar('3');
            Form1.Equate();
            Form1.AllClear();
            Assert.Equal(0, Form1.OperandMem);
            Assert.Equal(0, Form1.ResultDec);
            Assert.Equal('?', Form1.OperationType);
            Assert.Equal("0", Form1.DisplayStr);
        }
        // Test Equate
        [Fact]
        public void TestEquate1()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('3');
            Form1.Operation('+');
            Form1.InputChar('3');
            Form1.Equate();
            Assert.Equal(0, Form1.OperandMem);
            Assert.Equal("6", Form1.DisplayStr);
        }
        [Fact]
        public void TestEquate2()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('1');
            Form1.Operation('/');
            Form1.InputChar('3');
            Form1.Equate();
            Assert.Equal(0, Form1.OperandMem);
            Assert.Equal("0.333333333333333333", Form1.DisplayStr);
        }
        [Fact]
        public void TestEquate3()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('3');
            Form1.InputChar('3');
            Form1.Operation('*');
            Form1.InputChar('9');
            Form1.Equate();
            Assert.Equal("297", Form1.DisplayStr);
        }
        [Fact]
        public void TestEquate4()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('3');
            Form1.Operation('*');
            Form1.Equate();
            Assert.Equal("9", Form1.DisplayStr);
        }
        [Fact]
        public void TestEquate5()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('2');
            Form1.Operation('*');
            Form1.InputChar('3');
            Form1.Operation('*');
            Form1.InputChar('4');
            Form1.Equate();
            Form1.Operation('/');
            Form1.InputChar('8');
            Form1.Equate();
            Assert.Equal("3", Form1.DisplayStr);
        }
        // Test operation buttons
        [Fact]
        public void TestOperation1()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('1');
            Form1.Operation('/');
            Form1.InputChar('0');
            Form1.Equate();
            Assert.Equal(0, Form1.OperandMem);
            Assert.Equal("0", Form1.DisplayStr);
        }
        [Fact]
        public void TestOperation2()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('7');
            Form1.Operation('/');
            Form1.InputChar('7');
            Form1.Equate();
            Assert.Equal(0, Form1.OperandMem);
            Assert.Equal("1", Form1.DisplayStr);
        }
        [Fact]
        public void TestOperation3()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('3');
            Form1.Operation('*');
            Form1.InputChar('5');
            Form1.Equate();
            Assert.Equal(0, Form1.OperandMem);
            Assert.Equal("15", Form1.DisplayStr);
        }
        [Fact]
        public void TestOperation4()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('1');
            Form1.InputChar('0');
            Form1.Operation('-');
            Form1.InputChar('1');
            Form1.InputChar('2');
            Form1.Equate();
            Assert.Equal(0, Form1.OperandMem);
            Assert.Equal("-2", Form1.DisplayStr);
        }
        [Fact]
        public void TestOperation5()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('1');
            Form1.Operation('+');
            Form1.InputChar('3');
            Form1.Operation('*');
            Form1.InputChar('2');
            Form1.Operation('/');
            Form1.InputChar('8');
            Form1.Operation('-');
            Form1.InputChar('0');
            Form1.Equate();
            Assert.Equal(0, Form1.OperandMem);
            Assert.Equal("1", Form1.DisplayStr);
        }
        // Test memory buttons
        [Fact]
        public void TestMemPlus()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('1');
            Form1.InputChar('1');
            Form1.MemPlus();
            Form1.MemPlus();
            Form1.MemRecall();
            Assert.Equal("22", Form1.DisplayStr);
        }
        [Fact]
        public void TestMemMinus()
        {
            var Form1 = new CsCalcApp.CsCalcForm();
            Form1.InputChar('4');
            Form1.InputChar('3');
            Form1.MemMinus();
            Form1.MemRecall();
            Assert.Equal("-43", Form1.DisplayStr);
        }
    }
}