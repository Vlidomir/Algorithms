namespace Zadanie11_AverageVariant4;

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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F);
        label1.Location = new Point(42, 38);
        label1.Name = "label1";
        label1.Size = new Size(153, 25);
        label1.TabIndex = 0;
        label1.Text = "Первое число";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 14F);
        label2.Location = new Point(42, 84);
        label2.Name = "label2";
        label2.Size = new Size(143, 25);
        label2.TabIndex = 1;
        label2.Text = "Второе число";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 14F);
        label3.Location = new Point(42, 130);
        label3.Name = "label3";
        label3.Size = new Size(143, 25);
        label3.TabIndex = 2;
        label3.Text = "Третье число";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 14F);
        textBox1.Location = new Point(211, 35);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 32);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Font = new Font("Segoe UI", 14F);
        textBox2.Location = new Point(211, 81);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(100, 32);
        textBox2.TabIndex = 4;
        // 
        // textBox3
        // 
        textBox3.Font = new Font("Segoe UI", 14F);
        textBox3.Location = new Point(211, 127);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(100, 32);
        textBox3.TabIndex = 5;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F);
        button1.Location = new Point(86, 192);
        button1.Name = "button1";
        button1.Size = new Size(218, 40);
        button1.TabIndex = 6;
        button1.Text = "Найти среднее";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(391, 271);
        Controls.Add(button1);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Среднее арифметическое";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private Button button1;
}
