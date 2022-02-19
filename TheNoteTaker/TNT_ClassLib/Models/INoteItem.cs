
using DataAccess_ClassLib.Interfaces;

namespace TNT_ClassLib.Models
{
    public interface INoteItem : IModel<int>
    {
        string Note { get; set; }
        DateTime TimePosted { get; set; }
    }
}