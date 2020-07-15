namespace FastDelegates
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    [AttributeUsage(AttributeTargets.Method)]
    internal class PatchCallToCalliAttribute : Attribute { }
}
