namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<TAlias, TStack> Isinst<TObject, TAlias, TStack>( this IL<TObject, TStack> stack, ILRefTypeToken<TAlias> type )
			where TStack : IEmittable
			where TAlias : class
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
		public static IL<TAlias, TStack> As<TObject, TAlias, TStack>( this IL<TObject, TStack> stack, ILRefTypeToken<TAlias> type )
			where TStack : IEmittable
			where TAlias : class
		{
			return default;
		}
	}
}