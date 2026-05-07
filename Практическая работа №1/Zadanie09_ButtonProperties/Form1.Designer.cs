namespace ButtonPropertiesTask;

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
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label1.Location = new Point(112, 69);
        label1.Name = "label1";
        label1.Size = new Size(238, 25);
        label1.TabIndex = 0;
        label1.Text = "Место для вывода текста";
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F);
        button1.Location = new Point(79, 124);
        button1.Name = "button1";
        button1.Size = new Size(312, 35);
        button1.TabIndex = 1;
        button1.Text = "Вывести текст на метку";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI", 14F);
        button2.Location = new Point(79, 167);
        button2.Name = "button2";
        button2.Size = new Size(312, 35);
        button2.TabIndex = 2;
        button2.Text = "Стереть текст с метки";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Font = new Font("Segoe UI", 14F);
        button3.Location = new Point(79, 210);
        button3.Name = "button3";
        button3.Size = new Size(312, 35);
        button3.TabIndex = 3;
        button3.Text = "Сделать кнопку недоступной";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Font = new Font("Segoe UI", 14F);
        button4.Location = new Point(79, 253);
        button4.Name = "button4";
        button4.Size = new Size(312, 35);
        button4.TabIndex = 4;
        button4.Text = "Сделать кнопку доступной";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Font = new Font("Segoe UI", 14F);
        button5.Location = new Point(79, 296);
        button5.Name = "button5";
        button5.Size = new Size(312, 35);
        button5.TabIndex = 5;
        button5.Text = "Сделать кнопку невидимой";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Font = new Font("Segoe UI", 14F);
        button6.Location = new Point(79, 339);
        button6.Name = "button6";
        button6.Size = new Size(312, 35);
        button6.TabIndex = 6;
        button6.Text = "Сделать кнопку видимой";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(455, 468);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Управление свойствами кнопок";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
}
