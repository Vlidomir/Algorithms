namespace Zadanie11_AverageVariant4;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        double a = Convert.ToDouble(textBox1.Text);
        double b = Convert.ToDouble(textBox2.Text);
        double c = Convert.ToDouble(textBox3.Text);
        double sred = (a + b + c) / 3;

        MessageBox.Show("Среднее арифметическое равно " + sred.ToString("F1", System.Globalization.CultureInfo.InvariantCulture), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
}
