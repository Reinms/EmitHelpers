namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static TStack Cpobj<TToken, TStack>( this IL<IntPtr, IL<IntPtr, TStack>> stack, TToken token)
			where TStack : IEmittable
			where TToken : ITypeToken
		{
			return default;
		}
	}
}
namespace CecilEmit.IL.LongNames
{
	using System;
	public static partial class ILLongExtensions
	{
		public static TStack CopyObject<TToken, TStack>( this IL<IntPtr, IL<IntPtr, TStack>> stack, TToken token)
			where TStack : IEmittable
			where TToken : ITypeToken
		{
			return default;
		}
	}
}