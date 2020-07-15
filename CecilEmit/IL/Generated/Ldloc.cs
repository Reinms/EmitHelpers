namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<TLocal, TStack> Ldloc<TLocal,TStack>( this TStack stack, ILLocal<TLocal> loc )
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
		public static IL<TLocal, TStack> LoadLocal<TLocal,TStack>( this TStack stack, ILLocal<TLocal> loc )
			where TStack : IEmittable
		{
			return default;
		}
	}
}