namespace Zadanie01_PiecewiseFunction;

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
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        label1.Location = new Point(54, 77);
        label1.Name = "label1";
        label1.Size = new Size(31, 32);
        label1.TabIndex = 0;
        label1.Text = "X";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 14F);
        textBox1.Location = new Point(91, 77);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(93, 32);
        textBox1.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        label2.Location = new Point(52, 155);
        label2.Name = "label2";
        label2.Size = new Size(48, 32);
        label2.TabIndex = 2;
        label2.Text = "Y=";
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button1.Location = new Point(55, 236);
        button1.Name = "button1";
        button1.Size = new Size(164, 39);
        button1.TabIndex = 3;
        button1.Text = "Вычислить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(290, 324);
        Controls.Add(button1);
        Controls.Add(label2);
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
    private Label label2;
    private Button button1;
}
