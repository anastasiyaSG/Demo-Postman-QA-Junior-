using LibraryManagerTests.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace LibraryManagerTests.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
   
}
