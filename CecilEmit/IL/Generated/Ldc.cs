namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<Int32, TStack> Ldc<TStack>( this TStack stack, Int32 value )
			where TStack : IEmittable
		{
			return default;
		}
		public static IL<String, TStack> Ldc<TStack>( this TStack stack, String value )
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
		public static IL<Int32, TStack> LoadConst<TStack>( this TStack stack, Int32 value )
			where TStack : IEmittable
		{
			return default;
		}
		public static IL<String, TStack> LoadConst<TStack>( this TStack stack, String value )
			where TStack : IEmittable
		{
			return default;
		}
	}
}