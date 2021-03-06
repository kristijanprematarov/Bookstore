using Bookstore.Data;
using Bookstore.Entities;
using Bookstore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly DataContext _dataContext;

        public PublisherRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public void AddPublisher(Publisher publisher)
        {
            _dataContext.Publishers.Add(publisher);
            _dataContext.SaveChanges();
        }

        public void DeletePublisher(int id)
        {
            Publisher publisher = GetPublisherById(id);
            _dataContext.Publishers.Remove(publisher);
            _dataContext.SaveChanges();
        }

        public void EditPublisher(Publisher publisher)
        {
            _dataContext.Publishers.Update(publisher);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            var allPublishers = _dataContext.Publishers.AsEnumerable();
            return allPublishers;
        }

        public Publisher GetPublisherById(int id)
        {
            var result = _dataContext.Publishers.FirstOrDefault(publisher => publisher.Id == id);
            return result;
        }
    }
}
