using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Entities.Logger
{
    public class LoggerMessageDisplay
    {
        //Book Messages
        public const string BookCreated = "New book is created in DB !";
        public const string BookCreatedError = "Error when book is created !";
        public const string BookEdited = "New book is edited in DB !";
        public const string BookEditedError = "Error when book is edited !";
        public const string BookDeleted = "New book is deleted in DB !";
        public const string BookDeletedError = "Error when book is edited !";

        //Category Messages
        public const string CategoryCreated = "New category is created in DB !";
        public const string CategoryCreatedError = "Error when category is created !";
        public const string CategoryEdited = "New category is edited in DB !";
        public const string CategoryEditedError = "Error when category is edited !";
        public const string CategoryDeleted = "New category is deleted in DB !";
        public const string CategoryDeletedError = "Error when category is deleted !";


        //Author Messages
        public const string AuthorCreated = "New author is created in DB !";
        public const string AuthorCreatedError = "Error when author is created !";
        public const string AuthorEdited = "New author is edited in DB !";
        public const string AuthorEditedError = "Error when author is edited !";
        public const string AuthorDeleted = "New author is deleted in DB !";
        public const string AuthorDeletedError = "Error when author is deleted !";

        //Publisher Messages
        public const string PublisherCreated = "New publisher is created in DB !";
        public const string PublisherCreatedError = "Error when publisher is created !";
        public const string PublisherEdited = "New publisher is edited in DB !";
        public const string PublisherEditedError = "Error when publisher is edited !";
        public const string PublisherDeleted = "New publisher is deleted in DB !";
        public const string PublisherDeletedError = "Error when publisher is deleted !";

        //Upload Photo Messages
        public const string PhotoUploaded = "New photo uploaded !";
        public const string PhotoUploadedError = "Error when uploading photo !";
    }
}
