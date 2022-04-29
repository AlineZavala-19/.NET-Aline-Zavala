namespace Examen2;

public partial class Form2 : Form
{
    private CheckBox? checkBox1;
    private CheckBox? checkBox2;
    private CheckBox? checkBox3;
    private CheckBox? checkBox4;
    private CheckBox? checkBox5;
    public Form2()
    {
        InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
        {
            Text = "";
            if (checkBox1.Checked == true)
            {
                Text = Text + "(USD - Dolar estadounidense)";
            }
            if (checkBox2.Checked == true)
            {
                Text = Text + "(MXN - Peso mexicano)";
            }
            if (checkBox3.Checked == true)
            {
                Text = Text + "(CAD - Dolar canadiense)";
            }
            if (checkBox4.Checked == true)
            {
                Text = Text + "(EUR - Euro)";
            }
            if (checkBox5.Checked == true)
            {
                Text = Text + "(JPY - Yen japones)";
            }
        }
}
