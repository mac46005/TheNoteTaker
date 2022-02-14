
using DataAccess_ClassLib.Interfaces;

namespace TNT_ClassLib.Models
{
    public interface INoteItem<T> : IModel<T>
    {
        string Note { get; set; }
        DateTime TimePosted { get; set; }
    }
}