using Crito.Contexts;
using Crito.Models;

namespace Crito.Services
{
	public class SubscriberService
	{
		public readonly DataContext _context;

		public SubscriberService(DataContext context)
		{
			_context = context;
		}

		public async Task AddSubscriberAsync(ContactForm form)
		{
			_context.Subscribers.Add(new SubscriberEntity { Email = form.Email });
			await _context.SaveChangesAsync();
		}
	}
}
