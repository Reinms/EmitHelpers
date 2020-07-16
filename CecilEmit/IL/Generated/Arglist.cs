namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<ILPtr<ILArglist>, TStack> Arglist<TStack>( this TStack stack )
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
		public static IL<ILPtr<ILArglist>, TStack> ArgList<TStack>( this TStack stack )
			where TStack : IEmittable
		{
			return default;
		}
	}
}