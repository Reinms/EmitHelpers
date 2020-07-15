namespace FastDelegatesPatcher
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Mono.Cecil;
    using Mono.Cecil.Cil;

    public static class DelegatePatcher
    {
        public static void Main(String[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Bad Args");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(args[0]);

            var readParams = new ReaderParameters
            {
                ReadWrite = true,
                InMemory = true,
                ReadingMode = ReadingMode.Deferred,
            };
            var asm = AssemblyDefinition.ReadAssembly(args[0], readParams);
            if (asm is null)
            {
                Console.WriteLine("No Assembly found");
                Console.ReadKey();
                return;
            }


            foreach (var module in asm.Modules)
            {
                foreach (var type in module.Types)
                {
                    foreach (var method in type.Methods)
                    {
                        var skip = true;
                        CustomAttribute attribToRemove = null;
                        foreach (var attrib in method.CustomAttributes)
                        {
                            if (attrib.AttributeType.Name == "PatchCallToCalliAttribute")
                            {
                                skip = false;
                                attribToRemove = attrib;
                                break;
                            }
                        }
                        if (skip) continue;
                        method.CustomAttributes.Remove(attribToRemove);

                        var body = method.Body;
                        var instr = body.Instructions.First((ins) => ins.OpCode == OpCodes.Call);
                        var callSite = new CallSite(method.ReturnType);
                        foreach (var par in method.Parameters)
                        {
                            callSite.Parameters.Add(par);
                        }
                        var newInstr = Instruction.Create(OpCodes.Calli, callSite);

                        var processor = body.GetILProcessor();
                        processor.Replace(instr, newInstr);
                    }
                }
            }
            asm.Write(args[0]);
        }
    }
}
