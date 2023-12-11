using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void AddCBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void DeleteBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}

		public Blog GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetList()
		{
            return _blogDal.GetList();
        }

		public void UpdateBlog(Blog blog)
		{
            throw new NotImplementedException();
        }
	}
}
