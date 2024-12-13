namespace WinFormsApp2
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
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            textBox11 = new TextBox();
            button11 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, 404);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(34, 34);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(734, 316);
            dataGridView1.TabIndex = 1;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(92, 40);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(273, 31);
            textBox11.TabIndex = 2;
            // 
            // button11
            // 
            button11.Location = new Point(462, 37);
            button11.Name = "button11";
            button11.Size = new Size(112, 34);
            button11.TabIndex = 3;
            button11.Text = "Search";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button11);
            Controls.Add(textBox11);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private TextBox textBox11;
        private Button button11;
    }
}