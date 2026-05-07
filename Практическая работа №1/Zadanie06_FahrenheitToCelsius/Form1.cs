namespace FahrenheitToCelsius;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        double fahr = Convert.ToDouble(textBox1.Text);
        double cels = 5.0 / 9 * (fahr - 32);
        label2.Text = "Температура по Цельсию равна " + cels.ToString("F1", System.Globalization.CultureInfo.InvariantCulture);
    }
}
