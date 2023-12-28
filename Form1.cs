using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassBaiTap2
{
    public partial class Form1 : Form
    {
        string expression = "";
        bool isExecute = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            DialogResult result =  colorDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                bt00.BackColor = colorDialog1.Color;
                bt01.BackColor = colorDialog1.Color;
                bt02.BackColor = colorDialog1.Color;
                bt03.BackColor = colorDialog1.Color;
                bt04.BackColor = colorDialog1.Color;
                bt05.BackColor = colorDialog1.Color;
                bt06.BackColor = colorDialog1.Color;
                bt07.BackColor = colorDialog1.Color;
                bt08.BackColor = colorDialog1.Color;
                bt09.BackColor = colorDialog1.Color;
                btAdd.BackColor = colorDialog1.Color;
                btMinus.BackColor = colorDialog1.Color;
                btMul.BackColor = colorDialog1.Color;
                btDivision.BackColor = colorDialog1.Color;
                btClean.BackColor = colorDialog1.Color;
                btResult.BackColor = colorDialog1.Color;
                lbExpression.BackColor = colorDialog1.Color;
                lbResult.BackColor = colorDialog1.Color;
            }
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1 = new FontDialog();
            DialogResult result = fontDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                bt00.Font = fontDialog1.Font;
                bt01.Font = fontDialog1.Font;
                bt02.Font = fontDialog1.Font;
                bt03.Font = fontDialog1.Font;
                bt04.Font = fontDialog1.Font;
                bt05.Font = fontDialog1.Font;
                bt06.Font = fontDialog1.Font;
                bt07.Font = fontDialog1.Font;
                bt08.Font = fontDialog1.Font;
                bt09.Font = fontDialog1.Font;
                btAdd.Font = fontDialog1.Font;
                btMinus.Font = fontDialog1.Font;
                btMul.Font = fontDialog1.Font;
                btDivision.Font = fontDialog1.Font;
                btClean.Font = fontDialog1.Font;
                btResult.Font = fontDialog1.Font;
                lbExpression.Font = fontDialog1.Font;
                lbResult.Font = fontDialog1.Font;
            }
        }

        
        private bool isNumber(char a)
        {
            if ('0' <= a && a <= '9') return true;
            return false;
        }
        private List<string> convertRawStringIntoItems(string s)
        {
            List<string> result = new List<string>();
            if (s.Length == 0) return null;
            if (s.Length == 1)
            {
                result.Add(s.ElementAt(0)+"");
                return result;
            }
            string tmp = ""+ s.ElementAt(0);
            for(int i = 1; i < s.Length; i++)
            {
                if(s.ElementAt(i) != '+' && s.ElementAt(i) != '-')
                {
                    tmp += s.ElementAt(i);
                }
                else
                {
                    result.Add(tmp);
                    result.Add("" + s.ElementAt(i));
                    tmp = "";
                }
                if(i == s.Length - 1)
                    result.Add(tmp);

            }
            return result;
        }
        private double executeExpressionOfMulAndDiv(string s)
        {
            double result = 1;
            int mode = 1;
            string tmp = "";
            int i = 0; if (s.ElementAt(0) == '-')
            {
                result *= -1;
                i++;
            }
            for(; i < s.Length; i++)
            {
                if(s[i] != 'x' && s[i] != 247)
                {
                    tmp += s[i];
                }
                else
                {
                    
                    if (mode == 1) result *= Convert.ToInt64(tmp);
                    else result /= Convert.ToInt64(tmp);
                    if (s[i] == 'x') mode = 1;
                    else mode = 0;
                    tmp = ""; 
                }
                if (i == s.Length - 1)
                {
                    if (mode == 1) result *= Convert.ToInt64(tmp);
                    else result /= Convert.ToInt64(tmp);
                }
            }
            
            return result;
        }
        private double executeRawStringExpression(string s)
        {
            double result = 0; int mode = 1; // cho dau +
            List<string> expressionList = convertRawStringIntoItems(s);
            for(int i = 0; i < expressionList.Count; i++)
            {
                if (expressionList.ElementAt(i) == "+") mode = 1;
                else if (expressionList.ElementAt(i) == "-") mode = 0;
                else
                {
                    if (mode == 1) result +=
                            executeExpressionOfMulAndDiv(expressionList.ElementAt(i));
                    else
                    {
                        result -=
                            executeExpressionOfMulAndDiv(expressionList.ElementAt(i));
                    }
                }

            }
            return result;
        }
        private void btResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isExecute)
                {
                    if (expression.Length > 0)
                    {
                        char end = expression.ElementAt(expression.Length - 1);
                        if (end < '0' || end > '9')
                        {
                            expression = expression.Remove(expression.Length - 1);
                        }
                        if (!(expression.Length == 0))
                        {
                            //double result = executeRawStringExpression(expression);
                            //lbResult.Text = "" + result;
                            lbResult.Text = executeRawStringExpression(expression).ToString();
                            isExecute = true;
                        }
                    }
                }
            }
            catch(Exception)
            {
                lbResult.Text = "Biểu thức tính toán quá lớn!";
            }
            
        }

        
        private void bt01_Click(object sender, EventArgs e)
        {
            
        }

        private void bt02_Click(object sender, EventArgs e)
        {
            if (isExecute)
            {
                isExecute = false;
                expression = "";
            }
            expression += bt02.Text;
            lbExpression.Text = expression;
            lbResult.Text = "Kết quả";
        }

        private void bt03_Click(object sender, EventArgs e)
        {
            if (isExecute)
            {
                isExecute = false;
                expression = "";
            }
            expression += bt03.Text;
            lbExpression.Text = expression;
            lbResult.Text = "Kết quả";
        }
        private void bt04_Click(object sender, EventArgs e)
        {
            if (isExecute)
            {
                isExecute = false;
                expression = "";
            }
            expression += bt04.Text;
            lbExpression.Text = expression;
            lbResult.Text = "Kết quả";
        }

        private void bt05_Click(object sender, EventArgs e)
        {
            if (isExecute)
            {
                isExecute = false;
                expression = "";
            }
            expression += bt05.Text;
            lbExpression.Text = expression;
            lbResult.Text = "Kết quả";
        }
        private void bt06_Click(object sender, EventArgs e)
        {
            if (isExecute)
            {
                isExecute = false;
                expression = "";
            }
            expression += bt06.Text;
            lbExpression.Text = expression;
            lbResult.Text = "Kết quả";
        }
        private void bt07_Click(object sender, EventArgs e)
        {
            if (isExecute)
            {
                isExecute = false;
                expression = "";
            }
            expression += bt07.Text;
            lbExpression.Text = expression;
            lbResult.Text = "Kết quả";
        }

        private void bt08_Click(object sender, EventArgs e)
        {
            if (isExecute)
            {
                isExecute = false;
                expression = "";
            }
            expression += bt08.Text;
            lbExpression.Text = expression;
            lbResult.Text = "Kết quả";
        }

        private void bt09_Click(object sender, EventArgs e)
        {
            if (isExecute)
            {
                isExecute = false;
                expression = "";
            }
            expression += bt09.Text;
            lbExpression.Text = expression;
            lbResult.Text = "Kết quả";
        }
        private void btNumberClick(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (isExecute)
            {
                isExecute = false;
                expression = "";
            }
            expression += bt.Text;
            lbExpression.Text = expression;
            lbResult.Text = "Kết quả";
        }

        private void bt00_Click(object sender, EventArgs e)
        {
            if(expression.Length > 0)
            {
                char end = expression.ElementAt(expression.Length - 1);
                if(end != (char)247)
                {
                    if (isExecute)
                    {
                        isExecute = false;
                        expression = "";
                    }
                    expression += bt00.Text;
                    lbExpression.Text = expression;
                    lbResult.Text = "Kết quả";
                }
                else
                {
                    lbResult.Text = "Không thể chia cho 0!";
                }
            }
            else
            {
                if (isExecute)
                {
                    isExecute = false;
                    expression = "";
                }
                expression += bt00.Text;
                lbExpression.Text = expression;
                lbResult.Text = "Kết quả";
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (isExecute)
            {
                isExecute = false;
                expression = "";
            }
            if(expression.Length == 0)
            {
                expression += "+";
                lbExpression.Text = expression;
            }
            else
            {
                char end = expression.ElementAt(expression.Length - 1);
                if (end >= '0' && end <= '9')
                {
                    expression += btAdd.Text;
                    lbExpression.Text = expression;
                }
                else
                {
                    lbResult.Text = "Nhập không hợp lệ!";
                }
            }
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if (isExecute)
            {
                isExecute = false;
                expression = "";
            }
            if (expression.Length == 0)
            {
                expression += "-";
                lbExpression.Text = expression;
            }
            else
            {
                char end = expression.ElementAt(expression.Length - 1);
                if (end >= '0' && end <= '9')
                {
                    expression += btMinus.Text;
                    lbExpression.Text = expression;
                }
                else
                {
                    lbResult.Text = "Nhập không hợp lệ!";
                }
            }
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            if (!isExecute)
            {
                if(expression.Length > 0)
                {
                    char end = expression.ElementAt(expression.Length - 1);
                    if (end >= '0' && end <= '9')
                    {
                        expression += "x";
                        lbExpression.Text = expression;
                    }
                    else
                    {
                        lbResult.Text = "Nhập không hợp lệ!";
                    }
                }
                
            }
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            if (!isExecute)
            {
                if(expression.Length > 0)
                {
                    char end = expression.ElementAt(expression.Length - 1);
                    if (end >= '0' && end <= '9')
                    {
                        expression += (char)247;
                        lbExpression.Text = expression;
                    }
                    else
                    {
                        lbResult.Text = "Nhập không hợp lệ!";
                    }
                }
            }
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            lbExpression.Text = "Biểu thức";
            lbResult.Text = "Kết quả";
            expression = "";
            isExecute = false;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btDivision.Text = "" + (char)247;
            btMul.Text = "x";
        }

        private void dfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lbExpression_Click(object sender, EventArgs e)
        {

        }

        private void lbResult_Click(object sender, EventArgs e)
        {

        }

        private void bt01_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Button bt = (Button)sender;
                //MessageBox.Show("Kich phai");
                if (e.Button == MouseButtons.Right)
                {
                    colorDialog1 = new ColorDialog();
                    DialogResult result = colorDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        bt.BackColor = colorDialog1.Color;
                    }
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void bt01_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}
