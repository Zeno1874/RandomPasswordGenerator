
namespace RandomPasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ckb_hasUpperCase = new System.Windows.Forms.CheckBox();
            this.ckb_hasLowerCase = new System.Windows.Forms.CheckBox();
            this.ckb_hasNumber = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_passwordLength = new System.Windows.Forms.TextBox();
            this.tb_passowrdCount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ckb_hasSpecialCharacter = new System.Windows.Forms.CheckBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_passwordList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckb_hasUpperCase
            // 
            this.ckb_hasUpperCase.AutoSize = true;
            this.ckb_hasUpperCase.Checked = true;
            this.ckb_hasUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_hasUpperCase.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckb_hasUpperCase.Location = new System.Drawing.Point(222, 34);
            this.ckb_hasUpperCase.Name = "ckb_hasUpperCase";
            this.ckb_hasUpperCase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckb_hasUpperCase.Size = new System.Drawing.Size(15, 25);
            this.ckb_hasUpperCase.TabIndex = 0;
            this.ckb_hasUpperCase.UseVisualStyleBackColor = true;
            // 
            // ckb_hasLowerCase
            // 
            this.ckb_hasLowerCase.AutoSize = true;
            this.ckb_hasLowerCase.Checked = true;
            this.ckb_hasLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_hasLowerCase.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckb_hasLowerCase.Location = new System.Drawing.Point(222, 65);
            this.ckb_hasLowerCase.Name = "ckb_hasLowerCase";
            this.ckb_hasLowerCase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckb_hasLowerCase.Size = new System.Drawing.Size(15, 25);
            this.ckb_hasLowerCase.TabIndex = 1;
            this.ckb_hasLowerCase.UseVisualStyleBackColor = true;
            // 
            // ckb_hasNumber
            // 
            this.ckb_hasNumber.AutoSize = true;
            this.ckb_hasNumber.Checked = true;
            this.ckb_hasNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_hasNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckb_hasNumber.Location = new System.Drawing.Point(222, 3);
            this.ckb_hasNumber.Name = "ckb_hasNumber";
            this.ckb_hasNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckb_hasNumber.Size = new System.Drawing.Size(15, 25);
            this.ckb_hasNumber.TabIndex = 2;
            this.ckb_hasNumber.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "数字";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "大写字母";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "小写字母";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "特殊字符";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(3, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "密码长度";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(3, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 34);
            this.label8.TabIndex = 12;
            this.label8.Text = "密码数量";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_passwordLength
            // 
            this.tb_passwordLength.Dock = System.Windows.Forms.DockStyle.Right;
            this.tb_passwordLength.Location = new System.Drawing.Point(99, 127);
            this.tb_passwordLength.Name = "tb_passwordLength";
            this.tb_passwordLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_passwordLength.Size = new System.Drawing.Size(138, 28);
            this.tb_passwordLength.TabIndex = 15;
            // 
            // tb_passowrdCount
            // 
            this.tb_passowrdCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.tb_passowrdCount.Location = new System.Drawing.Point(99, 158);
            this.tb_passowrdCount.Name = "tb_passowrdCount";
            this.tb_passowrdCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_passowrdCount.Size = new System.Drawing.Size(138, 28);
            this.tb_passowrdCount.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.tb_passowrdCount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_passwordLength, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb_hasUpperCase, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ckb_hasLowerCase, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ckb_hasNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ckb_hasSpecialCharacter, 1, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("思源黑体 CN Regular", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 189);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // ckb_hasSpecialCharacter
            // 
            this.ckb_hasSpecialCharacter.AutoSize = true;
            this.ckb_hasSpecialCharacter.Checked = true;
            this.ckb_hasSpecialCharacter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_hasSpecialCharacter.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckb_hasSpecialCharacter.Location = new System.Drawing.Point(222, 96);
            this.ckb_hasSpecialCharacter.Name = "ckb_hasSpecialCharacter";
            this.ckb_hasSpecialCharacter.Size = new System.Drawing.Size(15, 25);
            this.ckb_hasSpecialCharacter.TabIndex = 17;
            this.ckb_hasSpecialCharacter.UseVisualStyleBackColor = true;
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("思源黑体 CN Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_generate.Location = new System.Drawing.Point(0, 229);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(239, 39);
            this.btn_generate.TabIndex = 19;
            this.btn_generate.Text = "生成密码";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("思源黑体 CN Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 303);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "密码选项";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_generate);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(6, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 268);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("思源黑体 CN Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(260, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 303);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "密码列表";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_passwordList);
            this.panel2.Location = new System.Drawing.Point(6, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 265);
            this.panel2.TabIndex = 0;
            // 
            // lb_passwordList
            // 
            this.lb_passwordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_passwordList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_passwordList.FormattingEnabled = true;
            this.lb_passwordList.ItemHeight = 19;
            this.lb_passwordList.Location = new System.Drawing.Point(0, 0);
            this.lb_passwordList.Margin = new System.Windows.Forms.Padding(8);
            this.lb_passwordList.Name = "lb_passwordList";
            this.lb_passwordList.Size = new System.Drawing.Size(468, 265);
            this.lb_passwordList.TabIndex = 2;
            this.lb_passwordList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_passwordList_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(745, 311);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "随机密码生成器";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ckb_hasUpperCase;
        private System.Windows.Forms.CheckBox ckb_hasLowerCase;
        private System.Windows.Forms.CheckBox ckb_hasNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_passwordLength;
        private System.Windows.Forms.TextBox tb_passowrdCount;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ckb_hasSpecialCharacter;
        private System.Windows.Forms.ListBox lb_passwordList;
    }
}

