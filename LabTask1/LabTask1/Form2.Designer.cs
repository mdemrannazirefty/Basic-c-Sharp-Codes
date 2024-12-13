
namespace LabTask1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(32, 12);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(756, 426);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            richTextBox.TextChanged += richTextBox_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private RichTextBox richTextBox;
    }
}