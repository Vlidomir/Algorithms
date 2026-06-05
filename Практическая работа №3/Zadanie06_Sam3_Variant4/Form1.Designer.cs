namespace Zadanie06_Sam3_Variant4;

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
        label4 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        textBox4 = new TextBox();
        button1 = new Button();
        label5 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(31, 32);
        label1.Name = "label1";
        label1.Size = new Size(171, 21);
        label1.TabIndex = 0;
        label1.Text = "Первый конверт: a, b";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(31, 72);
        label2.Name = "label2";
        label2.Size = new Size(177, 21);
        label2.TabIndex = 1;
        label2.Text = "Второй конверт: c, d";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F);
        label3.Location = new Point(226, 32);
        label3.Name = "label3";
        label3.Size = new Size(17, 21);
        label3.TabIndex = 2;
        label3.Text = "a";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(341, 32);
        label4.Name = "label4";
        label4.Size = new Size(17, 21);
        label4.TabIndex = 3;
        label4.Text = "b";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 12F);
        textBox1.Location = new Point(249, 29);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(68, 29);
        textBox1.TabIndex = 4;
        // 
        // textBox2
        // 
        textBox2.Font = new Font("Segoe UI", 12F);
        textBox2.Location = new Point(364, 29);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(68, 29);
        textBox2.TabIndex = 5;
        // 
        // textBox3
        // 
        textBox3.Font = new Font("Segoe UI", 12F);
        textBox3.Location = new Point(249, 69);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(68, 29);
        textBox3.TabIndex = 6;
        // 
        // textBox4
        // 
        textBox4.Font = new Font("Segoe UI", 12F);
        textBox4.Location = new Point(364, 69);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(68, 29);
        textBox4.TabIndex = 7;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 12F);
        button1.Location = new Point(128, 128);
        button1.Name = "button1";
        button1.Size = new Size(201, 35);
        button1.TabIndex = 8;
        button1.Text = "Проверить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        label5.Location = new Point(31, 193);
        label5.MaximumSize = new Size(410, 0);
        label5.Name = "label5";
        label5.Size = new Size(0, 21);
        label5.TabIndex = 9;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(476, 277);
        Controls.Add(label5);
        Controls.Add(button1);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Самостоятельная 3";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private Button button1;
    private Label label5;
}
