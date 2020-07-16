using System;
using System.Reflection;

namespace CecilEmit.IL
{
    public interface IEmpty : IEmittable { }
    public interface IEmittable { }
    public interface ITokenProvider<TToken> { }
    public interface ITypeToken : ITokenProvider<RuntimeTypeHandle>
    {
        Type type { get; }
    }
    public interface IFieldToken : ITokenProvider<RuntimeFieldHandle>
    {
        FieldInfo field { get; }
    }
    public interface IMethodToken : ITokenProvider<RuntimeMethodHandle>
    {
        MethodInfo method { get; }
    }

    public interface IRefTypeToken : ITypeToken { }
    public interface IValTypeToken : ITypeToken { }
    public struct ILValTypeToken<TAlias> : IValTypeToken
    where TAlias : struct
    {
        private Type t;
        public Type type { get => this.t; }
    }

    public class ILRefTypeToken<TAlias> : IRefTypeToken
        where TAlias : class
    {
        private Type t;
        public Type type { get => this.t; }
    }


    public struct IL<TValue, TStack> : IEmittable
        where TStack : IEmittable
    {

    }
    public struct ILArg<TArg>
    {

    }

    public struct ILLocal<TLocal>
    {

    }

    public struct ILField<TOn, TValue> : IFieldToken
    {
        public FieldInfo field { get => throw new NotImplementedException(); }
    }

    public struct ILSField<TValue> : IFieldToken
    {
        public FieldInfo field { get => throw new NotImplementedException(); }
    }

    public class ILBoxed<TBoxed>
        where TBoxed : struct
    {

    }

    public struct ILReturn
    {

    }

    public struct ILReturn<TReturned>
    {

    }

    public struct ILArray<T>
    {

    }

    public struct ILArglist
    {

    }

    public struct ILPtr<T>
    {

    }

    public struct ILRef<T>
    {

    }

    public struct ILTypedRef<T>
    {

    }

    public struct ILVoid : IValTypeToken
    {
        public Type type { get => typeof(void); }
    }

    public class ILNull : IRefTypeToken
    {
        public Type type { get => null; }
    }


}
