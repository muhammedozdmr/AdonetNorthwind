using TheNorthwind.Business;

//TODO: Kullanılmayan usingler Ctrl + R + G
namespace TheNorthwind.UI.Products
{
    public partial class UpdateUnitPricesBySupplierForm : Form
    {
        //Readonly sadece constructorda yazılır başka yerde değiştirilemesin fieldlar sadece işaretlenir
        private readonly SupplierService _supplierService = new SupplierService();
        private readonly ProductService _productService = new ProductService();
        public UpdateUnitPricesBySupplierForm()
        {
            InitializeComponent();
        }

        private void UpdateUnitPricesBySupplierForm_Load(object sender, EventArgs e)
        {
            cmbSupplier.DataSource = _supplierService.GetAll();
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "Id";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var supplierId = (int)cmbSupplier.SelectedValue;
            var changeRate = numPriceChangeRate.Value;
            var isDiscount = rbtDiscount.Checked;

            var productsTpBeUpdated = _productService.GetBySupplierId(supplierId);
            var confirmationBox = new UpdateUnitPricesConfirmationBox(productsTpBeUpdated);

            var dialogResult = confirmationBox.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                var commandResult = _productService.UpdatePricesBySupplier(supplierId, changeRate, isDiscount);
                MessageBox.Show(commandResult.Message);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edildi !");
            }
        }
    }
}
