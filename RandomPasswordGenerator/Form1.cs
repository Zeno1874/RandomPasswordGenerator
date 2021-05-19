using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RandomPasswordGenerator
{


    public partial class Form1 : Form
    {
        private bool hasLowerCase;
        private bool hasUpperCase;
        private bool hasNumber;
        private bool hasSpecialCharacter;

        private int passwordLength;
        private int passwordNum;

        List<char> LowerCases = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                                                'h', 'i', 'j', 'k', 'l', 'm', 'n',
                                                'o', 'p', 'q', 'r', 's', 't', 'u',
                                                'v', 'w', 'x', 'y', 'z' };

        List<char> UpperCases = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G',
                                                 'H', 'I', 'J', 'K', 'L', 'M', 'N',
                                                 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                                                 'V', 'W', 'X', 'Y', 'Z' };

        List<char> Numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        List<char> SpecialCharacters = new List<char> { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '?', '/', '+', '-' };
        public Form1()
        {
            InitializeComponent();
            ckb_hasLowerCase.Checked = true;
            ckb_hasNumber.Checked = true;
            ckb_hasSpecialCharacter.Checked = true;
            ckb_hasUpperCase.Checked = true;
            tb_passwordLength.Text = "16";
            tb_passowrdNumber.Text = "5";

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            hasNumber = this.ckb_hasNumber.Checked;
            hasLowerCase = this.ckb_hasLowerCase.Checked;
            hasUpperCase = this.ckb_hasUpperCase.Checked;
            hasSpecialCharacter = this.ckb_hasSpecialCharacter.Checked;

            passwordLength = int.Parse(this.tb_passwordLength.Text);
            passwordNum = int.Parse(this.tb_passowrdNumber.Text);

            List<char> charactersList = new List<char>();

            if (hasNumber)
            {
                charactersList.InsertRange(charactersList.Count, Numbers);
            }
            if (hasLowerCase)
            {
                charactersList.InsertRange(charactersList.Count, LowerCases);
            }
            if (hasUpperCase)
            {
                charactersList.InsertRange(charactersList.Count, UpperCases);
            }
            if (hasSpecialCharacter)
            {
                charactersList.InsertRange(charactersList.Count, SpecialCharacters);
            }

            List<string> newPasswordList = new List<string>();
            
            for (int num = 0; num < passwordNum; num++)
            {
                
                List<string> newPasswordChar = new List<string>();

                Random rm = new Random(Guid.NewGuid().GetHashCode());

                List<char> cs = new List<char>(charactersList);
                int count = cs.Count;
                for (int i = 0; i < passwordLength; i++)
                {
                    //rm = new Random(Guid.NewGuid().GetHashCode());
                    int index = rm.Next(count);
                    Console.WriteLine(cs[index]);
                    newPasswordChar.Add(cs[index].ToString());
                    cs.RemoveAt(index);
                    count -= 1;
                }

                string newPassword = string.Join("", newPasswordChar.ToArray());
                newPasswordList.Add(newPassword);
            }

            string newPL = string.Join("\n\n", newPasswordList.ToArray());

            this.tb_passwordList.Text = newPL;

        }
    }
}
