namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static TStack Cpblk<TStack>( this IL<UInt32, IL<IntPtr, IL<IntPtr, TStack>>> stack )
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
		public static TStack CopyBlock<TStack>( this IL<UInt32, IL<IntPtr, IL<IntPtr, TStack>>> stack )
			where TStack : IEmittable
		{
			return default;
		}
	}
}