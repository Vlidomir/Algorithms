namespace Zadanie02_TrafficLight;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private ComboBox comboBox1;
    private Label label1;

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
        label1 = new Label();
        SuspendLayout();
        comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Красный", "Желтый", "Зеленый" });
        comboBox1.Location = new Point(58, 34);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(154, 29);
        comboBox1.TabIndex = 0;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        label1.BackColor = Color.White;
        label1.BorderStyle = BorderStyle.FixedSingle;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label1.Location = new Point(86, 97);
        label1.Name = "label1";
        label1.Size = new Size(98, 36);
        label1.TabIndex = 1;
        label1.TextAlign = ContentAlignment.MiddleCenter;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(284, 181);
        Controls.Add(label1);
        Controls.Add(comboBox1);
        Name = "Form1";
        Text = "Светофор";
        ResumeLayout(false);
    }

    #endregion
}
