namespace FastDelegatesTests
{
	using System;
	using FastDelegates;
	using NUnit.Framework;

	[TestFixture]
	public abstract class FuncFixture<TReturn>
	{
		protected void TestFunc( FastFunc<TReturn>.Signature del)
		{
			FastFunc<TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del();
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call();
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TReturn>.Signature del, TArg1 arg1)
		{
			FastFunc<TArg1, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TReturn>.Signature del, TArg1 arg1, TArg2 arg2)
		{
			FastFunc<TArg1, TArg2, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3)
		{
			FastFunc<TArg1, TArg2, TArg3, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52, TArg53 arg53)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52, TArg53 arg53, TArg54 arg54)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52, TArg53 arg53, TArg54 arg54, TArg55 arg55)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52, TArg53 arg53, TArg54 arg54, TArg55 arg55, TArg56 arg56)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52, TArg53 arg53, TArg54 arg54, TArg55 arg55, TArg56 arg56, TArg57 arg57)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52, TArg53 arg53, TArg54 arg54, TArg55 arg55, TArg56 arg56, TArg57 arg57, TArg58 arg58)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52, TArg53 arg53, TArg54 arg54, TArg55 arg55, TArg56 arg56, TArg57 arg57, TArg58 arg58, TArg59 arg59)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52, TArg53 arg53, TArg54 arg54, TArg55 arg55, TArg56 arg56, TArg57 arg57, TArg58 arg58, TArg59 arg59, TArg60 arg60)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TArg61, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TArg61, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52, TArg53 arg53, TArg54 arg54, TArg55 arg55, TArg56 arg56, TArg57 arg57, TArg58 arg58, TArg59 arg59, TArg60 arg60, TArg61 arg61)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TArg61, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TArg61, TArg62, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TArg61, TArg62, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52, TArg53 arg53, TArg54 arg54, TArg55 arg55, TArg56 arg56, TArg57 arg57, TArg58 arg58, TArg59 arg59, TArg60 arg60, TArg61 arg61, TArg62 arg62)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TArg61, TArg62, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
	[TestFixture]
	public abstract class FuncFixture<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TArg61, TArg62, TArg63, TReturn>
	{
		protected void TestFunc( FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TArg61, TArg62, TArg63, TReturn>.Signature del, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32, TArg33 arg33, TArg34 arg34, TArg35 arg35, TArg36 arg36, TArg37 arg37, TArg38 arg38, TArg39 arg39, TArg40 arg40, TArg41 arg41, TArg42 arg42, TArg43 arg43, TArg44 arg44, TArg45 arg45, TArg46 arg46, TArg47 arg47, TArg48 arg48, TArg49 arg49, TArg50 arg50, TArg51 arg51, TArg52 arg52, TArg53 arg53, TArg54 arg54, TArg55 arg55, TArg56 arg56, TArg57 arg57, TArg58 arg58, TArg59 arg59, TArg60 arg60, TArg61 arg61, TArg62 arg62, TArg63 arg63)
		{
			FastFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32, TArg33, TArg34, TArg35, TArg36, TArg37, TArg38, TArg39, TArg40, TArg41, TArg42, TArg43, TArg44, TArg45, TArg46, TArg47, TArg48, TArg49, TArg50, TArg51, TArg52, TArg53, TArg54, TArg55, TArg56, TArg57, TArg58, TArg59, TArg60, TArg61, TArg62, TArg63, TReturn> func = del;
			Exception delThrow = null;
			TReturn delVal = default;
			try
			{
				delVal = del(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63);
			} catch( Exception e )
			{
				delThrow = e;
			}
			Exception funcThrow = null;
			TReturn funcVal = default;
			try
			{
				funcVal = func.Call(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63);
			} catch( Exception e )
			{
				funcThrow = e;
			}
			if( delThrow != null || funcThrow != null )
			{
				Assert.That( delThrow != null && funcThrow != null );
				Assert.That( delThrow.GetType() == funcThrow.GetType() );
				Assert.That( delThrow.Message == funcThrow.Message );
			} else
			{
				Assert.That( delVal, Is.EqualTo( funcVal ) );
			}
		}
	}
}