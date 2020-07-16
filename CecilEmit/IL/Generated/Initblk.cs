namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<IntPtr, TStack> Initblk<TStack>( this IL<UInt32,IL<IntPtr,IL<Byte, TStack>>> stack )
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
		public static IL<IntPtr, TStack> InitBlock<TStack>( this IL<UInt32,IL<IntPtr,IL<Byte, TStack>>> stack )
			where TStack : IEmittable
		{
			return default;
		}
	}
}