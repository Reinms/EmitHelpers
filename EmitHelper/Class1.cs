using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using EmitHelper.IL.ShortExtensions;

namespace EmitHelper.IL
{
	public interface ITokenProvider
	{ }
	public partial interface ILabel
	{ }
	public partial interface IMethod : ITokenProvider
	{ }
	public partial interface IField : ITokenProvider
	{ }
	public partial interface IType : ITokenProvider
	{ }
	public partial interface ITypeRef<TAlias>
	{
		IType type { get; }
	}
	public partial interface ICallingConventions
	{ }
	public partial interface ILEmitReciever { }
	public partial interface ILStack
	{
		ILEmptyStack bottom { get; }
	}
	public partial interface ILEmptyStack : ILStack
    {
		ILEmitReciever reciever { get; }
	}
    public partial class EmptyStack : ILEmptyStack
    {
        public ILEmitReciever reciever { get => throw new NotImplementedException(); }
        public ILEmptyStack bottom { get => this; }
    }

	public struct ILField<TOn,TValue>
    {
		public readonly IField field;
    }

	public struct ILSField<TValue>
    {
		public readonly IField field;
    }

	public struct ILArray<TElem>
    {

    }

	public struct ILIndex
    {

    }
	public struct ILLength
    {

    }



    public readonly partial struct IL<TVal, TUnder> : ILStack
        where TUnder : ILStack
    {
		internal IL( TUnder under )
        {
			this.bottom = under.bottom;
			this.under = under;
        }
		public ILEmptyStack bottom { get; }
		internal TUnder under { get; }
    }

	internal static class Extensions
    {
        internal static TUnder Pop<TVal, TUnder>(this IL<TVal, TUnder> stack)
            where TUnder : ILStack => stack.under;
	}


	public class ILBoxed<TBoxed>
		where TBoxed : struct
    {

    }

	public struct ILRef<T>
    {

    }

	public interface ILPointer { }
	public struct ILPtr : ILPointer
    {

    }
	public struct ILTypedPtr<T> : ILPointer
    {

    }

	public struct ILTypedReference<T>
    {

    }
	public struct ILLocal<T>
    {
		public readonly Int16 index;
    }

	public class ILNull { }

	public readonly struct ILArgument<T>
    {
		public readonly Int16 index;
    }

	public static class ILConvert
    {
		public interface IConvert<TFrom, TTo>
        {
			void Emit(ILEmitReciever rec);
        }

    }

	public static class ILCompare
    {
		public interface ICompare<T1, T2, TRes> 
		{
			void Emit(ILEmitReciever rec);
		}
    }

	public static class ILBranch
    {
		public interface IBranch<T1,T2>
        {
			void Emit(ILEmitReciever rec);
        }
    }
}
