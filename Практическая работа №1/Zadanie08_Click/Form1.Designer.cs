namespace ClickTask;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        panel1 = new Panel();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        textBox1 = new TextBox();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(button4);
        panel1.Controls.Add(button3);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Location = new Point(64, 49);
        panel1.Name = "panel1";
        panel1.Size = new Size(218, 204);
        panel1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Cursor = Cursors.Hand;
        button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button1.Location = new Point(55, 20);
        button1.Name = "button1";
        button1.Size = new Size(116, 34);
        button1.TabIndex = 0;
        button1.Text = "Кнопка 1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Cursor = Cursors.Hand;
        button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button2.Location = new Point(55, 61);
        button2.Name = "button2";
        button2.Size = new Size(116, 34);
        button2.TabIndex = 1;
        button2.Text = "Кнопка 2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Cursor = Cursors.Hand;
        button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button3.Location = new Point(55, 102);
        button3.Name = "button3";
        button3.Size = new Size(116, 34);
        button3.TabIndex = 2;
        button3.Text = "Кнопка 3";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Cursor = Cursors.Hand;
        button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button4.Location = new Point(55, 143);
        button4.Name = "button4";
        button4.Size = new Size(116, 34);
        button4.TabIndex = 3;
        button4.Text = "Кнопка 4";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 14F);
        textBox1.Location = new Point(59, 269);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(219, 32);
        textBox1.TabIndex = 1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(334, 381);
        Controls.Add(textBox1);
        Controls.Add(panel1);
        Name = "Form1";
        Text = "Щелчок";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private TextBox textBox1;
}
