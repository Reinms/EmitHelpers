#pragma warning disable IDE0022 // Use expression body for methods
namespace EmitHelper.IL
{
	using System;

	public partial interface ILabel 
	{ }
	public partial interface IMethod 
	{ }
	public partial interface IField 
	{ }
	public partial interface IType 
	{ }
	public partial interface ICallingConventions 
	{ }

	public partial interface ILEmitReciever
	{
		void Emit_add();
		void Emit_add_ovf();
		void Emit_add_ovf_un();
		void Emit_and();
		void Emit_arglist();
		void Emit_beq(ILabel target);
		void Emit_beq_s(ILabel target);
		void Emit_bge(ILabel target);
		void Emit_bge_s(ILabel target);
		void Emit_bge_un(ILabel target);
		void Emit_bge_un_s(ILabel target);
		void Emit_bgt(ILabel target);
		void Emit_bgt_s(ILabel target);
		void Emit_bgt_un(ILabel target);
		void Emit_bgt_un_s(ILabel target);
		void Emit_ble(ILabel target);
		void Emit_ble_s(ILabel target);
		void Emit_ble_un(ILabel target);
		void Emit_ble_un_s(ILabel target);
		void Emit_blt(ILabel target);
		void Emit_blt_s(ILabel target);
		void Emit_blt_un(ILabel target);
		void Emit_blt_un_s(ILabel target);
		void Emit_bne_un(ILabel target);
		void Emit_bne_un_s(ILabel target);
		void Emit_box(IType type);
		void Emit_br(ILabel target);
		void Emit_br_s(ILabel target);
		void Emit_break();
		void Emit_brfalse(ILabel target);
		void Emit_brfalse_s(ILabel target);
		void Emit_brtrue(ILabel target);
		void Emit_brtrue_s(ILabel target);
		void Emit_call(IMethod method);
		void Emit_calli(ICallingConventions conventions, IType returnType, IType[] requiredArguments, IType[] optionalArguments);
		void Emit_calli(ICallingConventions conventions, IType returnType, IType[] arguments);
		void Emit_callvirt(IMethod method);
		void Emit_castclass(IType type);
		void Emit_ceq();
		void Emit_cgt();
		void Emit_cgt_un();
		void Emit_ckfinite();
		void Emit_clt();
		void Emit_clt_un();
		void Emit_constrained_(IType type);
		void Emit_conv_i();
		void Emit_conv_i1();
		void Emit_conv_i2();
		void Emit_conv_i4();
		void Emit_conv_i8();
		void Emit_conv_ovf_i();
		void Emit_conv_ovf_i_un();
		void Emit_conv_ovf_i1();
		void Emit_conv_ovf_i1_un();
		void Emit_conv_ovf_i2();
		void Emit_conv_ovf_i2_un();
		void Emit_conv_ovf_i4();
		void Emit_conv_ovf_i4_un();
		void Emit_conv_ovf_i8();
		void Emit_conv_ovf_i8_un();
		void Emit_conv_ovf_u();
		void Emit_conv_ovf_u_un();
		void Emit_conv_ovf_u1();
		void Emit_conv_ovf_u1_un();
		void Emit_conv_ovf_u2();
		void Emit_conv_ovf_u2_un();
		void Emit_conv_ovf_u4();
		void Emit_conv_ovf_u4_un();
		void Emit_conv_ovf_u8();
		void Emit_conv_ovf_u8_un();
		void Emit_conv_r_un();
		void Emit_conv_r4();
		void Emit_conv_r8();
		void Emit_conv_u();
		void Emit_conv_u1();
		void Emit_conv_u2();
		void Emit_conv_u4();
		void Emit_conv_u8();
		void Emit_cpblk();
		void Emit_cpobj(IType type);
		void Emit_div();
		void Emit_div_un();
		void Emit_dup();
		void Emit_endfilter();
		void Emit_endfinally();
		void Emit_initblk();
		void Emit_initobj(IType type);
		void Emit_isinst(IType type);
		void Emit_jmp(IMethod method);
		void Emit_ldarg(Int16 value);
		void Emit_ldarg_0();
		void Emit_ldarg_1();
		void Emit_ldarg_2();
		void Emit_ldarg_3();
		void Emit_ldarg_s(Byte index);
		void Emit_ldarga(Int16 value);
		void Emit_ldarga_s(Byte index);
		void Emit_ldc_i4(Int32 value);
		void Emit_ldc_i4_0();
		void Emit_ldc_i4_1();
		void Emit_ldc_i4_2();
		void Emit_ldc_i4_3();
		void Emit_ldc_i4_4();
		void Emit_ldc_i4_5();
		void Emit_ldc_i4_6();
		void Emit_ldc_i4_7();
		void Emit_ldc_i4_8();
		void Emit_ldc_i4_m1();
		void Emit_ldc_i4_s(SByte value);
		void Emit_ldc_i4_s(Byte value);
		void Emit_ldc_i8(Int64 value);
		void Emit_ldc_r4(Single value);
		void Emit_ldc_r8(Double value);
		void Emit_ldelem(IType type);
		void Emit_ldelem_i();
		void Emit_ldelem_i1();
		void Emit_ldelem_i2();
		void Emit_ldelem_i4();
		void Emit_ldelem_i8();
		void Emit_ldelem_r4();
		void Emit_ldelem_r8();
		void Emit_ldelem_ref();
		void Emit_ldelem_u1();
		void Emit_ldelem_u2();
		void Emit_ldelem_u4();
		void Emit_ldelema(IType type);
		void Emit_ldfld(IField field);
		void Emit_ldflda(IField field);
		void Emit_ldftn(IMethod method);
		void Emit_ldind_i();
		void Emit_ldind_i1();
		void Emit_ldind_i2();
		void Emit_ldind_i4();
		void Emit_ldind_i8();
		void Emit_ldind_r4();
		void Emit_ldind_r8();
		void Emit_ldind_ref();
		void Emit_ldind_u1();
		void Emit_ldind_u2();
		void Emit_ldind_u4();
		void Emit_ldlen();
		void Emit_ldloc(Int16 value);
		void Emit_ldloc_0();
		void Emit_ldloc_1();
		void Emit_ldloc_2();
		void Emit_ldloc_3();
		void Emit_ldloc_s(Byte index);
		void Emit_ldloca(Int16 value);
		void Emit_ldloca_s(Byte index);
		void Emit_ldnull();
		void Emit_ldobj(IType type);
		void Emit_ldsfld(IField field);
		void Emit_ldsflda(IField field);
		void Emit_ldstr(String value);
		void Emit_ldtoken(IType typeToken);
		void Emit_ldtoken(IMethod methodToken);
		void Emit_ldtoken(IField fieldToken);
		void Emit_ldvirtftn(IMethod method);
		void Emit_leave(ILabel target);
		void Emit_leave_s(ILabel target);
		void Emit_localloc();
		void Emit_mkrefany(IType type);
		void Emit_mul();
		void Emit_mul_ovf();
		void Emit_mul_ovf_un();
		void Emit_neg();
		void Emit_newarr(IType type);
		void Emit_newobj(IMethod method);
		void Emit_nop();
		void Emit_not();
		void Emit_or();
		void Emit_pop();
		void Emit_prefix1();
		void Emit_prefix2();
		void Emit_prefix3();
		void Emit_prefix4();
		void Emit_prefix5();
		void Emit_prefix6();
		void Emit_prefix7();
		void Emit_prefixref();
		void Emit_readonly_();
		void Emit_refanytype();
		void Emit_refanyval(IType type);
		void Emit_rem();
		void Emit_rem_un();
		void Emit_ret();
		void Emit_rethrow();
		void Emit_shl();
		void Emit_shr();
		void Emit_shr_un();
		void Emit_sizeof(IType type);
		void Emit_starg(Int16 value);
		void Emit_starg_s(Byte index);
		void Emit_stelem(IType type);
		void Emit_stelem_i();
		void Emit_stelem_i1();
		void Emit_stelem_i2();
		void Emit_stelem_i4();
		void Emit_stelem_i8();
		void Emit_stelem_r4();
		void Emit_stelem_r8();
		void Emit_stelem_ref();
		void Emit_stfld(IField field);
		void Emit_stind_i();
		void Emit_stind_i1();
		void Emit_stind_i2();
		void Emit_stind_i4();
		void Emit_stind_i8();
		void Emit_stind_r4();
		void Emit_stind_r8();
		void Emit_stind_ref();
		void Emit_stloc(Int16 value);
		void Emit_stloc_0();
		void Emit_stloc_1();
		void Emit_stloc_2();
		void Emit_stloc_3();
		void Emit_stloc_s(Byte index);
		void Emit_stobj(IType type);
		void Emit_stsfld(IField field);
		void Emit_sub();
		void Emit_sub_ovf();
		void Emit_sub_ovf_un();
		void Emit_switch(ILabel[] targets);
		void Emit_tail_();
		void Emit_throw();
		void Emit_unaligned_(SByte value);
		void Emit_unaligned_(Byte value);
		void Emit_unbox(IType type);
		void Emit_unbox_any(IType type);
		void Emit_volatile_();
		void Emit_xor();
	}
}

namespace EmitHelper.IL.ShortExtensions
{
	using System;

	public static partial class ILExtensions
	{
		public static IL<Int32, TStack> Add<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_add();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		public static IL<Int32, TStack> And<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_and();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		public static IL<ILPtr, TStack> Arglist<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_arglist();
			return new IL<ILPtr, TStack>( stack );
		}


		//beq Cond_Branch
		//beq Pop1_pop1
		#warning Beq not implemented


		//bge Cond_Branch
		//bge Pop1_pop1
		#warning Bge not implemented


		//bgt Cond_Branch
		//bgt Pop1_pop1
		#warning Bgt not implemented


		//ble Cond_Branch
		//ble Pop1_pop1
		#warning Ble not implemented


		//blt Cond_Branch
		//blt Pop1_pop1
		#warning Blt not implemented


		//bne.un Cond_Branch
		//bne.un Pop1_pop1
		#warning Bne not implemented


		public static IL<ILBoxed<TBoxed>, TStack> Box<TBoxed, TStack>( this IL<TBoxed, TStack> stack)
			where TStack : ILStack
			where TBoxed : struct
		{
			//stack.bottom.reciever.Emit_box(typeof(TBoxed));// TODO: Aliasing stuff
			return new IL<ILBoxed<TBoxed>, TStack>( stack.Pop() );
		}

		public static IL<ILBoxed<TBoxedTo>, TStack> Box<TBoxedTo, TTypeRef, TBoxedFrom, TStack>( this IL<TBoxedFrom, TStack> stack, TTypeRef type)
			where TStack : ILStack
			where TBoxedTo : struct
			where TBoxedFrom : struct
			where TTypeRef : ITypeRef<TBoxedTo>
		{
			stack.bottom.reciever.Emit_box(type.type);
			return new IL<ILBoxed<TBoxedTo>, TStack>( stack.Pop() );
		}


		//br Branch
		#warning Br not implemented


		//break Break
		#warning Break not implemented


		//brfalse Cond_Branch
		#warning Brfalse not implemented


		//brtrue Cond_Branch
		#warning Brtrue not implemented


		//call Call
		//call Varpop
		//call Varpush
		#warning Call not implemented


		//calli Call
		//calli Varpop
		//calli Varpush
		#warning Calli not implemented


		//callvirt Call
		//callvirt Varpop
		//callvirt Varpush
		#warning Callvirt not implemented


		public static IL<TCastTo, TStack> Castclass<TCastTo, TCastFrom, TTypeRef, TStack>( this IL<TCastFrom, TStack> stack, TTypeRef type)
			where TStack : ILStack
			where TTypeRef : ITypeRef<TCastTo>
		{
			stack.bottom.reciever.Emit_castclass(type.type);
			return new IL<TCastTo, TStack>( stack.Pop() );
		}


		public static IL<TRes, TStack> Cmp<TCompare, T1, T2, TRes, TStack>( this IL<T2, IL<T1, TStack>> stack, TCompare comparison)
			where TStack : ILStack
			where TCompare : ILCompare.ICompare<T2,T1,TRes>
		{
			comparison.Emit( stack.bottom.reciever );
			return new IL<TRes, TStack>( stack.Pop().Pop() );
		}


		public static IL<Int32, TStack> Ckfinite<TStack>( this IL<Single, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ckfinite();
			return new IL<Int32, TStack>( stack.Pop() );
		}

		public static IL<Int32, TStack> Ckfinite<TStack>( this IL<Double, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ckfinite();
			return new IL<Int32, TStack>( stack.Pop() );
		}


		//constrained. Meta
		#warning Constrained not implemented


		//conv.i No aliased name
		public static IL<TTo, TStack> @conv_i<TConv, TFrom, TTo, TStack>( this IL<TFrom, TStack> stack, TConv conversion)
			where TStack : ILStack
			where TConv : ILConvert.IConvert<TFrom,TTo>
		{
			conversion.Emit( stack.bottom.reciever );
			return new IL<TTo, TStack>( stack.Pop() );
		}


		//cpblk No aliased name
		public static TStack @cpblk<TPtr1, TPtr2, TStack>( this IL<TPtr2, IL<UInt32, IL<TPtr1, TStack>>> stack)
			where TStack : ILStack
			where TPtr1 : ILPointer
			where TPtr2 : ILPointer
		{
			stack.bottom.reciever.Emit_cpblk();
			return stack.Pop().Pop().Pop();
		}


		//cpobj No aliased name
		public static TStack @cpobj<TValue, TStack>( this IL<ILTypedPtr<TValue>, IL<ILTypedPtr<TValue>, TStack>> stack)
			where TStack : ILStack
			where TValue : struct
		{
			//stack.bottom.reciever.Emit_cpobj(typeof(TValue));
			return stack.Pop().Pop();
		}


		public static IL<Int32, TStack> Div<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_div();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//dup No aliased name
		public static IL<TDuped, IL<TDuped, TStack>> @dup<TDuped, TStack>( this IL<TDuped, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_dup();
			return new IL<TDuped, IL<TDuped, TStack>>( stack );
		}


		//endfilter No aliased name
		//endfilter Return
		#warning @endfilter not implemented


		//endfinally No aliased name
		//endfinally Return
		#warning @endfinally not implemented


		//initblk No aliased name
		public static TStack @initblk<TPtr, TStack>( this IL<UInt32, IL<Byte, IL<TPtr, TStack>>> stack)
			where TStack : ILStack
			where TPtr : ILPointer
		{
			stack.bottom.reciever.Emit_initblk();
			return stack.Pop().Pop().Pop();
		}


		//initobj No aliased name
		public static TStack @initobj<TValue, TStack>( this IL<ILTypedPtr<TValue>, TStack> stack)
			where TStack : ILStack
			where TValue : struct
		{
			//stack.bottom.reciever.Emit_initobj();
			return stack.Pop();
		}


		//isinst No aliased name
		public static IL<TCastTo, TStack> @isinst<TCastTo, TCastFrom, TTypeRef, TStack>( this IL<TCastFrom, TStack> stack, TTypeRef type)
			where TStack : ILStack
			where TTypeRef : ITypeRef<TCastTo>
		{
			stack.bottom.reciever.Emit_isinst(type.type);
			return new IL<TCastTo, TStack>( stack.Pop() );
		}


		//jmp No aliased name
		//jmp Call
		#warning @jmp not implemented


		//ldarg No aliased name
		public static IL<TArg, TStack> @ldarg<TArg, TStack>( this TStack stack, ILArgument<TArg> argument)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldarg(argument.index);
			return new IL<TArg, TStack>( stack );
		}


		//ldarga No aliased name
		public static IL<ILRef<TArg>, TStack> @ldarga<TArg, TStack>( this TStack stack, ILArgument<TArg> argument)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldarga(argument.index);
			return new IL<ILRef<TArg>, TStack>( stack );
		}


		//ldc.i4 No aliased name
		public static IL<Int32, TStack> @ldc_i4<TStack>( this TStack stack, Int32 value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldc_i4(value);
			return new IL<Int32, TStack>( stack );
		}


		//ldelem No aliased name
		public static IL<TElem, TStack> @ldelem<TElem, TStack>( this IL<ILIndex ,IL<ILArray<TElem>, TStack>> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_ldsfld(field.field);
			return new IL<TElem, TStack>( stack.Pop().Pop() );
		}


		//ldelema No aliased name
		public static IL<ILRef<TElem>, TStack> @ldelema<TElem, TStack>( this IL<ILIndex, IL<ILArray<TElem>, TStack>> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_ldsflda(field.field);
			return new IL<ILRef<TElem>, TStack>( stack.Pop().Pop() );
		}


		//ldfld No aliased name
		public static IL<TValue, TStack> @ldfld<TOn, TValue, TStack>( this IL<TOn, TStack> stack, ILField<TOn,TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldsfld(field.field);
			return new IL<TValue, TStack>( stack.Pop() );
		}


		//ldflda No aliased name
		public static IL<ILRef<TValue>, TStack> @ldflda<TOn, TValue, TStack>( this IL<TOn, TStack> stack, ILField<TOn,TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldsflda(field.field);
			return new IL<ILRef<TValue>, TStack>( stack.Pop() );
		}


		//ldftn No aliased name
		#warning @ldftn not implemented


		//ldlen No aliased name
		public static IL<Int32, TStack> @ldlen<TElem, TStack>( this IL<ILArray<TElem>, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldlen();
			return new IL<Int32, TStack>( stack.Pop() );
		}


		//ldloc No aliased name
		public static IL<TLoc, TStack> @ldloc<TLoc, TStack>( this TStack stack, ILLocal<TLoc> local)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldloc(local.index);
			return new IL<TLoc, TStack>( stack );
		}


		//ldloca No aliased name
		public static IL<ILRef<TLoc>, TStack> @ldloca<TLoc, TStack>( this TStack stack, ILLocal<TLoc> local)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldloca(local.index);
			return new IL<ILRef<TLoc>, TStack>( stack );
		}


		//ldnull No aliased name
		public static IL<ILNull, TStack> @ldnull<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldnull();
			return new IL<ILNull, TStack>( stack );
		}


		//ldobj No aliased name
		public static IL<TValue, TStack> @ldobj<TValue, TStack>( this IL<ILRef<TValue>, TStack> stack)
			where TStack : ILStack
			where TValue : struct
		{
			//stack.bottom.reciever.Emit_ldsfld(field.field);
			return new IL<TValue, TStack>( stack.Pop() );
		}


		//ldsfld No aliased name
		public static IL<TValue, TStack> @ldsfld<TValue, TStack>( this TStack stack, ILSField<TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldsfld(field.field);
			return new IL<TValue, TStack>( stack );
		}


		//ldsflda No aliased name
		public static IL<ILRef<TValue>, TStack> @ldsflda<TValue, TStack>( this TStack stack, ILSField<TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldsflda(field.field);
			return new IL<ILRef<TValue>, TStack>( stack );
		}


		//ldtoken No aliased name
		public static IL<RuntimeFieldHandle, TStack> @ldtoken<TStack>( this TStack stack, IField field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldtoken(field);
			return new IL<RuntimeFieldHandle, TStack>( stack );
		}

		public static IL<RuntimeMethodHandle, TStack> @ldtoken<TStack>( this TStack stack, IMethod method)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldtoken(method);
			return new IL<RuntimeMethodHandle, TStack>( stack );
		}

		public static IL<RuntimeTypeHandle, TStack> @ldtoken<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldtoken(type);
			return new IL<RuntimeTypeHandle, TStack>( stack );
		}


		//ldvirtftn No aliased name
		//ldvirtftn Popref
		#warning @ldvirtftn not implemented


		//leave No aliased name
		//leave Branch
		#warning @leave not implemented


		//localloc No aliased name
		public static IL<ILPtr, TStack> @localloc<TStack>( this IL<Int32, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_localloc();
			return new IL<ILPtr, TStack>( stack.Pop() );
		}


		//mkrefany No aliased name
		public static IL<ILTypedReference<TValue>, TStack> @mkrefany<TValue, TStack>( this IL<ILRef<TValue>, TStack> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_mkrefany();
			return new IL<ILTypedReference<TValue>, TStack>( stack.Pop() );
		}


		//mul No aliased name
		public static IL<Int32, TStack> @mul<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_mul();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//neg No aliased name
		public static IL<Int32, TStack> @neg<TStack>( this IL<Int32, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_neg();
			return new IL<Int32, TStack>( stack.Pop() );
		}


		//newarr No aliased name
		public static IL<ILArray<TElem>, TStack> @newarr<TElem, TType, TStack>( this IL<ILLength, TStack> stack, TType elementType)
			where TStack : ILStack
			where TType : ITypeRef<TElem>
		{
			stack.bottom.reciever.Emit_newarr(elementType.type);
			return new IL<ILArray<TElem>, TStack>( stack.Pop() );
		}


		//newobj No aliased name
		//newobj Call
		//newobj Varpop
		//newobj Pushref
		#warning @newobj not implemented


		public static TStack Nop<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_nop();
			return stack;
		}


		//not No aliased name
		public static IL<Int32, TStack> @not<TStack>( this IL<Int32, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_not();
			return new IL<Int32, TStack>( stack.Pop() );
		}


		//or No aliased name
		public static IL<Int32, TStack> @or<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_or();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//pop No aliased name
		public static TStack @pop<TPopped, TStack>( this IL<TPopped, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_pop();
			return stack.Pop();
		}


		//readonly. No aliased name
		//readonly. Meta
		#warning @readonly_ not implemented


		//refanytype No aliased name
		public static IL<RuntimeTypeHandle, TStack> @refanytype<TValue, TStack>( this IL<ILTypedReference<TValue>, TStack> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_mkrefany();
			return new IL<RuntimeTypeHandle, TStack>( stack.Pop() );
		}


		//refanyval No aliased name
		public static IL<ILTypedPtr<TValue>, TStack> @refanyval<TValue, TStack>( this IL<ILTypedReference<TValue>, TStack> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_mkrefany();
			return new IL<ILTypedPtr<TValue>, TStack>( stack.Pop() );
		}


		//rem No aliased name
		public static IL<Int32, TStack> @rem<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_rem();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//ret No aliased name
		//ret Return
		//ret Varpop
		#warning @ret not implemented


		//rethrow No aliased name
		//rethrow Throw
		#warning @rethrow not implemented


		//shl No aliased name
		public static IL<Int32, TStack> @shl<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_shl();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//shr No aliased name
		public static IL<Int32, TStack> @shr<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_shr();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//sizeof No aliased name
		public static IL<UInt32, TStack> @sizeof<TType, TStack>( this TStack stack, TType type)
			where TStack : ILStack
			where TType : IType
		{
			stack.bottom.reciever.Emit_sizeof(type);
			return new IL<UInt32, TStack>( stack );
		}


		//starg No aliased name
		public static TStack @starg<TArg, TStack>( this IL<TArg, TStack> stack, ILArgument<TArg> argument)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_starg(argument.index);
			return stack.Pop();
		}


		//stelem No aliased name
		public static TStack @stelem<TElem, TStack>( this IL<TElem,IL<ILIndex, IL<ILArray<TElem>, TStack>>> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_stsfld(field.field);
			return stack.Pop().Pop().Pop();
		}


		//stfld No aliased name
		public static TStack @stfld<TOn, TValue, TStack>( this IL<TValue, IL<TOn, TStack>> stack, ILField<TOn,TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stsfld(field.field);
			return stack.Pop().Pop();
		}


		//stloc No aliased name
		public static TStack @stloc<TLoc, TStack>( this IL<TLoc, TStack> stack, ILLocal<TLoc> local)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stloc(local.index);
			return stack.Pop();
		}


		//stobj No aliased name
		public static TStack @stobj<TValue, TStack>( this IL<TValue, IL<ILRef<TValue>, TStack>> stack)
			where TStack : ILStack
			where TValue : struct
		{
			//stack.bottom.reciever.Emit_stsfld(field.field);
			return stack.Pop().Pop();
		}


		//stsfld No aliased name
		public static TStack @stsfld<TValue, TStack>( this IL<TValue, TStack> stack, ILSField<TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stsfld(field.field);
			return stack.Pop();
		}


		//sub No aliased name
		public static IL<Int32, TStack> @sub<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_sub();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//switch No aliased name
		//switch Cond_Branch
		#warning @switch not implemented


		//tail. No aliased name
		//tail. Meta
		#warning @tail_ not implemented


		//throw No aliased name
		//throw Throw
		//throw Popref
		#warning @throw not implemented


		//unaligned. No aliased name
		//unaligned. Meta
		#warning @unaligned_ not implemented


		//unbox No aliased name
		public static IL<ILRef<TBoxed>, TStack> @unbox<TBoxed, TStack>( this IL<ILBoxed<TBoxed>, TStack> stack)
			where TStack : ILStack
			where TBoxed : struct
		{
			//stack.bottom.reciever.Emit_box(typeof(TBoxed));// TODO: Aliasing stuff
			return new IL<ILRef<TBoxed>, TStack>( stack.Pop() );
		}


		//unbox.any No aliased name
		public static IL<TBoxed, TStack> @unbox_any<TBoxed, TStack>( this IL<ILBoxed<TBoxed>, TStack> stack)
			where TStack : ILStack
			where TBoxed : struct
		{
			//stack.bottom.reciever.Emit_box(typeof(TBoxed));// TODO: Aliasing stuff
			return new IL<TBoxed, TStack>( stack.Pop() );
		}


		//volatile. No aliased name
		//volatile. Meta
		#warning @volatile_ not implemented


		public static IL<Int32, TStack> Xor<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_xor();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


	}
}

namespace EmitHelper.IL.LongExtensions
{
	using System;

	public static partial class ILExtensions
	{
		public static IL<Int32, TStack> Add<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_add();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		public static IL<Int32, TStack> And<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_and();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		public static IL<ILPtr, TStack> ArgList<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_arglist();
			return new IL<ILPtr, TStack>( stack );
		}


		//beq Cond_Branch
		//beq Pop1_pop1
		#warning BranchEqual not implemented


		//bge Cond_Branch
		//bge Pop1_pop1
		#warning BranchGreaterOrEqual not implemented


		//bgt Cond_Branch
		//bgt Pop1_pop1
		#warning BranchGreater not implemented


		//ble Cond_Branch
		//ble Pop1_pop1
		#warning BranchLessOrEqual not implemented


		//blt Cond_Branch
		//blt Pop1_pop1
		#warning BranchLess not implemented


		//bne.un Cond_Branch
		//bne.un Pop1_pop1
		#warning BranchNotEqual not implemented


		public static IL<ILBoxed<TBoxed>, TStack> Box<TBoxed, TStack>( this IL<TBoxed, TStack> stack)
			where TStack : ILStack
			where TBoxed : struct
		{
			//stack.bottom.reciever.Emit_box(typeof(TBoxed));// TODO: Aliasing stuff
			return new IL<ILBoxed<TBoxed>, TStack>( stack.Pop() );
		}

		public static IL<ILBoxed<TBoxedTo>, TStack> Box<TBoxedTo, TTypeRef, TBoxedFrom, TStack>( this IL<TBoxedFrom, TStack> stack, TTypeRef type)
			where TStack : ILStack
			where TBoxedTo : struct
			where TBoxedFrom : struct
			where TTypeRef : ITypeRef<TBoxedTo>
		{
			stack.bottom.reciever.Emit_box(type.type);
			return new IL<ILBoxed<TBoxedTo>, TStack>( stack.Pop() );
		}


		//br Branch
		#warning Branch not implemented


		//break Break
		#warning Break not implemented


		//brfalse Cond_Branch
		#warning BranchFalse not implemented


		//brtrue Cond_Branch
		#warning BranchTrue not implemented


		//call Call
		//call Varpop
		//call Varpush
		#warning Call not implemented


		//calli Call
		//calli Varpop
		//calli Varpush
		#warning CallIndirect not implemented


		//callvirt Call
		//callvirt Varpop
		//callvirt Varpush
		#warning CallVirtual not implemented


		public static IL<TCastTo, TStack> CastClass<TCastTo, TCastFrom, TTypeRef, TStack>( this IL<TCastFrom, TStack> stack, TTypeRef type)
			where TStack : ILStack
			where TTypeRef : ITypeRef<TCastTo>
		{
			stack.bottom.reciever.Emit_castclass(type.type);
			return new IL<TCastTo, TStack>( stack.Pop() );
		}


		public static IL<TRes, TStack> Compare<TCompare, T1, T2, TRes, TStack>( this IL<T2, IL<T1, TStack>> stack, TCompare comparison)
			where TStack : ILStack
			where TCompare : ILCompare.ICompare<T2,T1,TRes>
		{
			comparison.Emit( stack.bottom.reciever );
			return new IL<TRes, TStack>( stack.Pop().Pop() );
		}


		public static IL<Int32, TStack> CheckFinite<TStack>( this IL<Single, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ckfinite();
			return new IL<Int32, TStack>( stack.Pop() );
		}

		public static IL<Int32, TStack> CheckFinite<TStack>( this IL<Double, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ckfinite();
			return new IL<Int32, TStack>( stack.Pop() );
		}


		//constrained. Meta
		#warning Constrained not implemented


		//conv.i No aliased name
		public static IL<TTo, TStack> @conv_i<TConv, TFrom, TTo, TStack>( this IL<TFrom, TStack> stack, TConv conversion)
			where TStack : ILStack
			where TConv : ILConvert.IConvert<TFrom,TTo>
		{
			conversion.Emit( stack.bottom.reciever );
			return new IL<TTo, TStack>( stack.Pop() );
		}


		//cpblk No aliased name
		public static TStack @cpblk<TPtr1, TPtr2, TStack>( this IL<TPtr2, IL<UInt32, IL<TPtr1, TStack>>> stack)
			where TStack : ILStack
			where TPtr1 : ILPointer
			where TPtr2 : ILPointer
		{
			stack.bottom.reciever.Emit_cpblk();
			return stack.Pop().Pop().Pop();
		}


		//cpobj No aliased name
		public static TStack @cpobj<TValue, TStack>( this IL<ILTypedPtr<TValue>, IL<ILTypedPtr<TValue>, TStack>> stack)
			where TStack : ILStack
			where TValue : struct
		{
			//stack.bottom.reciever.Emit_cpobj(typeof(TValue));
			return stack.Pop().Pop();
		}


		public static IL<Int32, TStack> Divide<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_div();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//dup No aliased name
		public static IL<TDuped, IL<TDuped, TStack>> @dup<TDuped, TStack>( this IL<TDuped, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_dup();
			return new IL<TDuped, IL<TDuped, TStack>>( stack );
		}


		//endfilter No aliased name
		//endfilter Return
		#warning @endfilter not implemented


		//endfinally No aliased name
		//endfinally Return
		#warning @endfinally not implemented


		//initblk No aliased name
		public static TStack @initblk<TPtr, TStack>( this IL<UInt32, IL<Byte, IL<TPtr, TStack>>> stack)
			where TStack : ILStack
			where TPtr : ILPointer
		{
			stack.bottom.reciever.Emit_initblk();
			return stack.Pop().Pop().Pop();
		}


		//initobj No aliased name
		public static TStack @initobj<TValue, TStack>( this IL<ILTypedPtr<TValue>, TStack> stack)
			where TStack : ILStack
			where TValue : struct
		{
			//stack.bottom.reciever.Emit_initobj();
			return stack.Pop();
		}


		//isinst No aliased name
		public static IL<TCastTo, TStack> @isinst<TCastTo, TCastFrom, TTypeRef, TStack>( this IL<TCastFrom, TStack> stack, TTypeRef type)
			where TStack : ILStack
			where TTypeRef : ITypeRef<TCastTo>
		{
			stack.bottom.reciever.Emit_isinst(type.type);
			return new IL<TCastTo, TStack>( stack.Pop() );
		}


		//jmp No aliased name
		//jmp Call
		#warning @jmp not implemented


		//ldarg No aliased name
		public static IL<TArg, TStack> @ldarg<TArg, TStack>( this TStack stack, ILArgument<TArg> argument)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldarg(argument.index);
			return new IL<TArg, TStack>( stack );
		}


		//ldarga No aliased name
		public static IL<ILRef<TArg>, TStack> @ldarga<TArg, TStack>( this TStack stack, ILArgument<TArg> argument)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldarga(argument.index);
			return new IL<ILRef<TArg>, TStack>( stack );
		}


		//ldc.i4 No aliased name
		public static IL<Int32, TStack> @ldc_i4<TStack>( this TStack stack, Int32 value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldc_i4(value);
			return new IL<Int32, TStack>( stack );
		}


		//ldelem No aliased name
		public static IL<TElem, TStack> @ldelem<TElem, TStack>( this IL<ILIndex ,IL<ILArray<TElem>, TStack>> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_ldsfld(field.field);
			return new IL<TElem, TStack>( stack.Pop().Pop() );
		}


		//ldelema No aliased name
		public static IL<ILRef<TElem>, TStack> @ldelema<TElem, TStack>( this IL<ILIndex, IL<ILArray<TElem>, TStack>> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_ldsflda(field.field);
			return new IL<ILRef<TElem>, TStack>( stack.Pop().Pop() );
		}


		//ldfld No aliased name
		public static IL<TValue, TStack> @ldfld<TOn, TValue, TStack>( this IL<TOn, TStack> stack, ILField<TOn,TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldsfld(field.field);
			return new IL<TValue, TStack>( stack.Pop() );
		}


		//ldflda No aliased name
		public static IL<ILRef<TValue>, TStack> @ldflda<TOn, TValue, TStack>( this IL<TOn, TStack> stack, ILField<TOn,TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldsflda(field.field);
			return new IL<ILRef<TValue>, TStack>( stack.Pop() );
		}


		//ldftn No aliased name
		#warning @ldftn not implemented


		//ldlen No aliased name
		public static IL<Int32, TStack> @ldlen<TElem, TStack>( this IL<ILArray<TElem>, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldlen();
			return new IL<Int32, TStack>( stack.Pop() );
		}


		//ldloc No aliased name
		public static IL<TLoc, TStack> @ldloc<TLoc, TStack>( this TStack stack, ILLocal<TLoc> local)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldloc(local.index);
			return new IL<TLoc, TStack>( stack );
		}


		//ldloca No aliased name
		public static IL<ILRef<TLoc>, TStack> @ldloca<TLoc, TStack>( this TStack stack, ILLocal<TLoc> local)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldloca(local.index);
			return new IL<ILRef<TLoc>, TStack>( stack );
		}


		//ldnull No aliased name
		public static IL<ILNull, TStack> @ldnull<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldnull();
			return new IL<ILNull, TStack>( stack );
		}


		//ldobj No aliased name
		public static IL<TValue, TStack> @ldobj<TValue, TStack>( this IL<ILRef<TValue>, TStack> stack)
			where TStack : ILStack
			where TValue : struct
		{
			//stack.bottom.reciever.Emit_ldsfld(field.field);
			return new IL<TValue, TStack>( stack.Pop() );
		}


		//ldsfld No aliased name
		public static IL<TValue, TStack> @ldsfld<TValue, TStack>( this TStack stack, ILSField<TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldsfld(field.field);
			return new IL<TValue, TStack>( stack );
		}


		//ldsflda No aliased name
		public static IL<ILRef<TValue>, TStack> @ldsflda<TValue, TStack>( this TStack stack, ILSField<TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldsflda(field.field);
			return new IL<ILRef<TValue>, TStack>( stack );
		}


		//ldtoken No aliased name
		public static IL<RuntimeFieldHandle, TStack> @ldtoken<TStack>( this TStack stack, IField field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldtoken(field);
			return new IL<RuntimeFieldHandle, TStack>( stack );
		}

		public static IL<RuntimeMethodHandle, TStack> @ldtoken<TStack>( this TStack stack, IMethod method)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldtoken(method);
			return new IL<RuntimeMethodHandle, TStack>( stack );
		}

		public static IL<RuntimeTypeHandle, TStack> @ldtoken<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldtoken(type);
			return new IL<RuntimeTypeHandle, TStack>( stack );
		}


		//ldvirtftn No aliased name
		//ldvirtftn Popref
		#warning @ldvirtftn not implemented


		//leave No aliased name
		//leave Branch
		#warning @leave not implemented


		//localloc No aliased name
		public static IL<ILPtr, TStack> @localloc<TStack>( this IL<Int32, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_localloc();
			return new IL<ILPtr, TStack>( stack.Pop() );
		}


		//mkrefany No aliased name
		public static IL<ILTypedReference<TValue>, TStack> @mkrefany<TValue, TStack>( this IL<ILRef<TValue>, TStack> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_mkrefany();
			return new IL<ILTypedReference<TValue>, TStack>( stack.Pop() );
		}


		//mul No aliased name
		public static IL<Int32, TStack> @mul<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_mul();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//neg No aliased name
		public static IL<Int32, TStack> @neg<TStack>( this IL<Int32, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_neg();
			return new IL<Int32, TStack>( stack.Pop() );
		}


		//newarr No aliased name
		public static IL<ILArray<TElem>, TStack> @newarr<TElem, TType, TStack>( this IL<ILLength, TStack> stack, TType elementType)
			where TStack : ILStack
			where TType : ITypeRef<TElem>
		{
			stack.bottom.reciever.Emit_newarr(elementType.type);
			return new IL<ILArray<TElem>, TStack>( stack.Pop() );
		}


		//newobj No aliased name
		//newobj Call
		//newobj Varpop
		//newobj Pushref
		#warning @newobj not implemented


		public static TStack NoOp<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_nop();
			return stack;
		}


		//not No aliased name
		public static IL<Int32, TStack> @not<TStack>( this IL<Int32, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_not();
			return new IL<Int32, TStack>( stack.Pop() );
		}


		//or No aliased name
		public static IL<Int32, TStack> @or<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_or();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//pop No aliased name
		public static TStack @pop<TPopped, TStack>( this IL<TPopped, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_pop();
			return stack.Pop();
		}


		//readonly. No aliased name
		//readonly. Meta
		#warning @readonly_ not implemented


		//refanytype No aliased name
		public static IL<RuntimeTypeHandle, TStack> @refanytype<TValue, TStack>( this IL<ILTypedReference<TValue>, TStack> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_mkrefany();
			return new IL<RuntimeTypeHandle, TStack>( stack.Pop() );
		}


		//refanyval No aliased name
		public static IL<ILTypedPtr<TValue>, TStack> @refanyval<TValue, TStack>( this IL<ILTypedReference<TValue>, TStack> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_mkrefany();
			return new IL<ILTypedPtr<TValue>, TStack>( stack.Pop() );
		}


		//rem No aliased name
		public static IL<Int32, TStack> @rem<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_rem();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//ret No aliased name
		//ret Return
		//ret Varpop
		#warning @ret not implemented


		//rethrow No aliased name
		//rethrow Throw
		#warning @rethrow not implemented


		//shl No aliased name
		public static IL<Int32, TStack> @shl<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_shl();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//shr No aliased name
		public static IL<Int32, TStack> @shr<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_shr();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//sizeof No aliased name
		public static IL<UInt32, TStack> @sizeof<TType, TStack>( this TStack stack, TType type)
			where TStack : ILStack
			where TType : IType
		{
			stack.bottom.reciever.Emit_sizeof(type);
			return new IL<UInt32, TStack>( stack );
		}


		//starg No aliased name
		public static TStack @starg<TArg, TStack>( this IL<TArg, TStack> stack, ILArgument<TArg> argument)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_starg(argument.index);
			return stack.Pop();
		}


		//stelem No aliased name
		public static TStack @stelem<TElem, TStack>( this IL<TElem,IL<ILIndex, IL<ILArray<TElem>, TStack>>> stack)
			where TStack : ILStack
		{
			//stack.bottom.reciever.Emit_stsfld(field.field);
			return stack.Pop().Pop().Pop();
		}


		//stfld No aliased name
		public static TStack @stfld<TOn, TValue, TStack>( this IL<TValue, IL<TOn, TStack>> stack, ILField<TOn,TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stsfld(field.field);
			return stack.Pop().Pop();
		}


		//stloc No aliased name
		public static TStack @stloc<TLoc, TStack>( this IL<TLoc, TStack> stack, ILLocal<TLoc> local)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stloc(local.index);
			return stack.Pop();
		}


		//stobj No aliased name
		public static TStack @stobj<TValue, TStack>( this IL<TValue, IL<ILRef<TValue>, TStack>> stack)
			where TStack : ILStack
			where TValue : struct
		{
			//stack.bottom.reciever.Emit_stsfld(field.field);
			return stack.Pop().Pop();
		}


		//stsfld No aliased name
		public static TStack @stsfld<TValue, TStack>( this IL<TValue, TStack> stack, ILSField<TValue> field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stsfld(field.field);
			return stack.Pop();
		}


		//sub No aliased name
		public static IL<Int32, TStack> @sub<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_sub();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//switch No aliased name
		//switch Cond_Branch
		#warning @switch not implemented


		//tail. No aliased name
		//tail. Meta
		#warning @tail_ not implemented


		//throw No aliased name
		//throw Throw
		//throw Popref
		#warning @throw not implemented


		//unaligned. No aliased name
		//unaligned. Meta
		#warning @unaligned_ not implemented


		//unbox No aliased name
		public static IL<ILRef<TBoxed>, TStack> @unbox<TBoxed, TStack>( this IL<ILBoxed<TBoxed>, TStack> stack)
			where TStack : ILStack
			where TBoxed : struct
		{
			//stack.bottom.reciever.Emit_box(typeof(TBoxed));// TODO: Aliasing stuff
			return new IL<ILRef<TBoxed>, TStack>( stack.Pop() );
		}


		//unbox.any No aliased name
		public static IL<TBoxed, TStack> @unbox_any<TBoxed, TStack>( this IL<ILBoxed<TBoxed>, TStack> stack)
			where TStack : ILStack
			where TBoxed : struct
		{
			//stack.bottom.reciever.Emit_box(typeof(TBoxed));// TODO: Aliasing stuff
			return new IL<TBoxed, TStack>( stack.Pop() );
		}


		//volatile. No aliased name
		//volatile. Meta
		#warning @volatile_ not implemented


		public static IL<Int32, TStack> XOr<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_xor();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


	}
}
#pragma warning restore IDE0022 // Use expression body for methods