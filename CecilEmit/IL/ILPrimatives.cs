namespace CecilEmit.IL
{
    public interface IEmpty : IEmittable { }
    public interface IEmittable { }


    public struct IL<TValue, TStack> : IEmittable
        where TStack : IEmittable
    {

    }

    public struct ILArg<TArg>
    {

    }

    public struct ILLocal<T>
    {

    }

    public struct ILField<TOn,TValue>
    {

    }

    public struct ILSField<TValue>
    {

    }

    public struct ILRef<T>
    {

    }

    public struct ILPointer<T>
    {

    }

    public struct ILBoxed<T>
        where T : struct
    {

    }

    public struct ILFunc<TReturn>
    {

    }

    public struct ILAction
    {

    }

    public struct ILReturn
    {

    }

    public struct ILReturn<T>
    {

    }



}
