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
        cmbMonedas.Items.Add("Seleccione la moneda a convertir");
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
        btnCalcular.Click+= new EventHandler(btnCalcularClick);

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

    }    private void cmb_ValueChanged(object sender, EventArgs e){
        if(cmbMonedas.SelectedIndex!=null){
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
        }
    }
    private void btnCalcularClick(object sender, EventArgs e){
        //Form2 nuevoFormulario = new Form2();

        if(cmbMonedas.SelectedItem.ToString()=="USD - Dolar estadounidense"){
            string calculo= cmbMonedas.SelectedItem.ToString();
            int mMXN;
            int mCAD;
            int mEUR;
            int mJPY;
            if(txtMonto.Text!=""){
                mMXN = Convert.ToInt32(txtMonto.Text);
                txtMXN.Text="$" + (mMXN*21.23).ToString();
                mCAD = Convert.ToInt32(txtMonto.Text);
                txCAD.Text="$" + (mCAD*1.28).ToString();
                mEUR = Convert.ToInt32(txtMonto.Text);
                txtEUR.Text= "€" + (mEUR*0.89).ToString();
                mJPY = Convert.ToInt32(txtMonto.Text);
                txtJPY.Text="¥" + (mJPY*113.05).ToString();
            }
        }
        if(cmbMonedas.SelectedItem.ToString()=="MXN - Peso mexicano"){
            string calculo= cmbMonedas.SelectedItem.ToString();
            int mUSD;
            int mCAD;
            int mEUR;
            int mJPY;
            if(txtMonto.Text!=""){
                mUSD = Convert.ToInt32(txtMonto.Text);
                txtUSD.Text="$" + (mUSD*0.05).ToString();
                mCAD = Convert.ToInt32(txtMonto.Text);
                txCAD.Text="$" + (mCAD*0.06).ToString();
                mEUR = Convert.ToInt32(txtMonto.Text);
                txtEUR.Text="€" + (mEUR*0.04).ToString();
                mJPY = Convert.ToInt32(txtMonto.Text);
                txtJPY.Text="¥" + (mJPY*5.32).ToString();
            }
        }
        if(cmbMonedas.SelectedItem.ToString()=="CAD - Dolar canadiense"){
            string calculo= cmbMonedas.SelectedItem.ToString();
            int mUSD;
            int mMXN;
            int mEUR;
            int mJPY;
            if(txtMonto.Text!=""){
                mUSD = Convert.ToInt32(txtMonto.Text);
                txtUSD.Text="$" + (mUSD*0.78).ToString();
                mMXN = Convert.ToInt32(txtMonto.Text);
                txtMXN.Text="$" + (mMXN*16.55).ToString();
                mEUR = Convert.ToInt32(txtMonto.Text);
                txtEUR.Text="€" + (mEUR*0.69).ToString();
                mJPY = Convert.ToInt32(txtMonto.Text);
                txtJPY.Text="¥" + (mJPY*88.12).ToString();
            }
        }
        if(cmbMonedas.SelectedItem.ToString()=="EUR - Euro"){
            string calculo= cmbMonedas.SelectedItem.ToString();
            int mUSD;
            int mMXN;
            int mCAD;
            int mJPY;
            if(txtMonto.Text!=""){
                mUSD = Convert.ToInt32(txtMonto.Text);
                txtUSD.Text="$" + (mUSD*1.13).ToString();
                mMXN = Convert.ToInt32(txtMonto.Text);
                txtMXN.Text="$" + (mMXN*23.96).ToString();
                mCAD = Convert.ToInt32(txtMonto.Text);
                txCAD.Text="$" + (mCAD*1.45).ToString();
                mJPY = Convert.ToInt32(txtMonto.Text);
                txtJPY.Text="¥" + (mJPY*127.56).ToString();
            }
        }
        if(cmbMonedas.SelectedItem.ToString()=="JPY - Yen japones"){
            string calculo= cmbMonedas.SelectedItem.ToString();
            int mUSD;
            int mMXN;
            int mCAD;
            int mEUR;
            if(txtMonto.Text!=""){
                mUSD = Convert.ToInt32(txtMonto.Text);
                txtUSD.Text="$" + (mUSD*0.0088).ToString();
                mMXN = Convert.ToInt32(txtMonto.Text);
                txtMXN.Text="$" + (mMXN*0.1878).ToString();
                mCAD = Convert.ToInt32(txtMonto.Text);
                txCAD.Text="$" + (mCAD*0.0113).ToString();
                mEUR = Convert.ToInt32(txtMonto.Text);
                txtEUR.Text="€" + (mEUR*0.0078).ToString();
            }
        }
    }
}
