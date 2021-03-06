using Bookstore.Data;
using Bookstore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Repository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly DataContext _dataContext;

        public ShoppingCartRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
    }
}
