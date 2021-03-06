using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Repository.Interfaces
{
    public interface IPublisherRepository
    {
        void AddPublisher(Publisher publisher);

        void EditPublisher(Publisher publisher);

        void DeletePublisher(int id);

        Publisher GetPublisherById(int id);

        IEnumerable<Publisher> GetAllPublishers();
    }
}
