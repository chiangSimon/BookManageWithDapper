using Dapper;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace BookManageWithDapper.Models
{
    public class BookDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<BookDbContext> _logger;
        private readonly string _connStr;
        
        public BookDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connStr = _configuration.GetConnectionString("connStr");
        }

        //public IEnumerable<BookDatum> GetData()
        //{
        //    using (var conn = new SqlConnection(_connStr))
        //    {
        //        var sql = "SELECT * FROM [BOOK_DATA]";
        //        var bookdata = conn.Query<BookDatum>(sql);
        //        foreach (var book in bookdata)
        //        {
        //            Console.WriteLine($"{book.BookId}, {book.BookName}, {book.BookClassId}");
        //        }
        //        return bookdata;
        //    };
        //}

        public IEnumerable<dynamic> GetData()
        {
            using (var conn = new SqlConnection(_connStr))
            {
                var sql = "SELECT * FROM [BOOK_DATA]";
                var bookdata = conn.Query(sql);
                foreach (var book in bookdata)
                {
                    Debug.WriteLine($"Book ID: {book.BOOK_ID}, Book Name: {book.BOOK_NAME}");
                }
                return bookdata;
            };
        }

    }
}
