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


		public static IL<Int32, TStack> Arglist<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_arglist();
			return default;
		}


		//beq Cond_Branch
		//beq Pop1_pop1
		public static TStack Beq<TStack>( this TStack stack, ILabel target)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_beq(target);
			return default;
		}


		//bge Cond_Branch
		//bge Pop1_pop1
		public static TStack Bge<TStack>( this TStack stack, ILabel target)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_bge(target);
			return default;
		}


		//bgt Cond_Branch
		//bgt Pop1_pop1
		public static TStack Bgt<TStack>( this TStack stack, ILabel target)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_bgt(target);
			return default;
		}


		//ble Cond_Branch
		//ble Pop1_pop1
		public static TStack Ble<TStack>( this TStack stack, ILabel target)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ble(target);
			return default;
		}


		//blt Cond_Branch
		//blt Pop1_pop1
		public static TStack Blt<TStack>( this TStack stack, ILabel target)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_blt(target);
			return default;
		}


		//bne.un Cond_Branch
		//bne.un Pop1_pop1
		public static TStack Bne<TStack>( this TStack stack, ILabel target)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_bne_un(target);
			return default;
		}


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
			stack.bottom.reciever.Emit_box(type);
			return new IL<ILBoxed<TBoxedTo>, TStack>( stack.Pop() );
		}


		//br Branch
		public static TStack Br<TStack>( this TStack stack, ILabel target)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_br(target);
			return default;
		}


		//break Break
		public static TStack Break<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_break();
			return default;
		}


		//brfalse Cond_Branch
		public static TStack Brfalse<TStack>( this IL<Int32, TStack> stack, ILabel target)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_brfalse(target);
			return default;
		}


		//brtrue Cond_Branch
		public static TStack Brtrue<TStack>( this IL<Int32, TStack> stack, ILabel target)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_brtrue(target);
			return default;
		}


		//call Call
		//call Varpop
		//call Varpush
		public static TStack Call<TStack>( this TStack stack, IMethod method)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_call(method);
			return default;
		}


		//calli Call
		//calli Varpop
		//calli Varpush
		public static TStack Calli<TStack>( this TStack stack, ICallingConventions conventions, IType returnType, IType[] arguments)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_calli(conventions, returnType, arguments);
			return default;
		}


		//callvirt Call
		//callvirt Varpop
		//callvirt Varpush
		public static TStack Callvirt<TStack>( this TStack stack, IMethod method)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_callvirt(method);
			return default;
		}


		public static IL<TCastTo, TStack> Castclass<TCastTo, TCastFrom, TTypeRef, TStack>( this IL<TCastFrom, TStack> stack, TTypeRef type)
			where TStack : ILStack
			where TBoxed : struct
			where TTypeRef : ITypeRef<TCastTo>
		{
			stack.bottom.reciever.Emit_castclass(type);
			return new IL<TCastTo, TStack>( stack.Pop() );
		}


		//ceq Pop1_pop1
		public static IL<Int32, TStack> Ceq<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ceq();
			return default;
		}


		//cgt Pop1_pop1
		public static IL<Int32, TStack> Cgt<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_cgt();
			return default;
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


		//clt Pop1_pop1
		public static IL<Int32, TStack> Clt<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_clt();
			return default;
		}


		//constrained. Meta
		public static TStack Constrained<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_constrained_(type);
			return default;
		}


		//conv.i No aliased name
		//conv.i Pop1
		public static IL<Int32, TStack> @conv_i<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_i();
			return default;
		}


		//conv.i1 No aliased name
		//conv.i1 Pop1
		public static IL<Int32, TStack> @conv_i1<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_i1();
			return default;
		}


		//conv.i2 No aliased name
		//conv.i2 Pop1
		public static IL<Int32, TStack> @conv_i2<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_i2();
			return default;
		}


		//conv.i4 No aliased name
		//conv.i4 Pop1
		public static IL<Int32, TStack> @conv_i4<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_i4();
			return default;
		}


		//conv.i8 No aliased name
		//conv.i8 Pop1
		public static IL<Int64, TStack> @conv_i8<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_i8();
			return default;
		}


		//conv.ovf.i No aliased name
		//conv.ovf.i Pop1
		public static IL<Int32, TStack> @conv_ovf_i<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_i();
			return default;
		}


		//conv.ovf.i.un No aliased name
		//conv.ovf.i.un Pop1
		public static IL<Int32, TStack> @conv_ovf_i_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_i_un();
			return default;
		}


		//conv.ovf.i1 No aliased name
		//conv.ovf.i1 Pop1
		public static IL<Int32, TStack> @conv_ovf_i1<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_i1();
			return default;
		}


		//conv.ovf.i1.un No aliased name
		//conv.ovf.i1.un Pop1
		public static IL<Int32, TStack> @conv_ovf_i1_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_i1_un();
			return default;
		}


		//conv.ovf.i2 No aliased name
		//conv.ovf.i2 Pop1
		public static IL<Int32, TStack> @conv_ovf_i2<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_i2();
			return default;
		}


		//conv.ovf.i2.un No aliased name
		//conv.ovf.i2.un Pop1
		public static IL<Int32, TStack> @conv_ovf_i2_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_i2_un();
			return default;
		}


		//conv.ovf.i4 No aliased name
		//conv.ovf.i4 Pop1
		public static IL<Int32, TStack> @conv_ovf_i4<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_i4();
			return default;
		}


		//conv.ovf.i4.un No aliased name
		//conv.ovf.i4.un Pop1
		public static IL<Int32, TStack> @conv_ovf_i4_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_i4_un();
			return default;
		}


		//conv.ovf.i8 No aliased name
		//conv.ovf.i8 Pop1
		public static IL<Int64, TStack> @conv_ovf_i8<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_i8();
			return default;
		}


		//conv.ovf.i8.un No aliased name
		//conv.ovf.i8.un Pop1
		public static IL<Int64, TStack> @conv_ovf_i8_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_i8_un();
			return default;
		}


		//conv.ovf.u No aliased name
		//conv.ovf.u Pop1
		public static IL<Int32, TStack> @conv_ovf_u<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_u();
			return default;
		}


		//conv.ovf.u.un No aliased name
		//conv.ovf.u.un Pop1
		public static IL<Int32, TStack> @conv_ovf_u_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_u_un();
			return default;
		}


		//conv.ovf.u1 No aliased name
		//conv.ovf.u1 Pop1
		public static IL<Int32, TStack> @conv_ovf_u1<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_u1();
			return default;
		}


		//conv.ovf.u1.un No aliased name
		//conv.ovf.u1.un Pop1
		public static IL<Int32, TStack> @conv_ovf_u1_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_u1_un();
			return default;
		}


		//conv.ovf.u2 No aliased name
		//conv.ovf.u2 Pop1
		public static IL<Int32, TStack> @conv_ovf_u2<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_u2();
			return default;
		}


		//conv.ovf.u2.un No aliased name
		//conv.ovf.u2.un Pop1
		public static IL<Int32, TStack> @conv_ovf_u2_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_u2_un();
			return default;
		}


		//conv.ovf.u4 No aliased name
		//conv.ovf.u4 Pop1
		public static IL<Int32, TStack> @conv_ovf_u4<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_u4();
			return default;
		}


		//conv.ovf.u4.un No aliased name
		//conv.ovf.u4.un Pop1
		public static IL<Int32, TStack> @conv_ovf_u4_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_u4_un();
			return default;
		}


		//conv.ovf.u8 No aliased name
		//conv.ovf.u8 Pop1
		public static IL<Int64, TStack> @conv_ovf_u8<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_u8();
			return default;
		}


		//conv.ovf.u8.un No aliased name
		//conv.ovf.u8.un Pop1
		public static IL<Int64, TStack> @conv_ovf_u8_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_ovf_u8_un();
			return default;
		}


		//conv.r.un No aliased name
		//conv.r.un Pop1
		public static IL<Double, TStack> @conv_r_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_r_un();
			return default;
		}


		//conv.r4 No aliased name
		//conv.r4 Pop1
		public static IL<Single, TStack> @conv_r4<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_r4();
			return default;
		}


		//conv.r8 No aliased name
		//conv.r8 Pop1
		public static IL<Double, TStack> @conv_r8<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_r8();
			return default;
		}


		//conv.u No aliased name
		//conv.u Pop1
		public static IL<Int32, TStack> @conv_u<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_u();
			return default;
		}


		//conv.u1 No aliased name
		//conv.u1 Pop1
		public static IL<Int32, TStack> @conv_u1<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_u1();
			return default;
		}


		//conv.u2 No aliased name
		//conv.u2 Pop1
		public static IL<Int32, TStack> @conv_u2<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_u2();
			return default;
		}


		//conv.u4 No aliased name
		//conv.u4 Pop1
		public static IL<Int32, TStack> @conv_u4<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_u4();
			return default;
		}


		//conv.u8 No aliased name
		//conv.u8 Pop1
		public static IL<Int64, TStack> @conv_u8<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_conv_u8();
			return default;
		}


		//cpblk No aliased name
		public static TStack @cpblk<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_cpblk();
			return default;
		}


		//cpobj No aliased name
		public static TStack @cpobj<TStack>( this IL<Int32, IL<Int32, TStack>> stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_cpobj(type);
			return default;
		}


		public static IL<Int32, TStack> Div<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_div();
			return new IL<Int32, TStack>( stack.Pop().Pop() );
		}


		//dup No aliased name
		//dup Pop1
		//dup Push1_push1
		public static TStack @dup<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_dup();
			return default;
		}


		//endfilter No aliased name
		//endfilter Return
		public static TStack @endfilter<TStack>( this IL<Int32, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_endfilter();
			return default;
		}


		//endfinally No aliased name
		//endfinally Return
		public static TStack @endfinally<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_endfinally();
			return default;
		}


		//initblk No aliased name
		public static TStack @initblk<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_initblk();
			return default;
		}


		//initobj No aliased name
		public static TStack @initobj<TStack>( this IL<Int32, TStack> stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_initobj(type);
			return default;
		}


		//isinst No aliased name
		//isinst Popref
		public static IL<Int32, TStack> @isinst<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_isinst(type);
			return default;
		}


		//jmp No aliased name
		//jmp Call
		public static TStack @jmp<TStack>( this TStack stack, IMethod method)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_jmp(method);
			return default;
		}


		//ldarg No aliased name
		//ldarg Push1
		public static TStack @ldarg<TStack>( this TStack stack, Int16 value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldarg(value);
			return default;
		}


		//ldarga No aliased name
		public static IL<Int32, TStack> @ldarga<TStack>( this TStack stack, Int16 value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldarga(value);
			return default;
		}


		//ldc.i4 No aliased name
		public static IL<Int32, TStack> @ldc_i4<TStack>( this TStack stack, Int32 value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldc_i4(value);
			return default;
		}


		//ldc.i4.s No aliased name
		public static IL<Int32, TStack> @ldc_i4_s<TStack>( this TStack stack, Byte value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldc_i4_s(value);
			return default;
		}


		//ldc.i8 No aliased name
		public static IL<Int64, TStack> @ldc_i8<TStack>( this TStack stack, Int64 value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldc_i8(value);
			return default;
		}


		//ldc.r4 No aliased name
		public static IL<Single, TStack> @ldc_r4<TStack>( this TStack stack, Single value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldc_r4(value);
			return default;
		}


		//ldc.r8 No aliased name
		public static IL<Double, TStack> @ldc_r8<TStack>( this TStack stack, Double value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldc_r8(value);
			return default;
		}


		//ldelem No aliased name
		//ldelem Popref_popi
		//ldelem Push1
		public static TStack @ldelem<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldelem(type);
			return default;
		}


		//ldelema No aliased name
		//ldelema Popref_popi
		public static IL<Int32, TStack> @ldelema<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldelema(type);
			return default;
		}


		//ldfld No aliased name
		//ldfld Popref
		//ldfld Push1
		public static TStack @ldfld<TStack>( this TStack stack, IField field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldfld(field);
			return default;
		}


		//ldflda No aliased name
		//ldflda Popref
		public static IL<Int32, TStack> @ldflda<TStack>( this TStack stack, IField field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldflda(field);
			return default;
		}


		//ldftn No aliased name
		public static IL<Int32, TStack> @ldftn<TStack>( this TStack stack, IMethod method)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldftn(method);
			return default;
		}


		//ldind.i No aliased name
		public static IL<Int32, TStack> @ldind_i<TStack>( this IL<Int32, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldind_i();
			return default;
		}


		//ldlen No aliased name
		//ldlen Popref
		public static IL<Int32, TStack> @ldlen<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldlen();
			return default;
		}


		//ldloc No aliased name
		//ldloc Push1
		public static TStack @ldloc<TStack>( this TStack stack, Int16 value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldloc(value);
			return default;
		}


		//ldloca No aliased name
		public static IL<Int32, TStack> @ldloca<TStack>( this TStack stack, Int16 value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldloca(value);
			return default;
		}


		//ldnull No aliased name
		//ldnull Pushref
		public static TStack @ldnull<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldnull();
			return default;
		}


		//ldobj No aliased name
		//ldobj Push1
		public static TStack @ldobj<TStack>( this IL<Int32, TStack> stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldobj(type);
			return default;
		}


		//ldsfld No aliased name
		//ldsfld Push1
		public static TStack @ldsfld<TStack>( this TStack stack, IField field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldsfld(field);
			return default;
		}


		//ldsflda No aliased name
		public static IL<Int32, TStack> @ldsflda<TStack>( this TStack stack, IField field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldsflda(field);
			return default;
		}


		//ldstr No aliased name
		//ldstr Pushref
		public static TStack @ldstr<TStack>( this TStack stack, String value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldstr(value);
			return default;
		}


		//ldtoken No aliased name
		public static IL<Int32, TStack> @ldtoken<TStack>( this TStack stack, IType typeToken)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldtoken(typeToken);
			return default;
		}


		//ldvirtftn No aliased name
		//ldvirtftn Popref
		public static IL<Int32, TStack> @ldvirtftn<TStack>( this TStack stack, IMethod method)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ldvirtftn(method);
			return default;
		}


		//leave No aliased name
		//leave Branch
		public static TStack @leave<TStack>( this TStack stack, ILabel target)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_leave(target);
			return default;
		}


		//localloc No aliased name
		public static IL<Int32, TStack> @localloc<TStack>( this IL<Int32, TStack> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_localloc();
			return default;
		}


		//mkrefany No aliased name
		//mkrefany Push1
		public static TStack @mkrefany<TStack>( this IL<Int32, TStack> stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_mkrefany(type);
			return default;
		}


		//mul No aliased name
		//mul Pop1_pop1
		//mul Push1
		public static TStack @mul<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_mul();
			return default;
		}


		//neg No aliased name
		//neg Pop1
		//neg Push1
		public static TStack @neg<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_neg();
			return default;
		}


		//newarr No aliased name
		//newarr Pushref
		public static TStack @newarr<TStack>( this IL<Int32, TStack> stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_newarr(type);
			return default;
		}


		//newobj No aliased name
		//newobj Call
		//newobj Varpop
		//newobj Pushref
		public static TStack @newobj<TStack>( this TStack stack, IMethod method)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_newobj(method);
			return default;
		}


		public static TStack Nop<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_nop();
			return default;
		}


		//not No aliased name
		//not Pop1
		//not Push1
		public static TStack @not<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_not();
			return default;
		}


		//or No aliased name
		//or Pop1_pop1
		//or Push1
		public static TStack @or<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_or();
			return default;
		}


		//pop No aliased name
		//pop Pop1
		public static TStack @pop<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_pop();
			return default;
		}


		//readonly. No aliased name
		//readonly. Meta
		public static TStack @readonly_<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_readonly_();
			return default;
		}


		//refanytype No aliased name
		//refanytype Pop1
		public static IL<Int32, TStack> @refanytype<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_refanytype();
			return default;
		}


		//refanyval No aliased name
		//refanyval Pop1
		public static IL<Int32, TStack> @refanyval<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_refanyval(type);
			return default;
		}


		//rem No aliased name
		//rem Pop1_pop1
		//rem Push1
		public static TStack @rem<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_rem();
			return default;
		}


		//rem.un No aliased name
		//rem.un Pop1_pop1
		//rem.un Push1
		public static TStack @rem_un<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_rem_un();
			return default;
		}


		//ret No aliased name
		//ret Return
		//ret Varpop
		public static TStack @ret<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_ret();
			return default;
		}


		//rethrow No aliased name
		//rethrow Throw
		public static TStack @rethrow<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_rethrow();
			return default;
		}


		//shl No aliased name
		//shl Pop1_pop1
		//shl Push1
		public static TStack @shl<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_shl();
			return default;
		}


		//shr No aliased name
		//shr Pop1_pop1
		//shr Push1
		public static TStack @shr<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_shr();
			return default;
		}


		//sizeof No aliased name
		public static IL<Int32, TStack> @sizeof<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_sizeof(type);
			return default;
		}


		//starg No aliased name
		//starg Pop1
		public static TStack @starg<TStack>( this TStack stack, Int16 value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_starg(value);
			return default;
		}


		//stelem No aliased name
		//stelem Popref_popi_pop1
		public static TStack @stelem<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stelem(type);
			return default;
		}


		//stfld No aliased name
		//stfld Popref_pop1
		public static TStack @stfld<TStack>( this TStack stack, IField field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stfld(field);
			return default;
		}


		//stind.i No aliased name
		public static TStack @stind_i<TStack>( this IL<Int32, IL<Int32, TStack>> stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stind_i();
			return default;
		}


		//stloc No aliased name
		//stloc Pop1
		public static TStack @stloc<TStack>( this TStack stack, Int16 value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stloc(value);
			return default;
		}


		//stobj No aliased name
		//stobj Popi_pop1
		public static TStack @stobj<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stobj(type);
			return default;
		}


		//stsfld No aliased name
		//stsfld Pop1
		public static TStack @stsfld<TStack>( this TStack stack, IField field)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_stsfld(field);
			return default;
		}


		//sub No aliased name
		//sub Pop1_pop1
		//sub Push1
		public static TStack @sub<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_sub();
			return default;
		}


		//switch No aliased name
		//switch Cond_Branch
		public static TStack @switch<TStack>( this IL<Int32, TStack> stack, ILabel[] targets)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_switch(targets);
			return default;
		}


		//tail. No aliased name
		//tail. Meta
		public static TStack @tail_<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_tail_();
			return default;
		}


		//throw No aliased name
		//throw Throw
		//throw Popref
		public static TStack @throw<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_throw();
			return default;
		}


		//unaligned. No aliased name
		//unaligned. Meta
		public static TStack @unaligned_<TStack>( this TStack stack, Byte value)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_unaligned_(value);
			return default;
		}


		//unbox No aliased name
		//unbox Popref
		public static IL<Int32, TStack> @unbox<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_unbox(type);
			return default;
		}


		//unbox.any No aliased name
		//unbox.any Popref
		//unbox.any Push1
		public static TStack @unbox_any<TStack>( this TStack stack, IType type)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_unbox_any(type);
			return default;
		}


		//volatile. No aliased name
		//volatile. Meta
		public static TStack @volatile_<TStack>( this TStack stack)
			where TStack : ILStack
		{
			stack.bottom.reciever.Emit_volatile_();
			return default;
		}


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
	}
}