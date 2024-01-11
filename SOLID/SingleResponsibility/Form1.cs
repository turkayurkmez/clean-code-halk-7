namespace SingleResponsibility
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            double price = Convert.ToDouble(textBoxPrice.Text);

            ProductService productService = new ProductService();
            productService.CreateProduct(name, price);

            MailService mailService = new MailService();
            mailService.SendInfoMail("info@hedehodo.com");





        }




    }
}