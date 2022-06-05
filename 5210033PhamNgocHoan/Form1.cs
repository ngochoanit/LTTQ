namespace _5210033PhamNgocHoan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buyBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuyBook buyBook = new frmBuyBook();
            buyBook.ShowDialog();   
        }

        private void arrayMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArrayMax arrayMax = new frmArrayMax();
            arrayMax.ShowDialog();  
        }
    }
}