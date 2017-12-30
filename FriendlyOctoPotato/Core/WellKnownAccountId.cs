using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyOctoPotato.Core
{
	/// <summary>
	/// A well known account ID identifies a generic account.
	/// </summary>
	public enum WellKnownAccountId : UInt64
	{
		/// <summary>
		/// No account. In many cases this shouldn't be used.
		/// </summary>
		NullId = 0,
		Reserved1 = 1,
		Reserved2 = 2,
		Reserved3 = 3,
		Reserved4 = 4,
		Reserved5 = 5,
		Reserved6 = 6,
		Reserved7 = 7,
		Reserved8 = 8,
		Reserved9 = 9,
		Reserved10 = 10,
		/// <summary>
		/// An account going to an external location.
		/// </summary>
		External = 11,
	}
}
