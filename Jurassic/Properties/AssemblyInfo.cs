using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


// The AllowPartiallyTrustedCallersAttribute requires the assembly to be signed with a strong name
// key.
//[assembly: System.Security.AllowPartiallyTrustedCallers]

// Unit tests and performance tests need access to internal members.
[assembly: InternalsVisibleTo("Unit Tests")]
//[assembly: InternalsVisibleTo("Performance")]
//[assembly: InternalsVisibleTo("JavaScript")]
//[assembly: InternalsVisibleTo("DebuggerTest")]
