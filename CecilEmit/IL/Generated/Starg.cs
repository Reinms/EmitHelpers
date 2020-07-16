namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static TStack Starg<TArg,TStack>( this IL<TArg, TStack> stack, ILArg<TArg> arg )
			where TStack : IEmittable
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
		public static TStack StoreArg<TArg,TStack>( this IL<TArg, TStack> stack, ILArg<TArg> arg )
			where TStack : IEmittable
		{
			return default;
		}
	}
}