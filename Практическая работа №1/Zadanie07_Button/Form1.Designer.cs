namespace ButtonTask;

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
        button1 = new Button();
        button2 = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button1.Location = new Point(35, 109);
        button1.Name = "button1";
        button1.Size = new Size(125, 36);
        button1.TabIndex = 0;
        button1.Text = "Кнопка 1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button2.Location = new Point(208, 109);
        button2.Name = "button2";
        button2.Size = new Size(116, 36);
        button2.TabIndex = 1;
        button2.Text = "Кнопка 2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
        label1.ForeColor = Color.Blue;
        label1.Location = new Point(132, 195);
        label1.Name = "label1";
        label1.Size = new Size(90, 25);
        label1.TabIndex = 2;
        label1.Text = "Привет!";
        label1.Visible = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(380, 294);
        Controls.Add(label1);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Кнопка";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private Label label1;
}
