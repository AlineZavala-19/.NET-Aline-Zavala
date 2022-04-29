namespace Examen2;

public partial class Form1 : Form
{
    private Label? lblMoneda;
    private ComboBox? cmbMonedas;
    private Label? lblMonto;
    private TextBox? txtMonto;
    private Button? btnCalcular;
    private Label? lblConversiones;
    private Label? lblUSD;
    private TextBox? txtUSD;
    private Label? lblMXN;
    private TextBox? txtMXN;
    private Label? lblCAD;
    private TextBox? txCAD;
    private Label? lblEUR;
    private TextBox? txtEUR;
    private Label? lblJPY;
    private TextBox? txtJPY;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }
    private void InicializarComponentes()
    {
        // Tamaño de la ventana
        this.Size = new Size(400,550);

        //Etiqueta Moneda
        lblMoneda= new Label();
        lblMoneda.Text="Moneda";
        lblMoneda.AutoSize=true;
        lblMoneda.Location= new Point(10,10);

        //ComboBox Monedas
        cmbMonedas = new ComboBox();
        cmbMonedas.Items.Add("USD - Dolar estadounidense");
        cmbMonedas.Items.Add("MXN - Peso mexicano");
        cmbMonedas.Items.Add("CAD - Dolar canadiense");
        cmbMonedas.Items.Add("EUR - Euro");
        cmbMonedas.Items.Add("JPY - Yen japones");
        cmbMonedas.SelectedIndex=0;
        cmbMonedas.Location= new Point(10,40);
        cmbMonedas.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Monto
        lblMonto= new Label();
        lblMonto.Text="Monto";
        lblMonto.AutoSize=true;
        lblMonto.Location= new Point(10,110);

        //TextBox Monto
        txtMonto=new TextBox();
        txtMonto.Size = new Size(100,20);
        txtMonto.Location= new Point(10,150);

        //Boton Calcular
        btnCalcular= new Button();
        btnCalcular.Text="Calcular";
        btnCalcular.AutoSize=true;
        btnCalcular.Location= new Point(200,150);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);

        //Etiqueta Conversiones
        lblConversiones= new Label();
        lblConversiones.Text="Conversiones";
        lblConversiones.AutoSize=true;
        lblConversiones.Location= new Point(10,200);

        // CONVERSIONES
        //Etiqueta Dolar Estadounidense
        lblUSD= new Label();
        lblUSD.Text="USD - Dolar estadounidense";
        lblUSD.AutoSize=true;
        lblUSD.Location= new Point(10,230);
        lblUSD.Visible=false;

        //TextBox Dolar Estadounidense
        txtUSD=new TextBox();
        txtUSD.Size = new Size(100,20);
        txtUSD.Location= new Point(250,230);
        txtUSD.Visible=false;

        //Etiqueta Peso Mexicano
        lblMXN= new Label();
        lblMXN.Text="MXN - Peso mexicano";
        lblMXN.AutoSize=true;
        lblMXN.Location= new Point(10,260);
        lblMXN.Visible=false;

        //TextBox Peso mexicano
        txtMXN=new TextBox();
        txtMXN.Size = new Size(100,20);
        txtMXN.Location= new Point(250,260);
        txtMXN.Visible=false;

        //Etiqueta Dolar canadiense
        lblCAD= new Label();
        lblCAD.Text="CAD - Dolar canadiense";
        lblCAD.AutoSize=true;
        lblCAD.Location= new Point(10,290);
        lblCAD.Visible=false;

        //TextBox Dolar canadiense
        txCAD=new TextBox();
        txCAD.Size = new Size(100,20);
        txCAD.Location= new Point(250,290);
        txCAD.Visible=false;

        //Etiqueta Euro
        lblEUR= new Label();
        lblEUR.Text="EUR - Euro";
        lblEUR.AutoSize=true;
        lblEUR.Location= new Point(10,320);
        lblEUR.Visible=false;

        //TextBox Euro
        txtEUR=new TextBox();
        txtEUR.Size = new Size(100,20);
        txtEUR.Location= new Point(250,320);
        txtEUR.Visible=false;

        //Etiqueta Yen Japones
        lblJPY= new Label();
        lblJPY.Text="JPY - Yen japones";
        lblJPY.AutoSize=true;
        lblJPY.Location= new Point(10,350);
        lblJPY.Visible=false;

        //TextBox Yen Japones
        txtJPY=new TextBox();
        txtJPY.Size = new Size(100,20);
        txtJPY.Location= new Point(250,350);
        txtJPY.Visible=false;

        //Agregar controles
        this.Controls.Add(lblMoneda);
        this.Controls.Add(cmbMonedas);
        this.Controls.Add(lblMonto);
        this.Controls.Add(txtMonto);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblConversiones);
        this.Controls.Add(lblUSD);
        this.Controls.Add(txtUSD);
        this.Controls.Add(lblMXN);
        this.Controls.Add(txtMXN);
        this.Controls.Add(lblCAD);
        this.Controls.Add(txCAD);
        this.Controls.Add(lblEUR);
        this.Controls.Add(txtEUR);
        this.Controls.Add(lblJPY);
        this.Controls.Add(txtJPY);

    }
    private void btnCalcular_Click(object sender, EventArgs e){
        Form2 nuevoFormulario = new Form2();
    }

    private void cmb_ValueChanged(object sender, EventArgs e){
        //if(cmbMonedas.SelectedIndex!=null){
            if(cmbMonedas.SelectedItem.ToString()=="USD - Dolar estadounidense"){
                lblMXN.Visible=true;
                txtMXN.Visible=true;
                lblCAD.Visible=true;
                txCAD.Visible=true;
                lblEUR.Visible=true;
                txtEUR.Visible=true;
                lblJPY.Visible=true;
                txtJPY.Visible=true;

            }
            if(cmbMonedas.SelectedItem.ToString()=="MXN - Peso mexicano"){
                lblUSD.Visible=true;
                txtUSD.Visible=true;
                lblCAD.Visible=true;
                txCAD.Visible=true;
                lblEUR.Visible=true;
                txtEUR.Visible=true;
                lblJPY.Visible=true;
                txtJPY.Visible=true;

            }
            if(cmbMonedas.SelectedItem.ToString()=="CAD - Dolar canadiense"){
                lblUSD.Visible=true;
                txtUSD.Visible=true;
                lblMXN.Visible=true;
                txtMXN.Visible=true;
                lblEUR.Visible=true;
                txtEUR.Visible=true;
                lblJPY.Visible=true;
                txtJPY.Visible=true;

            }
            if(cmbMonedas.SelectedItem.ToString()=="EUR - Euro"){
                lblUSD.Visible=true;
                txtUSD.Visible=true;
                lblMXN.Visible=true;
                txtMXN.Visible=true;
                lblCAD.Visible=true;
                txCAD.Visible=true;
                lblJPY.Visible=true;
                txtJPY.Visible=true;

            }
            if(cmbMonedas.SelectedItem.ToString()=="JPY - Yen japones"){
                lblUSD.Visible=true;
                txtUSD.Visible=true;
                lblMXN.Visible=true;
                txtMXN.Visible=true;
                lblCAD.Visible=true;
                txCAD.Visible=true;
                lblCAD.Visible=true;
                txCAD.Visible=true;

            }
        //}
    }
}
