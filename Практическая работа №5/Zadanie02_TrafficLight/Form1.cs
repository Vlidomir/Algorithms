namespace Zadanie02_TrafficLight;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public enum Cvetofor { Красный, Желтый, Зеленый }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cvetofor signal = (Cvetofor)comboBox1.SelectedIndex;
        switch (signal)
        {
            case Cvetofor.Красный:
                label1.Text = "Стойте!";
                label1.BackColor = Color.Red;
                break;
            case Cvetofor.Желтый:
                label1.Text = "Ждите!";
                label1.BackColor = Color.Yellow;
                break;
            case Cvetofor.Зеленый:
                label1.Text = "Идите!";
                label1.BackColor = Color.Green;
                break;
            default:
                MessageBox.Show("Светофор сломан");
                break;
        }
    }
}
