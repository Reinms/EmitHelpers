namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<Int32, TStack> Ckfinite<TStack>( this IL<Single, TStack> stack )
			where TStack : IEmittable
		{
			return default;
		}
		public static IL<Int32, TStack> Ckfinite<TStack>( this IL<Double, TStack> stack )
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
		public static IL<Int32, TStack> CheckFinite<TStack>( this IL<Single, TStack> stack )
			where TStack : IEmittable
		{
			return default;
		}
		public static IL<Int32, TStack> CheckFinite<TStack>( this IL<Double, TStack> stack )
			where TStack : IEmittable
		{
			return default;
		}
	}
}