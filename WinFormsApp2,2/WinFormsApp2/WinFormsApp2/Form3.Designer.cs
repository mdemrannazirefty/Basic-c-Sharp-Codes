namespace WinFormsApp2
{
    partial class Form3
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
            textboxid = new TextBox();
            find = new Button();
            textboxaddress = new TextBox();
            textboxnationality = new TextBox();
            textboxgender = new TextBox();
            textboxname = new TextBox();
            update = new Button();
            delete = new Button();
            SuspendLayout();
            // 
            // textboxid
            // 
            textboxid.Location = new Point(80, 59);
            textboxid.Name = "textboxid";
            textboxid.Size = new Size(150, 31);
            textboxid.TabIndex = 0;
            // 
            // find
            // 
            find.Location = new Point(290, 59);
            find.Name = "find";
            find.Size = new Size(112, 34);
            find.TabIndex = 1;
            find.Text = "Find";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click;
            // 
            // textboxaddress
            // 
            textboxaddress.Location = new Point(80, 265);
            textboxaddress.Name = "textboxaddress";
            textboxaddress.Size = new Size(150, 31);
            textboxaddress.TabIndex = 2;
            // 
            // textboxnationality
            // 
            textboxnationality.Location = new Point(80, 210);
            textboxnationality.Name = "textboxnationality";
            textboxnationality.Size = new Size(150, 31);
            textboxnationality.TabIndex = 3;
            // 
            // textboxgender
            // 
            textboxgender.Location = new Point(80, 161);
            textboxgender.Name = "textboxgender";
            textboxgender.Size = new Size(150, 31);
            textboxgender.TabIndex = 4;
            // 
            // textboxname
            // 
            textboxname.Location = new Point(80, 112);
            textboxname.Name = "textboxname";
            textboxname.Size = new Size(150, 31);
            textboxname.TabIndex = 5;
            // 
            // update
            // 
            update.Location = new Point(435, 59);
            update.Name = "update";
            update.Size = new Size(112, 34);
            update.TabIndex = 6;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(590, 59);
            delete.Name = "delete";
            delete.Size = new Size(112, 34);
            delete.TabIndex = 7;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(textboxname);
            Controls.Add(textboxgender);
            Controls.Add(textboxnationality);
            Controls.Add(textboxaddress);
            Controls.Add(find);
            Controls.Add(textboxid);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxid;
        private Button find;
        private TextBox textboxaddress;
        private TextBox textboxnationality;
        private TextBox textboxgender;
        private TextBox textboxname;
        private Button update;
        private Button delete;
    }
}