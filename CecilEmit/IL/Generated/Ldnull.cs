namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<ILNull, TStack> Ldnull<TStack>( this TStack stack )
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
		public static IL<ILNull, TStack> LoadNull<TStack>( this TStack stack )
			where TStack : IEmittable
		{
			return default;
		}
	}
}