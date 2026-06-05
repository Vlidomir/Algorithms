namespace Zadanie03_IntegerIf;

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
        textBox1 = new TextBox();
        button1 = new Button();
        label2 = new Label();
        textBox2 = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        label1.Location = new Point(46, 68);
        label1.Name = "label1";
        label1.Size = new Size(208, 30);
        label1.TabIndex = 0;
        label1.Text = "Введите целое число";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 14F);
        textBox1.Location = new Point(272, 67);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(98, 32);
        textBox1.TabIndex = 1;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button1.Location = new Point(120, 126);
        button1.Name = "button1";
        button1.Size = new Size(166, 39);
        button1.TabIndex = 2;
        button1.Text = "Вычислить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        label2.Location = new Point(46, 205);
        label2.Name = "label2";
        label2.Size = new Size(130, 30);
        label2.TabIndex = 3;
        label2.Text = "Результат";
        // 
        // textBox2
        // 
        textBox2.Font = new Font("Segoe UI", 14F);
        textBox2.Location = new Point(180, 204);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(98, 32);
        textBox2.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(420, 290);
        Controls.Add(textBox2);
        Controls.Add(label2);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Вычисление выражения";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Button button1;
    private Label label2;
    private TextBox textBox2;
}
