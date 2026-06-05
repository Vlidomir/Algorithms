namespace Zadanie03_IntegerIf;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int x = int.Parse(textBox1.Text);
        textBox2.Text = (x >= 0) ? (x + 10).ToString() : (x - 5).ToString();
    }
}
