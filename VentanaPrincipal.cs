using System.Windows;
namespace DB_Cine
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void clasificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clasificacion clasificacion = new Clasificacion();
            clasificacion.ShowDialog();
        }

        private void géneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            genero.ShowDialog();
        }

        private void películaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.ShowDialog();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            sucursal.ShowDialog();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala();
            sala.ShowDialog();
        }

        private void tipoBoletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoBoleto tipoboleto = new TipoBoleto();
            tipoboleto.ShowDialog();
        }

        private void ciudadEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CiudadEstado ciudadestado = new CiudadEstado();
            ciudadestado.ShowDialog();
        }

        private void funciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcion funcion = new Funcion();
            funcion.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void ventaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.ShowDialog();
        }

        private void detalleVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}



