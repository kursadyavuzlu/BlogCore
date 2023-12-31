﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void AddCBlog(Blog blog);
		void DeleteBlog(Blog blog);
		void UpdateBlog(Blog blog);
		List<Blog> GetList();
		Blog GetByID(int id);
		List<Blog> GetBlogListWithCategory();
	}
}
