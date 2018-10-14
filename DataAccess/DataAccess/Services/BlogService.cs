using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class BlogService : IBlogService
    {
        /*
        IUnitOfWork _unitOfWrok;
        public BlogService(IUnitOfWork unitOfWork)
        {
            _unitOfWrok = unitOfWork;
        }
        public async Task<IEnumerable<Blog>> GetAllBlogPageIndex(int pageIndex,int pageSize)
        {
            return await _unitOfWrok.BlogRepository.GetAllBlogByPageIndex(pageIndex, pageSize);
        }*/
    }
}
