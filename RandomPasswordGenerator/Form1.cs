using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RandomPasswordGenerator
{


    public partial class Form1 : Form
    {
        // 97-122
        private bool hasLowerCase;
        // 65-90
        private bool hasUpperCase;
        // 48-57
        private bool hasNumber;
        // 33-47
        // 58-64
        // 91-96
        private bool hasSpecialCharacter;

        private int passwordLength;
        private int passwordCount;

        // 小写字符
        List<char> LowerCases = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                                                'h', 'i', 'j', 'k', 'l', 'm', 'n',
                                                'o', 'p', 'q', 'r', 's', 't', 'u',
                                                'v', 'w', 'x', 'y', 'z' };
        // 大写字符
        List<char> UpperCases = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G',
                                                 'H', 'I', 'J', 'K', 'L', 'M', 'N',
                                                 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                                                 'V', 'W', 'X', 'Y', 'Z' };
        // 数字字符
        List<char> Numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        // 特殊字符
        List<char> SpecialCharacters = new List<char> { '!', '@', '#', '$', '%', '&', '*', '(', ')', '?', '+' };
        public Form1()
        {
            InitializeComponent();
            ckb_hasLowerCase.Checked = true;
            ckb_hasNumber.Checked = true;
            ckb_hasSpecialCharacter.Checked = true;
            ckb_hasUpperCase.Checked = true;
            tb_passwordLength.Text = "16";
            tb_passowrdCount.Text = "5";

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            this.lb_passwordList.Items.Clear();

            // 是否包含数字字符
            hasNumber = this.ckb_hasNumber.Checked;
            // 是否包含小写字母字符
            hasLowerCase = this.ckb_hasLowerCase.Checked;
            // 是否包含大写字母字符
            hasUpperCase = this.ckb_hasUpperCase.Checked;
            // 是否包含特殊字符
            hasSpecialCharacter = this.ckb_hasSpecialCharacter.Checked;
            // 密码长度
            passwordLength = int.Parse(this.tb_passwordLength.Text);
            //密码数量
            passwordCount = int.Parse(this.tb_passowrdCount.Text);

            // 密码列表
            List<string> newPasswordList = new List<string>();
            
            for (int count = 0; count < passwordCount; count++)
            {
                // 单个密码字符列表
                List<string> SinglePasswordCharList = new List<string>();

                Random rm = new Random(Guid.NewGuid().GetHashCode());

                List<char> charList = preparCharList(hasLowerCase, hasUpperCase, hasNumber, hasSpecialCharacter);
                int ccount = charList.Count;
                for (int i = 0; i < passwordLength; i++)
                {
                    int index = rm.Next(ccount);
                    SinglePasswordCharList.Add(charList[index].ToString());
                    charList.RemoveAt(index);
                    ccount -= 1;
                }
                // 单个密码
                string newSinglePassword = string.Join("", SinglePasswordCharList.ToArray());
                newPasswordList.Add(newSinglePassword);
            }

            foreach(string str in newPasswordList)
            {
                this.lb_passwordList.Items.Add(str);

            }
        }

        private void lb_passwordList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lb_passwordList.SelectedIndex;
            String str = this.lb_passwordList.Items[index].ToString();
            
            Clipboard.SetDataObject(str);
            MessageBox.Show("密码”" + str+ "”已复制");
        }

        /**
         * 准备密码字符集合
         **/
        private List<char> preparCharList(bool hasL,bool hasU,bool hasN,bool hasS)
        {

            List<char> charactersList = new List<char>();

            if (hasN)
            {
                charactersList.InsertRange(charactersList.Count, Numbers);
            }
            if (hasL)
            {
                charactersList.InsertRange(charactersList.Count, LowerCases);
            }
            if (hasU)
            {
                charactersList.InsertRange(charactersList.Count, UpperCases);
            }
            if (hasS)
            {
                charactersList.InsertRange(charactersList.Count, SpecialCharacters);
            }

            return charactersList;
        }
    }
}
