namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<TBoxed,TStack> Unbox_Any<TBoxed,TStack>( this IL<ILBoxed<TBoxed>, TStack> stack )
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
		public static IL<TBoxed,TStack> UnboxToValue<TBoxed,TStack>( this IL<ILBoxed<TBoxed>, TStack> stack )
			where TStack : IEmittable
			where TBoxed : struct
		{
			return default;
		}
	}
}