namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<TField, TStack> Ldfld<TField,TOn,TStack>( this IL<TOn, TStack> stack, ILField<TOn,TField> field )
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
		public static IL<TField, TStack> LoadField<TField,TOn,TStack>( this IL<TOn, TStack> stack, ILField<TOn,TField> field )
			where TStack : IEmittable
		{
			return default;
		}
	}
}