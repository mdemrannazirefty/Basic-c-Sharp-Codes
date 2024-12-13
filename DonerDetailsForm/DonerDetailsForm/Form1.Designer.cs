namespace DonerDetailsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            updatebutton = new Button();
            cancelbutton = new Button();
            label14 = new Label();
            dnobox = new TextBox();
            agebox = new TextBox();
            namebox = new TextBox();
            passwordbox = new TextBox();
            mobilebox = new TextBox();
            emailbox = new TextBox();
            datebox = new DateTimePicker();
            countrybox = new ComboBox();
            statebox = new ComboBox();
            citybox = new ComboBox();
            bgroupbox = new ComboBox();
            sexbox = new ComboBox();
            addressbox = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Donor's Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 47);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Donor No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 81);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Blood Group:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 115);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 154);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 192);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 5;
            label6.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 317);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 6;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(427, 81);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 7;
            label8.Text = "Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(427, 115);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 8;
            label9.Text = "Country:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(427, 154);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 9;
            label10.Text = "State";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(427, 192);
            label11.Name = "label11";
            label11.Size = new Size(34, 20);
            label11.TabIndex = 10;
            label11.Text = "City";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(427, 232);
            label12.Name = "label12";
            label12.Size = new Size(59, 20);
            label12.TabIndex = 11;
            label12.Text = "Mobile:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(427, 273);
            label13.Name = "label13";
            label13.Size = new Size(49, 20);
            label13.TabIndex = 12;
            label13.Text = "Email:";
            // 
            // updatebutton
            // 
            updatebutton.Location = new Point(505, 383);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(94, 29);
            updatebutton.TabIndex = 13;
            updatebutton.Text = "Update";
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += button1_Click;
            // 
            // cancelbutton
            // 
            cancelbutton.Location = new Point(633, 383);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(94, 29);
            cancelbutton.TabIndex = 14;
            cancelbutton.Text = "Cancel";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Click += button2_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(213, 115);
            label14.Name = "label14";
            label14.Size = new Size(32, 20);
            label14.TabIndex = 15;
            label14.Text = "Sex";
            // 
            // dnobox
            // 
            dnobox.Location = new Point(131, 44);
            dnobox.Name = "dnobox";
            dnobox.Size = new Size(125, 27);
            dnobox.TabIndex = 16;
            // 
            // agebox
            // 
            agebox.Location = new Point(92, 112);
            agebox.Name = "agebox";
            agebox.Size = new Size(115, 27);
            agebox.TabIndex = 17;
            // 
            // namebox
            // 
            namebox.Location = new Point(124, 151);
            namebox.Name = "namebox";
            namebox.Size = new Size(125, 27);
            namebox.TabIndex = 18;
            // 
            // passwordbox
            // 
            passwordbox.Location = new Point(124, 310);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(125, 27);
            passwordbox.TabIndex = 19;
            // 
            // mobilebox
            // 
            mobilebox.Location = new Point(492, 232);
            mobilebox.Name = "mobilebox";
            mobilebox.Size = new Size(125, 27);
            mobilebox.TabIndex = 20;
            // 
            // emailbox
            // 
            emailbox.Location = new Point(492, 273);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(125, 27);
            emailbox.TabIndex = 21;
            // 
            // datebox
            // 
            datebox.Location = new Point(492, 81);
            datebox.Name = "datebox";
            datebox.Size = new Size(250, 27);
            datebox.TabIndex = 22;
            // 
            // countrybox
            // 
            countrybox.FormattingEnabled = true;
            countrybox.Location = new Point(492, 115);
            countrybox.Name = "countrybox";
            countrybox.Size = new Size(151, 28);
            countrybox.TabIndex = 23;
            // 
            // statebox
            // 
            statebox.FormattingEnabled = true;
            statebox.Location = new Point(492, 149);
            statebox.Name = "statebox";
            statebox.Size = new Size(151, 28);
            statebox.TabIndex = 24;
            // 
            // citybox
            // 
            citybox.FormattingEnabled = true;
            citybox.Location = new Point(492, 189);
            citybox.Name = "citybox";
            citybox.Size = new Size(151, 28);
            citybox.TabIndex = 25;
            // 
            // bgroupbox
            // 
            bgroupbox.FormattingEnabled = true;
            bgroupbox.Location = new Point(150, 77);
            bgroupbox.Name = "bgroupbox";
            bgroupbox.Size = new Size(151, 28);
            bgroupbox.TabIndex = 26;
            // 
            // sexbox
            // 
            sexbox.FormattingEnabled = true;
            sexbox.Location = new Point(251, 111);
            sexbox.Name = "sexbox";
            sexbox.Size = new Size(151, 28);
            sexbox.TabIndex = 27;
            // 
            // addressbox
            // 
            addressbox.Location = new Point(124, 192);
            addressbox.Name = "addressbox";
            addressbox.Size = new Size(251, 108);
            addressbox.TabIndex = 28;
            addressbox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addressbox);
            Controls.Add(sexbox);
            Controls.Add(bgroupbox);
            Controls.Add(citybox);
            Controls.Add(statebox);
            Controls.Add(countrybox);
            Controls.Add(datebox);
            Controls.Add(emailbox);
            Controls.Add(mobilebox);
            Controls.Add(passwordbox);
            Controls.Add(namebox);
            Controls.Add(agebox);
            Controls.Add(dnobox);
            Controls.Add(label14);
            Controls.Add(cancelbutton);
            Controls.Add(updatebutton);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Donor Detail Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button updatebutton;
        private Button cancelbutton;
        private Label label14;
        private TextBox dnobox;
        private TextBox agebox;
        private TextBox namebox;
        private TextBox passwordbox;
        private TextBox mobilebox;
        private TextBox emailbox;
        private DateTimePicker datebox;
        private ComboBox countrybox;
        private ComboBox statebox;
        private ComboBox citybox;
        private ComboBox bgroupbox;
        private ComboBox sexbox;
        private RichTextBox addressbox;
    }
}
