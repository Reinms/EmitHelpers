
namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static TStack Initobj<TToken, TStack>( this IL<IntPtr, TStack> stack, TToken type )
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
		public static TStack InitObject<TToken, TStack>( this IL<IntPtr, TStack> stack, TToken type )
			where TStack : IEmittable
			where TToken : ITypeToken
		{
			return default;
		}
	}
}