namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<TArg, TStack> Ldarg<TArg,TStack>( this TStack stack, ILArg<TArg> arg )
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
		public static IL<TArg, TStack> LoadArg<TArg,TStack>( this TStack stack, ILArg<TArg> arg )
			where TStack : IEmittable
		{
			return default;
		}
	}
}