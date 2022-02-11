using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medallion;

namespace RndPassGenForms
{
    public partial class Form1 : Form
    {
        string strNumbers = "1234567890";
        string strLetters = "qwertyuiopasdfghjklzxcvbnm";
        string strSymbols = "~!@#$%^&*";
        string strSymbolsPlus = "()-_=+[{}]|<,.>/?";
        char[] chrAllChars;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genPassword.Text = "Press generate";
            chrAllChars = strLetters.ToCharArray();
            
        }

        private void button1_Click(object sender, EventArgs e) //Generate
        {
            genPassword.Text = GeneratePassword();
        }
        private char[] genCheckCbxStates()
        {
            string summary = "";
            if (cbxLetters.Checked) summary = summary + strLetters;
            if (cbxNumbers.Checked) summary = summary + strNumbers;
            if (cbxSymbols.Checked) summary = summary + strSymbols;
            if (cbxMayus.Checked) summary = summary + strLetters.ToUpper();
            return summary.Shuffled().ToArray();

        }
        private string GeneratePassword()
        {
            chrAllChars = genCheckCbxStates();
            int chrAllCharsLength = chrAllChars.Length;
            chrAllChars.Shuffled().ToArray();
            int size = Convert.ToInt32(comboBox1.SelectedItem);
            int rndNumber;
            char[] genpassword = new char[size];
            char[] tempass;
            for (int i = 0; i < size ; i++)
            {
                
                tempass = genpassword;
                rndNumber = random.Next(1, chrAllCharsLength);
                genpassword[i] = chrAllChars[rndNumber];
                
            }
            string returned = new string(genpassword);
            return returned;
        }

        #region Checkboxes
        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Letters
        {
            if (!cbxNumbers.Checked && !cbxSymbols.Checked) cbxLetters.Checked = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //Numbers
        {
            if (!cbxLetters.Checked && !cbxSymbols.Checked) cbxNumbers.Checked = true;
        } 

        private void checkBox3_CheckedChanged(object sender, EventArgs e) //Symbols
        {
            if (!cbxNumbers.Checked && !cbxLetters.Checked) cbxSymbols.Checked = true;
        } 

        private void checkBox4_CheckedChanged(object sender, EventArgs e) //Mayus
        {

        }
        #endregion
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
