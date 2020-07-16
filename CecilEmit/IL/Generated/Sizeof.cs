namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<UInt32,TStack> Sizeof<TType,TStack>( this TStack stack, ITypeRef<TType> type )
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
		public static IL<UInt32,TStack> SizeOf<TType,TStack>( this TStack stack, ITypeRef<TType> type )
			where TStack : IEmittable
		{
			return default;
		}
	}
}