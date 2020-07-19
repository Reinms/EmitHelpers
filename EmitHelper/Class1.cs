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
	public partial interface ITypeRef<TAlias> : IType
	{ }
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



}
