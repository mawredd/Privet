namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(18, 46);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(129, 31);
            button1.TabIndex = 0;
            button1.Text = "НАЖИМАЙ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(36, 547);
            button2.Name = "button2";
            button2.Size = new Size(127, 41);
            button2.TabIndex = 3;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(449, 74);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 295);
            textBox1.TabIndex = 4;
          
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1371, 600);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "METANIT.COM";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}
