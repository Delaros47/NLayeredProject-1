using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace NorthwindUI
{
    public partial class Form1 : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public Form1()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EfCategoryDal());
            _productService = new ProductManager(new EfProductDal());
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
    }
}