﻿namespace CecilEmit.IL.ShortNames
{
	using System;
	public static partial class ILShortExtensions
	{
		public static IL<Int32,TStack> Rem<TStack>( this IL<Int32, IL<Int32, TStack>> stack )
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
		public static IL<Int32,TStack> Remainder<TStack>( this IL<Int32, IL<Int32, TStack>> stack )
			where TStack : IEmittable
		{
			return default;
		}
	}
}