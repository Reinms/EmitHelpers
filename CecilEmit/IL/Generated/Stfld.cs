namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static TStack Stfld<TField,TOn,TStack>( this IL<TField, IL<TOn, TStack>> stack, ILField<TOn,TField> field )
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
		public static TStack StoreField<TField,TOn,TStack>( this IL<TField, IL<TOn, TStack>> stack, ILField<TOn,TField> field )
			where TStack : IEmittable
		{
			return default;
		}
	}
}