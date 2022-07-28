namespace Ch11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.btnUid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHp = new System.Windows.Forms.Button();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.lbuid = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbHp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkfrult1 = new System.Windows.Forms.CheckBox();
            this.chkfrult2 = new System.Windows.Forms.CheckBox();
            this.chkfrult3 = new System.Windows.Forms.CheckBox();
            this.chkfrult5 = new System.Windows.Forms.CheckBox();
            this.chkfrult4 = new System.Windows.Forms.CheckBox();
            this.btnChkfrult1 = new System.Windows.Forms.Button();
            this.btnChkColor = new System.Windows.Forms.Button();
            this.chkColor4 = new System.Windows.Forms.CheckBox();
            this.chkColor5 = new System.Windows.Forms.CheckBox();
            this.chkColor3 = new System.Windows.Forms.CheckBox();
            this.chkColor2 = new System.Windows.Forms.CheckBox();
            this.chkColor1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbFruitReshlt = new System.Windows.Forms.Label();
            this.lbColorResult = new System.Windows.Forms.Label();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "텍스트박스컨트롤";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(377, 70);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(100, 23);
            this.txtUid.TabIndex = 1;
            // 
            // btnUid
            // 
            this.btnUid.Location = new System.Drawing.Point(483, 70);
            this.btnUid.Name = "btnUid";
            this.btnUid.Size = new System.Drawing.Size(75, 23);
            this.btnUid.TabIndex = 2;
            this.btnUid.Text = "버튼1";
            this.btnUid.UseVisualStyleBackColor = true;
            this.btnUid.Click += new System.EventHandler(this.btnUid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "아이디 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "이름:";
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(483, 99);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 5;
            this.btnName.Text = "버튼2";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(377, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "휴대폰:";
            // 
            // btnHp
            // 
            this.btnHp.Location = new System.Drawing.Point(483, 128);
            this.btnHp.Name = "btnHp";
            this.btnHp.Size = new System.Drawing.Size(75, 23);
            this.btnHp.TabIndex = 8;
            this.btnHp.Text = "버튼3";
            this.btnHp.UseVisualStyleBackColor = true;
            this.btnHp.Click += new System.EventHandler(this.btnHp_Click);
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(377, 128);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(100, 23);
            this.txtHP.TabIndex = 7;
            // 
            // lbuid
            // 
            this.lbuid.AutoSize = true;
            this.lbuid.Location = new System.Drawing.Point(564, 74);
            this.lbuid.Name = "lbuid";
            this.lbuid.Size = new System.Drawing.Size(34, 15);
            this.lbuid.TabIndex = 10;
            this.lbuid.Text = "결과:";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(564, 104);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(34, 15);
            this.lbname.TabIndex = 11;
            this.lbname.Text = "결과:";
            // 
            // lbHp
            // 
            this.lbHp.AutoSize = true;
            this.lbHp.Location = new System.Drawing.Point(564, 132);
            this.lbHp.Name = "lbHp";
            this.lbHp.Size = new System.Drawing.Size(34, 15);
            this.lbHp.TabIndex = 12;
            this.lbHp.Text = "결과:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "checkBox 컨트롤 실습";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "좋아하는과일 선택";
            // 
            // chkfrult1
            // 
            this.chkfrult1.AutoSize = true;
            this.chkfrult1.Location = new System.Drawing.Point(305, 242);
            this.chkfrult1.Name = "chkfrult1";
            this.chkfrult1.Size = new System.Drawing.Size(50, 19);
            this.chkfrult1.TabIndex = 15;
            this.chkfrult1.Text = "사과";
            this.chkfrult1.UseVisualStyleBackColor = true;
            // 
            // chkfrult2
            // 
            this.chkfrult2.AutoSize = true;
            this.chkfrult2.Location = new System.Drawing.Point(361, 242);
            this.chkfrult2.Name = "chkfrult2";
            this.chkfrult2.Size = new System.Drawing.Size(50, 19);
            this.chkfrult2.TabIndex = 16;
            this.chkfrult2.Text = "딸기";
            this.chkfrult2.UseVisualStyleBackColor = true;
            // 
            // chkfrult3
            // 
            this.chkfrult3.AutoSize = true;
            this.chkfrult3.Location = new System.Drawing.Point(417, 242);
            this.chkfrult3.Name = "chkfrult3";
            this.chkfrult3.Size = new System.Drawing.Size(50, 19);
            this.chkfrult3.TabIndex = 17;
            this.chkfrult3.Text = "포도";
            this.chkfrult3.UseVisualStyleBackColor = true;
            // 
            // chkfrult5
            // 
            this.chkfrult5.AutoSize = true;
            this.chkfrult5.Location = new System.Drawing.Point(529, 242);
            this.chkfrult5.Name = "chkfrult5";
            this.chkfrult5.Size = new System.Drawing.Size(50, 19);
            this.chkfrult5.TabIndex = 18;
            this.chkfrult5.Text = "참외";
            this.chkfrult5.UseVisualStyleBackColor = true;
            // 
            // chkfrult4
            // 
            this.chkfrult4.AutoSize = true;
            this.chkfrult4.Location = new System.Drawing.Point(473, 242);
            this.chkfrult4.Name = "chkfrult4";
            this.chkfrult4.Size = new System.Drawing.Size(50, 19);
            this.chkfrult4.TabIndex = 19;
            this.chkfrult4.Text = "수박";
            this.chkfrult4.UseVisualStyleBackColor = true;
            // 
            // btnChkfrult1
            // 
            this.btnChkfrult1.Location = new System.Drawing.Point(585, 238);
            this.btnChkfrult1.Name = "btnChkfrult1";
            this.btnChkfrult1.Size = new System.Drawing.Size(75, 23);
            this.btnChkfrult1.TabIndex = 20;
            this.btnChkfrult1.Text = "확인";
            this.btnChkfrult1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChkfrult1.UseVisualStyleBackColor = true;
            this.btnChkfrult1.Click += new System.EventHandler(this.btnChkfrult1_Click);
            // 
            // btnChkColor
            // 
            this.btnChkColor.Location = new System.Drawing.Point(585, 323);
            this.btnChkColor.Name = "btnChkColor";
            this.btnChkColor.Size = new System.Drawing.Size(75, 23);
            this.btnChkColor.TabIndex = 27;
            this.btnChkColor.Text = "확인";
            this.btnChkColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChkColor.UseVisualStyleBackColor = true;
            this.btnChkColor.Click += new System.EventHandler(this.btnChkColor_Click);
            // 
            // chkColor4
            // 
            this.chkColor4.AutoSize = true;
            this.chkColor4.Location = new System.Drawing.Point(473, 327);
            this.chkColor4.Name = "chkColor4";
            this.chkColor4.Size = new System.Drawing.Size(50, 19);
            this.chkColor4.TabIndex = 26;
            this.chkColor4.Text = "노랑";
            this.chkColor4.UseVisualStyleBackColor = true;
            // 
            // chkColor5
            // 
            this.chkColor5.AutoSize = true;
            this.chkColor5.Location = new System.Drawing.Point(529, 327);
            this.chkColor5.Name = "chkColor5";
            this.chkColor5.Size = new System.Drawing.Size(50, 19);
            this.chkColor5.TabIndex = 25;
            this.chkColor5.Text = "검정";
            this.chkColor5.UseVisualStyleBackColor = true;
            // 
            // chkColor3
            // 
            this.chkColor3.AutoSize = true;
            this.chkColor3.Location = new System.Drawing.Point(417, 327);
            this.chkColor3.Name = "chkColor3";
            this.chkColor3.Size = new System.Drawing.Size(50, 19);
            this.chkColor3.TabIndex = 24;
            this.chkColor3.Text = "녹색";
            this.chkColor3.UseVisualStyleBackColor = true;
            // 
            // chkColor2
            // 
            this.chkColor2.AutoSize = true;
            this.chkColor2.Location = new System.Drawing.Point(361, 327);
            this.chkColor2.Name = "chkColor2";
            this.chkColor2.Size = new System.Drawing.Size(50, 19);
            this.chkColor2.TabIndex = 23;
            this.chkColor2.Text = "파랑";
            this.chkColor2.UseVisualStyleBackColor = true;
            // 
            // chkColor1
            // 
            this.chkColor1.AutoSize = true;
            this.chkColor1.Location = new System.Drawing.Point(305, 327);
            this.chkColor1.Name = "chkColor1";
            this.chkColor1.Size = new System.Drawing.Size(50, 19);
            this.chkColor1.TabIndex = 22;
            this.chkColor1.Text = "빨강";
            this.chkColor1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "좋아하는 색을 모두 선택하세요";
            // 
            // lbFruitReshlt
            // 
            this.lbFruitReshlt.AutoSize = true;
            this.lbFruitReshlt.Location = new System.Drawing.Point(306, 264);
            this.lbFruitReshlt.Name = "lbFruitReshlt";
            this.lbFruitReshlt.Size = new System.Drawing.Size(38, 15);
            this.lbFruitReshlt.TabIndex = 28;
            this.lbFruitReshlt.Text = "결과 :";
            // 
            // lbColorResult
            // 
            this.lbColorResult.AutoSize = true;
            this.lbColorResult.Location = new System.Drawing.Point(306, 360);
            this.lbColorResult.Name = "lbColorResult";
            this.lbColorResult.Size = new System.Drawing.Size(38, 15);
            this.lbColorResult.TabIndex = 29;
            this.lbColorResult.Text = "결과 :";
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(292, 396);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(75, 23);
            this.btnForm2.TabIndex = 30;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Form3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.lbColorResult);
            this.Controls.Add(this.lbFruitReshlt);
            this.Controls.Add(this.btnChkColor);
            this.Controls.Add(this.chkColor4);
            this.Controls.Add(this.chkColor5);
            this.Controls.Add(this.chkColor3);
            this.Controls.Add(this.chkColor2);
            this.Controls.Add(this.chkColor1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnChkfrult1);
            this.Controls.Add(this.chkfrult4);
            this.Controls.Add(this.chkfrult5);
            this.Controls.Add(this.chkfrult3);
            this.Controls.Add(this.chkfrult2);
            this.Controls.Add(this.chkfrult1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbHp);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbuid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHp);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUid);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtUid;
        private Button btnUid;
        private Label label2;
        private Label label3;
        private Button btnName;
        private TextBox txtName;
        private Label label4;
        private Button btnHp;
        private TextBox txtHP;
        private Label lbuid;
        private Label lbname;
        private Label lbHp;
        private Label label5;
        private Label label6;
        private CheckBox chkfrult1;
        private CheckBox chkfrult2;
        private CheckBox chkfrult3;
        private CheckBox chkfrult5;
        private CheckBox chkfrult4;
        private Button btnChkfrult1;
        private Button btnChkColor;
        private CheckBox chkColor4;
        private CheckBox chkColor5;
        private CheckBox chkColor3;
        private CheckBox chkColor2;
        private CheckBox chkColor1;
        private Label label7;
        private Label lbFruitReshlt;
        private Label lbColorResult;
        private Button btnForm2;
        private Button button1;
    }
}