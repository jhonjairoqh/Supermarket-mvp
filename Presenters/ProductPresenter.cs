using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
     internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBindingSource(productBindingSource);

            LoadAllProductList();

            this.view.Show();
        }

        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var product = new ProductModel();

            if (int.TryParse(view.ProductId, out int id))
            {
                product.Id = id;
            }

            product.Name = view.ProductName;

            if (string.IsNullOrWhiteSpace(product.Name))
            {
                view.Message = "Please enter the product name.";
                view.IsSuccessful = false;
                return;
            }

            if (!decimal.TryParse(view.ProductPrice, out decimal price))
            {
                view.Message = "The price is not valid.";
                view.IsSuccessful = false;
                return;
            }
            product.Price = price;

            if (!int.TryParse(view.ProductStock, out int stock))
            {
                view.Message = "The stock is not valid.";
                view.IsSuccessful = false;
                return;
            }
            product.Stock = stock;

            if (!int.TryParse(view.ProductCategory, out int categoryId))
            {
                view.Message = "The category is not valid.";
                view.IsSuccessful = false;
                return;
            }
            product.CategoryId = categoryId;

            var validator = new Common.ModelDataValidation();

            try
            {
                validator.Validate(product);

                if (product.Id > 0)
                {
                    repository.Edit(product);
                    view.Message = "Product updated successfully.";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product added successfully.";
                }

                view.IsSuccessful = true;
                LoadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.Message = ex.Message;
                view.IsSuccessful = false;
            }
        }

        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductPrice = "0";
            view.ProductStock = "0";
            view.ProductCategory = "0";
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;
                repository.Delete(product.Id);

                view.IsSuccessful = true;
                view.Message = "Product deleted successfully.";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete product.";
            }
        }

        private void LoadSelectedProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductPrice = product.Price.ToString();
            view.ProductStock = product.Stock.ToString();
            view.ProductCategory = product.CategoryId.ToString();

            view.IsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }

            productBindingSource.DataSource = productList;
        }
    }
}
