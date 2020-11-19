using System;
using System.ComponentModel.DataAnnotations;

namespace formdeneme.Models.DomainModels
{
    public class Form
    {


        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required, MaxLength(1000)]
        public string Description { get; set; }

        [Required, Range(0, 999.99)]

        public string SamplePage { get; set; }

        [EmailAddress]
        public string AuthorEmail { get; set; }

        [Phone]
        public string AuthorPhone { get; set; }
    }
}
