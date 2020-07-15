namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<TField, TStack> Ldsfld<TField,TStack>( this TStack stack, ILSField<TField> field )
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
		public static IL<TField, TStack> LoadStaticField<TField,TStack>( this TStack stack, ILSField<TField> field )
			where TStack : IEmittable
		{
			return default;
		}
	}
}