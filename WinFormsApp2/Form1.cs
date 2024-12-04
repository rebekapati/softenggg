using WinFormsApp2.BookModels;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        FunnyDatabaseContext context = new FunnyDatabaseContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loadadat();
        }

        private void Loadadat()
        {
            var x = from y in context.Books
                    select y;

            bookBindingSource.DataSource = x.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bookBindingSource.EndEdit();
                context.SaveChanges();
                Loadadat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookBindingSource.EndEdit();
            var valamiUj = (Book)bookBindingSource.Current;
            context.Books.Add(valamiUj);
            context.SaveChanges();
            Loadadat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bookBindingSource.EndEdit();
            var torlendo = (Book)bookBindingSource.Current;
            context.Books.Remove(torlendo);
            context.SaveChanges();
            Loadadat();
        }
    }
}
