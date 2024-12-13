namespace Loginsql
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
            emailbox = new TextBox();
            mobilebox = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label13 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // emailbox
            // 
            emailbox.Location = new Point(315, 176);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(125, 27);
            emailbox.TabIndex = 56;
            // 
            // mobilebox
            // 
            mobilebox.Location = new Point(315, 135);
            mobilebox.Name = "mobilebox";
            mobilebox.Size = new Size(125, 27);
            mobilebox.TabIndex = 55;
            // 
            // button2
            // 
            button2.Location = new Point(372, 223);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 54;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(252, 223);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 53;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(234, 177);
            label13.Name = "label13";
            label13.Size = new Size(70, 20);
            label13.TabIndex = 52;
            label13.Text = "Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(234, 135);
            label12.Name = "label12";
            label12.Size = new Size(75, 20);
            label12.TabIndex = 51;
            label12.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(emailbox);
            Controls.Add(mobilebox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(label12);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailbox;
        private TextBox mobilebox;
        private Button button2;
        private Button button1;
        private Label label13;
        private Label label12;
    }
}
