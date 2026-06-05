namespace Zadanie01_SeasonsComboBox;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private ComboBox comboBox1;
    private PictureBox pictureBox1;

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
        comboBox1 = new ComboBox();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Зима", "Весна", "Лето", "Осень" });
        comboBox1.Location = new Point(86, 32);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(385, 33);
        comboBox1.TabIndex = 0;
        comboBox1.Text = "Выберите время года";
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        pictureBox1.Location = new Point(86, 82);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(385, 283);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(560, 420);
        Controls.Add(pictureBox1);
        Controls.Add(comboBox1);
        Name = "Form1";
        Text = "Работа с ComboBox";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion
}
