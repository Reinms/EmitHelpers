namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static ILReturn Ret( this IL<IEmpty, IEmpty> stack )
		{
			return default;
		}
		public static ILReturn<TReturn> Ret<TReturn>( this IL<TReturn, IEmpty> stack )
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
		public static ILReturn Return( this IL<IEmpty, IEmpty> stack )
		{
			return default;
		}
		public static ILReturn<TReturn> Return<TReturn>( this IL<TReturn, IEmpty> stack )
		{
			return default;
		}
	}
}