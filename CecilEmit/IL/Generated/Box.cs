namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<ILBoxed<TBoxed>, TStack> Box<TBoxed, TStack>( this IL<TBoxed, TStack> stack )
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
		public static IL<ILBoxed<TBoxed>, TStack> Box<TBoxed, TStack>( this IL<TBoxed, TStack> stack )
			where TStack : IEmittable
			where TBoxed : struct
		{
			return default;
		}
	}
}