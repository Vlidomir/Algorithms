namespace Zadanie05_Sam2_Variant4;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int n = int.Parse(textBox1.Text);
        int a = n / 100;
        int b = n / 10 % 10;
        int c = n % 10;

        if (a == c)
            label2.Text = "Число является палиндромом";
        else
            label2.Text = "Число не является палиндромом";
    }
}
