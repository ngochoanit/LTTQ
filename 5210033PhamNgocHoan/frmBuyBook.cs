using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5210033PhamNgocHoan
{
    public partial class frmBuyBook : Form
    {
        List<Book> books;
        List<Book> bookeds = new List<Book>();
        public frmBuyBook()
        {
            InitializeComponent();
            books = new List<Book>()
            {
                new Book(){Id = 1, Name = "Sach 1", Price = 2000},
                new Book(){Id = 1, Name = "Sach 2", Price = 1000},
                new Book(){Id = 1, Name = "Sach 3", Price = 3000},
                new Book(){Id = 1, Name = "Sach 3", Price = 2000},
                new Book(){Id = 1, Name = "Sach 4", Price = 1000},
                new Book(){Id = 1, Name = "Sach 5", Price = 3000},
                new Book(){Id = 1, Name = "Sach 6", Price = 2000},
                new Book(){Id = 1, Name = "Sach 7", Price = 1000},
                new Book(){Id = 1, Name = "Sach 8", Price = 3000},
                new Book(){Id = 1, Name = "Sach 9", Price = 1000},
                new Book(){Id = 1, Name = "Sach 10", Price = 3000},

            };

            comboBox1.DataSource = books;
            comboBox1.DisplayMember = "Name";

            PriceBinding();
        }
        void PriceBinding()
        {
           textBox1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Price"));
        }

    }
}
