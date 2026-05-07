namespace Zadanie10_CentimetersToMeters;

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
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label1.Location = new Point(54, 52);
        label1.Name = "label1";
        label1.Size = new Size(180, 25);
        label1.TabIndex = 0;
        label1.Text = "Расстояние (см)";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 14F);
        textBox1.Location = new Point(255, 47);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 32);
        textBox1.TabIndex = 1;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button1.Location = new Point(126, 99);
        button1.Name = "button1";
        button1.Size = new Size(168, 36);
        button1.TabIndex = 2;
        button1.Text = "Перевести";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(470, 180);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Перевод расстояния из сантиметров в метры";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Button button1;
}
