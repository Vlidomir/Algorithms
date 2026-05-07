namespace FahrenheitToCelsius;

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
        label2 = new Label();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F);
        label1.Location = new Point(24, 76);
        label1.Name = "label1";
        label1.Size = new Size(292, 25);
        label1.TabIndex = 0;
        label1.Text = "Введите градусы по Фаренгейту";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 14F);
        textBox1.Location = new Point(410, 73);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 32);
        textBox1.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 14F);
        label2.Location = new Point(35, 152);
        label2.Name = "label2";
        label2.Size = new Size(0, 25);
        label2.TabIndex = 2;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F);
        button1.Location = new Point(180, 241);
        button1.Name = "button1";
        button1.Size = new Size(184, 38);
        button1.TabIndex = 3;
        button1.Text = "Перевести";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(640, 368);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Перевод градусов";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private Button button1;
}
