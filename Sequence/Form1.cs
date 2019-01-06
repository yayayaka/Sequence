using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sequence
{
    public partial class Form1 : Form
    {
        private int cursorPosition = 0;
        public Form1()
        {
            InitializeComponent();
            SequenceValidationLabelInit();
            enterSequenceTextBox.Focus();
        }

        private void getResultButton_Click(object sender, EventArgs e)
        {
            ProofSequence();
        }

        private void ProofSequence()
        {
            Regex regex02 = new Regex("^(aͰa)|(bͰb)|(cͰc)|(dͰd)|(eͰe)|(fͰf)|(AͰA)|(BͰB)|(CͰC)|(DͰD)|(EͰE)|(FͰF)|(¬aͰ¬a)|(¬bͰ¬b)|(¬cͰ¬c)|(¬dͰ¬d)|(¬eͰ¬e)|(¬fͰ¬f)|(¬AͰ¬A)|(¬BͰ¬B)|(¬CͰ¬C)|(¬DͰ¬D)|(¬EͰ¬E)|(¬FͰ¬F)$");
            resultTextBox.Text = "";
            if (regex02.IsMatch(enterSequenceTextBox.Text))
            {
                resultTextBox.Text = enterSequenceTextBox.Text + Environment.NewLine + "теорема доказана" + Environment.NewLine + "так как эквивалентна" + Environment.NewLine + "ФͰФ";
            }
            else if (true)
            {

            }
        }

        private void enterU0370Button_Click(object sender, EventArgs e)
        {
            cursorPosition = enterSequenceTextBox.SelectionStart;
            enterSequenceTextBox.Text = enterSequenceTextBox.Text.Insert(cursorPosition, "\u0370");//Ͱ
            enterSequenceTextBox.Focus();
            enterSequenceTextBox.Select(cursorPosition + 1, 0);
        }

        private void enterU02C4Button_Click(object sender, EventArgs e)
        {
            cursorPosition = enterSequenceTextBox.SelectionStart;
            enterSequenceTextBox.Text = enterSequenceTextBox.Text.Insert(cursorPosition, "\u02C4");//˄
            enterSequenceTextBox.Focus();
            enterSequenceTextBox.Select(cursorPosition + 1, 0);
        }

        private void enterU02C5Button_Click(object sender, EventArgs e)
        {
            cursorPosition = enterSequenceTextBox.SelectionStart;
            enterSequenceTextBox.Text = enterSequenceTextBox.Text.Insert(cursorPosition, "\u02C5");//˅
            enterSequenceTextBox.Focus();
            enterSequenceTextBox.Select(cursorPosition + 1, 0);
        }

        private void enterU00ACButton_Click(object sender, EventArgs e)
        {
            cursorPosition = enterSequenceTextBox.SelectionStart;
            enterSequenceTextBox.Text = enterSequenceTextBox.Text.Insert(cursorPosition, "\u00AC");//¬
            enterSequenceTextBox.Focus();
            enterSequenceTextBox.Select(cursorPosition + 1, 0);
        }

        private void enterU2192Button_Click(object sender, EventArgs e)
        {
            cursorPosition = enterSequenceTextBox.SelectionStart;
            enterSequenceTextBox.Text = enterSequenceTextBox.Text.Insert(cursorPosition, "\u2192");//→
            enterSequenceTextBox.Focus();
            enterSequenceTextBox.Select(cursorPosition + 1, 0);
        }

        private void SequenceValidationLabelInit()
        {
            sequenceValidationLabel.Text = "Введите секвецию";
            sequenceValidationLabel.ForeColor = Color.Green;
            getResultButton.Enabled = false;
        }

        private void enterSequenceTextBox_TextChanged(object sender, EventArgs e)
        {
            string sequencePattern = @"^((\(*(¬)?\(*[abcdefABCDEF]\)*(,\(*(¬)?\(*[abcdefABCDEF]\)*)*([˄˅→]\(*(¬)?\(*[abcdefABCDEF]\)*(,\(*(¬)?\(*[abcdefABCDEF]\)*)*)*)?Ͱ(\(*(¬)?\(*[abcdefABCDEF]\)*(,\(*(¬)?\(*[abcdefABCDEF]\)*)*([˄˅→]\(*(¬)?\(*[abcdefABCDEF]\)*(,\(*(¬)?\(*[abcdefABCDEF]\)*)*)*)?(;\s*)?)*$";
            string multiEqualsPattern = @"Ͱ{2,}";
            string emptyEqualsPattern = @"^Ͱ$";
            Regex regexSequencePattern = new Regex(sequencePattern);
            Regex regexMultiEqualsPattern = new Regex(multiEqualsPattern);
            Regex regexEmptyEqualsPattern = new Regex(emptyEqualsPattern);
            if (!regexEmptyEqualsPattern.IsMatch(enterSequenceTextBox.Text) &&
                (enterSequenceTextBox.Text.ToCharArray().Where(ch => ch == 'Ͱ').Count() - enterSequenceTextBox.Text.ToCharArray().Where(ch => ch == ';').Count() <= 1) &&
                IsWriteBrackets(enterSequenceTextBox.Text) && //(enterSequenceTextBox.Text.ToCharArray().Where(ch => ch == '(').Count() - enterSequenceTextBox.Text.ToCharArray().Where(ch => ch == ')').Count() == 0) &&
                !regexMultiEqualsPattern.IsMatch(enterSequenceTextBox.Text) &&
                regexSequencePattern.IsMatch(enterSequenceTextBox.Text))
            {
                sequenceValidationLabel.ForeColor = Color.Green;
                sequenceValidationLabel.Text = "Секвенция принимается";
                getResultButton.Enabled = true;
            }
            else
            {
                sequenceValidationLabel.ForeColor = Color.Red;
                sequenceValidationLabel.Text = "Секвенция не принимается";
                getResultButton.Enabled = false;
            }
            if (enterSequenceTextBox.Text == "")
            {
                SequenceValidationLabelInit();
            }
        }

        private bool IsWriteBrackets(string str)
        {
            if (!(enterSequenceTextBox.Text.ToCharArray().Where(ch => ch == '(').Count() - enterSequenceTextBox.Text.ToCharArray().Where(ch => ch == ')').Count() == 0))
            {
                return false;
            }
            string[] subStrs = str.Split('Ͱ', ';', ' ');
            Regex regex01 = new Regex(@"\(*[abcdefABCDEF]\)*([˄˅→]\(*[abcdefABCDEF])?\)*");
            foreach (string subStr in subStrs.Where(s => s.Length != 0))
            {
                if (!(subStr.ToCharArray().Where(ch => ch == '(').Count() - subStr.ToCharArray().Where(ch => ch == ')').Count() == 0) || !regex01.IsMatch(subStr))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsLeftSideEqualsRightSide(string str)
        {
            string[] subStrs = str.Split('Ͱ');
            if (subStrs.Length != 2)
            {
                return false;
            }
            if (subStrs[0] == subStrs[1])
            {
                return true;
            }
            return false;
        }
    }
}
// TODO: скобки в разных местах валидация!!!