using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManageWithDapper.Models;

public partial class BookDatum
{
    [Column("BOOK_ID")]
    public int BookId { get; set; }

    [Column("BOOK_NAME")]
    public string BookName { get; set; } = null!;

    public string BookClassId { get; set; } = null!;

    public string? BookAuthor { get; set; }

    public DateTime? BookBoughtDate { get; set; }

    public string? BookPublisher { get; set; }

    public string? BookNote { get; set; }

    public string BookStatus { get; set; } = null!;

    public string? BookKeeper { get; set; }

    public int? BookAmount { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyUser { get; set; }
}
