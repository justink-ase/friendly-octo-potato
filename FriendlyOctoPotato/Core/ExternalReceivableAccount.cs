using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyOctoPotato.Core
{
	public class ExternalAccount : Account
	{
		public override UInt64 Id => (UInt64)WellKnownAccountId.External;
		/// <inheritdoc/>
		/// <remarks>
		/// <para>External accounts always have a balance equal to
		/// <see cref="Int64.MaxValue"/>. We don't know their balance, and if
		/// the user has funds from this account, it must mean they've got
		/// the money.</para>
		/// </remarks>
		public override Int64 Balance => Int64.MaxValue;
	}
}
