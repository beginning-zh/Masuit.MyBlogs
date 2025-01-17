﻿using Masuit.LuceneEFCore.SearchEngine.Interfaces;
using Masuit.MyBlogs.Core.Infrastructure.Repository.Interface;

namespace Masuit.MyBlogs.Core.Infrastructure.Services;

public sealed partial class LeaveMessageService : BaseService<LeaveMessage>, ILeaveMessageService
{
	public LeaveMessageService(IBaseRepository<LeaveMessage> repository, ISearchEngine<DataContext> searchEngine, ILuceneIndexSearcher searcher) : base(repository, searchEngine, searcher)
	{
	}
}