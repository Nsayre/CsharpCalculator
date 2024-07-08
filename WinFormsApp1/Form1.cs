

namespace CsCalcApp
{
    public partial class CsCalcForm : Form
    {
        // memory is the number stored in calculator memory (accessible from M buttons)
        // operand_mem: operand stored in calculator memory between operations
        // display_str: The currently displayed string
        // result_dec is the decimal result of a calculation
        // result_str is the decimal result represented as a string
        // operation is the current mathmetical operation among + - * /
        // maximum number of characters to display
        public decimal Memory = 0;
        public decimal OperandMem = 0;
        public string DisplayStr = "";
        public decimal ResultDec = 0;
        public string ResultStr = "";
        public char OperationType = '?';
        public int MaxDisplayLength = 20;
        public bool OperandCarryover = false;

        // Function to execute expression
        public void Equate()
        {
            // Calculate result of operation
            if (OperationType == '+')
            {
                ResultDec = OperandMem + decimal.Parse(calc_display.Text);
            }
            if (OperationType == '-')
            {
                ResultDec = OperandMem - decimal.Parse(calc_display.Text);
            }
            if (OperationType == '*')
            {
                ResultDec = OperandMem * decimal.Parse(calc_display.Text);
            }
            if (OperationType == '/')
            {
                // If attempting to divide by zero clear and reset display
                if (decimal.Parse(calc_display.Text) == 0)
                    {
                    OperandMem = 0;
                    ResultDec = 0;
                    OperationType = '?';
                    calc_display.Text = "0";
                    DisplayStr = calc_display.Text;
                    return;
                }
                ResultDec = OperandMem / decimal.Parse(calc_display.Text);
            }
           
            ResultStr = ResultDec.ToString();
            // If result is a decimal number
            // then display 20 chars to right starting at one's place
            // Otherwise display first 20 digits to the left of decimal place
            if (ResultStr.Contains('.'))
            {
                calc_display.Text = ResultStr.Substring(0, Math.Min(ResultStr.Length, MaxDisplayLength));
            }
            else
            {
                calc_display.Text = ResultStr.Substring(ResultStr.Length - Math.Min(ResultStr.Length, MaxDisplayLength));
            }
            DisplayStr = calc_display.Text;
            OperandMem = 0;
            OperandCarryover = true;
            OperationType = '?';
            return;
        }

        // Operation Function that executes the given operation on current operands
        public void Operation(char next_operation)
        {
            // If operation already defined, calculate result before proceeding
            if (OperationType != '?')
            {
                Equate();
            }
            // Set operator
            OperationType = next_operation;
            // Save current display as operand
            OperandMem = decimal.Parse(calc_display.Text);
            DisplayStr = calc_display.Text;
            // set carry over so that a new number can correctly be input
            OperandCarryover = true;
            return;
        }
 
        // Clear Button Function
        public void Clear()
        {
            calc_display.Text = "0";
            DisplayStr = calc_display.Text;
        }

        // All Clear Button Function
        public void AllClear()
        {
            OperandMem = 0;
            ResultDec = 0;
            OperationType = '?';
            calc_display.Text = "0";
            DisplayStr = calc_display.Text;
        }

        // Function to add currently displayed value to memory
        public void MemPlus()
        {
            Memory += decimal.Parse(calc_display.Text);
        }
        
        // Function to subtract currently displayed value from memory
        public void MemMinus()
        {
            Memory -= decimal.Parse(calc_display.Text);
        }

        // Function to recall value currently stored in memory
        public void MemRecall()
        {
            ResultStr = Memory.ToString();
            // If decimal display 20 chars to right starting at one's place
            if (ResultStr.Contains('.'))
            {
                calc_display.Text = ResultStr.Substring(0, Math.Min(ResultStr.Length, MaxDisplayLength));
                return;
            }
            // If not decimal display up to 20 characters to the left of decimal
            calc_display.Text = ResultStr.Substring(ResultStr.Length - Math.Min(ResultStr.Length, MaxDisplayLength));
            DisplayStr = calc_display.Text;
        }

        // Function to handle character input (0-9 and ".")
        public void InputChar(char input_char)
        {
            // if an operand was pressed, previous number is carried over
            // if in this case a new char is input it will replace the carried over number
            if (OperandCarryover == true)
            {
                calc_display.Text = input_char.ToString();
                DisplayStr = calc_display.Text;
                OperandCarryover = false;
                return;
            }
            // Only add char if currently displayed number is less than 20 chars
            if (calc_display.Text.Length < MaxDisplayLength)
            {
                // Only add "." if not already in string
                if (input_char == '.')
                {
                    if (!calc_display.Text.Contains('.'))
                    {
                        calc_display.Text += ".";
                        DisplayStr = calc_display.Text;
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                if (calc_display.Text == "0")
                {
                    // If current display is 0, don't allow adding zeros
                    if (input_char == '0')
                    {
                        DisplayStr = calc_display.Text;
                        return;
                    }
                    // special case where "." is first input
                    if (input_char == '.')
                    {
                        calc_display.Text = "0.";
                        DisplayStr = calc_display.Text;
                        return;
                    }
                    // if current display is 0, replace to avoid leading zeros
                    calc_display.Text = input_char.ToString();
                    DisplayStr = calc_display.Text;
                    return;
                }

                // Only allow entering zeros if "." is present
                if ((calc_display.Text.Contains('.')) && input_char == '0')
                {
                    calc_display.Text += input_char.ToString();
                    DisplayStr = calc_display.Text;
                    return;
                }
                calc_display.Text += input_char.ToString();
                DisplayStr = calc_display.Text;
                return;
            }
        }
        public CsCalcForm()
        {
            InitializeComponent();
        }

        // Digit input buttons
        private void one_button_Click(object sender, EventArgs e)
        {
            InputChar('1');
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            InputChar('2');
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            InputChar('3');
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            InputChar('4');
        }
        private void five_button_Click(object sender, EventArgs e)
        {
            InputChar('5');
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            InputChar('6');
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            InputChar('7');
        }
        private void eight_button_Click(object sender, EventArgs e)
        {
            InputChar('8');
        }
        private void nine_button_Click(object sender, EventArgs e)
        {
            InputChar('9');
        }

        // Zero input buttons
        private void zero_button_Click(object sender, EventArgs e)
        {
            InputChar('0');
        }

        private void double_zero_button_Click(object sender, EventArgs e)
        {
            InputChar('0');
            InputChar('0');
        }

        // Decimal point button
        private void decimal_button_Click(object sender, EventArgs e)
        {
            InputChar('.');
        }

        // Operator buttons
        private void plus_button_Click(object sender, EventArgs e)
        {
            Operation('+');
        }

        private void multiply_button_Click(object sender, EventArgs e)
        {
            Operation('*');
        }

        private void divide_button_Click(object sender, EventArgs e)
        {
            Operation('/');
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            Operation('-');
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            Equate();
        }

        // Clear buttons
        // "All Clear" button function, clears current calculation and sets display to default
        private void all_clear_button_Click(object sender, EventArgs e)
        {
            AllClear();
        }
        
        // "Clear" button function, clears current display, maintaining calculation
        private void clear_button_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Memory buttons
        // Adds the currently displayed number to the number stored in memory        
        private void mem_plus_button_Click(object sender, EventArgs e)
        {
            MemPlus();
        }

        // Subtracts the currently displayed number to the number stored in memory
        private void mem_minus_button_Click(object sender, EventArgs e)
        {
            MemMinus();
        }

        // Displays the number currently stored in memory
        private void mem_recall_clear_button_Click(object sender, EventArgs e)
        {
            MemRecall();
        }
    }
}
