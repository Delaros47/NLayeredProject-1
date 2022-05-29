using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace NorthwindUI
{
    public partial class Form1 : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public Form1()
        {
            InitializeComponent();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProducts();
            GetAllCategories();
        }

        private void GetAllProducts()
        {
            dataGridViewNorthwind.DataSource = _productService.GetAll();
        }

        private void GetAllCategories()
        {
            cbxCategoryName.DataSource = _categoryService.GetAll();
            cbxCategoryName.DisplayMember = "CategoryName";
            cbxCategoryName.ValueMember = "CategoryId";

            cbxAddCategoryName.DataSource = _categoryService.GetAll();
            cbxAddCategoryName.DisplayMember = "CategoryName";
            cbxAddCategoryName.ValueMember = "CategoryId";

        }

        private void cbxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewNorthwind.DataSource = _productService.GetProductsByCategoryId(Convert.ToInt32(cbxCategoryName.SelectedValue));

            }
            catch
            {

            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewNorthwind.DataSource = _productService.GetProductsByName(txtProductName.Text);

            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                ProductName = txtAddProductName.Text,
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(txtUnitsInStocks.Text),
                CategoryId = Convert.ToInt32(cbxAddCategoryName.SelectedValue),
            });
            MessageBox.Show("Product has successfully added");
            GetAllProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                ProductId = Convert.ToInt32(dataGridViewNorthwind.CurrentRow.Cells[0].Value.ToString())
            });
            MessageBox.Show("Product has successfully deleted");
            GetAllProducts();
        }

        private void dataGridViewNorthwind_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAddProductName.Text = dataGridViewNorthwind.CurrentRow.Cells[2].Value.ToString();
            cbxAddCategoryName.SelectedValue = dataGridViewNorthwind.CurrentRow.Cells[1].Value;
            txtQuantityPerUnit.Text = dataGridViewNorthwind.CurrentRow.Cells[3].Value.ToString();
            txtUnitPrice.Text = dataGridViewNorthwind.CurrentRow.Cells[4].Value.ToString();
            txtUnitsInStocks.Text = dataGridViewNorthwind.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dataGridViewNorthwind.CurrentRow.Cells[0].Value.ToString()),
                ProductName = txtAddProductName.Text,
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(txtUnitsInStocks.Text),
                CategoryId = Convert.ToInt32(cbxAddCategoryName.SelectedValue),
            });
            MessageBox.Show("Product has successfully updated");
            GetAllProducts();
        }
    }
}