using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyOctoPotato.Core
{
	public class Account
	{
		/// <summary>
		/// The precision of <see cref="Balance"/> in terms of a fraction of
		/// the smallest currency amount. The smallest positive value of
		/// <see cref="Balance"/> is 1/<see cref="Precision"/> of the smallest
		/// currency form.
		/// </summary>
		/// <example>
		/// <para>If <see cref="Precision"/> is 100, then a <see cref="Balance"/>
		/// of 1 is equivalent in terms of USD to $0.0100.</para>
		/// </example>
		public const UInt16 Precision = 100; // $0.0100 for US locale
		/// <summary>
		/// The account's ID. This is used for <see cref="Transaction"/>s.
		/// </summary>
		/// <seealso cref="Transaction"/>
		public virtual UInt64 Id { get; }
		/// <summary>
		/// The balance of the account. This value is influenced by <see cref="Precision"/>.
		/// </summary>
		/// <remarks>
		/// <para>Because of this value being determined by the precision, a
		/// value of exactly $1.00 (assuming US locale) with a precision of
		/// 10 should have a value of 1000.</para>
		/// </remarks>
		public virtual Int64 Balance { get => throw new NotImplementedException(); }
	}
}
