namespace DonerDetailsForm
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
            Searchbutton = new Button();
            dataGridView1 = new DataGridView();
            searchbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Searchbutton
            // 
            Searchbutton.Location = new Point(636, 25);
            Searchbutton.Name = "Searchbutton";
            Searchbutton.Size = new Size(94, 29);
            Searchbutton.TabIndex = 0;
            Searchbutton.Text = "search";
            Searchbutton.UseVisualStyleBackColor = true;
            Searchbutton.Click += Search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(683, 322);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchbox
            // 
            searchbox.Location = new Point(47, 25);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(556, 27);
            searchbox.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchbox);
            Controls.Add(dataGridView1);
            Controls.Add(Searchbutton);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Searchbutton;
        private DataGridView dataGridView1;
        private TextBox searchbox;
    }
}