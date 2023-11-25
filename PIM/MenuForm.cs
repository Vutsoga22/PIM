using FormFolhaDePag;
using FormFunc;

namespace PIM
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFolhaPag formFolhaPag = new FormFolhaPag();
            formFolhaPag.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFuncionarios formFuncionarios = new FormFuncionarios();
            formFuncionarios.Show();
        }
    }
}