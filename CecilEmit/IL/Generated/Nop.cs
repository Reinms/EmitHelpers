namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static TStack Nop<TStack>( TStack stack )
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
		public static TStack NoOp<TStack>( TStack stack )
			where TStack : IEmittable
		{
			return default;
		}
	}
}