namespace WinFormsApp7
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
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 29);
            button1.Name = "button1";
            button1.Size = new Size(118, 37);
            button1.TabIndex = 0;
            button1.Text = "Qovluq sec";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(157, 29);
            button2.Name = "button2";
            button2.Size = new Size(121, 37);
            button2.TabIndex = 1;
            button2.Text = "Ac";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(307, 29);
            button3.Name = "button3";
            button3.Size = new Size(121, 37);
            button3.TabIndex = 2;
            button3.Text = "Yadda saxla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(463, 29);
            button4.Name = "button4";
            button4.Size = new Size(123, 37);
            button4.TabIndex = 3;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(611, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "C:\\User......";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(159, 22);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 114);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(186, 274);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(245, 114);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(525, 274);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 56);
            panel1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(392, 19);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(186, 19);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 19);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 3;
            // 
            // label5
            // 
            label5.Location = new Point(295, 19);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 2;
            label5.Text = "Yaramma tarixi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 19);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 1;
            label4.Text = "Olcu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 19);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 0;
            label3.Text = "Ad:";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 474);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            toolStripStatusLabel2.Click += toolStripStatusLabel2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 9;
            label1.Text = "fayllar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 85);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 10;
            label2.Text = "metn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 496);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "fayl menecer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private StatusStrip statusStrip1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
