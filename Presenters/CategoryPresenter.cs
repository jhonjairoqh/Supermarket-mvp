using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CategoryPresenter
    {
        private ICategoryView view;
        private ICategoryRepository repository;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoryModel> categoryList;
        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.categoryBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectedCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;
        
            this.view.SetCategoryListBindingSource(categoryBindingSource);

            LoadAllCategoryList();

            this.view.Show();
        }

        private void LoadAllCategoryList()
        {
            categoryList = repository.GetAll();
            categoryBindingSource.DataSource = categoryList; 
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategory(object? sender, EventArgs e)
        {
            var category = new CategoryModel();

            if (int.TryParse(view.CategoryId, out int id))
            {
                category.Id = id;
            }

            category.Name = view.CategoryName;
            category.Description = view.CategoryDescription;

            try
            {
                if (category.Id > 0)  
                {
                    repository.Edit(category);
                    view.Message = "Category updated successfully.";
                }
                else  
                {
                    repository.Add(category);
                    view.Message = "Category added successfully.";
                }

                view.IsSuccessful = true;
                LoadAllCategoryList();
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
            view.CategoryId = "0";
            view.CategoryName = "";
            view.CategoryDescription = "";
        }

        private void DeleteSelectedCategory(object? sender, EventArgs e)
        {
            try
            {
                var category = (CategoryModel)categoryBindingSource.Current;
                repository.Delete(category.Id);

                view.IsSuccessful = true;
                view.Message = "Category deleted successfully.";
                LoadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete category.";
            }
        }

        private void LoadSelectedCategoryToEdit(object? sender, EventArgs e)
        {
            var category = (CategoryModel)categoryBindingSource.Current;

            view.CategoryId = category.Id.ToString();
            view.CategoryName = category.Name;
            view.CategoryDescription = category.Description;

            view.IsEdit = true;
        }

        private void AddNewCategory(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategory(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue)
            {
                categoryList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoryList = repository.GetAll();
            }

            categoryBindingSource.DataSource = categoryList;
        }
    }
}


