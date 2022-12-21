
namespace Elliptic_Curves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateBtnA = new System.Windows.Forms.Button();
            this.KeyCheckA = new System.Windows.Forms.CheckBox();
            this.EncryptMessTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.OpenkeyATB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GPointABox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SecretKeyATB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EPointATB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToEcryptTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateBtnB = new System.Windows.Forms.Button();
            this.KeyCheckB = new System.Windows.Forms.CheckBox();
            this.DecryptMessTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.OpenkeyBTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GPointBBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SecretKeyBTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EPointBTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ToDecryptTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UpdateBtnA);
            this.groupBox1.Controls.Add(this.KeyCheckA);
            this.groupBox1.Controls.Add(this.EncryptMessTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.EncryptBtn);
            this.groupBox1.Controls.Add(this.OpenkeyATB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.GPointABox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SecretKeyATB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EPointATB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ToEcryptTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алиса";
            // 
            // UpdateBtnA
            // 
            this.UpdateBtnA.Location = new System.Drawing.Point(276, 133);
            this.UpdateBtnA.Name = "UpdateBtnA";
            this.UpdateBtnA.Size = new System.Drawing.Size(139, 29);
            this.UpdateBtnA.TabIndex = 14;
            this.UpdateBtnA.Text = "Загрузить точки";
            this.UpdateBtnA.UseVisualStyleBackColor = true;
            this.UpdateBtnA.Click += new System.EventHandler(this.UpdateBtnA_Click);
            // 
            // KeyCheckA
            // 
            this.KeyCheckA.AutoSize = true;
            this.KeyCheckA.Location = new System.Drawing.Point(29, 231);
            this.KeyCheckA.Name = "KeyCheckA";
            this.KeyCheckA.Size = new System.Drawing.Size(112, 24);
            this.KeyCheckA.TabIndex = 13;
            this.KeyCheckA.Text = "Шифровать";
            this.KeyCheckA.UseVisualStyleBackColor = true;
            // 
            // EncryptMessTB
            // 
            this.EncryptMessTB.Location = new System.Drawing.Point(41, 346);
            this.EncryptMessTB.Name = "EncryptMessTB";
            this.EncryptMessTB.Size = new System.Drawing.Size(374, 27);
            this.EncryptMessTB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Преобразованное сообщение:";
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(134, 263);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(166, 46);
            this.EncryptBtn.TabIndex = 10;
            this.EncryptBtn.Text = "Преобразовать текст";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // OpenkeyATB
            // 
            this.OpenkeyATB.Location = new System.Drawing.Point(41, 198);
            this.OpenkeyATB.Name = "OpenkeyATB";
            this.OpenkeyATB.Size = new System.Drawing.Size(374, 27);
            this.OpenkeyATB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Открытый ключ:";
            // 
            // GPointABox
            // 
            this.GPointABox.FormattingEnabled = true;
            this.GPointABox.Location = new System.Drawing.Point(74, 133);
            this.GPointABox.Name = "GPointABox";
            this.GPointABox.Size = new System.Drawing.Size(155, 28);
            this.GPointABox.TabIndex = 7;
            this.GPointABox.SelectedIndexChanged += new System.EventHandler(this.GPointABox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "G(13):";
            // 
            // SecretKeyATB
            // 
            this.SecretKeyATB.Location = new System.Drawing.Point(276, 94);
            this.SecretKeyATB.Name = "SecretKeyATB";
            this.SecretKeyATB.Size = new System.Drawing.Size(139, 27);
            this.SecretKeyATB.TabIndex = 5;
            this.SecretKeyATB.Text = "5";
            this.SecretKeyATB.TextChanged += new System.EventHandler(this.SecretKeyATB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "d:";
            // 
            // EPointATB
            // 
            this.EPointATB.Location = new System.Drawing.Point(41, 94);
            this.EPointATB.Name = "EPointATB";
            this.EPointATB.Size = new System.Drawing.Size(188, 27);
            this.EPointATB.TabIndex = 3;
            this.EPointATB.Text = "41;1;3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "E:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сообщение:";
            // 
            // ToEcryptTB
            // 
            this.ToEcryptTB.Location = new System.Drawing.Point(41, 55);
            this.ToEcryptTB.Name = "ToEcryptTB";
            this.ToEcryptTB.Size = new System.Drawing.Size(374, 27);
            this.ToEcryptTB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdateBtnB);
            this.groupBox2.Controls.Add(this.KeyCheckB);
            this.groupBox2.Controls.Add(this.DecryptMessTB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DecryptBtn);
            this.groupBox2.Controls.Add(this.OpenkeyBTB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.GPointBBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.SecretKeyBTB);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.EPointBTB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.ToDecryptTB);
            this.groupBox2.Location = new System.Drawing.Point(492, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 389);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Боб";
            // 
            // UpdateBtnB
            // 
            this.UpdateBtnB.Location = new System.Drawing.Point(280, 135);
            this.UpdateBtnB.Name = "UpdateBtnB";
            this.UpdateBtnB.Size = new System.Drawing.Size(139, 29);
            this.UpdateBtnB.TabIndex = 28;
            this.UpdateBtnB.Text = "Загрузить точки";
            this.UpdateBtnB.UseVisualStyleBackColor = true;
            this.UpdateBtnB.Click += new System.EventHandler(this.UpdateBtnB_Click);
            // 
            // KeyCheckB
            // 
            this.KeyCheckB.AutoSize = true;
            this.KeyCheckB.Location = new System.Drawing.Point(33, 233);
            this.KeyCheckB.Name = "KeyCheckB";
            this.KeyCheckB.Size = new System.Drawing.Size(112, 24);
            this.KeyCheckB.TabIndex = 27;
            this.KeyCheckB.Text = "Шифровать";
            this.KeyCheckB.UseVisualStyleBackColor = true;
            // 
            // DecryptMessTB
            // 
            this.DecryptMessTB.Location = new System.Drawing.Point(45, 346);
            this.DecryptMessTB.Name = "DecryptMessTB";
            this.DecryptMessTB.Size = new System.Drawing.Size(374, 27);
            this.DecryptMessTB.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Преобразованное сообщение:";
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(148, 263);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(166, 46);
            this.DecryptBtn.TabIndex = 24;
            this.DecryptBtn.Text = "Преобразовать текст";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // OpenkeyBTB
            // 
            this.OpenkeyBTB.Location = new System.Drawing.Point(45, 200);
            this.OpenkeyBTB.Name = "OpenkeyBTB";
            this.OpenkeyBTB.Size = new System.Drawing.Size(374, 27);
            this.OpenkeyBTB.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Открытый ключ:";
            // 
            // GPointBBox
            // 
            this.GPointBBox.FormattingEnabled = true;
            this.GPointBBox.Location = new System.Drawing.Point(78, 135);
            this.GPointBBox.Name = "GPointBBox";
            this.GPointBBox.Size = new System.Drawing.Size(155, 28);
            this.GPointBBox.TabIndex = 21;
            this.GPointBBox.SelectedIndexChanged += new System.EventHandler(this.GPointBBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "G(13):";
            // 
            // SecretKeyBTB
            // 
            this.SecretKeyBTB.Location = new System.Drawing.Point(280, 96);
            this.SecretKeyBTB.Name = "SecretKeyBTB";
            this.SecretKeyBTB.Size = new System.Drawing.Size(139, 27);
            this.SecretKeyBTB.TabIndex = 19;
            this.SecretKeyBTB.Text = "7";
            this.SecretKeyBTB.TextChanged += new System.EventHandler(this.SecretKeyBTB_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "d:";
            // 
            // EPointBTB
            // 
            this.EPointBTB.Location = new System.Drawing.Point(45, 96);
            this.EPointBTB.Name = "EPointBTB";
            this.EPointBTB.Size = new System.Drawing.Size(188, 27);
            this.EPointBTB.TabIndex = 17;
            this.EPointBTB.Text = "41;1;3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "E:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Сообщение:";
            // 
            // ToDecryptTB
            // 
            this.ToDecryptTB.Location = new System.Drawing.Point(45, 57);
            this.ToDecryptTB.Name = "ToDecryptTB";
            this.ToDecryptTB.Size = new System.Drawing.Size(374, 27);
            this.ToDecryptTB.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Шифрование на эллиптических кривых";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ToEcryptTB;
        private System.Windows.Forms.CheckBox KeyCheckA;
        private System.Windows.Forms.TextBox EncryptMessTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.TextBox OpenkeyATB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GPointABox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SecretKeyATB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EPointATB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox KeyCheckB;
        private System.Windows.Forms.TextBox DecryptMessTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.TextBox OpenkeyBTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox GPointBBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SecretKeyBTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EPointBTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ToDecryptTB;
        private System.Windows.Forms.Button UpdateBtnA;
        private System.Windows.Forms.Button UpdateBtnB;
    }
}

