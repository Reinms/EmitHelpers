namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<TDuped, IL<TDuped, TStack>> Dup<TDuped, TStack>( this IL<TDuped, TStack> stack )
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
		public static IL<TDuped, IL<TDuped, TStack>> Dupe<TDuped, TStack>( this IL<TDuped, TStack> stack )
			where TStack : IEmittable
		{
			return default;
		}
	}
}