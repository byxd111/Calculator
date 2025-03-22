
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        // 界面适配相关变量
        int normalWidth = 0;
        int normalHeight = 0;
        Dictionary<string, Rectangle> normalControls = new Dictionary<string, Rectangle>();

        // 计算逻辑相关变量
        private string _currentInput = "0";
        private double _storedNumber;
        private string _pendingOperator;
        private bool _newNumber = true;

        public Form1()
        {
            InitializeComponent();
            this.Load += MainForm_load;
            this.SizeChanged += MainForm_SizeChanged;
            this.label1.Text = "0";  // 初始化显示
        }
        private void MainForm_load(object? sender, EventArgs e)
        {
            normalWidth = this.panel2.Width;
            normalHeight = this.panel2.Height;
            foreach (Control item in this.panel2.Controls)
            {
                normalControls.Add(item.Name, new Rectangle(item.Left, item.Top, item.Width, item.Height));

            }
        }

        private void MainForm_SizeChanged(object? sender, EventArgs e)
        {
            int w = this.panel2.Width;
            int h = this.panel2.Height;
            foreach (Control item in this.panel2.Controls)
            {
                double newX = w * 1.0 / normalWidth * normalControls[item.Name].X;
                double newY = h * 1.0 / normalHeight * normalControls[item.Name].Y;
                double newW = w * 1.0 / normalWidth * normalControls[item.Name].Width;
                double newH = h * 1.0 / normalHeight * normalControls[item.Name].Height;
                item.Left = (int)newX;
                item.Top = (int)newY;
                item.Width = (int)newW;
                item.Height = (int)newH;
            }
        }

    
  

        // 数字按钮点击事件
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string input = btn.Text;

            // 处理小数点
            if (_newNumber)
            {
                _currentInput = (input == ".") ? "0." : input;
                _newNumber = false;
            }
            else
            {
                if (input == "." && _currentInput.Contains(".")) return;

                // 防止首位多个0
                if (_currentInput == "0" && input != ".")
                    _currentInput = input;
                else
                    _currentInput += input;
            }

            UpdateDisplay(_currentInput);
        }

        // 运算符按钮点击事件
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (_pendingOperator != null && !_newNumber)
            {
                Calculate(); // 执行之前的运算（连续运算）
            }
            if (double.TryParse(_currentInput, out double num))
            {
                _storedNumber = num;
                _pendingOperator = ((Button)sender).Text;
                _newNumber = true;
                UpdateDisplay($"{_storedNumber} {_pendingOperator} ");
            }
        }

        // 等号按钮点击事件
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (_pendingOperator != null)
            {
                Calculate();
                _pendingOperator = null;
                UpdateDisplay(_currentInput);
            }
        }

        // 清除按钮点击事件
        private void ClearButton_Click(object sender, EventArgs e)
        {
            _currentInput = "0";
            _storedNumber = 0;
            _pendingOperator = null;
            _newNumber = true;
            UpdateDisplay(_currentInput);
        }

        private void Calculate()
        {
            if (double.TryParse(_currentInput, out double currentNum))
            {
               

                try
                {
                    switch (_pendingOperator)
                    {
                        case "+":
                            _storedNumber += currentNum;
                            break;
                        case "-":
                            _storedNumber -= currentNum;
                            break;
                        case "×":
                            _storedNumber *= currentNum;
                            break;
                        case "÷":
                            if (currentNum == 0) throw new DivideByZeroException();
                            _storedNumber /= currentNum;
                            break;
                    }
                    _currentInput = FormatResult(_storedNumber); // 防止科学计数法
                    _newNumber = true;
                }
                catch (DivideByZeroException)
                {
                    HandleError("Cannot divide by zero");
                }
            }
        }

        private string FormatResult(double result)// 格式化显示结果
        {
            return result % 1 == 0 ?
                result.ToString("F0") :
                result.ToString("G15").TrimEnd('0').TrimEnd('.');
        }
        private void HandleError(string message)// 错误处理
        {
            label1.Text = message;
            _currentInput = "0";
            _storedNumber = 0;
            _pendingOperator = null;
            _newNumber = true;
        }
        private void UpdateDisplay(string content)
        {
            if (_pendingOperator != null && !_newNumber)
            {
                label1.Text = $"{_storedNumber} {_pendingOperator} {content}";
            }
            else if (_pendingOperator != null)
            {
                label1.Text = $"{_storedNumber} {_pendingOperator}";
            }
            else
            {
                label1.Text = content;
            }
            
        }
    }
}

