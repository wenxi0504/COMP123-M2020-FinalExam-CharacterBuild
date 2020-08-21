using System;
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
        {   
            //create object numbers
            Random numbers=new Random();
            // randomly create number from 0-50 and assign to index of firstname
            // and lastname
            int firtNameIndex=numbers.Next(50);
            int lastNameIndex= numbers.Next(50);
            //Assign the random firstname/lastname value to firstname textbox
            FirstNameTextBox.Text = FirstNameListBox.Items[firtNameIndex].ToString();
            LastNameTextBox.Text = LastNameListBox.Items[lastNameIndex].ToString();

        }
        //In the GenerateNameForm’s Load event handler. Call the GenerateNames method.
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }
        //In the GenerateNameButton’s click event handler,
        //set the value of the FirstName/lastname property of the Program.character object to the value of
        //text property of the FirstNameTextBox/LastName textbox control
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        { //instantiate a new AbilityGeneratorForm object of the AbilityGeneratorForm class.
            AbilityGeneratorForm abilityGeneratorForm=new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();
        }
    }
}
