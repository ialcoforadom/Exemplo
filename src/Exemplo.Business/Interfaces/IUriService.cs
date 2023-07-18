using Exemplo.Business.Models.Pagination;

namespace Exemplo.Business.Interfaces
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilterBase filter, string route);
    }
}
