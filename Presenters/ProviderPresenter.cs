using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class ProviderPresenter
    {
        private IProviderView view;
        private IProviderRepository repository;
        private BindingSource providerBindingSource;
        private IEnumerable<ProviderModel> providerList;

        public ProviderPresenter(IProviderView view, IProviderRepository repository)
        {
            this.providerBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProvider;
            this.view.AddNewEvent += AddNewProvider;
            this.view.EditEvent += LoadSelectedProviderToEdit;
            this.view.DeleteEvent += DeleteSelectedProvider;
            this.view.SaveEvent += SaveProvider;
            this.view.CancelEvent += CancelAction;

            this.view.SetProviderListBindingSource(providerBindingSource);

            LoadAllProviderList();

            this.view.Show();
        }

        private void LoadAllProviderList()
        {
            providerList = repository.GetAll();
            providerBindingSource.DataSource = providerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProvider(object? sender, EventArgs e)
        {
            var provider = new ProviderModel();

            if (int.TryParse(view.ProviderId, out int id))
            {
                provider.Id = id;
            }

            provider.Name = view.ProviderName;
            provider.Contact = view.ProviderContact;
            provider.Address = view.ProviderAddress;

            var validator = new Common.ModelDataValidation();

            try
            {
                validator.Validate(provider);

                if (provider.Id > 0)
                {
                    repository.Edit(provider);
                    view.Message = "Provider updated successfully.";
                }
                else
                {
                    repository.Add(provider);
                    view.Message = "Provider added successfully.";
                }

                view.IsSuccessful = true;
                LoadAllProviderList();
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
            view.ProviderId = "0";
            view.ProviderName = "";
            view.ProviderContact = "";
            view.ProviderAddress = "";
        }

        private void DeleteSelectedProvider(object? sender, EventArgs e)
        {
            try
            {
                var provider = (ProviderModel)providerBindingSource.Current;
                repository.Delete(provider.Id);

                view.IsSuccessful = true;
                view.Message = "Provider deleted successfully.";
                LoadAllProviderList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete provider.";
            }
        }

        private void LoadSelectedProviderToEdit(object? sender, EventArgs e)
        {
            var provider = (ProviderModel)providerBindingSource.Current;

            view.ProviderId = provider.Id.ToString();
            view.ProviderName = provider.Name;
            view.ProviderContact = provider.Contact;
            view.ProviderAddress = provider.Address;

            view.IsEdit = true;
        }

        private void AddNewProvider(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProvider(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue)
            {
                providerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providerList = repository.GetAll();
            }

            providerBindingSource.DataSource = providerList;
        }
    }
}
