namespace ApartmanOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gelirler_Click(object sender, EventArgs e)
        {
            new Gelirler().Show();
        }

        private void giderler_Click(object sender, EventArgs e)
        {
            new Giderler().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
