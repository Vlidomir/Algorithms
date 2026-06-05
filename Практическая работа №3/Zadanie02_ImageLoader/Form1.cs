namespace Zadanie02_ImageLoader;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        pictureBox1.Visible = true;
        openFileDialog1.Filter = "Изображения (*.bmp;*.gif;*.jpg;*.jpeg;*.tif)|*.bmp;*.gif;*.jpg;*.jpeg;*.tif";
        if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        pictureBox1.Visible = false;
    }
}
