namespace Zadanie01_SeasonsComboBox;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (comboBox1.SelectedIndex)
        {
            case 0:
                pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Зима.jpg"));
                break;
            case 1:
                pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Весна.jpg"));
                break;
            case 2:
                pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Лето.jpg"));
                break;
            case 3:
                pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Осень.jpg"));
                break;
        }
    }
}
