namespace Zadanie04_Sam1_Variant4;

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
        label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        label1.Location = new Point(45, 62);
        label1.Name = "label1";
        label1.Size = new Size(31, 30);
        label1.TabIndex = 0;
        label1.Text = "X";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 14F);
        textBox1.Location = new Point(82, 61);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(92, 32);
        textBox1.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        label2.Location = new Point(43, 145);
        label2.Name = "label2";
        label2.Size = new Size(62, 30);
        label2.TabIndex = 2;
        label2.Text = "F(x)=";
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button1.Location = new Point(44, 221);
        button1.Name = "button1";
        button1.Size = new Size(165, 40);
        button1.TabIndex = 3;
        button1.Text = "Вычислить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(276, 307);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Самостоятельная 1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private Button button1;
}
