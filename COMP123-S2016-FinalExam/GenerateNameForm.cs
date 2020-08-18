﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNames()
        {   Random numbers=new Random();
            int firtNameIndex=numbers.Next(50);
            int lastNameIndex= numbers.Next(50);
            FirstNameTextBox.Text = FirstNameListBox.Items[firtNameIndex].ToString();
            LastNameTextBox.Text = LastNameListBox.Items[lastNameIndex].ToString();

        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm AbilityGeneratorForm=new AbilityGeneratorForm();
            AbilityGeneratorForm.Show();
           this.Hide();
        }
    }
}
