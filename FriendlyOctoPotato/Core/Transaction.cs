using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyOctoPotato.Core
{
    public class Transaction
    {
		public UInt64 Id { get; }
		/// <summary>
		/// The origin of the transaction.
		/// </summary>
		public Account Source { get; }
		/// <summary>
		/// The destination for the transaction.
		/// </summary>
		public Account Destination { get; }

		public UInt64 DebitCurrency { get; }

		public UInt64 CreditCurrency { get; }
    }
}
