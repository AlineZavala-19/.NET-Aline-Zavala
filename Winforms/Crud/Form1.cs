namespace Crud;

public partial class Form1 : Form
{
    private CervezaContext bd;
    private DataGridView gdCervezas;
    private Button btnAgregar;
    private Button btnEditar;
    private Button btnEliminar;
    public Form1()
    {
        bd = new CervezaContext();
        gdCervezas = new DataGridView();
        btnAgregar = new Button();
        btnEditar = new Button();
        btnEliminar = new Button();
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        gdCervezas.DataSource = bd.Cervezas.ToList();
        this.Size = new Size(650,350);
        gdCervezas.Size = new Size(500,280);
        gdCervezas.Location = new Point(15,15);
        btnAgregar.AutoSize = true;
        btnEditar.AutoSize = true;
        btnEliminar.AutoSize = true;
        btnAgregar.Text = "Agregar";
        btnEditar.Text = "Editar";
        btnEliminar.Text = "Eliminar";
        btnAgregar.Location = new Point(530,15);
        btnEditar.Location = new Point(530,150);
        btnEliminar.Location = new Point(530,270);
        this.Controls.Add(gdCervezas);
        this.Controls.Add(btnAgregar);
        this.Controls.Add(btnEditar);
        this.Controls.Add(btnEliminar);
    }
}
