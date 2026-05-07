namespace Zadanie10_CentimetersToMeters;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int x = int.Parse(textBox1.Text);
        int ch = x / 100;
        int ost = x % 100;
        MessageBox.Show("Расстояние равно " + Convert.ToString(ch) + " метров " + Convert.ToString(ost) + " сантиметров", "Результат перевода", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
}
