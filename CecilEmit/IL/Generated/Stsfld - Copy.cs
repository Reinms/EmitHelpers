namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static TStack Stsfld<TField,TStack>( this IL<TField, TStack> stack, ILSField<TField> field )
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
		public static TStack StoreStaticField<TField,TStack>( this IL<TField, TStack> stack, ILSField<TField> field )
			where TStack : IEmittable
		{
			return default;
		}
	}
}