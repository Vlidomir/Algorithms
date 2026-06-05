namespace Zadanie02_ImageLoader;

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
        pictureBox1 = new PictureBox();
        button1 = new Button();
        button2 = new Button();
        openFileDialog1 = new OpenFileDialog();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        pictureBox1.Location = new Point(32, 29);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(391, 271);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        pictureBox1.Visible = false;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F);
        button1.Location = new Point(35, 324);
        button1.Name = "button1";
        button1.Size = new Size(110, 35);
        button1.TabIndex = 1;
        button1.Text = "Открыть";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI", 14F);
        button2.Location = new Point(160, 324);
        button2.Name = "button2";
        button2.Size = new Size(122, 35);
        button2.TabIndex = 2;
        button2.Text = "Очистить";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(458, 388);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
        Name = "Form1";
        Text = "Загрузка изображений";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
    private Button button1;
    private Button button2;
    private OpenFileDialog openFileDialog1;
}
