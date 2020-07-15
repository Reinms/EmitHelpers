namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static TStack Stloc<TLocal,TStack>( this IL<TLocal, TStack> stack, ILLocal<TLocal> loc )
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
		public static TStack StoreLocal<TLocal,TStack>( this IL<TLocal, TStack> stack, ILLocal<TLocal> loc )
			where TStack : IEmittable
		{
			return default;
		}
	}
}