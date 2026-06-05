namespace Zadanie04_Sam1_Variant4;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        double x = Convert.ToDouble(textBox1.Text);
        double y;

        if (x <= 1)
            y = 0;
        else
            y = 1 / (x + 6);

        label2.Text = "F(x)=" + Convert.ToString(y);
    }
}
