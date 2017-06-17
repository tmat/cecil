#if !READ_ONLY
using System.IO;
using System.Linq;

using Mono.Cecil.Cil;
using Mono.Cecil.WindowsPdb;
using NUnit.Framework;

namespace Mono.Cecil.Tests {

	[TestFixture]
	public class WindowsPdbTests : BaseTestFixture {

        [Test]
		public void Main ()
		{
			TestModule ("test.exe", module => {
				var type = module.GetType ("Program");
				var main = type.GetMethod ("Main");

				AssertCode (@"
	.locals init (System.Int32 i, System.Int32 CS$1$0000, System.Boolean CS$4$0001)
	.line 6,6:2,3 'c:\sources\cecil\symbols\Mono.Cecil.Pdb\Test\Resources\assemblies\test.cs'
	IL_0000: nop
	.line 7,7:8,18 'c:\sources\cecil\symbols\Mono.Cecil.Pdb\Test\Resources\assemblies\test.cs'
	IL_0001: ldc.i4.0
	IL_0002: stloc.0
	.line hidden 'c:\sources\cecil\symbols\Mono.Cecil.Pdb\Test\Resources\assemblies\test.cs'
	IL_0003: br.s IL_0012
	.line 8,8:4,21 'c:\sources\cecil\symbols\Mono.Cecil.Pdb\Test\Resources\assemblies\test.cs'
	IL_0005: ldarg.0
	IL_0006: ldloc.0
	IL_0007: ldelem.ref
	IL_0008: call System.Void Program::Print(System.String)
	IL_000d: nop
	.line 7,7:36,39 'c:\sources\cecil\symbols\Mono.Cecil.Pdb\Test\Resources\assemblies\test.cs'
	IL_000e: ldloc.0
	IL_000f: ldc.i4.1
	IL_0010: add
	IL_0011: stloc.0
	.line 7,7:19,34 'c:\sources\cecil\symbols\Mono.Cecil.Pdb\Test\Resources\assemblies\test.cs'
	IL_0012: ldloc.0
	IL_0013: ldarg.0
	IL_0014: ldlen
	IL_0015: conv.i4
	IL_0016: clt
	IL_0018: stloc.2
	.line hidden 'c:\sources\cecil\symbols\Mono.Cecil.Pdb\Test\Resources\assemblies\test.cs'
	IL_0019: ldloc.2
	IL_001a: brtrue.s IL_0005
	.line 10,10:3,12 'c:\sources\cecil\symbols\Mono.Cecil.Pdb\Test\Resources\assemblies\test.cs'
	IL_001c: ldc.i4.0
	IL_001d: stloc.1
	IL_001e: br.s IL_0020
	.line 11,11:2,3 'c:\sources\cecil\symbols\Mono.Cecil.Pdb\Test\Resources\assemblies\test.cs'
	IL_0020: ldloc.1
	IL_0021: ret
", main);
			}, readOnly: Platform.OnMono, symbolReaderProvider: typeof(PdbReaderProvider), symbolWriterProvider: typeof(PdbWriterProvider));
		}
    }
}
#endif