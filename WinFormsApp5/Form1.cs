
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        // ����������ر���
        int normalWidth = 0;
        int normalHeight = 0;
        Dictionary<string, Rectangle> normalControls = new Dictionary<string, Rectangle>();

        // �����߼���ر���
        private string _currentInput = "0";
        private double _storedNumber;
        private string _pendingOperator;
        private bool _newNumber = true;

        public Form1()
        {
            InitializeComponent();
            this.Load += MainForm_load;
            this.SizeChanged += MainForm_SizeChanged;
            this.label1.Text = "0";  // ��ʼ����ʾ
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

    
  

        // ���ְ�ť����¼�
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string input = btn.Text;

            // ����С����
            if (_newNumber)
            {
                _currentInput = (input == ".") ? "0." : input;
                _newNumber = false;
            }
            else
            {
                if (input == "." && _currentInput.Contains(".")) return;

                // ��ֹ��λ���0
                if (_currentInput == "0" && input != ".")
                    _currentInput = input;
                else
                    _currentInput += input;
            }

            UpdateDisplay(_currentInput);
        }

        // �������ť����¼�
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (_pendingOperator != null && !_newNumber)
            {
                Calculate(); // ִ��֮ǰ�����㣨�������㣩
            }
            if (double.TryParse(_currentInput, out double num))
            {
                _storedNumber = num;
                _pendingOperator = ((Button)sender).Text;
                _newNumber = true;
                UpdateDisplay($"{_storedNumber} {_pendingOperator} ");
            }
        }

        // �ȺŰ�ť����¼�
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (_pendingOperator != null)
            {
                Calculate();
                _pendingOperator = null;
                UpdateDisplay(_currentInput);
            }
        }

        // �����ť����¼�
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
                        case "��":
                            _storedNumber *= currentNum;
                            break;
                        case "��":
                            if (currentNum == 0) throw new DivideByZeroException();
                            _storedNumber /= currentNum;
                            break;
                    }
                    _currentInput = FormatResult(_storedNumber); // ��ֹ��ѧ������
                    _newNumber = true;
                }
                catch (DivideByZeroException)
                {
                    HandleError("Cannot divide by zero");
                }
            }
        }

        private string FormatResult(double result)// ��ʽ����ʾ���
        {
            return result % 1 == 0 ?
                result.ToString("F0") :
                result.ToString("G15").TrimEnd('0').TrimEnd('.');
        }
        private void HandleError(string message)// ������
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

