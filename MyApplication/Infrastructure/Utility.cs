﻿//namespace MyApplication.Infrastructure
namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static Models.User AuthenticatedUser { get; set; }
        public static Models.User AuthenticatedPassword { get; set; }
    }
}
