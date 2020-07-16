namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<ILRef<TBoxed>,TStack> Unbox<TBoxed,TStack>( this IL<ILBoxed<TBoxed>, TStack> stack )
			where TStack : IEmittable
			where TBoxed : struct
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
		public static IL<ILRef<TBoxed>,TStack> UnboxToRef<TBoxed,TStack>( this IL<ILBoxed<TBoxed>, TStack> stack )
			where TStack : IEmittable
			where TBoxed : struct
		{
			return default;
		}
	}
}