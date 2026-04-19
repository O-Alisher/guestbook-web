using Microsoft.AspNetCore.Mvc.RazorPages;
using GuestBook.Web.Services;
using GuestBook.Web.Models;

namespace GuestBook.Web.Pages;

public class AllEntriesModel : PageModel
{
    private readonly TableStorageService _table;

    public IEnumerable<GuestBookEntry> Entries { get; set; }
        = new List<GuestBookEntry>();

    public AllEntriesModel(TableStorageService table)
    {
        _table = table;
    }

    public void OnGet()
    {
        Entries = _table.GetAllEntries();
    }
}