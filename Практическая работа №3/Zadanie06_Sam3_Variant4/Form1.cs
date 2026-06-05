namespace Zadanie06_Sam3_Variant4;

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
        double d = Convert.ToDouble(textBox4.Text);

        bool firstIntoSecond = (a < c && b < d) || (a < d && b < c);
        bool secondIntoFirst = (c < a && d < b) || (c < b && d < a);

        if (firstIntoSecond)
            label5.Text = "Первый конверт можно вложить во второй";
        else if (secondIntoFirst)
            label5.Text = "Второй конверт можно вложить в первый";
        else
            label5.Text = "Конверты нельзя вложить друг в друга";
    }
}
